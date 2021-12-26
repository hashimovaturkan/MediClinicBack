using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Domain.Models.Entities
{
    public class DoctorDepartmentRelation : BaseEntity
    {
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
