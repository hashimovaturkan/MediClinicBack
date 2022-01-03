using MediClinic.Application.Core.Extensions;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.BlogCategoryModule
{
    public class BlogCategoryCreateCommand : IRequest<int>
    {
        public string Name { get; set; }
        public int? CreatedUserId { get; set; }
       
        public class BlogCategoryCreateCommandHandler : IRequestHandler<BlogCategoryCreateCommand, int>
        {
            readonly MediClinicDbContext db;
            readonly IActionContextAccessor ctx;
            public BlogCategoryCreateCommandHandler(MediClinicDbContext db, IActionContextAccessor ctx)
            {
                this.ctx = ctx;
                this.db = db;
            }
            public async Task<int> Handle(BlogCategoryCreateCommand request, CancellationToken cancellationToken)
            {
                if (ctx.IsModelStateValid())
                {
                    var model = new BlogCategory();
                    model.Name = request.Name;
                    model.CreatedByUserId = request.CreatedUserId;
                    model.CreatedDate = DateTime.Now;

                    db.BlogCategories.Add(model);
                    await db.SaveChangesAsync();

                    return model.Id;

                }

                return 0;

            }
        }
    }
}
