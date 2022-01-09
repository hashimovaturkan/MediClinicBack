using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Domain.Models.Entities
{
    public class DoctorWorkTimeRelation:BaseEntity
    {
        public int WorkTimeId { get; set; }
        public virtual WorkTime WorkTime { get; set; }
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
