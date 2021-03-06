using MediatR;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Client.DoctorModule
{
    public class DoctorDetailsQuery : IRequest<Doctor>
    {
        public int? Id { get; set; }
        public class DoctorDetailsQueryHandler : IRequestHandler<DoctorDetailsQuery, Doctor>
        {
            readonly MediClinicDbContext db;
            public DoctorDetailsQueryHandler(MediClinicDbContext db)
            {
                this.db = db;
            }
            public async Task<Doctor> Handle(DoctorDetailsQuery request, CancellationToken cancellationToken)
            {
                if (request.Id == null && request.Id <= 0)
                    return null;

                var model = await db.Doctors
                    .Include(e => e.DoctorDepartmentRelation.Where(k => k.DeletedByUserId == null)).ThenInclude(e => e.Department)
                    .Include(e => e.Appointments.Where(k => k.DeletedByUserId == null))
                    .Include(c => c.BlogPosts.Where(k => k.DeletedByUserId == null))
                    .Include(e => e.SocialMedia.Where(k => k.DeletedByUserId == null))
                    .Include(c => c.DoctorWorkTimeRelation.Where(k => k.DeletedByUserId == null))
                    .ThenInclude(c => c.WorkTime)
                    .FirstOrDefaultAsync(s => s.DeletedByUserId == null && s.Id == request.Id);

                return model;
            }
        }
    }
}
