using AutoMapper.Configuration;
using MediatR;
using MediClinic.Application.Core.Extensions;
using MediClinic.Application.Modules.Admin.RolesModule;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities.Membership;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MediClinic.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RolesController : Controller
    {
        readonly UserManager<MediClinicUser> userManager;
        readonly SignInManager<MediClinicUser> signInManager;
        readonly RoleManager<MediClinicRole> roleManager;
        readonly MediClinicDbContext db;
        readonly IMediator mediator;
        readonly IWebHostEnvironment env;
        public RolesController(UserManager<MediClinicUser> userManager,
                                 SignInManager<MediClinicUser> signInManager,
                                 RoleManager<MediClinicRole> roleManager,
                                 MediClinicDbContext db,
                                 IWebHostEnvironment env,
                                 IMediator mediator)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.env = env;
            this.db = db;
            this.mediator = mediator;
        }

        [Authorize(Policy = "admin.roles.index")]
        public async Task<IActionResult> Index(RolePagedQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
                return NotFound();

            return View(response);
        }


        [Authorize(Policy = "admin.roles.details")]
        public async Task<IActionResult> Details(RoleSingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }

            return View(response);
        }


        [Authorize(Policy = "admin.roles.create")]
        public async Task<IActionResult> Create()
        {
            var claims = Extension.principals;
            ViewData["RoleClaims"] = new SelectList(claims);
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "admin.roles.create")]
        public async Task<IActionResult> Create(RoleCreateDto dto)
        {
            if (ModelState.IsValid)
            {
                    var role = new MediClinicRole()
                    {
                        Name = dto.Name,
                        CreatedDate = DateTime.Now,
                        CreatedByUserId = User.GetCurrentUserId()
                    };

                    IdentityResult result = await roleManager.CreateAsync(role);

                    if (result.Succeeded)
                    {
                        foreach (var item in dto.Claims)
                        {
                            if (item != null)
                            {
                                db.RoleClaims.Add(new MediClinicRoleClaim
                                {
                                    RoleId = role.Id,
                                    ClaimType = item,
                                    ClaimValue = "1",
                                    CreatedByUserId = User.GetCurrentUserId(),
                                    CreatedDate =  DateTime.Now

                                });
                                await db.SaveChangesAsync();
                            }
                        }

                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        return View(dto);
                    }
            }


            return View(dto);




        }

        [Authorize(Policy = "admin.roles.edit")]
        public async Task<IActionResult> Edit(RoleSingleQuery query)
        {
            var claims = Extension.principals;
            ViewData["RoleClaims"] = new SelectList(claims);

            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }

            return View(response);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "admin.roles.edit")]
        public async Task<IActionResult> Edit(RoleEditDto dto)
        {
            if (ModelState.IsValid)
            {
                var isExistRole = db.Roles.FirstOrDefault(e => e.Id == dto.Id);

                if(isExistRole != null)
                {
                    isExistRole.Name = dto.Name;
                    await db.SaveChangesAsync();

                    var IsExistRoleClaims = db.RoleClaims.Where(e => e.RoleId == dto.Id && e.DeletedByUserId == null).ToList();

                    var deletedClaims = IsExistRoleClaims.Where(e => !dto.Claims.Contains(e.ClaimType)).ToList();

                    foreach (var item in deletedClaims)
                    {
                        item.DeletedByUserId = User.GetCurrentUserId();
                        item.DeletedDate = DateTime.Now;
                    }

                    await db.SaveChangesAsync();
                    var createClaims = dto.Claims.Where(e => !IsExistRoleClaims.Select(k => k.ClaimType).Contains(e)).ToList();

                    foreach (var item in createClaims)
                    {
                        if (item != null)
                        {
                            db.RoleClaims.Add(new MediClinicRoleClaim
                            {
                                RoleId = dto.Id,
                                ClaimType = item,
                                ClaimValue = "1",
                                CreatedByUserId = User.GetCurrentUserId(),
                                CreatedDate = DateTime.Now

                            });
                            await db.SaveChangesAsync();
                        }

                    }

                    return RedirectToAction(nameof(Index));
                }

                return View(dto);
                
            }

            return View(dto);
        }


        //[HttpPost]
        //[Authorize(Policy = "admin.users.delete")]
        //public async Task<IActionResult> Delete(UserDeleteCommand command)
        //{
        //    command.DeletedUserId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
        //    var response = await mediator.Send(command);
        //    return Json(response);
        //}

        //[HttpPost]
        //[Authorize(Policy = "admin.users.deleteAll")]
        //public async Task<IActionResult> DeleteAll(UserDeleteAllCommand command)
        //{
        //    command.DeletedUserId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
        //    var response = await mediator.Send(command);
        //    return Json(response);
        //}

        //[HttpPost]
        //[Authorize(Policy = "admin.users.setrole")]
        //[Route("/user-set-role")]
        //public async Task<IActionResult> SetRole(int userId, int roleId, bool selected)
        //{
        //    #region Check user and role
        //    var user = await db.Users.FirstOrDefaultAsync(c => c.Id == userId);
        //    var role = await db.Roles.FirstOrDefaultAsync(c => c.Id == roleId);
        //    if (user == null || role == null)
        //    {
        //        return Json(new
        //        {
        //            message = "Wrong query!",
        //            error = true
        //        });
        //    }


        //    if (userId == User.GetCurrentUserId())
        //    {
        //        return Json(new
        //        {
        //            message = "Istifadeci ozu ozunu selahiyyetlendire bilmez!",
        //            error = true
        //        });
        //    }
        //    #endregion

        //    if (selected)
        //    {
        //        if (await db.UserRoles.AnyAsync(c => c.UserId == userId && c.RoleId == roleId))
        //        {
        //            return Json(new
        //            {
        //                message = $"'{user.UserName}' adli istifadeci artiq '{role.Name}' adli roldadir.",
        //                error = true
        //            });
        //        }
        //        else
        //        {
        //            db.UserRoles.Add(new MediClinicUserRole
        //            {
        //                UserId = userId,
        //                RoleId = roleId
        //            });

        //            await db.SaveChangesAsync();

        //            return Json(new
        //            {
        //                message = $"'{user.UserName}' adli istifadeci '{role.Name}' adli rola elave edildi.",
        //                error = false
        //            });
        //        }
        //    }
        //    else
        //    {
        //        var userRole = await db.UserRoles.FirstOrDefaultAsync(c => c.UserId == userId && c.RoleId == roleId);

        //        if (userRole == null)
        //        {
        //            return Json(new
        //            {
        //                message = $"'{user.UserName}' adli istifadeci artiq '{role.Name}' adli rolda deyil.",
        //                error = true
        //            });
        //        }
        //        else
        //        {
        //            db.UserRoles.Remove(userRole);

        //            await db.SaveChangesAsync();

        //            return Json(new
        //            {
        //                message = $"'{user.UserName}' adli istifadeci '{role.Name}' adli roldan cixarildi.",
        //                error = false
        //            });
        //        }
        //    }
        //}

        //[HttpPost]
        //[Authorize(Policy = "admin.users.principal")]
        //[Route("/user-set-principal")]
        //public async Task<IActionResult> SetPrincipal(int userId, string principalName, bool selected)
        //{
        //    #region Check user and principal
        //    var user = await db.Users.FirstOrDefaultAsync(c => c.Id == userId);
        //    var hasPrincipal = Extension.principals.Contains(principalName);
        //    if (user == null || !hasPrincipal)
        //    {
        //        return Json(new
        //        {
        //            message = "Wrong query!",
        //            error = true
        //        });
        //    }

        //    //bu method videoda hardadi
        //    if (userId == User.GetCurrentUserId())
        //    {
        //        return Json(new
        //        {
        //            message = "Istifadeci ozu ozunu selahiyyetlendire bilmez!",
        //            error = true
        //        });
        //    }
        //    #endregion

        //    if (selected)
        //    {
        //        if (await db.UserClaims.AnyAsync(c => c.UserId == userId && c.ClaimType.Equals(principalName) && c.ClaimValue.Equals("1")))
        //        {
        //            return Json(new
        //            {
        //                message = $"'{user.UserName}' adli istifadeci artiq '{principalName}' adli selahiyyete malikdir.",
        //                error = true
        //            });
        //        }
        //        else
        //        {
        //            db.UserClaims.Add(new MediClinicUserClaim
        //            {
        //                UserId = userId,
        //                ClaimType = principalName,
        //                ClaimValue = "1"

        //            });

        //            await db.SaveChangesAsync();

        //            return Json(new
        //            {
        //                message = $"'{principalName}' adli selahiyyet '{user.UserName}' adli istifadeciye elave edildi.",
        //                error = false
        //            });
        //        }
        //    }
        //    else
        //    {
        //        var userClaim = await db.UserClaims.FirstOrDefaultAsync(c => c.UserId == userId && c.ClaimType.Equals(principalName) && c.ClaimValue.Equals("1"));
        //        if (userClaim == null)
        //        {
        //            return Json(new
        //            {
        //                message = $"'{user.UserName}' adli istifadeci '{principalName}' adli selahiyyete malik deyil.",
        //                error = true
        //            });
        //        }
        //        else
        //        {
        //            db.UserClaims.Remove(userClaim);

        //            await db.SaveChangesAsync();

        //            return Json(new
        //            {
        //                message = $"'{user.UserName}' adli istifadeci '{principalName}' adli selahiyyetden cixarildi.",
        //                error = false
        //            });
        //        }
        //    }
        //}
    }
}
