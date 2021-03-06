using MediatR;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using MediClinic.Application.Core.Extensions;
using MediClinic.Domain.Models.DataContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.FaqsModule
{
    public class FaqUpdateCommand:FaqViewModel,IRequest<long>
    {
        public class FaqUpdateCommandHandler : IRequestHandler<FaqUpdateCommand, long>
        {
            readonly MediClinicDbContext db;
            readonly IActionContextAccessor ctx;
            public FaqUpdateCommandHandler(MediClinicDbContext db, IActionContextAccessor ctx)
            {
                this.ctx = ctx;
                this.db = db;
            }
            public async Task<long> Handle(FaqUpdateCommand request, CancellationToken cancellationToken)
            {
                if (request.Id == null || request.Id <= 0)
                    return 0;

                var faq = db.Faqs.FirstOrDefault(c => c.Id == request.Id && c.DeletedByUserId == null);
                if (faq == null)
                {
                    return 0;
                }

                if (ctx.IsModelStateValid())
                {
                    faq.Answer = request.Answer;
                    faq.Question = request.Question;

                    await db.SaveChangesAsync(cancellationToken);

                    return faq.Id;

                }

                return 0;

            }
        }
    }
}
