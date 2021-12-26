using MediClinic.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Domain.Models.ViewModels
{
    public class BlogPostCategoriesViewModel
    {
        public List<BlogCategory> BlogCategories { get; set; }
        public PagedViewModel<BlogPost> BlogPosts { get; set; }
    }
}
