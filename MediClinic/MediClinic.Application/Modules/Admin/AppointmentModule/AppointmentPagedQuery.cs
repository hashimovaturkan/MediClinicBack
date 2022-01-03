using MediatR;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities;
using MediClinic.Domain.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.AppointmentModule
{
    public class AppointmentPagedQuery : IRequest<PagedViewModel<Appointment>>
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public class AppointmentPagedQueryHandler : IRequestHandler<AppointmentPagedQuery, PagedViewModel<Appointment>>
        {
            readonly MediClinicDbContext db;
            public AppointmentPagedQueryHandler(MediClinicDbContext db)
            {
                this.db = db;
            }
            public async Task<PagedViewModel<Appointment>> Handle(AppointmentPagedQuery request, CancellationToken cancellationToken)
            {
                var model = db.Appointments.Where(s => s.DeletedByUserId == null).AsQueryable();

                return new PagedViewModel<Appointment>(model, request.PageIndex, request.PageSize);
            }
        }
    }
}
