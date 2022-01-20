using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Domain.Models.FormModels
{
    public class CreateUserFormModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        //public string ImgUrl { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public IFormFile file { get; set; }
        public bool SendMail { get; set; }
    }
}
