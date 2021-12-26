using MediClinic.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Domain.Models.Entities
{
    public class WorkTimeWeekDayRelation: BaseEntity
    {
        public WeekDay WeekDay { get; set; }
        public int WorkTimeId { get; set; }
        public virtual WorkTime WorkTime { get; set; }
    }
}
