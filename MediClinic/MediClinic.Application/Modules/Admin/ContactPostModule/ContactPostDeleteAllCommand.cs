using MediatR;
using MediClinic.Application.Core.Infrastructure;
using MediClinic.Domain.Models.DataContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.ContactPostModule
{
    public class ContactPostDeleteAllCommand : IRequest<CommandJsonResponse>
    {
        public int[] mustDeleted { get; set; }
        public int? DeletedUserId { get; set; }

        public class ContactPostDeleteAllCommandHandler : IRequestHandler<ContactPostDeleteAllCommand, CommandJsonResponse>
        {
            readonly MediClinicDbContext db;
            public ContactPostDeleteAllCommandHandler(MediClinicDbContext db)
            {
                this.db = db;
            }
            public async Task<CommandJsonResponse> Handle(ContactPostDeleteAllCommand request, CancellationToken cancellationToken)
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
                    var BlogPost = db.ContactPosts.FirstOrDefault(s => s.Id == item && s.DeletedByUserId == null);
                    if (BlogPost == null)
                    {
                        response.Error = true;
                        response.Message = "There is no data!";
                        return response;
                    }

                    BlogPost.DeletedByUserId = request.DeletedUserId;
                    BlogPost.DeletedDate = DateTime.Now;
                }

                response.Error = false;
                response.Message = "Successfully operation!";

                await db.SaveChangesAsync(cancellationToken);

                return response;

            }
        }

    }
}
