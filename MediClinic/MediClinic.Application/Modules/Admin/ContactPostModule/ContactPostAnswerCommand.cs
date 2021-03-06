using MediClinic.Application.Core.Extensions;
using MediClinic.Domain.Models.DataContexts;
using MediatR;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.ContactPostModule
{
    public class ContactPostAnswerCommand:IRequest<int?>
    {
        public int? Id { get; set; }
        public string Answer { get; set; }
        public int? AnswerUserId { get; set; }
        public class ContactPostAnswerCommandHandler : IRequestHandler<ContactPostAnswerCommand, int?>
        {
            readonly MediClinicDbContext db;
            readonly IActionContextAccessor ctx;
            readonly IConfiguration configuration;
            public ContactPostAnswerCommandHandler(MediClinicDbContext db, IActionContextAccessor ctx, IConfiguration configuration)
            {
                this.ctx = ctx;
                this.configuration = configuration;
                this.db = db;
            }
            public async Task<int?> Handle(ContactPostAnswerCommand request, CancellationToken cancellationToken)
            {
                if (request.Id == null || request.Answer == null)
                {
                    return null;

                }
                db.Database.BeginTransaction();
                
                var contactPost = await db.ContactPosts
                .FirstOrDefaultAsync(m => m.Id == request.Id
                                    && m.DeletedByUserId == null
                                    && m.AnswerDate == null);
                if (contactPost == null)
                {
                    return null;
                }
                contactPost.Answer = request.Answer;
                contactPost.AnswerDate = DateTime.Now;
                contactPost.AnswerByUserId = request.AnswerUserId;
                await db.SaveChangesAsync();
                
                var mailSend = configuration.SendEmail(contactPost.Email, "MediClinic Answer", $"{request.Answer}");
                
                if (mailSend == false)
                {
                    db.Database.RollbackTransaction();
                    return null;
                }

                db.Database.CommitTransaction();

                return request.Id;

            }
        }
    }
}
