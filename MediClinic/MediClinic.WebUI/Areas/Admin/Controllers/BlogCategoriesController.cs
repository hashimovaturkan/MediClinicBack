using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities;
using MediatR;
using MediClinic.Application.Modules.Admin.BlogCategoryModule;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace MediClinic.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogCategoriesController : Controller
    {
        readonly IMediator mediator;

        public BlogCategoriesController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [Authorize(Policy = "admin.blogcategories.index")]
        public async Task<IActionResult> Index(BlogCategoryPagedQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
                return NotFound();

            return View(response);
        }

        [Authorize(Policy = "admin.blogcategories.details")]
        public async Task<IActionResult> Details(BlogCategorySingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }

            return View(response);
        }

        [Authorize(Policy = "admin.blogcategories.create")]
        public async Task<IActionResult> Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "admin.blogcategories.create")]
        public async Task<IActionResult> Create(BlogCategoryCreateCommand command)
        {
            command.CreatedUserId =Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var response = await mediator.Send(command);
            if (response > 0)
                return RedirectToAction(nameof(Index));

            return View(command);
        }

        [Authorize(Policy = "admin.blogcategories.edit")]
        public async Task<IActionResult> Edit(BlogCategorySingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }

            var model = new BlogCategoryViewModel();
            model.Id = response.Id;
            model.Name = response.Name;
            model.CreatedUserId = response.CreatedByUserId;
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "admin.blogcategories.edit")]
        public async Task<IActionResult> Edit(BlogCategoryUpdateCommand command)
        {
            var response = await mediator.Send(command);
            if (response > 0)
                return RedirectToAction(nameof(Index));

            return View(command);
        }


        [HttpPost]
        [Authorize(Policy = "admin.blogcategories.delete")]
        public async Task<IActionResult> Delete(BlogCategoryDeleteCommand command)
        {
            command.DeletedUserId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var response = await mediator.Send(command);
            return Json(response);
        }

        [HttpPost]
        [Authorize(Policy = "admin.blogcategories.deleteAll")]
        public async Task<IActionResult> DeleteAll(BlogCategoryDeleteAllCommand command)
        {
            command.DeletedUserId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var response = await mediator.Send(command);
            return Json(response);
        }
    }
}
