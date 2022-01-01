using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Domain.Models.Entities
{
    //bunu selectde mail/instagram/linkedin/facebook kimi selectler cixar
    public class SocialMedia :BaseEntity
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
        //public virtual ICollection<DoctorSocialMediaRelation> DoctorSocialMediaRelations { get; set; }
    }
}
