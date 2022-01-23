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
using System.Security.Claims;
using System.Threading.Tasks;

namespace MediClinic.WebUI.Controllers
{
    [AllowAnonymous]
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
            this.env = env;
            this.db = db;
        }

        public async Task<IActionResult> Profile()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = await userManager.FindByIdAsync(userId);

            return View(user);
        }

        public async Task<IActionResult> Setting()
        {
            try
            {
                var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                var user = await userManager.FindByIdAsync(userId);

                return View(user);
            }
            catch (Exception)
            {

                return Redirect("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Setting(UserFormModel newUser)
        {
            if (ModelState.IsValid)
            {
                var mUserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                var mUser = await userManager.FindByIdAsync(mUserId);

                mUser.Name = newUser.Name;
                mUser.Surname = newUser.Surname;
                mUser.PhoneNumber = newUser.PhoneNumber;

                if(newUser.UserName != mUser.UserName)
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

                if(model.NewPass != model.NewPassAgain)
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

                if (userManager.PasswordHasher.VerifyHashedPassword(user,user.PasswordHash, model.OldPass)
    != PasswordVerificationResult.Failed)
                {
                    var result =await userManager.ChangePasswordAsync(user, model.OldPass, model.NewPass);

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

        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(LoginFormModel user)
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

                if (foundedUser == null || !await userManager.IsInRoleAsync(foundedUser, "User"))
                {
                    //ViewBag.Message = "Your username or password is incorrect!";
                    return Json(new
                    {
                        error = true,
                        message = "Your username or password is incorrect!"
                    });
                    //return View(user);
                }

                if (!await userManager.IsEmailConfirmedAsync(foundedUser))
                {
                    //ViewBag.Message = "Please,confirm your email!";
                    //return View(user);
                    return Json(new
                    {
                        error = true,
                        message = "Please,confirm your email!"
                    });
                }

                var sResult = await signInManager.PasswordSignInAsync(foundedUser, user.Password, true, true);

                if (sResult.Succeeded != true)
                {
                    //ViewBag.Message = "Your username or password is incorrect!";
                    //return View(user);
                    return Json(new
                    {
                        error = true,
                        message = "Your username or password is incorrect!"
                    });
                }

                var redirectUrl = Request.Query["ReturnUrl"];
                if (!string.IsNullOrWhiteSpace(redirectUrl))
                {
                    //return Redirect(redirectUrl);
                    return Json(new
                    {
                        error = false,
                        message = "Your username or password is correct!"
                    });
                }

                return Json(new
                {
                    error = false,
                    message = "Your username or password is correct!"
                });
                //return RedirectToAction("Index", "Home");
            }
            //ViewBag.Message = "Your username or password is incorrect!";
            //return View();
            return Json(new
            {
                error = true,
                message = "Your username or password is incorrect!"
            });
        }

        [Route("register.html")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [Route("register.html")]
        public async Task<IActionResult> Register(RegisterFormModel user)
        {
            if (ModelState.IsValid)
            {
                db.Database.BeginTransaction();
                var username = await userManager.FindByNameAsync(user.UserName);
                var email = await userManager.FindByEmailAsync(user.Email);
                if (username != null)
                    return Json(new
                    {
                        error = true,
                        message = "Your username is already used!"
                    });

                if (email != null)
                    return Json(new
                    {
                        error = true,
                        message = "Your email is already registered!"
                    });

                MediClinicRole mediClinicRole = new MediClinicRole
                {
                    Name = "User"
                };

                if (!roleManager.RoleExistsAsync(mediClinicRole.Name).Result)
                {
                    var createRole = roleManager.CreateAsync(mediClinicRole).Result;
                    if (!createRole.Succeeded)
                    {
                        return Json(new
                        {
                            error = true,
                            message = "Error, please try again!"
                        });
                    }
                }
                else
                {
                    //var role = roleManager.FindByNameAsync(riodeRole.Name).Result;
                }

                string password = user.Password;
                var mediClinicUser = new MediClinicUser()
                {
                    UserName = user.UserName,
                    Email = user.Email,
                    EmailConfirmed = false,
                    ImgUrl = "notfoundprofile.png",
                    //CreatedByUserId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value),
                    CreatedDate = DateTime.Now
                };

                //password 3den yxuari olmalidi
                var createdUser = userManager.CreateAsync(mediClinicUser, password).Result;

                if (createdUser.Succeeded)
                {
                    userManager.AddToRoleAsync(mediClinicUser, mediClinicRole.Name).Wait();

                    string token = userManager.GenerateEmailConfirmationTokenAsync(mediClinicUser).Result;
                    string path = $"{Request.Scheme}://{Request.Host}/email-confirm?email={mediClinicUser.Email}&token={token}";
                    var sendMail = configuration.SendEmail(user.Email, "MediClinic email confirming", $"Please, use <a href={path}>this link</a> for confirming");

                    if (sendMail == false)
                    {
                        db.Database.RollbackTransaction();
                        return Json(new
                        {
                            error = true,
                            message = "Please, try again"
                        });
                    }

                    db.Database.CommitTransaction();


                    return Json(new
                    {
                        error = false,
                        message = "Successfully, please check your email!"
                    });
                }
                else
                {
                    return Json(new
                    {
                        error = true,
                        message = "Error, please try again!"
                    });
                }

            }

            return Json(new
            {
                error = true,
                message = "Incomplete data"
            });
        }

        [Route("email-confirm")]
        public async Task<IActionResult> EmailConfirm(string email, string token)
        {
            var user = userManager.FindByEmailAsync(email).Result;
            if (user == null)
            {
                ViewBag.Message = "Token error!";
                return View();
            }

            token = token.Replace(" ", "+");

            if (user.EmailConfirmed == true)
            {
                ViewBag.Message = "You have already confirmed.";
                return View();
            }

            IdentityResult result = await userManager.
                        ConfirmEmailAsync(user, token);
            if (result.Succeeded)
            {
                ViewBag.Message = "We're excited to have you get started. Your account is confirmed successfully.";
                return View();
            }
            else
            {
                ViewBag.Message = "Error while confirming your email!";
                return View();
            }

        }

        
        [Route("logout.html")]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [Route("accessdenied.html")]
        public IActionResult AccessDeny()
        {
            return View();
        }
    }
}
