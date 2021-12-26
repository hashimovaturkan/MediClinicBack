using MediClinic.Domain.Models.DataContexts;
using Microsoft.AspNetCore.Mvc;

namespace MediClinic.Application.Core.Components
{
    public class RegisterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
