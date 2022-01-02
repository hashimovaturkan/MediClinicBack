using MediatR;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Client.DepartmentModule
{
    public class DepartmentListQuery : IRequest<IEnumerable<Department>>
    {
        public class DepartmentListQueryHandler : IRequestHandler<DepartmentListQuery, IEnumerable<Department>>
        {
            readonly MediClinicDbContext db;
            public DepartmentListQueryHandler(MediClinicDbContext db)
            {
                this.db = db;
            }
            public async Task<IEnumerable<Department>> Handle(DepartmentListQuery request, CancellationToken cancellationToken)
            {
                var model = await db.Departments
                    .Where(e => e.DeletedByUserId == null)
                    .ToListAsync();

                return model;
            }
        }
    }
}
