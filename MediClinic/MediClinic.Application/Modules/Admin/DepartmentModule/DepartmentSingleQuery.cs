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

namespace MediClinic.Application.Modules.Admin.DepartmentModule
{
    public class DepartmentSingleQuery : IRequest<Department>
    {
        public long? Id { get; set; }

        public class DepartmentSingleQueryHandler : IRequestHandler<DepartmentSingleQuery, Department>
        {
            readonly MediClinicDbContext db;
            public DepartmentSingleQueryHandler(MediClinicDbContext db)
            {
                this.db = db;
            }
            public async Task<Department> Handle(DepartmentSingleQuery request, CancellationToken cancellationToken)
            {
                if (request.Id == null && request.Id <= 0)
                    return null;

                var model = await db.Departments
                    .FirstOrDefaultAsync(s => s.Id == request.Id && s.DeletedDate == null);

                return model;
            }
        }
    }
}
