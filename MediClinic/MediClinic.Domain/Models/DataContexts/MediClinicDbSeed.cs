using MediClinic.Domain.Models.Entities.Membership;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Domain.Models.DataContexts
{
    public static class MediClinicDbSeed
    {
        public static IApplicationBuilder SeedMembership(this IApplicationBuilder builder)
        {
            using (var scope = builder.ApplicationServices.CreateScope())
            {


                var role = new MediClinicRole
                {
                    Name = "SuperAdmin"
                };

                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<MediClinicUser>>();
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<MediClinicRole>>();


                bool hasRole = roleManager.RoleExistsAsync(role.Name).Result;   //role axtarilsin
                if (hasRole == true) //eger role varsa
                {
                    role = roleManager.FindByNameAsync(role.Name).Result;  //hemin rolu tap
                }
                else  //eger rol yoxdursa
                {
                    var iResult = roleManager.CreateAsync(role).Result; //hemin rolu yarat
                    if (!iResult.Succeeded)         //eger rol yaradila bilmedise
                        goto end;
                }

                string password = "123";

                var user = new MediClinicUser
                {
                    UserName = "Turkan",
                    Email = "turkan@mail.ru",
                    EmailConfirmed = true,
                    ImgUrl = "notfoundprofile.png"

                };

                var founded = userManager.FindByEmailAsync(user.Email).Result;   // user axtarilsin

                if (founded != null && !userManager.IsInRoleAsync(founded, role.Name).Result)  // eger user varsa ve hemin rolda deyilse
                {
                    userManager.AddToRoleAsync(founded, role.Name).Wait();   //useri hemin rola add ele
                }
                else if (founded == null)  // eger user yoxdursa
                {
                    var iUserResult = userManager.CreateAsync(user, password).Result;  // useri yarat

                    if (iUserResult.Succeeded) //eger user yaradildisa
                    {
                        userManager.AddToRoleAsync(user, role.Name).Wait();   //useri hemin rola add ele
                    }
                    else
                    {
                        goto end;
                    }
                }
            }

        end:
            return builder;
        }

        public static IApplicationBuilder Seed(this IApplicationBuilder builder)
        {
            using (var scope = builder.ApplicationServices.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<MediClinicDbContext>();
                db.Database.Migrate();

                //eger ilk yarananda isteyirikse bos qalmasin biseyler mesleen bloglar bele edirik
                //InitBlogPosts(db);
            }
            return builder;
        }
    }
}
