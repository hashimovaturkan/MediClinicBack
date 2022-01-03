using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Domain.Models.FormModels
{
    public class AppointmentFeedback
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public bool IsAccepted { get; set; }
        public int DoctorId { get; set; }
        public DateTime? Date { get; set; }
    }
}
