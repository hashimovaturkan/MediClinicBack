using MediClinic.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Domain.Models.ViewModels
{
    public class BlogPostDepartmentViewModel
    {
        public IEnumerable<BlogPost> Blogs { get; set; }
        public IEnumerable<Department> Departments { get; set; }
    }
}
