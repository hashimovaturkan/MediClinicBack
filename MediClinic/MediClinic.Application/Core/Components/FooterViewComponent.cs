using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Application.Core.Components
{
    public class FooterViewComponent : ViewComponent
    {
        readonly MediClinicDbContext db;
        public FooterViewComponent(MediClinicDbContext db)
        {
            this.db = db;
        }
        public IViewComponentResult Invoke()
        {
            var vm = new BlogPostDepartmentViewModel();
            vm.Departments = db.Departments.ToList();
            vm.Blogs = db.BlogPosts.OrderByDescending(e => e.CreatedDate).Take(3).ToList();
            return View(vm);
        }
    }
}
