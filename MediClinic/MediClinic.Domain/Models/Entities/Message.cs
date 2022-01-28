using MediClinic.Domain.Models.Entities.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Domain.Models.Entities
{
    public class Message:BaseEntity
    {
        public int? SendedUserId { get; set; }
        public virtual MediClinicUser SendedUser { get; set; }
        public int? AchievedUserId { get; set; }
        public virtual MediClinicUser AchievedUser { get; set; }
        public string Text { get; set; }
    }
}
