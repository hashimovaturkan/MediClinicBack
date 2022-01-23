using MediClinic.Domain.Models.DataContexts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Application.Core.Components
{
    public class SubscribeViewComponent: ViewComponent
    {
        readonly MediClinicDbContext db;
        public SubscribeViewComponent(MediClinicDbContext db)
        {
            this.db = db;
        }
        public IViewComponentResult Invoke()
        {
            var model = db.Subscribes.Where(e => e.DeletedByUserId == null && e.EmailConfirmed == true).OrderByDescending(e => e.CreatedDate).Take(5).ToList();
            return View(model);
        }
    }
}
