using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Domain.Models.FormModels
{
    public class PasswordFormModel
    {
        public string OldPass { get; set; }
        public string NewPass { get; set; }
        public string NewPassAgain { get; set; }
    }
}
