using MediatR;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Client.DoctorModule
{
    public class DoctorListQuery : IRequest<IEnumerable<Doctor>>
    {
        public class DoctorListQueryHandler : IRequestHandler<DoctorListQuery, IEnumerable<Doctor>>
        {
            readonly MediClinicDbContext db;
            public DoctorListQueryHandler(MediClinicDbContext db)
            {
                this.db = db;
            }
            public async Task<IEnumerable<Doctor>> Handle(DoctorListQuery request, CancellationToken cancellationToken)
            {
                var model =await db.Doctors
                    .Include(e => e.DoctorDepartmentRelation.Where(k => k.DeletedByUserId == null)).ThenInclude(e => e.Department)
                    .Include(e => e.SocialMedia.Where(k => k.DeletedByUserId == null))
                    .Where(e => e.DeletedByUserId == null)
                    .ToListAsync();

                return model;
            }
        }
    }
}
