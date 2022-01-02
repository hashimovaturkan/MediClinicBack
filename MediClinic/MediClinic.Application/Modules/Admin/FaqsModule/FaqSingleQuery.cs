using MediatR;
using Microsoft.EntityFrameworkCore;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.FaqsModule
{
    public class FaqSingleQuery:IRequest<Faq>
    {
        public long? Id { get; set; }

        public class FaqSingleQueryHandler : IRequestHandler<FaqSingleQuery, Faq>
        {
            readonly MediClinicDbContext db;
            public FaqSingleQueryHandler(MediClinicDbContext db)
            {
                this.db = db;
            }
            public async Task<Faq> Handle(FaqSingleQuery request, CancellationToken cancellationToken)
            {
                if (request.Id == null || request.Id <= 0)
                    return null;

                var faq = await db.Faqs.FirstOrDefaultAsync(c => c.Id == request.Id && c.DeletedByUserId == null, cancellationToken);

                return faq;
            }
        }
    }
}
