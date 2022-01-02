using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.BlogPostModule
{
    public class BlogPostSingleQuery : IRequest<BlogPost>
    {
        public long? Id { get; set; }

        public class BlogPostSingleQueryHandler : IRequestHandler<BlogPostSingleQuery, BlogPost>
        {
            readonly MediClinicDbContext db;
            public BlogPostSingleQueryHandler(MediClinicDbContext db)
            {
                this.db = db;
            }
            public async Task<BlogPost> Handle(BlogPostSingleQuery request, CancellationToken cancellationToken)
            {
                if (request.Id == null && request.Id <= 0)
                    return null;

                var model = await db.BlogPosts
                    .Include(e => e.Doctor)
                    .FirstOrDefaultAsync(s => s.Id == request.Id && s.DeletedDate == null);

                return model;
            }
        }
    }
}
