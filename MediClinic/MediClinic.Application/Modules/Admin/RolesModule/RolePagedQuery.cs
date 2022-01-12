using MediatR;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities.Membership;
using MediClinic.Domain.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.RolesModule
{
    public class RolePagedQuery : IRequest<PagedViewModel<MediClinicRole>>
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public class RolePagedQueryHandler : IRequestHandler<RolePagedQuery, PagedViewModel<MediClinicRole>>
        {
            readonly MediClinicDbContext db;
            public RolePagedQueryHandler(MediClinicDbContext db)
            {
                this.db = db;
            }
            public async Task<PagedViewModel<MediClinicRole>> Handle(RolePagedQuery request, CancellationToken cancellationToken)
            {
                var model = db.Roles.Where(s => s.DeletedByUserId == null).AsQueryable();

                return new PagedViewModel<MediClinicRole>(model, request.PageIndex, request.PageSize);
            }
        }
    }
}
