using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.DepartmentModule
{
    public class DepartmentViewModel
    {
        public int? Id { get; set; }
        public int? CreatedUserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public IFormFile file { get; set; }
        public string fileTemp { get; set; }
    }
}
