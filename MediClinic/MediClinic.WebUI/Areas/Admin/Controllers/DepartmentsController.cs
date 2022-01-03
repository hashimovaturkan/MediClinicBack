using MediatR;
using MediClinic.Application.Modules.Admin.DepartmentModule;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MediClinic.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DepartmentsController : Controller
    {
        readonly IMediator mediator;

        public DepartmentsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        //[Authorize(Policy = "admin.academicbackgrounds.index")]
        public async Task<IActionResult> Index(DepartmentPagedQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
                return NotFound();

            return View(response);
        }

        //[Authorize(Policy = "admin.academicbackgrounds.details")]
        public async Task<IActionResult> Details(DepartmentSingleQuery query)
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
        public async Task<IActionResult> Create(DepartmentCreateCommand command)
        {
            command.CreatedUserId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var response = await mediator.Send(command);

            if (response > 0)
                return RedirectToAction(nameof(Index));

            return View(command);
        }

        //[Authorize(Policy = "admin.academicbackgrounds.edit")]
        public async Task<IActionResult> Edit(DepartmentSingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }

            var model = new DepartmentViewModel();
            model.Id = response.Id;
            model.Title = response.Title;
            model.Content = response.Content;
            model.Description = response.Description;
            model.ImgUrl = response.ImgUrl;
            model.CreatedUserId = response.CreatedByUserId;
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Policy = "admin.academicbackgrounds.edit")]
        public async Task<IActionResult> Edit(DepartmentUpdateCommand command)
        {
            var response = await mediator.Send(command);
            if (response > 0)
                return RedirectToAction(nameof(Index));

            return View(command);
        }


        [HttpPost]
        //[Authorize(Policy = "admin.academicbackgrounds.delete")]
        public async Task<IActionResult> Delete(DepartmentDeleteCommand command)
        {
            command.DeletedUserId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var response = await mediator.Send(command);
            return Json(response);
        }
    }
}
