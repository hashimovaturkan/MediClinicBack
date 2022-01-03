using MediatR;
using MediClinic.Application.Core.Infrastructure;
using MediClinic.Domain.Models.DataContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.DepartmentModule
{
    public class DepartmentDeleteCommand : IRequest<CommandJsonResponse>
    {
        public int? Id { get; set; }
        public int? DeletedUserId { get; set; }

        public class DepartmentDeleteCommandHandler : IRequestHandler<DepartmentDeleteCommand, CommandJsonResponse>
        {
            readonly MediClinicDbContext db;
            public DepartmentDeleteCommandHandler(MediClinicDbContext db)
            {
                this.db = db;
            }
            public async Task<CommandJsonResponse> Handle(DepartmentDeleteCommand request, CancellationToken cancellationToken)
            {
                var response = new CommandJsonResponse();

                if (request.Id == null && request.Id <= 0)
                {
                    response.Error = true;
                    response.Message = "The information is incomplete!";
                    return response;
                }

                var size = db.BlogPosts.FirstOrDefault(s => s.Id == request.Id && s.DeletedByUserId == null);
                if (size == null)
                {
                    response.Error = true;
                    response.Message = "There is no data!";
                    return response;
                }

                size.DeletedByUserId = request.DeletedUserId;
                size.DeletedDate = DateTime.Now;
                response.Error = false;
                response.Message = "Successfully operation!";

                await db.SaveChangesAsync(cancellationToken);

                return response;

            }
        }
    }
}
