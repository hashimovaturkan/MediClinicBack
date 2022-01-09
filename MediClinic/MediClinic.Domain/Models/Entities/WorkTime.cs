using MediClinic.Domain.Models.Enums;
using System;
using System.Collections.Generic;

namespace MediClinic.Domain.Models.Entities
{
    //weekdayleri selectde qoy
    public class WorkTime:BaseEntity
    {
        //public virtual ICollection<WorkTimeWeekDayRelation> WorkTimeWeekDayRelation { get; set; }
        public WeekDay WeekDay { get; set; }
        public DateTime StartedTime { get; set; }
        public DateTime EndedTime { get; set; }
        public virtual ICollection<DoctorWorkTimeRelation> DoctorWorkTimeRelation { get; set; }


    }
}
