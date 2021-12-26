using MediatR;
using MediClinic.Application.Core.Extensions;
using MediClinic.Application.Core.Middlewares;
using MediClinic.Application.Core.Provider;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities.Membership;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace MediClinic.WebUI
{
    public class Startup
    {
        readonly IConfiguration configuration; 
        public Startup(IConfiguration configuration) 
        {
            this.configuration = configuration; 
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(cfg => {
                cfg.ModelBinderProviders.Insert(0, new BooleanBinderProvider()); 

                var policy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();

                cfg.Filters.Add(new AuthorizeFilter(policy));
            })
                .AddNewtonsoftJson(cfg =>
                    cfg.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                );

            services.AddDbContext<MediClinicDbContext>(cfg => {
                cfg.UseSqlServer(configuration.GetConnectionString("cString"));  
            }, ServiceLifetime.Scoped);

            //service injection etmek ucun
            //services.AddScoped<Classinadi>();


            //butun urller kicik herfli olsun
            services.AddRouting(cfg => cfg.LowercaseUrls = true);

            //IActionContextAccessor'u cagiranda ActionContextAccessor'u singleton seklinde versin
            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();

            //4.1
            services.AddIdentity<MediClinicUser, MediClinicRole>()
                .AddEntityFrameworkStores<MediClinicDbContext>()
                .AddDefaultTokenProviders();

            services.AddScoped<UserManager<MediClinicUser>>(); //4.2
            services.AddScoped<RoleManager<MediClinicRole>>();  //4.3
            services.AddScoped<SignInManager<MediClinicUser>>();  //4.4
            //realtimeda deyisiklikler tetbiq olunsun
            services.AddScoped<IClaimsTransformation, AppClaimProvider>();

            services.Configure<IdentityOptions>(cfg =>
            {
                cfg.Password.RequireDigit = false;
                cfg.Password.RequireUppercase = false;
                cfg.Password.RequireLowercase = false;
                cfg.Password.RequiredUniqueChars = 1;
                cfg.Password.RequireNonAlphanumeric = false;
                cfg.Password.RequiredLength = 3;

                cfg.User.RequireUniqueEmail = true;

                cfg.Lockout.MaxFailedAccessAttempts = 3;
                cfg.Lockout.DefaultLockoutTimeSpan = new TimeSpan(0, 3, 0);

                cfg.SignIn.RequireConfirmedEmail = true;
            });

            services.ConfigureApplicationCookie(cfg =>
            {
                cfg.LoginPath = "/signin.html";
                cfg.AccessDeniedPath = "/accessdenied.html";

                cfg.ExpireTimeSpan = new TimeSpan(0, 5, 0);
                cfg.Cookie.Name = "MediClinic";
            });

            services.AddAuthentication(); //senin umumiyyetle girmeye selahiyyetin var ya yox

            //senin hara girmeye selahiyyetin var
            services.AddAuthorization(cfg =>
            {
                foreach (var item in Extension.principals)
                {
                    cfg.AddPolicy(item, p =>
                    {
                        p.RequireAssertion(h =>
                        {
                            return h.User.IsInRole("SuperAdmin") ||
                            h.User.HasClaim(item, "1");
                        });
                    });
                }

            });

            var asmbls = AppDomain.CurrentDomain.GetAssemblies().Where(a => a.FullName.StartsWith("MediClinic."))
                .ToArray();
            services.AddMediatR(asmbls);

            services.AddAutoMapper(asmbls);

        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.Seed();
            }



            //sadece rootun icindekilerin gorunmesine icaze verir
            app.UseStaticFiles();

            //program ilk ayaga qalxabda superadmini falan yaratsin 
            app.SeedMembership();

            app.UseRouting();

            app.UseRequestLocalization(cfg => {

                cfg.AddSupportedUICultures("az", "en");
                cfg.AddSupportedCultures("az", "en");

                cfg.RequestCultureProviders.Clear();
                cfg.RequestCultureProviders.Add(new CultureProvider());
            });



            //eger adminden giririkse allow olmayan bi yere admin signinne gelmesi ucun
            app.Use(async (context, next) =>
            {
                if (!context.User.Identity.IsAuthenticated
                && !context.Request.Cookies.ContainsKey("mediclinic")
                && context.Request.RouteValues.TryGetValue("area", out object areaName)
                && areaName.ToString().ToLower().Equals("admin"))
                {
                    var attr = context.GetEndpoint().Metadata.GetMetadata<AllowAnonymousAttribute>();
                    //eger actionin ustunde allowanonymous atributu varsa onda normal nexte dussun yoxdursa o zaman yonlensin signine 
                    if (attr == null)
                    {
                        context.Response.Redirect("/admin/signin.html");
                        await context.Response.CompleteAsync();
                    }

                }
                await next();
            });


            app.UseAudit();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("admin_signIn", "admin/signin.html",
                    defaults: new
                    {
                        controller = "Account",
                        action = "Login",
                        area = "Admin"
                    });

                endpoints.MapControllerRoute("default_signIn", "signin.html",
                    defaults: new
                    {
                        controller = "Account",
                        action = "SignIn",
                        area = ""
                    });

                endpoints.MapControllerRoute("admin_signOut", "admin/logout.html",
                    defaults: new
                    {
                        controller = "Account",
                        action = "Logout",
                        area = "Admin"
                    });

                endpoints.MapControllerRoute(
                      name: "areas-with-lang",
                      pattern: "{lang}/{area:exists}/{controller=Dashboard}/{action=Index}/{id?}",
                      constraints: new
                      {
                          lang = "en|az|ru"
                      }
                    );

                endpoints.MapControllerRoute(
                      name: "areas",
                      pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
                    );

                endpoints.MapControllerRoute("default-with-lang", "{lang}/{controller=home}/{action=index}/{id?}",
                    constraints: new
                    {
                        lang = "en|az|ru"
                    });
                endpoints.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}");
            });
        }
    }
}
