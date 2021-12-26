using MediClinic.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Domain.Models.ViewModels
{
    public class BlogPostCategoriesDetailsViewModel
    {
        public List<BlogCategory> BlogCategories { get; set; }
        public BlogPost BlogPost { get; set; }
        public List<BlogPost> BlogPosts { get; set; }
    }
}
