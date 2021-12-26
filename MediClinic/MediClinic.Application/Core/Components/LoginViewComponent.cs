using Microsoft.AspNetCore.Mvc;

namespace MediClinic.Application.Core.Components
{
    public class LoginViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
