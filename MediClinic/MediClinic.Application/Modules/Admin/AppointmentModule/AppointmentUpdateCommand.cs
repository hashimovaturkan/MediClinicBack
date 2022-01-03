using MediatR;
using MediClinic.Application.Core.Extensions;
using MediClinic.Domain.Models.DataContexts;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.AppointmentModule
{
    public class AppointmentUpdateCommand : AppointmentViewModel, IRequest<int>
    {
        public class AppointmentUpdateCommandHandler : IRequestHandler<AppointmentUpdateCommand, int>
        {
            readonly MediClinicDbContext db;
            readonly IActionContextAccessor ctx;
            readonly IWebHostEnvironment env;
            public AppointmentUpdateCommandHandler(MediClinicDbContext db, IActionContextAccessor ctx, IWebHostEnvironment env)
            {
                this.ctx = ctx;
                this.db = db;
                this.env = env;
            }
            public async Task<int> Handle(AppointmentUpdateCommand request, CancellationToken cancellationToken)
            {
                if (request.Id == null || request.Id <= 0)
                    return 0;

                if (ctx.IsModelStateValid())
                {
                    var entity = await db.Appointments.FirstOrDefaultAsync(b => b.Id == request.Id && b.DeletedByUserId == null);

                    if (entity == null)
                    {
                        return 0;
                    }

                    entity.Name = request.Name;
                    entity.Phone = request.Phone;
                    entity.Email = request.Email;
                    entity.Message = request.Message;
                    entity.IsAccepted = request.IsAccepted;
                    entity.DoctorId = request.DoctorId;
                    entity.Date = request.Date;

                    await db.SaveChangesAsync();
                    return entity.Id;

                }
                return 0;

            }
        }
    }
}
