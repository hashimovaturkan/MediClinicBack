using MediatR;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using MediClinic.Application.Core.Extensions;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.FaqsModule
{
    public class FaqCreateCommand:IRequest<int>
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public int? CreatedUserId { get; set; }

        public class FaqCreateCommandHandler : IRequestHandler<FaqCreateCommand, int>
        {
            readonly MediClinicDbContext db;
            readonly IActionContextAccessor ctx;
            public FaqCreateCommandHandler(MediClinicDbContext db, IActionContextAccessor ctx)
            {
                this.db = db;
            }
            public async Task<int> Handle(FaqCreateCommand request, CancellationToken cancellationToken)
            {
                
                    var faq =new Faq();
                    faq.Answer = request.Answer;
                    faq.Question = request.Question;
                    faq.CreatedByUserId = request.CreatedUserId;
                    faq.CreatedDate = DateTime.Now;

                    await db.Faqs.AddAsync(faq);
                    await db.SaveChangesAsync(cancellationToken);

                    return faq.Id;
                
            }
        }
    }
}
