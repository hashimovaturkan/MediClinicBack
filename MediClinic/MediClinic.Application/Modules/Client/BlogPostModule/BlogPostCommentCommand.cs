using MediatR;
using MediClinic.Application.Core.Infrastructure;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities;
using MediClinic.Domain.Models.Entities.Membership;
using Microsoft.EntityFrameworkCore;
using MediClinic.Application.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace MediClinic.Application.Modules.Client.BlogPostModule
{
    public class BlogPostCommentCommand : IRequest<BlogPostCommentViewModel>
    {
        public int? commentId { get; set; }
        public int postId { get; set; }
        public string comment { get; set; }
        public string id { get; set; }

        public class BlogPostCommentCommandHandler : IRequestHandler<BlogPostCommentCommand, BlogPostCommentViewModel>
        {
            readonly MediClinicDbContext db;
            readonly IHttpContextAccessor _httpContextAccessor;
            public BlogPostCommentCommandHandler(MediClinicDbContext db, IHttpContextAccessor _httpContextAccessor)
            {
                this.db = db;
                this._httpContextAccessor = _httpContextAccessor;
            }

            public async Task<BlogPostCommentViewModel> Handle(BlogPostCommentCommand request, CancellationToken cancellationToken)
            {
                var json = new CommandJsonResponse();
                var response = new BlogPostCommentViewModel();
                if (string.IsNullOrWhiteSpace(request.comment))
                {
                    json.Error = true;
                    json.Message = "Serh bos buraxila bilmez!";

                    response.CommandJsonResponse = json;
                    return response;
                }

                if (request.postId < 1)
                {
                    json.Error = true;
                    json.Message = "Post movcud deyil!";

                    response.CommandJsonResponse = json;
                    return response;
                }


                var post = await db.BlogPosts.FirstOrDefaultAsync(c => c.Id == request.postId);


                if (post == null)
                {
                    json.Error = true;
                    json.Message = "Post movcud deyil!";

                    response.CommandJsonResponse = json;
                    return response;
                }

                //var a = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;


                var commentModel = new BlogPostComment
                {
                    ParentId = request.commentId,
                    BlogPostId = request.postId,
                    Comment = request.comment,
                    //MediClinicUserId = Microsoft.AspNetCore.Mvc.Razor.RazorPageBase.User.GetCurrentUserId()
                    MediClinicUserId = Int32.Parse(request.id)
                    //,CreatedByUserId= User.GetCurrentUserId()
            };

                if (request.commentId.HasValue && await db.BlogPostComments.AnyAsync(c => c.Id == request.commentId))
                    commentModel.ParentId = request.commentId;

                await db.BlogPostComments.AddAsync(commentModel);
                await db.SaveChangesAsync();

                commentModel = await db.BlogPostComments
                    .Include(c => c.CreatedByUserId)
                    .Include(c => c.Parent)
                    .FirstOrDefaultAsync(c => c.Id == commentModel.Id);

                json.Error = false;
                json.Message = "Elave edildi!";

                response.CommandJsonResponse = json;
                response.BlogPostComment = commentModel;
                return response;


            }
        }
    }
}
