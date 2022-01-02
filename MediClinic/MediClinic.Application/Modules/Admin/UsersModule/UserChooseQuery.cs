using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities.Membership;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.UsersModule
{
    public class UserChooseQuery : IRequest<List<MediClinicUser>>
    {
        public class UserChooseQueryHandler : IRequestHandler<UserChooseQuery, List<MediClinicUser>>
        {
            readonly MediClinicDbContext db;
            public UserChooseQueryHandler(MediClinicDbContext db)
            {
                this.db = db;
            }

            public async Task<List<MediClinicUser>> Handle(UserChooseQuery request, CancellationToken cancellationToken)
            {
                var categories = await db.Users
                                    .Where(c => c.DeletedByUserId == null).ToListAsync();
                return categories;
            }
        }
    }
}
