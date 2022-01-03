using MediatR;
using MediClinic.Application.Core.Extensions;
using MediClinic.Domain.Models.DataContexts;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.DepartmentModule
{
    public class DepartmentUpdateCommand : DepartmentViewModel, IRequest<int>
    {
        public class DepartmentUpdateCommandHandler : IRequestHandler<DepartmentUpdateCommand, int>
        {
            readonly MediClinicDbContext db;
            readonly IActionContextAccessor ctx;
            readonly IWebHostEnvironment env;
            public DepartmentUpdateCommandHandler(MediClinicDbContext db, IActionContextAccessor ctx, IWebHostEnvironment env)
            {
                this.ctx = ctx;
                this.db = db;
                this.env = env;
            }
            public async Task<int> Handle(DepartmentUpdateCommand request, CancellationToken cancellationToken)
            {
                if (request.Id == null || request.Id <= 0)
                    return 0;

                if (string.IsNullOrWhiteSpace(request.fileTemp) && request.file == null)
                {
                    ctx.ActionContext.ModelState.AddModelError("file", "Image was added!");
                }

                if (ctx.IsModelStateValid())
                {
                    var entity = await db.BlogPosts.FirstOrDefaultAsync(b => b.Id == request.Id && b.DeletedByUserId == null);

                    if (entity == null)
                    {
                        return 0;
                    }

                    entity.Title = request.Title;
                    entity.Content = request.Content;
                    entity.Description = request.Description;

                    if (request.file != null)
                    {
                        string extension = Path.GetExtension(request.file.FileName);
                        request.ImgUrl = $"{Guid.NewGuid()}{extension}";

                        string physicalFileName = Path.Combine(env.ContentRootPath,
                                                               "wwwroot",
                                                               "uploads",
                                                               "images",
                                                               request.ImgUrl);

                        using (var stream = new FileStream(physicalFileName, FileMode.Create, FileAccess.Write))
                        {
                            await request.file.CopyToAsync(stream);
                        }

                        if (!string.IsNullOrWhiteSpace(entity.ImgUrl))
                        {
                            System.IO.File.Delete(Path.Combine(env.ContentRootPath,
                                                              "wwwroot",
                                                              "uploads",
                                                              "images",
                                                              entity.ImgUrl));
                        }

                        entity.ImgUrl = request.ImgUrl;

                    }

                    await db.SaveChangesAsync();
                    return entity.Id;

                }
                return 0;

            }
        }
    }
}
