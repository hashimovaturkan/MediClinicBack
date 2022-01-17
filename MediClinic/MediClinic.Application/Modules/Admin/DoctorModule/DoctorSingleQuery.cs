using MediatR;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.DoctorModule
{
    public class DoctorSingleQuery : IRequest<Doctor>
    {
        public long? Id { get; set; }

        public class DoctorSingleQueryHandler : IRequestHandler<DoctorSingleQuery, Doctor>
        {
            readonly MediClinicDbContext db;
            public DoctorSingleQueryHandler(MediClinicDbContext db)
            {
                this.db = db;
            }
            public async Task<Doctor> Handle(DoctorSingleQuery request, CancellationToken cancellationToken)
            {
                if (request.Id == null && request.Id <= 0)
                    return null;

                var model = db.Doctors
                    .Include(e => e.DoctorDepartmentRelation.Where(k => k.DeletedByUserId == null))
                    .ThenInclude(e => e.Department)
                    .Include(e => e.DoctorWorkTimeRelation.Where(k => k.DeletedByUserId == null))
                    .ThenInclude(e => e.WorkTime)
                    .Include(e => e.SocialMedia.Where(k => k.DeletedByUserId == null))
                    .FirstOrDefault(s => s.Id == request.Id && s.DeletedDate == null);

                return model;
            }
        }
    }
}
