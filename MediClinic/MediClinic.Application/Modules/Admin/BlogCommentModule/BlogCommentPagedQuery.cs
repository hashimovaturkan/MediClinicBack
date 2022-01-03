using MediatR;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities;
using MediClinic.Domain.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.BlogCommentModule
{
    public class BlogCommentPagedQuery : IRequest<PagedViewModel<BlogPostComment>>
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public class BlogCommentPagedQueryHandler : IRequestHandler<BlogCommentPagedQuery, PagedViewModel<BlogPostComment>>
        {
            readonly MediClinicDbContext db;
            public BlogCommentPagedQueryHandler(MediClinicDbContext db)
            {
                this.db = db;
            }
            public async Task<PagedViewModel<BlogPostComment>> Handle(BlogCommentPagedQuery request, CancellationToken cancellationToken)
            {
                var model = db.BlogPostComments.Where(s => s.DeletedByUserId == null).AsQueryable();

                return new PagedViewModel<BlogPostComment>(model, request.PageIndex, request.PageSize);
            }
        }
    }
}
