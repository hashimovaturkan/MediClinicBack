using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities;
using MediClinic.Domain.Models.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.BlogPostModule
{
    public class BlogPostPagedQuery : IRequest<PagedViewModel<BlogPost>>
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public class BlogPostPagedQueryHandler : IRequestHandler<BlogPostPagedQuery, PagedViewModel<BlogPost>>
        {
            readonly MediClinicDbContext db;
            public BlogPostPagedQueryHandler(MediClinicDbContext db)
            {
                this.db = db;
            }
            public async Task<PagedViewModel<BlogPost>> Handle(BlogPostPagedQuery request, CancellationToken cancellationToken)
            {
                var model = db.BlogPosts.Where(s => s.DeletedByUserId == null)
                    .OrderByDescending(e => e.CreatedDate).AsQueryable();

                return new PagedViewModel<BlogPost>(model, request.PageIndex, request.PageSize);
            }
        }
    }
}
