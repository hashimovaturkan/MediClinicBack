using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Domain.Models.Entities
{
    public class Appointment : BaseEntity
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public bool IsAccepted { get; set; }
        //public int? DepartmentId { get; set; }
        public int? DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
        //public virtual Department Department { get; set; }
        public DateTime? Date { get; set; }

    }
}
