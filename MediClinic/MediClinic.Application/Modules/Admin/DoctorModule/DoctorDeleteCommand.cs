using MediatR;
using MediClinic.Application.Core.Infrastructure;
using MediClinic.Domain.Models.DataContexts;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.DoctorModule
{
    public class DoctorDeleteCommand : IRequest<CommandJsonResponse>
    {
        public int? Id { get; set; }
        public int? DeletedUserId { get; set; }

        public class DoctorDeleteCommandHandler : IRequestHandler<DoctorDeleteCommand, CommandJsonResponse>
        {
            readonly MediClinicDbContext db;
            public DoctorDeleteCommandHandler(MediClinicDbContext db)
            {
                this.db = db;
            }
            public async Task<CommandJsonResponse> Handle(DoctorDeleteCommand request, CancellationToken cancellationToken)
            {
                var response = new CommandJsonResponse();

                if (request.Id == null && request.Id <= 0)
                {
                    response.Error = true;
                    response.Message = "The information is incomplete!";
                    return response;
                }

                var doctor = db.Doctors.FirstOrDefault(s => s.Id == request.Id && s.DeletedByUserId == null);
                if (doctor == null)
                {
                    response.Error = true;
                    response.Message = "There is no data!";
                    return response;
                }

                doctor.DeletedByUserId = request.DeletedUserId;
                doctor.DeletedDate = DateTime.Now;
                response.Error = false;
                response.Message = "Successfully operation!";

                await db.SaveChangesAsync(cancellationToken);

                return response;

            }
        }
    }
}
