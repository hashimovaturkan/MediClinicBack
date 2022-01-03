﻿using MediatR;
using MediClinic.Application.Modules.Admin.BlogCommentModule;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MediClinic.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogCommentsController : Controller
    {
        readonly IMediator mediator;

        public BlogCommentsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        //[Authorize(Policy = "admin.personalsetting.index")]
        public async Task<IActionResult> Index(BlogCommentPagedQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
                return NotFound();

            return View(response);
        }

        //[Authorize(Policy = "admin.personalsetting.details")]
        public async Task<IActionResult> Details(BlogCommentSingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }

            return View(response);
        }


        [HttpPost]
        //[Authorize(Policy = "admin.personalsetting.delete")]
        public async Task<IActionResult> Delete(BlogCommentDeleteCommand command)
        {
            command.DeletedUserId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var response = await mediator.Send(command);
            return Json(response);
        }
    }
}
