using MediatR;
using MediClinic.Application.Core.Extensions;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities;
using MediClinic.Domain.Models.Enums;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.DoctorModule
{
    public class DoctorCreateCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Speciality { get; set; }
        public string Education { get; set; }
        public string Experience { get; set; }
        public string AboutContent { get; set; }
        public string Description { get; set; }
        public string Room { get; set; }
        public int CreatedUserId { get; set; }
        public IList<int> DepartmentIds { get; set; }
        public IFormFile file { get; set; }
        //public DateTime StartedTime { get; set; }
        //public DateTime EndedTime { get; set; }
        //public IList<string> WeekDays { get; set; }
        public IList<SocialMediaModel> SocialMediaModels { get; set; }
        public IList<WorkTimeModel> WorkTimeModels { get; set; }

        public class SocialMediaModel
        {
            public string Name { get; set; }
            public string Url { get; set; }
        }

        public class WorkTimeModel
        {
            public DateTime? StartedTime { get; set; }
            public DateTime? EndedTime { get; set; }
            public string WeekDay { get; set; }
        }

        public class DoctorCreateCommandHandler : IRequestHandler<DoctorCreateCommand, int>
        {
            readonly MediClinicDbContext db;
            readonly IActionContextAccessor ctx;
            readonly IWebHostEnvironment env;
            public DoctorCreateCommandHandler(MediClinicDbContext db, IActionContextAccessor ctx, IWebHostEnvironment env)
            {
                this.ctx = ctx;
                this.db = db;
                this.env = env;
            }
            public async Task<int> Handle(DoctorCreateCommand request, CancellationToken cancellationToken)
            {
                //started ended datetime'da standart date qoy time'i deyishsin muqayiseye gore 
                if (ctx.IsModelStateValid())
                {
                    var model = new Doctor();
                    model.Name = request.Name;
                    model.Phone = request.Phone;
                    model.Room = request.Room;
                    model.Speciality = request.Speciality;
                    model.Education = request.Education;
                    model.Experience = request.Experience;
                    model.Email = request.Email;
                    model.AboutContent = request.AboutContent;
                    model.Description = request.Description;
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

                    db.Doctors.Add(model);
                    await db.SaveChangesAsync(cancellationToken);

                    foreach (var item in request.WorkTimeModels)
                    {
                        if (item.EndedTime != null && item.StartedTime != null && item.WeekDay != null)
                        {
                            var isExistWorkTime = db.WorkTimes.Where(e => e.EndedTime == item.EndedTime && e.StartedTime == item.StartedTime && e.WeekDay == (WeekDay)Enum.Parse(typeof(WeekDay), item.WeekDay, true)).FirstOrDefault();
                            if (isExistWorkTime == null)
                            {
                                var a = new DateTime();
                                var b = new DateTime();
                                var workTime = new WorkTime();
                                workTime.StartedTime = a.AddHours((double)item.StartedTime?.Hour);
                                workTime.EndedTime = b.AddHours((double)item.EndedTime?.Hour);
                                workTime.CreatedDate = DateTime.Now;
                                workTime.CreatedByUserId = request.CreatedUserId;
                                workTime.WeekDay = (WeekDay)Enum.Parse(typeof(WeekDay), item.WeekDay, true);

                                db.WorkTimes.Add(workTime);
                                await db.SaveChangesAsync(cancellationToken);

                                var workTimeRelation = new DoctorWorkTimeRelation();
                                workTimeRelation.DoctorId = model.Id;
                                workTimeRelation.WorkTimeId = workTime.Id;
                                workTimeRelation.CreatedDate = DateTime.Now;
                                workTimeRelation.CreatedByUserId = request.CreatedUserId;

                                db.DoctorWorkTimeRelations.Add(workTimeRelation);

                            }
                            else
                            {
                                var workTimeRelation = new DoctorWorkTimeRelation();
                                workTimeRelation.DoctorId = model.Id;
                                workTimeRelation.WorkTimeId = isExistWorkTime.Id;
                                workTimeRelation.CreatedDate = DateTime.Now;
                                workTimeRelation.CreatedByUserId = request.CreatedUserId;

                                db.DoctorWorkTimeRelations.Add(workTimeRelation);
                            }
                        }

                    }
                    await db.SaveChangesAsync(cancellationToken);

                    request.SocialMediaModels = request?.SocialMediaModels?.Distinct().OrderBy(e => e.Name).ToList();
                    foreach (var media in request.SocialMediaModels)
                    {
                        if (media.Name != null && media.Url != null)
                        {
                            var socialMedia = new SocialMedia();
                            socialMedia.DoctorId = model.Id;
                            socialMedia.Name = media.Name;
                            socialMedia.Url = media.Url;
                            socialMedia.CreatedDate = DateTime.Now;
                            socialMedia.CreatedByUserId = request.CreatedUserId;

                            db.SocialMedia.Add(socialMedia);
                        }
                    }
                    await db.SaveChangesAsync(cancellationToken);

                    request.DepartmentIds = request?.DepartmentIds?.Distinct().ToList();
                    foreach (var id in request.DepartmentIds)
                    {
                        if (id != 0)
                        {
                            var doctorDepartment = new DoctorDepartmentRelation();
                            doctorDepartment.DoctorId = model.Id;
                            doctorDepartment.DepartmentId = id;
                            doctorDepartment.CreatedDate = DateTime.Now;
                            doctorDepartment.CreatedByUserId = request.CreatedUserId;

                            db.DoctorDepartmentRelations.Add(doctorDepartment);
                        }


                    }

                    await db.SaveChangesAsync(cancellationToken);
                    return model.Id;

                }

                return 0;

            }
        }
    }
}
