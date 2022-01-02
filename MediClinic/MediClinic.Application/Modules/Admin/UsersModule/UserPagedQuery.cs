using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities.Membership;
using MediClinic.Domain.Models.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.UsersModule
{
    public class UserPagedQuery : IRequest<PagedViewModel<MediClinicUser>>
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public class UserPagedQueryHandler : IRequestHandler<UserPagedQuery, PagedViewModel<MediClinicUser>>
        {
            readonly MediClinicDbContext db;
            public UserPagedQueryHandler(MediClinicDbContext db)
            {
                this.db = db;
            }
            public async Task<PagedViewModel<MediClinicUser>> Handle(UserPagedQuery request, CancellationToken cancellationToken)
            {
                var model = db.Users.Where(s => s.DeletedByUserId == null).AsQueryable();

                return new PagedViewModel<MediClinicUser>(model, request.PageIndex, request.PageSize);
            }
        }
    }
}
