using MediatR;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities;
using MediClinic.Domain.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.DepartmentModule
{
    public class DepartmentPagedQuery : IRequest<PagedViewModel<Department>>
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public class DepartmentPagedQueryHandler : IRequestHandler<DepartmentPagedQuery, PagedViewModel<Department>>
        {
            readonly MediClinicDbContext db;
            public DepartmentPagedQueryHandler(MediClinicDbContext db)
            {
                this.db = db;
            }
            public async Task<PagedViewModel<Department>> Handle(DepartmentPagedQuery request, CancellationToken cancellationToken)
            {
                var model = db.Departments.Where(s => s.DeletedByUserId == null).AsQueryable();

                return new PagedViewModel<Department>(model, request.PageIndex, request.PageSize);
            }
        }
    }
}
