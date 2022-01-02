using MediClinic.Domain.Models.DataContexts;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace MediClinic.Application.Core.Components
{
    public class DepartmentViewComponent : ViewComponent
    {
        readonly MediClinicDbContext db;
        public DepartmentViewComponent(MediClinicDbContext db)
        {
            this.db = db;
        }
        public IViewComponentResult Invoke()
        {
            var model = db.Departments.Where(e => e.DeletedByUserId == null).ToList();
            return View(model);
        }
    }
}
