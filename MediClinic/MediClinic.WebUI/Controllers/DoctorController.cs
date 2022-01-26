using MediatR;
using MediClinic.Application.Core.Extensions;
using MediClinic.Application.Core.Infrastructure;
using MediClinic.Application.Modules.Client.DoctorModule;
using MediClinic.Domain.Models.DataContexts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MediClinic.WebUI.Controllers
{
    [AllowAnonymous]
    public class DoctorController : Controller
    {
        readonly IMediator mediator;
        readonly MediClinicDbContext db;
        readonly IConfiguration configuration;

        public DoctorController(IMediator mediator,MediClinicDbContext db, IConfiguration configuration)
        {
            this.mediator = mediator;
            this.db = db;
            this.configuration = configuration;

        }
        public async Task<IActionResult> Index(DoctorListQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
                return NotFound();
            
            return View(response);
        }

        public async Task<IActionResult> Details(DoctorDetailsQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> DoctorAppointment(DoctorAppointmentCommand command)
        {
            if(User.FindFirst(ClaimTypes.NameIdentifier).Value != null)
                    command.CreatedUserId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var response = await mediator.Send(command);
            return Json(response);
        }

        [HttpPost]
        public async Task<IActionResult> FindDoctor(string Email, string Name)
        {
            if (ModelState.IsValid)
            {
                db.Database.BeginTransaction();
                string FilePath = Directory.GetCurrentDirectory() + "\\wwwroot\\uploads\\files\\FindDoctor.html";
                StreamReader str = new StreamReader(FilePath);
                string MailText = str.ReadToEnd();
                str.Close();
                var sendMail = configuration.SendEmail(Email, "Need Help Finding The Right Doctor? Look at this brochure", MailText);

                if (sendMail == false)
                {
                    db.Database.RollbackTransaction();
                    return Json(new
                    {
                        error = true,
                        message = "Please, try again!"
                    });
                }

                db.Database.CommitTransaction();

                return Json(new
                {
                    error = false,
                    message = "Successfully, please check your email!"
                });

            }

            return Json(new
            {
                error = true,
                message = "The information is incomplete!"
            });
        }
    }
}
