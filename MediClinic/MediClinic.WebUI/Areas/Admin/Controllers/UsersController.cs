﻿using MediClinic.Application.Core.Extensions;
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

namespace MediClinic.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
        readonly IMediator mediator;
        readonly MediClinicDbContext db;

        public UsersController(IMediator mediator, MediClinicDbContext db)
        {
            this.db = db;
            this.mediator = mediator;
        }
        public async Task<IActionResult> Index(UserPagedQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
                return NotFound();

            return View(response);
        }

        //[Authorize(Policy = "admin.users.details")]
        public async Task<IActionResult> Details(UserSingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }

            return View(response);
        }

        //[Authorize(Policy = "admin.users.create")]
        public async Task<IActionResult> Create()
        {
            //ViewData["CvTemplateUserId"] = new SelectList(await mediator.Send(new UserChooseQuery()), "Id", "Username" ?? "Email");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Policy = "admin.users.create")]
        public async Task<IActionResult> Create(UserCreateCommand command)
        {
            //var response = await mediator.Send(command);
            //if (response > 0)
            //    return RedirectToAction(nameof(Index));

            return View(command);
        }

        //[Authorize(Policy = "admin.users.edit")]
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
            model.CreatedUserId = response.CreatedByUserId;
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Policy = "admin.users.edit")]
        public async Task<IActionResult> Edit(UserUpdateCommand command)
        {
            var response = await mediator.Send(command);
            if (response > 0)
                return RedirectToAction(nameof(Index));

            return View(command);
        }


        [HttpPost]
        //[Authorize(Policy = "admin.users.delete")]
        public async Task<IActionResult> Delete(UserDeleteCommand command)
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

            //bu method videoda hardadi
            //if(userId = User.GetCurrentUserId())
            //{
            //    return Json(new
            //    {
            //        message = "Istifadeci ozu ozunu selahiyyetlendire bilmez!",
            //        error = true
            //    });
            //}
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
            //if (userId = User.GetCurrentUserId())
            //{
            //    return Json(new
            //    {
            //        message = "Istifadeci ozu ozunu selahiyyetlendire bilmez!",
            //        error = true
            //    });
            //}
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
    }
}
