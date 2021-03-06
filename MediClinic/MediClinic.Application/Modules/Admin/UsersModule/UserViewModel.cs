using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.UsersModule
{
    public class UserViewModel
    {
        public int? Id { get; set; }
        public int? CreatedUserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PhoneNumber { get; set; }
        public IFormFile file { get; set; }
        public string ImgUrl { get; set; }
        public string fileTemp { get; set; }
    }
}
