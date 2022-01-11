using MediatR;
using MediClinic.Application.Core.Infrastructure;
using MediClinic.Domain.Models.DataContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.UsersModule
{
    public class UserDeleteAllCommand : IRequest<CommandJsonResponse>
    {
        public int[] mustDeleted { get; set; }
        public int? DeletedUserId { get; set; }

        public class UserDeleteAllCommandHandler : IRequestHandler<UserDeleteAllCommand, CommandJsonResponse>
        {
            readonly MediClinicDbContext db;
            public UserDeleteAllCommandHandler(MediClinicDbContext db)
            {
                this.db = db;
            }
            public async Task<CommandJsonResponse> Handle(UserDeleteAllCommand request, CancellationToken cancellationToken)
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
                    var User = db.Users.FirstOrDefault(s => s.Id == item && s.DeletedByUserId == null);
                    if (User == null)
                    {
                        response.Error = true;
                        response.Message = "There is no data!";
                        return response;
                    }

                    User.DeletedByUserId = request.DeletedUserId;
                    User.DeletedDate = DateTime.Now;
                }

                response.Error = false;
                response.Message = "Successfully operation!";

                await db.SaveChangesAsync(cancellationToken);

                return response;

            }
        }
    }
}
