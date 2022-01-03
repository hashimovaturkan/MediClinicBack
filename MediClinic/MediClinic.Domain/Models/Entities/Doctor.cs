using System.Collections.Generic;

namespace MediClinic.Domain.Models.Entities
{
    //yaradanda relationida yaratsin
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
        //public int DoctorDepartmentRelationId { get; set; }
        public virtual ICollection<DoctorDepartmentRelation> DoctorDepartmentRelation { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<BlogPost> BlogPosts { get; set; }
        public int WorkTimeId { get; set; }
        public virtual WorkTime WorkTime { get; set; }
        //public int DoctorWorkWeekRelationId { get; set; }
        //public virtual DoctorWorkWeekRelation DoctorWorkWeekRelation { get; set; }
        public virtual ICollection<SocialMedia> SocialMedia { get; set; }
        //public virtual ICollection<DoctorSocialMediaRelation> DoctorSocialMediaRelations { get; set; }

    }
}
