using MediatR;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities;
using MediClinic.Domain.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Client.BlogPostModule
{
    public class BlogPostListQuery : IRequest<PagedViewModel<BlogPost>>
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 6;
        public int Id { get; set; } 

        public class BlogPostListQueryHandler : IRequestHandler<BlogPostListQuery, PagedViewModel<BlogPost>>
        {
            readonly MediClinicDbContext db;
            public BlogPostListQueryHandler(MediClinicDbContext db)
            {
                this.db = db;
            }
            public async Task<PagedViewModel<BlogPost>> Handle(BlogPostListQuery request, CancellationToken cancellationToken)
            {
                if (request.Id == 0)
                {
                    var model = db.BlogPosts
                    .Include(e => e.BlogCategory)
                    .Include(e => e.Doctor)
                    .Where(s => s.DeletedByUserId == null && s.PublishedDate <= DateTime.Now)
                    .OrderByDescending(e => e.CreatedDate)
                    .AsQueryable();

                    return new PagedViewModel<BlogPost>(model, request.PageIndex, request.PageSize);
                }
                else
                {
                    var model = db.BlogPosts
                    .Include(e => e.BlogCategory)
                    .Include(e => e.Doctor)
                    .Where(s => s.DeletedByUserId == null && s.PublishedDate <= DateTime.Now && s.BlogCategoryId == request.Id)
                    .OrderByDescending(e => e.CreatedDate)
                    .AsQueryable();

                    return new PagedViewModel<BlogPost>(model, request.PageIndex, request.PageSize);
                }

                
            }
        }
    }
}
