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
    public class DepartmentChooseQuery : IRequest<List<Department>>
    {
        public class DepartmentChooseQueryHandler : IRequestHandler<DepartmentChooseQuery, List<Department>>
        {
            readonly MediClinicDbContext db;
            public DepartmentChooseQueryHandler(MediClinicDbContext db)
            {
                this.db = db;
            }

            public async Task<List<Department>> Handle(DepartmentChooseQuery request, CancellationToken cancellationToken)
            {
                var categories = await db.Departments
                                    .Where(c => c.DeletedByUserId == null).ToListAsync();
                return categories;
            }
        }
    }
}
