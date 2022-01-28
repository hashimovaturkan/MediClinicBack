using MediClinic.Application.Core.Extensions;
using MediClinic.Domain.Models.DataContexts;
using MediatR;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace MediClinic.Application.Modules.Admin.UsersModule
{
    public class UserUpdateCommand : UserViewModel, IRequest<int>
    {
        public class UserUpdateCommandHandler : IRequestHandler<UserUpdateCommand, int>
        {
            readonly MediClinicDbContext db;
            readonly IActionContextAccessor ctx;
            readonly IWebHostEnvironment env;
            public UserUpdateCommandHandler(MediClinicDbContext db, IActionContextAccessor ctx, IWebHostEnvironment env)
            {
                this.ctx = ctx;
                this.db = db;
                this.env = env;
            }
            public async Task<int> Handle(UserUpdateCommand request, CancellationToken cancellationToken)
            {
                if (request.Id == null || request.Id <= 0)
                    return 0;

                var model = db.Users.FirstOrDefault(s => s.Id == request.Id && s.DeletedByUserId == null);
                if (model == null)
                    return 0;

                if (ctx.IsModelStateValid())
                {
                    model.UserName = request.UserName;
                    model.Email = request.Email;
                    model.EmailConfirmed = request.EmailConfirmed;
                    model.NormalizedEmail = request.Email.ToUpper();
                    model.NormalizedUserName = request.UserName.ToUpper();
                    model.PhoneNumber = request.PhoneNumber;

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

                        if (!string.IsNullOrWhiteSpace(model.ImgUrl))
                        {
                            System.IO.File.Delete(Path.Combine(env.ContentRootPath,
                                                              "wwwroot",
                                                              "uploads",
                                                              "images",
                                                              model.ImgUrl));
                        }

                        model.ImgUrl = request.ImgUrl;

                    }

                    await db.SaveChangesAsync(cancellationToken);

                    return model.Id;
                }
                return 0;
            }
        }
    }
}
