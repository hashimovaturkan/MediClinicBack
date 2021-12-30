using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Domain.Models.FormModels
{
    public class UserFormModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string ImgUrl { get; set; }
        public string Email { get; set; }
    }
}
