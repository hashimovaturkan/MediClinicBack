using MediatR;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.DoctorModule
{
    public class DoctorChooseQuery : IRequest<List<Doctor>>
    {
        public class DoctorChooseQueryHandler : IRequestHandler<DoctorChooseQuery, List<Doctor>>
        {
            readonly MediClinicDbContext db;
            public DoctorChooseQueryHandler(MediClinicDbContext db)
            {
                this.db = db;
            }

            public async Task<List<Doctor>> Handle(DoctorChooseQuery request, CancellationToken cancellationToken)
            {
                var categories = await db.Doctors
                                    .Where(c => c.DeletedByUserId == null).ToListAsync();
                return categories;
            }
        }
    }
}
