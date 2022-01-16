using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Domain.Models.Entities.Membership
{
    public class MediClinicRoleClaim : IdentityRoleClaim<int>
    {
        public int? CreatedByUserId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int? DeletedByUserId { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
