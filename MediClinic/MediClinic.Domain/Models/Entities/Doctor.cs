using MediClinic.Domain.Models.Entities.Membership;
using System.Collections.Generic;

namespace MediClinic.Domain.Models.Entities
{
    public class Doctor : BaseEntity
    {
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Speciality { get; set; }
        public string Education { get; set; }
        public string Experience { get; set; }
        public string AboutContent { get; set; }
        public string Description { get; set; }
        public string Room { get; set; }
        public virtual ICollection<DoctorDepartmentRelation> DoctorDepartmentRelation { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<BlogPost> BlogPosts { get; set; }
        public virtual ICollection<DoctorWorkTimeRelation> DoctorWorkTimeRelation { get; set; }
        public virtual ICollection<SocialMedia> SocialMedia { get; set; }
        //public int? UserId { get; set; }
        //public virtual MediClinicUser User { get; set; }

    }
}
