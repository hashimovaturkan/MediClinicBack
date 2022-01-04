using MediatR;
using MediClinic.Application.Core.Extensions;
using MediClinic.Application.Modules.Admin.AppointmentModule;
using MediClinic.Application.Modules.Admin.DoctorModule;
using MediClinic.Domain.Models.FormModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediClinic.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AppointmentsController : Controller
    {
        readonly IMediator mediator;
        readonly IConfiguration configuration;

        public AppointmentsController(IMediator mediator,IConfiguration configuration)
        {
            this.mediator = mediator;
            this.configuration = configuration;
        }

        //[Authorize(Policy = "admin.personalsetting.index")]
        public async Task<IActionResult> Index(AppointmentPagedQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
                return NotFound();

            return View(response);
        }

        //[Authorize(Policy = "admin.personalsetting.details")]
        public async Task<IActionResult> Details(AppointmentSingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }
            var doctor = await mediator.Send(new DoctorChooseQuery());
            ViewData["DoctorId"] = doctor.Where(b => b.Id == response.DoctorId).FirstOrDefault(b => b.DeletedByUserId == null)?.Name;

            return View(response);
        }

        //[Authorize(Policy = "admin.academicbackgrounds.edit")]
        public async Task<IActionResult> Edit(AppointmentSingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }

            ViewData["DoctorId"] = new SelectList(await mediator.Send(new DoctorChooseQuery()), "Id", "Name", response.DoctorId);

            var model = new AppointmentViewModel();
            model.Id = response.Id;
            model.Name = response.Name;
            model.Phone = response.Phone;
            model.Email = response.Email;
            model.Date = response.Date;
            model.IsAccepted = response.IsAccepted;
            model.Message = response.Message;
            model.DoctorId = response.DoctorId;
            model.CreatedUserId = response.CreatedByUserId;
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Policy = "admin.academicbackgrounds.edit")]
        public async Task<IActionResult> Edit(AppointmentUpdateCommand command)
        {
            var response = await mediator.Send(command);
            if (response > 0)
                return RedirectToAction(nameof(Index));

            return View(command);
        }

        [HttpPost]
        //[Authorize(Policy = "admin.personalsetting.delete")]
        public async Task<IActionResult> Feedback(AppointmentFeedback model)
        {
            var doctor = await mediator.Send(new DoctorChooseQuery());
            ViewData["DoctorId"] = doctor.Where(b => b.Id == model.DoctorId).FirstOrDefault(b => b.DeletedByUserId == null).Name;

            string path = $"{Request.Scheme}://{Request.Host}/email-confirm?email={model.Email}";
            var sendMail = configuration.SendEmail(model.Email, 
                "MediClinic Appointment", $"<p style='padding: 32px; border: 1px solid #e6e6e6; font-size: 20px;line-height: 32px; box-shadow: 0 3px 20px rgba(10, 8, 59 , 12%);color:#7e7f8f;'>Dear {model.Name},<br><br>I would like to confirm your appointment with Dr.{doctor} on {model.Date?.ToString("dddd, dd MMMM yyyy")}. If you have any questions or want to request changes, please contact us.<br><br>Regards,<br>MediClinic hospital</p>");


            if (sendMail == false)
            {
                return Json(new
                {
                    error = true,
                    message = "Please, try again"
                });
            }

            return Json(new
            {
                error = false,
                message = "Successfully, Your account is updated, Please check your email for confirming!"
            });
        }
    }
}
