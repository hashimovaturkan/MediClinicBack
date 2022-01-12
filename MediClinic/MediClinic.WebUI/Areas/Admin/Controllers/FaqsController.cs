using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities;
using MediClinic.Application.Modules.Admin.FaqsModule;
using System.Security.Claims;

namespace MediClinic.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FaqsController : Controller
    {
        private readonly MediClinicDbContext db;
        readonly IMediator mediator;

        public FaqsController(MediClinicDbContext db, IMediator mediator)
        {
            this.db = db;
            this.mediator = mediator;
        }

        [Authorize(Policy = "admin.faqs.index")]
        public async Task<IActionResult> Index(FaqPagedQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
                return NotFound();

            return View(response);
        }

        [Authorize(Policy = "admin.faqs.details")]
        public async Task<IActionResult> Details(FaqSingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }

            return View(response);
        }

        [Authorize(Policy = "admin.faqs.create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "admin.faqs.create")]
        public async Task<IActionResult> Create(FaqCreateCommand command)
        {
            command.CreatedUserId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var response =await mediator.Send(command);
            if(response > 0)
                return RedirectToAction(nameof(Index));
            
            return View(command);
        }

        [Authorize(Policy = "admin.faqs.edit")]
        public async Task<IActionResult> Edit(FaqSingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }
            var vm = new FaqViewModel();
            vm.Id = response.Id;
            vm.Answer = response.Answer;
            vm.Question = response.Question;
            vm.CreatedUserId = response.CreatedByUserId;
            return View(vm);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "admin.faqs.edit")]
        public async Task<IActionResult> Edit(FaqUpdateCommand command)
        {
            var response = await mediator.Send(command);

            if (response > 0)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(command);
        }

        
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "admin.faqs.delete")]
        [HttpPost]
        public async Task<IActionResult> Delete(FaqDeleteCommand command)
        {
            command.DeletedUserId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var response = await mediator.Send(command);
            
            return Json(response);
        }

        [HttpPost]
        [Authorize(Policy = "admin.faqs.deleteAll")]
        public async Task<IActionResult> DeleteAll(FaqDeleteAllCommand command)
        {
            command.DeletedUserId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var response = await mediator.Send(command);
            return Json(response);
        }

    }
}
