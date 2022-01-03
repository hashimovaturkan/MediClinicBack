using MediatR;
using MediClinic.Application.Modules.Admin.DoctorModule;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using static MediClinic.Application.Modules.Admin.DoctorModule.DoctorViewModel;

namespace MediClinic.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DoctorsController : Controller
    {
        readonly IMediator mediator;

        public DoctorsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        //[Authorize(Policy = "admin.academicbackgrounds.index")]
        public async Task<IActionResult> Index(DoctorPagedQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
                return NotFound();

            return View(response);
        }

        //[Authorize(Policy = "admin.academicbackgrounds.details")]
        public async Task<IActionResult> Details(DoctorSingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }

            return View(response);
        }

        //[Authorize(Policy = "admin.academicbackgrounds.create")]
        public async Task<IActionResult> Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Policy = "admin.academicbackgrounds.create")]
        public async Task<IActionResult> Create(DoctorCreateCommand command)
        {
            command.CreatedUserId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var response = await mediator.Send(command);

            if (response > 0)
                return RedirectToAction(nameof(Index));

            return View(command);
        }

        //[Authorize(Policy = "admin.academicbackgrounds.edit")]
        public async Task<IActionResult> Edit(DoctorSingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }

            var model = new DoctorViewModel();
            model.Id = response.Id;
            model.AboutContent = response.AboutContent;
            model.Description = response.Description;
            model.Education = response.Education;
            model.Email = response.Email;
            model.Experience = response.Experience;
            model.Name = response.Name;
            model.Phone = response.Phone;
            model.Room = response.Room;
            model.Speciality = response.Speciality;
            model.StartedTime = response.WorkTime.StartedTime;
            model.EndedTime = response.WorkTime.EndedTime;
            model.ImgUrl = response.ImgUrl;
            model.WorkTimeId = response.WorkTimeId;
            model.CreatedUserId = response.CreatedByUserId;

            foreach (var item in response.WorkTime.WorkTimeWeekDayRelation.Select(e => e.WeekDay))
            {
                model.WeekDays.Add(item);
            }
            foreach (var item in response.SocialMedia)
            {
                var s = new SocialMediaModel();
                s.Id = item.Id;
                s.Name = item.Name;
                s.Url = item.Url;
                model.SocialMediaModels.Add(s);
            }
            foreach (var item in response.DoctorDepartmentRelation.Select(e => e.DepartmentId))
            {
                model.DepartmentIds.Add(item);
            }

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Policy = "admin.academicbackgrounds.edit")]
        public async Task<IActionResult> Edit(DoctorUpdateCommand command)
        {
            var response = await mediator.Send(command);
            if (response > 0)
                return RedirectToAction(nameof(Index));

            return View(command);
        }


        [HttpPost]
        //[Authorize(Policy = "admin.academicbackgrounds.delete")]
        public async Task<IActionResult> Delete(DoctorDeleteCommand command)
        {
            command.DeletedUserId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var response = await mediator.Send(command);
            return Json(response);
        }
    }
}
