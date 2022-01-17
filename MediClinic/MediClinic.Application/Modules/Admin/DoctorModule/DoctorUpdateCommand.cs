using MediatR;
using MediClinic.Application.Core.Extensions;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities;
using MediClinic.Domain.Models.Enums;
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

                    if (request.DepartmentIds != null)
                    {
                        //silinsin
                        var IsDeletedDepartments = await db.DoctorDepartmentRelations.Where(e => e.DoctorId == entity.Id && !request.DepartmentIds.Contains(e.DepartmentId)).ToListAsync();
                        foreach (var department in IsDeletedDepartments)
                        {
                            department.DeletedByUserId = request.CreatedUserId;
                            department.DeletedDate = DateTime.Now;
                        }

                        foreach (var id in request.DepartmentIds)
                        {
                            if (id != 0)
                            {
                                //teze yaransin
                                var department = await db.DoctorDepartmentRelations.FirstOrDefaultAsync(e => e.DepartmentId == id && e.DoctorId == entity.Id);
                                if (department == null || department.DeletedByUserId != null)
                                {
                                    var doctorDepartment = new DoctorDepartmentRelation();
                                    doctorDepartment.DoctorId = entity.Id;
                                    doctorDepartment.DepartmentId = id;
                                    doctorDepartment.CreatedByUserId = request.CreatedUserId;
                                    doctorDepartment.CreatedDate = DateTime.Now;

                                    db.DoctorDepartmentRelations.Add(doctorDepartment);
                                    await db.SaveChangesAsync(cancellationToken);
                                }
                                else //update
                                {
                                    department.DepartmentId = id;
                                    await db.SaveChangesAsync(cancellationToken);
                                }
                            }

                        }

                    
                    }

                    if(request.SocialMediaModels != null)
                    {
                        //silinsin
                        var IsDeletedMedia = await db.SocialMedia.Where(e => !request.SocialMediaModels.Select(k => k.Id).Contains(e.Id) && e.DoctorId == entity.Id).ToListAsync();
                        foreach (var media in IsDeletedMedia)
                        {
                            media.DeletedByUserId = request.CreatedUserId;
                            media.DeletedDate = DateTime.Now;
                        }

                        foreach (var media in request.SocialMediaModels)
                        {
                            if (media.Name != null && media.Url != null)
                            {
                                //teze yaransin
                                var socialMedia = await db.SocialMedia.FirstOrDefaultAsync(e => e.Id == media.Id);
                                if (socialMedia == null || socialMedia.DeletedByUserId != null)
                                {
                                    var m = new SocialMedia();
                                    m.DoctorId = entity.Id;
                                    m.Url = media.Url;
                                    m.Name = media.Name;
                                    m.CreatedByUserId = request.CreatedUserId;
                                    m.CreatedDate = DateTime.Now;

                                    db.SocialMedia.Add(m);
                                    await db.SaveChangesAsync(cancellationToken);
                                }
                                else  //update
                                {
                                    socialMedia.Url = media.Url;
                                    socialMedia.Name = media.Name;
                                    await db.SaveChangesAsync(cancellationToken);
                                }
                            }

                        }

                    
                    }

                    if(request.WorkTimeModels != null)
                    {
                        //silinsin
                        var IsDeletedTime = await db.WorkTimes.Where(e => !request.WorkTimeModels.Select(k => k.Id).Contains(e.Id) && e.DoctorWorkTimeRelation.Select(k => k.DoctorId).Contains(entity.Id)).ToListAsync();
                        foreach (var time in IsDeletedTime)
                        {
                            var m = await db.DoctorWorkTimeRelations.Where(e => e.DoctorId == entity.Id && e.WorkTimeId == time.Id).FirstOrDefaultAsync();
                            if (m != null)
                            {
                                m.DeletedByUserId = request.CreatedUserId;
                                m.DeletedDate = DateTime.Now;
                            }

                        }

                        foreach (var item in request.WorkTimeModels)
                        {
                            if (item?.EndedTime != null && item?.StartedTime != null && item.WeekDay != null)
                            {
                                //teze yaransin
                                var workTime = await db.WorkTimes.FirstOrDefaultAsync(e => e.Id == item.Id);
                                if (workTime == null || workTime.DeletedByUserId != null)
                                {
                                    var a = new DateTime();
                                    var b = new DateTime();

                                    var workTimeModel = new WorkTime();
                                    workTimeModel.StartedTime = a.AddHours((double)item.StartedTime.Hour).AddMinutes((double)item.StartedTime.Minute);
                                    workTimeModel.EndedTime = b.AddHours((double)item.EndedTime.Hour).AddMinutes((double)item.EndedTime.Minute);
                                    workTimeModel.WeekDay = (WeekDay)Enum.Parse(typeof(WeekDay), item.WeekDay, true);
                                    workTimeModel.CreatedByUserId = request.CreatedUserId;
                                    workTimeModel.CreatedDate = DateTime.Now;

                                    db.WorkTimes.Add(workTimeModel);
                                    await db.SaveChangesAsync(cancellationToken);

                                    var workTimeRelation = new DoctorWorkTimeRelation();
                                    workTimeRelation.DoctorId = entity.Id;
                                    workTimeRelation.WorkTimeId = workTimeModel.Id;
                                    workTimeRelation.CreatedDate = DateTime.Now;
                                    workTimeRelation.CreatedByUserId = request.CreatedUserId;

                                    db.DoctorWorkTimeRelations.Add(workTimeRelation);
                                    await db.SaveChangesAsync(cancellationToken);

                                }
                                else //update
                                {
                                    var a = new DateTime();
                                    var b = new DateTime();

                                    workTime.StartedTime = a.AddHours((double)item.StartedTime.Hour).AddMinutes((double)item.StartedTime.Minute);
                                    workTime.EndedTime = b.AddHours((double)item.EndedTime.Hour).AddMinutes((double)item.EndedTime.Minute);
                                    workTime.WeekDay = (WeekDay)Enum.Parse(typeof(WeekDay), item.WeekDay, true);
                                    await db.SaveChangesAsync(cancellationToken);
                                }
                            }

                        }

                        
                    }


                    await db.SaveChangesAsync(cancellationToken);

                    return entity.Id;

                //return 0;

            }
        }
    }
}
