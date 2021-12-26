using MediatR;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Client.BlogPostModule
{
    public class BlogPostDetailsQuery : IRequest<BlogPost>
    {
        public int? Id { get; set; }

        public class BlogPostDetailsQueryHandler : IRequestHandler<BlogPostDetailsQuery, BlogPost>
        {
            readonly MediClinicDbContext db;
            public BlogPostDetailsQueryHandler(MediClinicDbContext db)
            {
                this.db = db;
            }
            public async Task<BlogPost> Handle(BlogPostDetailsQuery request, CancellationToken cancellationToken)
            {
                if (request.Id == null && request.Id <= 0)
                    return null;

                var model = await db.BlogPosts
                    .Include(e => e.Doctor)
                    .Include(e => e.BlogCategory)
                    .Include(c => c.Comments)
                    .ThenInclude(c => c.MediClinicUser)
                    .Include(c => c.Comments)
                    .ThenInclude(c => c.Children)
                    .FirstOrDefaultAsync(s => s.DeletedByUserId == null && s.Id == request.Id && s.PublishedDate != null);

                return model;
            }
        }
    }
}
