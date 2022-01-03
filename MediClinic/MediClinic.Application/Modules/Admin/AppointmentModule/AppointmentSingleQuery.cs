using MediatR;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.AppointmentModule
{
    public class AppointmentSingleQuery : IRequest<Appointment>
    {
        public long? Id { get; set; }

        public class AppointmentSingleQueryHandler : IRequestHandler<AppointmentSingleQuery, Appointment>
        {
            readonly MediClinicDbContext db;
            public AppointmentSingleQueryHandler(MediClinicDbContext db)
            {
                this.db = db;
            }
            public async Task<Appointment> Handle(AppointmentSingleQuery request, CancellationToken cancellationToken)
            {
                if (request.Id == null && request.Id <= 0)
                    return null;

                var model = await db.Appointments
                    .Include(e => e.Doctor)
                    .FirstOrDefaultAsync(s => s.Id == request.Id && s.DeletedDate == null);

                return model;
            }
        }
    }
}
