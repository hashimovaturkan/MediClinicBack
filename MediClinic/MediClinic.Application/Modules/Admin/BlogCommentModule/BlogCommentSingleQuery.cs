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

namespace MediClinic.Application.Modules.Admin.BlogCommentModule
{
    public class BlogCommentSingleQuery : IRequest<BlogPostComment>
    {
        public int? Id { get; set; }

        public class BlogCommentSingleQueryHandler : IRequestHandler<BlogCommentSingleQuery, BlogPostComment>
        {
            readonly MediClinicDbContext db;
            public BlogCommentSingleQueryHandler(MediClinicDbContext db)
            {
                this.db = db;
            }
            public async Task<BlogPostComment> Handle(BlogCommentSingleQuery request, CancellationToken cancellationToken)
            {
                if (request.Id == null && request.Id <= 0)
                    return null;

                var model = await db.BlogPostComments
                    .Include(e => e.MediClinicUser)
                    .Include(e => e.BlogPost)
                    .Include(e => e.Parent)
                    .Include(e => e.Children)
                    .FirstOrDefaultAsync(s => s.Id == request.Id && s.DeletedDate == null);

                return model;
            }
        }
    }
}
