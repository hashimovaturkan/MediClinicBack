using MediatR;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities.Membership;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.RolesModule
{
    public class RoleSingleQuery : IRequest<RoleRoleClaimsDto>
    {
        public int? Id { get; set; }

        public class RoleSingleQueryHandler : IRequestHandler<RoleSingleQuery, RoleRoleClaimsDto>
        {
            readonly MediClinicDbContext db;
            public RoleSingleQueryHandler(MediClinicDbContext db)
            {
                this.db = db;
            }
            public async Task<RoleRoleClaimsDto> Handle(RoleSingleQuery request, CancellationToken cancellationToken)
            {
                if (request.Id == null || request.Id <= 0)
                    return null;

                var role = await db.Roles
                    .FirstOrDefaultAsync(c => c.Id == request.Id && c.DeletedByUserId == null, cancellationToken);

                var roleClaims = await db.RoleClaims
                    .Where(c => c.RoleId == request.Id && c.DeletedByUserId == null)
                    .ToListAsync(cancellationToken);

                var dto = new RoleRoleClaimsDto();
                dto.MediClinicRoleClaims = roleClaims;
                dto.MediClinicRole = role;

                return dto;
            }
        }
    }
}
