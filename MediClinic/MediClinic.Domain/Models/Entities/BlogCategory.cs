using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Domain.Models.Entities
{
    public class BlogCategory:BaseEntity
    {
        public string Name { get; set; }
        public int? OrderBy { get; set; } = 0;
        public virtual List<BlogPost> BlogPosts { get; set; }
    }
}
