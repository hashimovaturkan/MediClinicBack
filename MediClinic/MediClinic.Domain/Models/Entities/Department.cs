using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Domain.Models.Entities
{
    //yaradanda relationida yaratsin
    public class Department : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        //public int DoctorDepartmentRelationId { get; set; }
        public virtual ICollection<DoctorDepartmentRelation> DoctorDepartmentRelation { get; set; }
    }
}
