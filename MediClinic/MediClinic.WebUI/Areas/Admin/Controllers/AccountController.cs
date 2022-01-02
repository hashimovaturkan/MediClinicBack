using MediClinic.Application.Core.Extensions;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities.Membership;
using MediClinic.Domain.Models.FormModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MediClinic.WebUI.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class AccountController : Controller
    {
        readonly UserManager<MediClinicUser> userManager;
        readonly SignInManager<MediClinicUser> signInManager;
        readonly RoleManager<MediClinicRole> roleManager;
        readonly IConfiguration configuration;
        readonly MediClinicDbContext db;
        public AccountController(UserManager<MediClinicUser> userManager,
                                 SignInManager<MediClinicUser> signInManager,
                                 RoleManager<MediClinicRole> roleManager,
                                 IConfiguration configuration,
                                 MediClinicDbContext db)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.configuration = configuration;
            this.db = db;
        }

        //[Authorize(Policy = "admin.account.login")]
        //[Route("admin/signin.html")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        //[Authorize(Policy = "admin.account.login")]
        //[Route("admin/signin.html")]
        public async Task<IActionResult> Login(LoginFormModel user)
        {
            if (ModelState.IsValid)
            {
                MediClinicUser foundedUser = null;
                if (user.UserName.IsEmail() == true)
                {
                    foundedUser = await userManager.FindByEmailAsync(user.UserName);
                }
                else
                {
                    foundedUser = await userManager.FindByNameAsync(user.UserName);
                }

                if (foundedUser == null)
                {
                    ViewBag.Message = "Your username or password is incorrect!";
                    return View(user);
                }


               
                var rIds = db.UserRoles.Where(ur => ur.UserId == foundedUser.Id).Select(ur => ur.RoleId).ToArray();

                
                var hasAnotherRole = db.Roles.Where(r => !r.NormalizedName.Equals("USER") && rIds.Contains(r.Id)).Any();

                
                if (hasAnotherRole == false)
                {
                    ViewBag.Message = "Your username or password is incorrect!";
                    return View(user);
                }

                var sResult = await signInManager.PasswordSignInAsync(foundedUser, user.Password, true, true);

                if (sResult.Succeeded != true)
                {
                    ViewBag.Message = "Your username or password is incorrect!";
                    return View(user);
                }

                return RedirectToAction("Index", "Dashboard");
            }
            ViewBag.Message = "Your username or password is incorrect!";
            return View();
        }

        //[Authorize(Policy = "admin.account.logout")]
        [Route("admin/logout.html")]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }

        //[Authorize(Policy = "admin.account.forgotpass")]
        public IActionResult ForgotPass()
        {
            return View();
        }
    }
}
