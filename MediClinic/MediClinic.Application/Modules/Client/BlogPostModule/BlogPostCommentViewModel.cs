using MediClinic.Application.Core.Infrastructure;
using MediClinic.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Client.BlogPostModule
{
    public class BlogPostCommentViewModel
    {
        public CommandJsonResponse CommandJsonResponse { get; set; }
        public BlogPostComment BlogPostComment { get; set; }
    }
}
