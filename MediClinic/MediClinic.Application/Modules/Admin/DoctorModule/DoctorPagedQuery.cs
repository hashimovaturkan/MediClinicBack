using MediatR;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities;
using MediClinic.Domain.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.DoctorModule
{
    public class DoctorPagedQuery : IRequest<PagedViewModel<Doctor>>
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public class DoctorPagedQueryHandler : IRequestHandler<DoctorPagedQuery, PagedViewModel<Doctor>>
        {
            readonly MediClinicDbContext db;
            public DoctorPagedQueryHandler(MediClinicDbContext db)
            {
                this.db = db;
            }
            public async Task<PagedViewModel<Doctor>> Handle(DoctorPagedQuery request, CancellationToken cancellationToken)
            {
                var model = db.Doctors
                    .Include(e => e.DoctorDepartmentRelation)
                    .ThenInclude(e => e.Department)
                    .Include(e => e.DoctorWorkTimeRelation)
                    .ThenInclude(e => e.WorkTime)
                    .Include(e => e.SocialMedia)
                    .Where(s => s.DeletedByUserId == null).AsQueryable();

                return new PagedViewModel<Doctor>(model, request.PageIndex, request.PageSize);
            }
        }
    }
}
