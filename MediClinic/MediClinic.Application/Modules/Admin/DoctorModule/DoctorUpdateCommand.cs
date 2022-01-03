using MediatR;
using MediClinic.Application.Core.Extensions;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities;
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

namespace MediClinic.Application.Modules.Admin.DoctorModule
{
    public class DoctorUpdateCommand : DoctorViewModel, IRequest<int>
    {
        public class DoctorUpdateCommandHandler : IRequestHandler<DoctorUpdateCommand, int>
        {
            readonly MediClinicDbContext db;
            readonly IActionContextAccessor ctx;
            readonly IWebHostEnvironment env;
            public DoctorUpdateCommandHandler(MediClinicDbContext db, IActionContextAccessor ctx, IWebHostEnvironment env)
            {
                this.ctx = ctx;
                this.db = db;
                this.env = env;
            }
            public async Task<int> Handle(DoctorUpdateCommand request, CancellationToken cancellationToken)
            {
                if (request.Id == null || request.Id <= 0)
                    return 0;

                if (string.IsNullOrWhiteSpace(request.fileTemp) && request.file == null)
                {
                    ctx.ActionContext.ModelState.AddModelError("file", "Image was added!");
                }

                if (ctx.IsModelStateValid())
                {
                    var entity = await db.Doctors.FirstOrDefaultAsync(b => b.Id == request.Id && b.DeletedByUserId == null);

                    if (entity == null)
                    {
                        return 0;
                    }

                    entity.Name = request.Name;
                    entity.Phone = request.Phone;
                    entity.Room = request.Room;
                    entity.Speciality = request.Speciality;
                    entity.Education = request.Education;
                    entity.Experience = request.Experience;
                    entity.Email = request.Email;
                    entity.AboutContent = request.AboutContent;
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

                    foreach (var id in request.DepartmentIds)
                    {
                        //teze yaransin
                        var department = await db.DoctorDepartmentRelations.FirstOrDefaultAsync(e => e.Id == id && e.DoctorId == entity.Id);
                        if (department == null)
                        {
                            var doctorDepartment = new DoctorDepartmentRelation();
                            doctorDepartment.DoctorId = entity.Id;
                            doctorDepartment.DepartmentId = id;
                            doctorDepartment.CreatedByUserId = request.CreatedUserId;
                            doctorDepartment.CreatedDate = DateTime.Now;

                            db.DoctorDepartmentRelations.Add(doctorDepartment);
                        }
                    }

                    //silinsin
                    var IsDeletedDepartments = await db.DoctorDepartmentRelations.Where(e => e.DoctorId == entity.Id && !request.DepartmentIds.Contains(e.DepartmentId)).ToListAsync();
                    foreach (var department in IsDeletedDepartments)
                    {
                        department.DeletedByUserId = request.CreatedUserId;
                        department.DeletedDate = DateTime.Now;
                    }

                    foreach (var media in request.SocialMediaModels)
                    {
                        //teze yaransin
                        var socialMedia = await db.SocialMedia.FirstOrDefaultAsync(e => e.Id == media.Id);
                        if (socialMedia == null)
                        {
                            var m = new SocialMedia();
                            m.DoctorId = entity.Id;
                            m.Url = media.Url;
                            m.Name = media.Name;
                            m.CreatedByUserId = request.CreatedUserId;
                            m.CreatedDate = DateTime.Now;

                            db.SocialMedia.Add(m);
                        }
                    }

                    //silinsin
                    var IsDeletedMedia = await db.SocialMedia.Where(e => !request.SocialMediaModels.Select(k => k.Id).Contains(e.Id)).ToListAsync();
                    foreach (var media in IsDeletedMedia)
                    {
                        media.DeletedByUserId = request.CreatedUserId;
                        media.DeletedDate = DateTime.Now;
                    }


                    if (request.WorkTimeId == null)
                    {
                        var workTime = new WorkTime();
                        workTime.StartedTime = request.StartedTime;
                        workTime.EndedTime = request.EndedTime;

                        db.WorkTimes.Add(workTime);
                        await db.SaveChangesAsync(cancellationToken);
                        entity.WorkTimeId = workTime.Id;

                        foreach (var weekDay in request.WeekDays)
                        {
                            var m = new WorkTimeWeekDayRelation();
                            m.WorkTimeId = entity.WorkTimeId;
                            m.WeekDay = weekDay;
                            m.CreatedByUserId = request.CreatedUserId;
                            m.CreatedDate = DateTime.Now;

                            db.WorkTimeWeekDayRelations.Add(m);
                        }
                        await db.SaveChangesAsync(cancellationToken);

                    }






                    await db.SaveChangesAsync();
                    return entity.Id;

                }
                return 0;

            }
        }
    }
}
