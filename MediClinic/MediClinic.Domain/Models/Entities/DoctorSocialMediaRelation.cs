using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Domain.Models.Entities
{
    public class DoctorSocialMediaRelation : BaseEntity
    {
        public int SocialMediaId { get; set; }
        public int DoctorId { get; set; }
        public virtual SocialMedia SocialMedia { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
