using MediatR;
using MediClinic.Application.Modules.Client.DepartmentModule;
using MediClinic.Domain.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediClinic.WebUI.Controllers
{
    [AllowAnonymous]
    public class DepartmentController : Controller
    {
        readonly IMediator mediator;
        public DepartmentController(IMediator mediator)
        {
            this.mediator = mediator;

        }
        public async Task<IActionResult> Index(DepartmentListQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
                return NotFound();

            return View(response);
        }

        

        public async Task<IActionResult> Details(DepartmentDetailsQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }

            var vm = new DepartmentViewModel();
            vm.Departments = await mediator.Send(new DepartmentListQuery());
            vm.Department = response;
            return View(vm);
        }
    }
}
