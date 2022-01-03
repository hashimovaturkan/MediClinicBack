using MediatR;
using MediClinic.Application.Modules.Admin.BlogCategoryModule;
using MediClinic.Application.Modules.Admin.BlogPostModule;
using MediClinic.Application.Modules.Admin.DoctorModule;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MediClinic.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogPostsController : Controller
    {
        readonly IMediator mediator;

        public BlogPostsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        //[Authorize(Policy = "admin.academicbackgrounds.index")]
        public async Task<IActionResult> Index(BlogPostPagedQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
                return NotFound();

            return View(response);
        }

        //[Authorize(Policy = "admin.academicbackgrounds.details")]
        public async Task<IActionResult> Details(BlogPostSingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }
            var category = await mediator.Send(new BlogCategoryChooseQuery());
            ViewData["BlogCategoryId"] = category.Where(b => b.Id == response.BlogCategoryId).FirstOrDefault(b => b.DeletedByUserId == null).Name;
            var doctor = await mediator.Send(new DoctorChooseQuery());
            ViewData["BlogDoctorId"] = doctor.Where(b => b.Id == response.DoctorId).FirstOrDefault(b => b.DeletedByUserId == null).Name;
            return View(response);
        }

        //[Authorize(Policy = "admin.academicbackgrounds.create")]
        public async Task<IActionResult> Create()
        {
            ViewData["BlogCategoryId"] = new SelectList(await mediator.Send(new BlogCategoryChooseQuery()), "Id", "Name");
            ViewData["BlogDoctorId"] = new SelectList(await mediator.Send(new DoctorChooseQuery()), "Id", "Name");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Policy = "admin.academicbackgrounds.create")]
        public async Task<IActionResult> Create(BlogPostCreateCommand command)
        {
            command.CreatedUserId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var response = await mediator.Send(command);
            ViewData["BlogCategoryId"] = new SelectList(await mediator.Send(new BlogCategoryChooseQuery()), "Id", "Name", command.BlogCategoryId);
            ViewData["BlogDoctorId"] = new SelectList(await mediator.Send(new DoctorChooseQuery()), "Id", "Name", command.DoctorId);

            if (response > 0)
                return RedirectToAction(nameof(Index));

            return View(command);
        }

        //[Authorize(Policy = "admin.academicbackgrounds.edit")]
        public async Task<IActionResult> Edit(BlogPostSingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }

            ViewData["BlogCategoryId"] = new SelectList(await mediator.Send(new BlogCategoryChooseQuery()), "Id", "Name", response.BlogCategoryId);
            ViewData["BlogDoctorId"] = new SelectList(await mediator.Send(new DoctorChooseQuery()), "Id", "Name", response.DoctorId);

            var model = new BlogPostViewModel();
            model.Id = response.Id;
            model.Title = response.Title;
            model.Content = response.Content;
            model.PublishedDate = response.PublishedDate;
            model.ImgUrl = response.ImgUrl;
            model.BlogCategoryId = response.BlogCategoryId;
            model.DoctorId = response.DoctorId;
            model.CreatedUserId = response.CreatedByUserId;
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Policy = "admin.academicbackgrounds.edit")]
        public async Task<IActionResult> Edit(BlogPostUpdateCommand command)
        {
            var response = await mediator.Send(command);
            if (response > 0)
                return RedirectToAction(nameof(Index));

            return View(command);
        }


        [HttpPost]
        //[Authorize(Policy = "admin.academicbackgrounds.delete")]
        public async Task<IActionResult> Delete(BlogPostDeleteCommand command)
        {
            command.DeletedUserId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var response = await mediator.Send(command);
            return Json(response);
        }
    }
}
