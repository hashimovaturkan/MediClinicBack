using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities;
using MediClinic.Domain.Models.Enums;
using MediClinic.Domain.Models.FormModels;
using MediClinic.Domain.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediClinic.WebUI.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly MediClinicDbContext db;

        public HomeController(MediClinicDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
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
                        .Include(c => c.WorkTime)
                        .ThenInclude(c => c.WorkTimeWeekDayRelation)
                        .Where(e => e.DeletedByUserId == null && e.DoctorDepartmentRelation.Select(e => e.Department.Title).Contains(department)).ToListAsync();
            }
            else
            {
                doctors = await db.Doctors
                        .Include(e => e.DoctorDepartmentRelation).ThenInclude(e => e.Department)
                        .Include(e => e.Appointments)
                        .Include(c => c.BlogPosts)
                        .Include(e => e.SocialMedia)
                        .Include(c => c.WorkTime)
                        .ThenInclude(c => c.WorkTimeWeekDayRelation)
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
    }
}
