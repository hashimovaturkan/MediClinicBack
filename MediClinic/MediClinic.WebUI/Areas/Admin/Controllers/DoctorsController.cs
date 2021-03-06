using MediatR;
using MediClinic.Application.Modules.Admin.DepartmentModule;
using MediClinic.Application.Modules.Admin.DoctorModule;
using MediClinic.Domain.Models.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        [Authorize(Policy = "admin.doctors.index")]
        public async Task<IActionResult> Index(DoctorPagedQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
                return NotFound();

            return View(response);
        }

        [Authorize(Policy = "admin.doctors.details")]
        public async Task<IActionResult> Details(DoctorSingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }

            return View(response);
        }

        [Authorize(Policy = "admin.doctors.create")]
        public async Task<IActionResult> Create()
        {
            ViewData["WeekDayId"] = new SelectList(Enum.GetValues(typeof(WeekDay)));
            ViewData["DepartmentId"] = new SelectList(await mediator.Send(new DepartmentChooseQuery()), "Id", "Title");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "admin.doctors.create")]
        public async Task<IActionResult> Create(DoctorCreateCommand command)
        {
            command.CreatedUserId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var response = await mediator.Send(command);

            ViewData["WeekDayId"] = new SelectList(Enum.GetValues(typeof(WeekDay)));
            ViewData["DepartmentId"] = new SelectList(await mediator.Send(new DepartmentChooseQuery()), "Id", "Title");

            if (response > 0)
                return RedirectToAction(nameof(Index));

            return View(command);
        }

        [Authorize(Policy = "admin.doctors.edit")]
        public async Task<IActionResult> Edit(DoctorSingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }

            ViewData["WeekDayId"] = new SelectList(Enum.GetValues(typeof(WeekDay)));
            ViewData["DepartmentId"] = new SelectList(await mediator.Send(new DepartmentChooseQuery()), "Id", "Title");

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
            //model.StartedTime = response.WorkTime.StartedTime;
            //model.EndedTime = response.WorkTime.EndedTime;
            model.ImgUrl = response.ImgUrl;
            //model.WorkTimeId = response.WorkTimeId;
            model.CreatedUserId = response.CreatedByUserId;

            model.WorkTimeModels = new List<WorkTimeModel>();
            foreach (var item in response.DoctorWorkTimeRelation)
            {
                var s = new WorkTimeModel();
                s.Id = item.WorkTime.Id;
                s.StartedTime = item.WorkTime.StartedTime;
                s.EndedTime = item.WorkTime.EndedTime;
                s.WeekDay = item.WorkTime.WeekDay.ToString();
                model.WorkTimeModels.Add(s);
            }
            model.SocialMediaModels = new List<SocialMediaModel>();
            foreach (var item in response.SocialMedia)
            {
                var s = new SocialMediaModel();
                s.Id = item.Id;
                s.Name = item.Name;
                s.Url = item.Url;

                model.SocialMediaModels.Add(s);
            }

            model.DepartmentIds = new List<int>();

            foreach (var item in response.DoctorDepartmentRelation.Select(e => e.DepartmentId))
            {
                model.DepartmentIds.Add(item);
            }

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "admin.doctors.edit")]
        public async Task<IActionResult> Edit(DoctorUpdateCommand command)
        {
            command.CreatedUserId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var response = await mediator.Send(command);
            if (response > 0)
                return RedirectToAction(nameof(Index));

            return View(command);
        }


        [HttpPost]
        [Authorize(Policy = "admin.doctors.delete")]
        public async Task<IActionResult> Delete(DoctorDeleteCommand command)
        {
            command.DeletedUserId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var response = await mediator.Send(command);
            return Json(response);
        }

        [HttpPost]
        [Authorize(Policy = "admin.doctors.deleteAll")]
        public async Task<IActionResult> DeleteAll(DoctorDeleteAllCommand command)
        {
            command.DeletedUserId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var response = await mediator.Send(command);
            return Json(response);
        }
    }
}
