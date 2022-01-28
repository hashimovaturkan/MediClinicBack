using MediatR;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.BlogCategoryModule
{
    public class BlogCategoryChooseQuery : IRequest<List<BlogCategory>>
    {
        public class BlogCategoryChooseQueryHandler : IRequestHandler<BlogCategoryChooseQuery, List<BlogCategory>>
        {
            readonly MediClinicDbContext db;
            public BlogCategoryChooseQueryHandler(MediClinicDbContext db)
            {
                this.db = db;
            }

            public async Task<List<BlogCategory>> Handle(BlogCategoryChooseQuery request, CancellationToken cancellationToken)
            {
                var categories = await db.BlogCategories
                                    .Include(e => e.BlogPosts.Where(k => k.DeletedByUserId == null))
                                    .Where(c => c.DeletedByUserId == null ).ToListAsync();
                return categories;
            }
        }
    }
}
