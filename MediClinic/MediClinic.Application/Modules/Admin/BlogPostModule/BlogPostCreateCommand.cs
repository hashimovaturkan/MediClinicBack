using MediClinic.Application.Core.Extensions;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.BlogPostModule
{
    public class BlogPostCreateCommand : IRequest<int>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public DateTime? PublishedDate { get; set; }
        public string ImgUrl { get; set; }
        public int BlogCategoryId { get; set; }
        public int DoctorId { get; set; }
        public int CreatedUserId { get; set; }
        public IFormFile file { get; set; }
        public class BlogPostCreateCommandHandler : IRequestHandler<BlogPostCreateCommand, int>
        {
            readonly MediClinicDbContext db;
            readonly IActionContextAccessor ctx;
            readonly IWebHostEnvironment env;
            public BlogPostCreateCommandHandler(MediClinicDbContext db, IActionContextAccessor ctx, IWebHostEnvironment env)
            {
                this.ctx = ctx;
                this.db = db;
                this.env = env;
            }
            public async Task<int> Handle(BlogPostCreateCommand request, CancellationToken cancellationToken)
            {
                if (request.file == null)
                {
                    ctx.ActionContext.ModelState.AddModelError("file", "There is not image");
                }

                if (ctx.IsModelStateValid())
                {
                    var model = new BlogPost();
                    model.Title = request.Title;
                    model.Content = request.Content;
                    model.Description = request.Description;
                    model.PublishedDate = request.PublishedDate;
                    model.BlogCategoryId = request.BlogCategoryId;
                    model.DoctorId = request.DoctorId;
                    model.CreatedByUserId = request.CreatedUserId;
                    model.CreatedDate = DateTime.Now;

                    string extension = Path.GetExtension(request.file.FileName);
                    model.ImgUrl = $"{Guid.NewGuid()}{extension}";

                    string physicalFileName = Path.Combine(env.ContentRootPath,
                                                           "wwwroot",
                                                           "uploads",
                                                           "images",
                                                           model.ImgUrl);

                    using (var stream = new FileStream(physicalFileName, FileMode.Create, FileAccess.Write))
                    {
                        await request.file.CopyToAsync(stream);
                    }

                    db.BlogPosts.Add(model);
                    await db.SaveChangesAsync();

                    return model.Id;
                }

                return 0;




            }
        }
    }
}
