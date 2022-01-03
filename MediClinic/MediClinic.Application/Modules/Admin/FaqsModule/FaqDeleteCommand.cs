using MediatR;
using MediClinic.Application.Core.Infrastructure;
using MediClinic.Domain.Models.DataContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.FaqsModule
{
    public class FaqDeleteCommand:IRequest<CommandJsonResponse>
    {
        public int? Id { get; set; }
        public int? DeletedUserId { get; set; }

        public class FaqDeleteCommandHandler : IRequestHandler<FaqDeleteCommand, CommandJsonResponse>
        {
            readonly MediClinicDbContext db;
            public FaqDeleteCommandHandler(MediClinicDbContext db)
            {
                this.db = db;
            }
            public async Task<CommandJsonResponse> Handle(FaqDeleteCommand request, CancellationToken cancellationToken)
            {
                if (request.Id <=0 || request.Id == null)
                {
                    return new CommandJsonResponse() {
                        Error = true,
                        Message = "The information is incomplete!"
                    };

                }
                var faq =db.Faqs.FirstOrDefault(m=> m.Id == request.Id && m.DeletedByUserId == null);

                if(faq == null)
                {
                    return new CommandJsonResponse()
                    {
                        Error = true,
                        Message = "There is no data!"
                    };
                }

                faq.DeletedByUserId = request.DeletedUserId;
                faq.DeletedDate = DateTime.Now;
                await db.SaveChangesAsync(cancellationToken);

                return new CommandJsonResponse()
                {
                    Error = false,
                    Message = "Successfully operation!"
                };

            }
        }
    }
}
