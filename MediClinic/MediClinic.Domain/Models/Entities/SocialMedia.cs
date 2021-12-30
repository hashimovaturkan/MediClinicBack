using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Domain.Models.Entities
{
    public class SocialMedia :BaseEntity
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public virtual ICollection<DoctorSocialMediaRelation> DoctorSocialMediaRelations { get; set; }
    }
}
