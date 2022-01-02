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
    public class UserSingleQuery : IRequest<MediClinicUser>
    {
        public long? Id { get; set; }

        public class UserSingleQueryHandler : IRequestHandler<UserSingleQuery, MediClinicUser>
        {
            readonly MediClinicDbContext db;
            public UserSingleQueryHandler(MediClinicDbContext db)
            {
                this.db = db;
            }
            public async Task<MediClinicUser> Handle(UserSingleQuery request, CancellationToken cancellationToken)
            {
                if (request.Id == null && request.Id <= 0)
                    return null;

                var model =await db.Users.FirstOrDefaultAsync(s => s.Id == request.Id && s.DeletedDate == null);

                return model;
            }
        }
    }
}
