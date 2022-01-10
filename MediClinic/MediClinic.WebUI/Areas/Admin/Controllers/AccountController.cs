using MediClinic.Application.Core.Extensions;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities.Membership;
using MediClinic.Domain.Models.FormModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;
using System.Security.Claims;
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
        readonly IWebHostEnvironment env;
        public AccountController(UserManager<MediClinicUser> userManager,
                                 SignInManager<MediClinicUser> signInManager,
                                 RoleManager<MediClinicRole> roleManager,
                                 IConfiguration configuration,
                                 MediClinicDbContext db,
                                 IWebHostEnvironment env)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.configuration = configuration;
            this.db = db;
            this.env = env;
        }

        public async Task<IActionResult> Profile()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = await userManager.FindByIdAsync(userId);

            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Profile(UserFormModel newUser)
        {
            if (ModelState.IsValid)
            {
                var mUserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                var mUser = await userManager.FindByIdAsync(mUserId);

                mUser.Name = newUser.Name;
                mUser.Surname = newUser.Surname;
                mUser.PhoneNumber = newUser.PhoneNumber;

                if (newUser.UserName != mUser.UserName)
                {
                    var username = await userManager.FindByNameAsync(newUser.UserName);
                    if (username != null)
                        return Json(new
                        {
                            error = true,
                            message = "Your username is already used!"
                        });
                    else
                    {
                        mUser.UserName = newUser.UserName;
                    }
                }

                if (newUser.Email != mUser.Email)
                {
                    var email = await userManager.FindByEmailAsync(newUser.Email);

                    if (email != null)
                        return Json(new
                        {
                            error = true,
                            message = "Your email is already registered!"
                        });
                    else
                    {
                        mUser.Email = newUser.Email;
                        mUser.EmailConfirmed = false;
                    }


                    string token = userManager.GenerateEmailConfirmationTokenAsync(mUser).Result;
                    string path = $"{Request.Scheme}://{Request.Host}/email-confirm?email={mUser.Email}&token={token}";
                    var sendMail = configuration.SendEmail(mUser.Email, "MediClinic email confirming", $"Please, use <a href={path}>this link</a> for confirming");


                    if (sendMail == false)
                    {
                        return Json(new
                        {
                            error = true,
                            message = "Please, try again"
                        });
                    }

                    await userManager.UpdateAsync(mUser);
                    return Json(new
                    {
                        error = false,
                        message = "Successfully, Your account is updated, Please check your email for confirming!"
                    });
                }

                await userManager.UpdateAsync(mUser);

                return Json(new
                {
                    error = false,
                    message = "Successfully, Your account is updated!"
                });

            }
            return Json(new
            {
                error = true,
                message = "Incomplete data"
            });
        }


        [HttpPost]
        public async Task<IActionResult> ChangeImage(IFormFile file)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = await userManager.FindByIdAsync(userId);

            string extension = Path.GetExtension(file.FileName);
            user.ImgUrl = $"{Guid.NewGuid()}{extension}";

            string physicalFileName = Path.Combine(env.ContentRootPath,
                                                   "wwwroot",
                                                   "uploads",
                                                   "images",
                                                   user.ImgUrl);

            using (var stream = new FileStream(physicalFileName, FileMode.Create, FileAccess.Write))
            {
                await file.CopyToAsync(stream);
            }

            await userManager.UpdateAsync(user);

            return Json(new
            {
                error = false,
                message = "Your account's image is changed! Please, refresh page!"
            });

        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(PasswordFormModel model)
        {
            if (ModelState.IsValid)
            {
                //var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                //var user = await userManager.FindByIdAsync(userId);

                //var token = await userManager.GeneratePasswordResetTokenAsync(user);

                //var result = await userManager.ResetPasswordAsync(user, token, "MyN3wP@ssw0rd");

                if (model.NewPass != model.NewPassAgain)
                {
                    return Json(new
                    {
                        error = true,
                        message = "Error, Please try again!"
                    });
                }

                var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                var user = await userManager.FindByIdAsync(userId);

                //var oldPasswordHashed = userManager.PasswordHasher.HashPassword(user, model.OldPass);

                if (userManager.PasswordHasher.VerifyHashedPassword(user, user.PasswordHash, model.OldPass)
    != PasswordVerificationResult.Failed)
                {
                    var result = await userManager.ChangePasswordAsync(user, model.OldPass, model.NewPass);

                    if (!result.Succeeded)
                    {
                        return Json(new
                        {
                            error = true,
                            message = "Error,Your password could not be changed, Please try again!"
                        });
                    }
                    else
                    {
                        return Json(new
                        {
                            error = false,
                            message = "Successfully, Your password is updated!"
                        });
                    }
                }
                else
                {
                    return Json(new
                    {
                        error = true,
                        message = "Error,Your password could not be changed, Please try again!"
                    });
                }

            }
            return Json(new
            {
                error = true,
                message = "Incomplete data"
            });

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
