using MediatR;
using MediClinic.Application.Modules.Admin.BlogCategoryModule;
using MediClinic.Application.Modules.Client.BlogPostModule;
using MediClinic.Domain.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace MediClinic.WebUI.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        readonly IMediator mediator;

        public BlogController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<IActionResult> Index(BlogPostListQuery query)
        {

            var response = await mediator.Send(query);

            if (response == null)
                return NotFound();

            var vm = new BlogPostCategoriesViewModel();
            vm.BlogCategories = await mediator.Send(new BlogCategoryChooseQuery());
            vm.BlogPosts = response;
            return View(vm);
        }

        public async Task<IActionResult> Details(BlogPostDetailsQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }

            var vm = new BlogPostCategoriesDetailsViewModel();
            vm.BlogCategories = await mediator.Send(new BlogCategoryChooseQuery());
            vm.BlogPost = response;
            vm.BlogPosts = await mediator.Send(new RelatedBlogPostListQuery(response.Id, response.BlogCategoryId));

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> PostComment(BlogPostCommentCommand query)
        {

            var response = await mediator.Send(query);
            if (response.BlogPostComment == null && response.CommandJsonResponse.Error == true)
            {
                return Json(response.CommandJsonResponse);
            }
            else
            {
                return PartialView("_Comment", response.BlogPostComment);
            }
            
        }
    }
}
