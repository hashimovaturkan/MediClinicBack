using MediClinic.Domain.Models.Entities.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.RolesModule
{
    public class RoleRoleClaimsDto
    {
        public MediClinicRole MediClinicRole { get; set; }
        public List<MediClinicRoleClaim> MediClinicRoleClaims { get; set; }
    }
}
