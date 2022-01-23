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
using MediClinic.Application.Modules.Admin.ContactPostModule;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace MediClinic.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactPostsController : Controller
    {
        readonly IMediator mediator;

        public ContactPostsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [Authorize(Policy = "admin.contactposts.index")]
        public async Task<IActionResult> Index(ContactPostPagedQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
                return NotFound();

            return View(response);
        }

        [Authorize(Policy = "admin.contactposts.details")]
        public async Task<IActionResult> Details(ContactPostSingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }

            return View(response);
        }

        [HttpPost]
        [Authorize(Policy = "admin.contactposts.answer")]
        public async Task<IActionResult> Answer(ContactPostAnswerCommand model)
        {
            model.AnswerUserId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var response = await mediator.Send(model);

            if (response == null)
                return NotFound();

            return Redirect(nameof(Index));
        }

        [HttpPost]
        [Authorize(Policy = "admin.contactposts.delete")]
        public async Task<IActionResult> Delete(ContactPostDeleteCommand command)
        {
            command.DeletedUserId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var response = await mediator.Send(command);
            return Json(response);
        }

        [HttpPost]
        [Authorize(Policy = "admin.contactposts.deleteAll")]
        public async Task<IActionResult> DeleteAll(ContactPostDeleteAllCommand command)
        {
            command.DeletedUserId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var response = await mediator.Send(command);
            return Json(response);
        }

        //[HttpPost]
        //[Authorize(Policy = "admin.contactposts.staredmessage")]
        //public async Task<IActionResult> StaredMessage(int[] messages)
        //{
        //    //model.AnswerUserId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
        //    //var response = await mediator.Send(model);

        //    //if (response == null)
        //    //    return NotFound();

        //    return Redirect(nameof(Index));
        //}

    }
}
