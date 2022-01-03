using MediClinic.Domain.Models.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.DoctorModule
{
    public class DoctorViewModel
    {
        public int? Id { get; set; }
        public int? WorkTimeId { get; set; }
        public int? CreatedUserId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Speciality { get; set; }
        public string Education { get; set; }
        public string Experience { get; set; }
        public string AboutContent { get; set; }
        public string Description { get; set; }
        public string Room { get; set; }
        public string ImgUrl { get; set; }
        public List<int> DepartmentIds { get; set; }
        public IFormFile file { get; set; }
        public string fileTemp { get; set; }
        public DateTime StartedTime { get; set; }
        public DateTime EndedTime { get; set; }
        public List<WeekDay> WeekDays { get; set; }
        public List<SocialMediaModel> SocialMediaModels { get; set; }

        public class SocialMediaModel
        {
            public int? Id { get; set; }
            public string Name { get; set; }
            public string Url { get; set; }
        }
    }
}
