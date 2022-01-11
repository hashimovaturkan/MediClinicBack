using MediatR;
using MediClinic.Application.Core.Infrastructure;
using MediClinic.Domain.Models.DataContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.FaqsModule
{
    public class FaqDeleteAllCommand : IRequest<CommandJsonResponse>
    {
        public int[] mustDeleted { get; set; }
        public int? DeletedUserId { get; set; }

        public class FaqDeleteAllCommandHandler : IRequestHandler<FaqDeleteAllCommand, CommandJsonResponse>
        {
            readonly MediClinicDbContext db;
            public FaqDeleteAllCommandHandler(MediClinicDbContext db)
            {
                this.db = db;
            }
            public async Task<CommandJsonResponse> Handle(FaqDeleteAllCommand request, CancellationToken cancellationToken)
            {
                var response = new CommandJsonResponse();

                if (request.mustDeleted == null)
                {
                    response.Error = true;
                    response.Message = "The information is incomplete!";
                    return response;
                }

                foreach (var item in request.mustDeleted)
                {
                    var Faq = db.Faqs.FirstOrDefault(s => s.Id == item && s.DeletedByUserId == null);
                    if (Faq == null)
                    {
                        response.Error = true;
                        response.Message = "There is no data!";
                        return response;
                    }

                    Faq.DeletedByUserId = request.DeletedUserId;
                    Faq.DeletedDate = DateTime.Now;
                }

                response.Error = false;
                response.Message = "Successfully operation!";

                await db.SaveChangesAsync(cancellationToken);

                return response;

            }
        }
    }
}
