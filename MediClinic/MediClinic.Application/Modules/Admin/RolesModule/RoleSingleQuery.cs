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
    public class RoleSingleQuery : IRequest<MediClinicRole>
    {
        public int? Id { get; set; }

        public class RoleSingleQueryHandler : IRequestHandler<RoleSingleQuery, MediClinicRole>
        {
            readonly MediClinicDbContext db;
            public RoleSingleQueryHandler(MediClinicDbContext db)
            {
                this.db = db;
            }
            public async Task<MediClinicRole> Handle(RoleSingleQuery request, CancellationToken cancellationToken)
            {
                if (request.Id == null || request.Id <= 0)
                    return null;

                var role = await db.Roles.FirstOrDefaultAsync(c => c.Id == request.Id && c.DeletedByUserId == null, cancellationToken);

                return role;
            }
        }
    }
}
