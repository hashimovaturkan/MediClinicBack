using MediatR;
using MediClinic.Application.Core.Extensions;
using MediClinic.Application.Modules.Admin.DoctorModule;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities;
using MediClinic.Domain.Models.Enums;
using MediClinic.Domain.Models.FormModels;
using MediClinic.Domain.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MediClinic.WebUI.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        readonly IMediator mediator;
        readonly MediClinicDbContext db;
        readonly IConfiguration configuration;

        public HomeController(IMediator mediator, MediClinicDbContext db, IConfiguration configuration)
        {
            this.mediator = mediator;
            this.db = db;
            this.configuration = configuration;

        }
        public async Task<IActionResult> Index()
        {
            var model = await mediator.Send(new DoctorChooseQuery());
            model = model.Take(4).OrderByDescending(e => e.CreatedDate).ToList();

            return View(model);
        }

        public async Task<IActionResult> Faq()
        {
            var model =await db.Faqs.Where(e => e.DeletedByUserId == null).ToListAsync();
            return View(model);
        }

        public async Task<IActionResult> Timetable(string department = "all")
        {
            var departments = await db.Departments.Where(e => e.DeletedByUserId == null).ToListAsync();
            IEnumerable<Doctor> doctors;
            if (department != "all")
            {
                doctors = await db.Doctors
                        .Include(e => e.DoctorDepartmentRelation.Where(e => e.Department.Title == department)).ThenInclude(e => e.Department)
                        .Include(e => e.Appointments)
                        .Include(c => c.BlogPosts)
                        .Include(e => e.SocialMedia)
                        .Include(c => c.DoctorWorkTimeRelation)
                        .ThenInclude(c => c.WorkTime)
                        .Where(e => e.DeletedByUserId == null && e.DoctorDepartmentRelation.Select(e => e.Department.Title).Contains(department)).ToListAsync();
            }
            else
            {
                doctors = await db.Doctors
                        .Include(e => e.DoctorDepartmentRelation).ThenInclude(e => e.Department)
                        .Include(e => e.Appointments)
                        .Include(c => c.BlogPosts)
                        .Include(e => e.SocialMedia)
                        .Include(c => c.DoctorWorkTimeRelation)
                        .ThenInclude(c => c.WorkTime)
                        .Where(e => e.DeletedByUserId == null).ToListAsync();
            }

            var vm = new DepartmentDoctorViewModel();
            vm.Departments = departments;
            vm.Doctors = doctors;
            vm.CurrentDepartment = department;
            vm.WeekDays = Enum.GetValues(typeof(WeekDay)).Cast<WeekDay>();

            return View(vm);
        }

        [HttpGet]
        public async Task<IActionResult> Contact()
        {
            ContactFormModel model = new ContactFormModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Contact(ContactFormModel model)
        {
            if (ModelState.IsValid)
            {
                var post = new ContactPost();
                post.Comment = model.Comment;
                post.Email = model.Email;
                post.Name = model.Name;

                await db.ContactPosts.AddAsync(post);

                await db.SaveChangesAsync();

                return Json(new
                {
                    error = false,
                    message = "Your request has been successfully submitted"

                });
            }
            return Json(new
            {
                error = true,
                message = "Please try again.."

            });
        }

        [HttpPost]
        public async Task<IActionResult> FilterTime(int DepartmentId)
        {
            try
            {
                var dateMin = await db.Departments.Where(e => e.Id == DepartmentId).Select(e => e.DoctorDepartmentRelation.Select(k => k.Doctor.DoctorWorkTimeRelation.Select(f => f.WorkTime.StartedTime).Min()).First()).FirstOrDefaultAsync();
                var dateMax = await db.Departments.Where(e => e.Id == DepartmentId).Select(e => e.DoctorDepartmentRelation.Select(k => k.Doctor.DoctorWorkTimeRelation.Select(e => e.WorkTime.EndedTime).Max()).First()).FirstOrDefaultAsync();
                return Json(new
                {
                    error = false,
                    dateMin = dateMin.Hour,
                    dateMax = dateMax.Hour

                });

            }
            catch (Exception ex)
            {

                return Json(new
                {
                    error = false,
                    dateMin = 0,
                    dateMax = 0

                });
            }


        }

        public IActionResult Subscribe([Bind("Email")] Subscribe model)
        {
            if (ModelState.IsValid)
            {
                db.Database.BeginTransaction();
                var current = db.Subscribes.FirstOrDefault(s => s.Email.Equals(model.Email));
                if (current != null && current.EmailConfirmed == true)
                {
                    return Json(new
                    {
                        error = true,
                        message = "You have already subscribed!"
                    });
                }
                else if (current != null && (current.EmailConfirmed ?? false == false))
                {
                    return Json(new
                    {
                        error = true,
                        message = "You have to check your email, please!"
                    });
                }
                db.Subscribes.Add(model);
                db.SaveChanges();

                string token = $"subscribetoken-{model.Id}-{DateTime.Now:yyyyMMddHHmmss}";

                token = token.Encrypt();

                string path = $"{Request.Scheme}://{Request.Host}/subscribe-confirm?token={token}";


                var mailSend = configuration.SendEmail(model.Email, "Mediclinic Subscribe", $"Please, use <a href={path}>this link</a> for subscribing");

                if (mailSend == false)
                {
                    db.Database.RollbackTransaction();
                    return Json(new
                    {
                        error = true,
                        message = "Please, try again"
                    });
                }
                db.Database.CommitTransaction();
                return Json(new
                {
                    error = false,
                    message = "Please, check your email!"
                });
            }

            return Json(new
            {
                error = true,
                message = "Error! Please try again!"
            });
        }

        [HttpGet]
        [Route("subscribe-confirm")]
        public IActionResult SubscribeConfirm(string token)
        {
            token = token.Decrypt();

            Match match = Regex.Match(token, @"subscribetoken-(?<id>\d+)-(?<executeTimeStamp>\d{14})");


            if (match.Success)
            {
                int id = Convert.ToInt32(match.Groups["id"].Value);
                string executeTimeStamp = match.Groups["executeTimeStamp"].Value;

                var subscribe = db.Subscribes.FirstOrDefault(s => s.Id == id && s.DeletedByUserId == null);

                if (subscribe == null)
                {
                    ViewBag.Message = Tuple.Create(true, "Token Error");
                    goto end;
                }
                if ((subscribe.EmailConfirmed ?? false) == true)
                {
                    ViewBag.Message = Tuple.Create(true, "It was confirmed");
                    goto end;
                }
                subscribe.EmailConfirmed = true;
                subscribe.EmailConfirmedDate = DateTime.Now;
                db.SaveChanges();
                ViewBag.Message = Tuple.Create(false, "You were confirmed!");

            }
            else
            {
                ViewBag.Message = Tuple.Create(true, "Wrong Application!");
            }
        end:
            return View();
        }

        public IActionResult WorkHours()
        {
            return View();
        }

        public IActionResult Process()
        {
            return View();
        }

        public IActionResult WhoWeAre()
        {
            return View();
        }

        public IActionResult OurServices()
        {
            return View();
        }

        public IActionResult OurClients()
        {
            return View();
        }
    }
}
