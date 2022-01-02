using MediatR;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Client.DepartmentModule
{
    public class DepartmentDetailsQuery : IRequest<Department>
    {
        public int? Id { get; set; }
        public class DepartmentDetailsQueryHandler : IRequestHandler<DepartmentDetailsQuery, Department>
        {
            readonly MediClinicDbContext db;
            public DepartmentDetailsQueryHandler(MediClinicDbContext db)
            {
                this.db = db;
            }
            public async Task<Department> Handle(DepartmentDetailsQuery request, CancellationToken cancellationToken)
            {
                if (request.Id == null && request.Id <= 0)
                    return null;

                var model = await db.Departments
                    .Include(e => e.DoctorDepartmentRelation)
                    .ThenInclude(e => e.Doctor).ThenInclude(e => e.SocialMedia)
                    .FirstOrDefaultAsync(s => s.DeletedByUserId == null && s.Id == request.Id);

                return model;
            }
        }
    }
}
