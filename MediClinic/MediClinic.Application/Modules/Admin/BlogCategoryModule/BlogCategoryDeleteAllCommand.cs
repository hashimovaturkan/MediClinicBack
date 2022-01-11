using MediatR;
using MediClinic.Application.Core.Infrastructure;
using MediClinic.Domain.Models.DataContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.BlogCategoryModule
{
    public class BlogCategoryDeleteAllCommand : IRequest<CommandJsonResponse>
    {
        public int[] mustDeleted { get; set; }
        public int? DeletedUserId { get; set; }

        public class BlogCategoryDeleteAllCommandHandler : IRequestHandler<BlogCategoryDeleteAllCommand, CommandJsonResponse>
        {
            readonly MediClinicDbContext db;
            public BlogCategoryDeleteAllCommandHandler(MediClinicDbContext db)
            {
                this.db = db;
            }
            public async Task<CommandJsonResponse> Handle(BlogCategoryDeleteAllCommand request, CancellationToken cancellationToken)
            {
                var response = new CommandJsonResponse();

                if (request.mustDeleted == null)
                {
                    response.Error = true;
                    response.Message = "The information is incomplete!";
                    return response;
                }

                foreach (var item in request.mustDeleted)
                {
                    var BlogCategory = db.BlogCategories.FirstOrDefault(s => s.Id == item && s.DeletedByUserId == null);
                    if (BlogCategory == null)
                    {
                        response.Error = true;
                        response.Message = "There is no data!";
                        return response;
                    }

                    BlogCategory.DeletedByUserId = request.DeletedUserId;
                    BlogCategory.DeletedDate = DateTime.Now;
                }

                response.Error = false;
                response.Message = "Successfully operation!";

                await db.SaveChangesAsync(cancellationToken);

                return response;

            }
        }
    }
}
