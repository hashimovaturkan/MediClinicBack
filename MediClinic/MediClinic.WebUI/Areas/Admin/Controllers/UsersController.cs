
using MediClinic.Application.Modules.Admin.UsersModule;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities.Membership;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using MediClinic.Domain.Models.FormModels;
using System.IO;
using Microsoft.Extensions.Configuration;
using MediClinic.Application.Core.Extensions;

namespace MediClinic.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
        readonly UserManager<MediClinicUser> userManager;
        readonly SignInManager<MediClinicUser> signInManager;
        readonly RoleManager<MediClinicRole> roleManager;
        readonly IConfiguration configuration;
        readonly MediClinicDbContext db;
        readonly IWebHostEnvironment env;
        readonly IMediator mediator;
        public UsersController(UserManager<MediClinicUser> userManager,
                                 SignInManager<MediClinicUser> signInManager,
                                 RoleManager<MediClinicRole> roleManager,
                                 IConfiguration configuration,
                                 MediClinicDbContext db,
                                 IWebHostEnvironment env,
                                 IMediator mediator)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.configuration = configuration;
            this.env = env;
            this.mediator = mediator;
            this.db = db;
        }

        [Authorize(Policy = "admin.users.index")]
        public async Task<IActionResult> Index(UserPagedQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
                return NotFound();

            return View(response);
        }

        [Authorize(Policy = "admin.users.details")]
        public async Task<IActionResult> Details(UserSingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }

            return View(response);
        }

        [Authorize(Policy = "admin.users.create")]
        public async Task<IActionResult> Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "admin.users.create")]
        public async Task<IActionResult> Create(CreateUserFormModel user)
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

                string password = user.Password;
                var mediClinicUser = new MediClinicUser()
                {
                    UserName = user.UserName,
                    Email = user.Email,
                    Name = user.Name,
                    Surname = user.Surname,
                    EmailConfirmed = false,
                    PhoneNumber = user.PhoneNumber,
                    CreatedByUserId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value),
                    CreatedDate = DateTime.Now
            };


                if (user.file != null)
                {
                    string extension = Path.GetExtension(user.file.FileName);
                    mediClinicUser.ImgUrl = $"{Guid.NewGuid()}{extension}";

                    string physicalFileName = Path.Combine(env.ContentRootPath,
                                                           "wwwroot",
                                                           "uploads",
                                                           "images",
                                                           mediClinicUser.ImgUrl);

                    using (var stream = new FileStream(physicalFileName, FileMode.Create, FileAccess.Write))
                    {
                        await user.file.CopyToAsync(stream);
                    }
                }

                //password 3den yxuari olmalidi
                var createdUser = userManager.CreateAsync(mediClinicUser, password).Result;

                if (createdUser.Succeeded)
                {

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

                    if (user.SendMail == true)
                    {
                        var mail = configuration.SendEmail(user.Email, "MediClinic information about your username and password.", $"<strong>Your Username </strong>: {user.UserName} ; </br><strong>Your Password </strong>: {user.Password} ;</br> ");
                        if (mail == false)
                        {
                            db.Database.RollbackTransaction();
                            return Json(new
                            {
                                error = true,
                                message = "Please, try again"
                            });
                        }

                        
                        return Json(new
                        {
                            error = false,
                            message = "Successfully, please check user's email for confirming and information about user's credentials!"
                        });

                        //db.Database.CommitTransaction();

                    }
                    else
                    {
                        return Json(new
                        {
                            error = false,
                            message = "Successfully, please check user's email for confirming!"
                        });
                    }

                    
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

        [Authorize(Policy = "admin.users.edit")]
        public async Task<IActionResult> Edit(UserSingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }

            ViewBag.Roles = await (from r in db.Roles
                                   join ur in db.UserRoles
                                   on new { RoleId = r.Id, UserId = response.Id } equals new { ur.RoleId, ur.UserId } into lJoin
                                   from lj in lJoin.DefaultIfEmpty()
                                   where r.DeletedByUserId == null
                                   select Tuple.Create(r.Id, r.Name, lj != null))
                             .ToListAsync();

            ViewBag.Principals = (from p in Extension.principals
                                  join uc in db.UserClaims
                                  on new { ClaimValue = "1", ClaimType = p, UserId = response.Id } equals new { uc.ClaimValue, uc.ClaimType, uc.UserId } into lJoin
                                  from lj in lJoin.DefaultIfEmpty()
                                  select Tuple.Create(p, lj != null))
                             .ToList();

            var model = new UserViewModel();
            model.Id = response.Id;
            model.UserName = response.UserName;
            model.Email = response.Email;
            model.EmailConfirmed = response.EmailConfirmed;
            model.PhoneNumber = response.PhoneNumber;
            model.ImgUrl = response.ImgUrl;
            model.CreatedUserId = response.CreatedByUserId;
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "admin.users.edit")]
        public async Task<IActionResult> Edit(UserUpdateCommand command)
        {
            var response = await mediator.Send(command);
            if (response > 0)
                return RedirectToAction(nameof(Index));

            return View(command);
        }


        [HttpPost]
        [Authorize(Policy = "admin.users.delete")]
        public async Task<IActionResult> Delete(UserDeleteCommand command)
        {
            command.DeletedUserId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var response = await mediator.Send(command);
            return Json(response);
        }

        [HttpPost]
        [Authorize(Policy = "admin.users.deleteAll")]
        public async Task<IActionResult> DeleteAll(UserDeleteAllCommand command)
        {
            command.DeletedUserId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var response = await mediator.Send(command);
            return Json(response);
        }

        [HttpPost]
        [Authorize(Policy = "admin.users.setrole")]
        [Route("/user-set-role")]
        public async Task<IActionResult> SetRole(int userId, int roleId, bool selected)
        {
            #region Check user and role
            var user = await db.Users.FirstOrDefaultAsync(c => c.Id == userId);
            var role = await db.Roles.FirstOrDefaultAsync(c => c.Id == roleId);
            if (user == null || role == null)
            {
                return Json(new
                {
                    message = "Wrong query!",
                    error = true
                });
            }

            
            if (userId == User.GetCurrentUserId())
            {
                return Json(new
                {
                    message = "Istifadeci ozu ozunu selahiyyetlendire bilmez!",
                    error = true
                });
            }
            #endregion

            if (selected)
            {
                if (await db.UserRoles.AnyAsync(c => c.UserId == userId && c.RoleId == roleId))
                {
                    return Json(new
                    {
                        message = $"'{user.UserName}' adli istifadeci artiq '{role.Name}' adli roldadir.",
                        error = true
                    });
                }
                else
                {
                    db.UserRoles.Add(new MediClinicUserRole
                    {
                        UserId = userId,
                        RoleId = roleId
                    });

                    await db.SaveChangesAsync();

                    return Json(new
                    {
                        message = $"'{user.UserName}' adli istifadeci '{role.Name}' adli rola elave edildi.",
                        error = false
                    });
                }
            }
            else
            {
                var userRole = await db.UserRoles.FirstOrDefaultAsync(c => c.UserId == userId && c.RoleId == roleId);

                if (userRole == null)
                {
                    return Json(new
                    {
                        message = $"'{user.UserName}' adli istifadeci artiq '{role.Name}' adli rolda deyil.",
                        error = true
                    });
                }
                else
                {
                    db.UserRoles.Remove(userRole);

                    await db.SaveChangesAsync();

                    return Json(new
                    {
                        message = $"'{user.UserName}' adli istifadeci '{role.Name}' adli roldan cixarildi.",
                        error = false
                    });
                }
            }
        }

        [HttpPost]
        [Authorize(Policy = "admin.users.principal")]
        [Route("/user-set-principal")]
        public async Task<IActionResult> SetPrincipal(int userId, string principalName, bool selected)
        {
            #region Check user and principal
            var user = await db.Users.FirstOrDefaultAsync(c => c.Id == userId);
            var hasPrincipal = Extension.principals.Contains(principalName);
            if (user == null || !hasPrincipal)
            {
                return Json(new
                {
                    message = "Wrong query!",
                    error = true
                });
            }

            //bu method videoda hardadi
            if (userId == User.GetCurrentUserId())
            {
                return Json(new
                {
                    message = "Istifadeci ozu ozunu selahiyyetlendire bilmez!",
                    error = true
                });
            }
            #endregion

            if (selected)
            {
                if (await db.UserClaims.AnyAsync(c => c.UserId == userId && c.ClaimType.Equals(principalName) && c.ClaimValue.Equals("1")))
                {
                    return Json(new
                    {
                        message = $"'{user.UserName}' adli istifadeci artiq '{principalName}' adli selahiyyete malikdir.",
                        error = true
                    });
                }
                else
                {
                    db.UserClaims.Add(new MediClinicUserClaim
                    {
                        UserId = userId,
                        ClaimType = principalName,
                        ClaimValue = "1"

                    });

                    await db.SaveChangesAsync();

                    return Json(new
                    {
                        message = $"'{principalName}' adli selahiyyet '{user.UserName}' adli istifadeciye elave edildi.",
                        error = false
                    });
                }
            }
            else
            {
                var userClaim = await db.UserClaims.FirstOrDefaultAsync(c => c.UserId == userId && c.ClaimType.Equals(principalName) && c.ClaimValue.Equals("1"));
                if (userClaim == null)
                {
                    return Json(new
                    {
                        message = $"'{user.UserName}' adli istifadeci '{principalName}' adli selahiyyete malik deyil.",
                        error = true
                    });
                }
                else
                {
                    db.UserClaims.Remove(userClaim);

                    await db.SaveChangesAsync();

                    return Json(new
                    {
                        message = $"'{user.UserName}' adli istifadeci '{principalName}' adli selahiyyetden cixarildi.",
                        error = false
                    });
                }
            }
        }

        [HttpPost]
        [Authorize(Policy = "admin.users.checkusername")]
        public async Task<IActionResult> CheckUserName(string username)
        {
            var name = await userManager.FindByNameAsync(username);
            if (name != null)
                return Json(new
                {
                    error = true,
                    message = "Your username is already used!"
                });
            else
            {
                return Json(new
                {
                    error = false
                });
            }
        }

    }
}
