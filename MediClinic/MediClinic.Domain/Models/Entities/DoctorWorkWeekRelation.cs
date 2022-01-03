using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Domain.Models.Entities
{
    public class DoctorWorkWeekRelation:BaseEntity
    {
        public int WorkTimeWeekDayRelationId { get; set; }
        public virtual WorkTimeWeekDayRelation WorkTimeWeekDayRelation { get; set; }
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
