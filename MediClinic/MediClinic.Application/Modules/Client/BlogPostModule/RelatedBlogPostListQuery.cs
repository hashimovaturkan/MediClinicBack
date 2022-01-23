using MediatR;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Client.BlogPostModule
{
    public class RelatedBlogPostListQuery : IRequest<List<BlogPost>>
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public RelatedBlogPostListQuery(int Id, int CategoryId)
        {
            this.CategoryId = CategoryId;
            this.Id = Id;
        }
            
        public class RelatedBlogPostListQueryHandler : IRequestHandler<RelatedBlogPostListQuery, List<BlogPost>>
        {
            readonly MediClinicDbContext db;
            public RelatedBlogPostListQueryHandler(MediClinicDbContext db)
            {
                this.db = db;
            }
            public async Task<List<BlogPost>> Handle(RelatedBlogPostListQuery request, CancellationToken cancellationToken)
            {
                var model = await db.BlogPosts
                    .Include(e => e.BlogCategory)
                    .Include(e => e.Doctor)
                    .Where(s => s.DeletedByUserId == null && s.Id != request.Id && s.BlogCategoryId == request.CategoryId && s.PublishedDate <= DateTime.Now)
                    .OrderByDescending(o => o.Id)
                    .Take(3)
                    .ToListAsync();

                return model;
            }
        }
    }
}
