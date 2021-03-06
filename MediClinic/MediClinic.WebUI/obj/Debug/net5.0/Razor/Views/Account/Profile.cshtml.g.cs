#pragma checksum "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Account\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b84c697f020fe907d40b4adb54e2eef8d89aacb9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Profile), @"mvc.1.0.view", @"/Views/Account/Profile.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 3 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\_ViewImports.cshtml"
using MediClinic.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\_ViewImports.cshtml"
using MediClinic.Application.Core.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\_ViewImports.cshtml"
using MediClinic.Domain.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\_ViewImports.cshtml"
using MediClinic.Domain.Models.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\_ViewImports.cshtml"
using MediClinic.Application.Core.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\_ViewImports.cshtml"
using Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\_ViewImports.cshtml"
using MediClinic.Domain.Models.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\_ViewImports.cshtml"
using MediClinic.Domain.Models.Entities.Membership;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b84c697f020fe907d40b4adb54e2eef8d89aacb9", @"/Views/Account/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9cacdcd74fff0c4b6024b4ab95c09d39c797628", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MediClinicUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Account\Profile.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""profile__main"">
    <div class=""custom-container-fluid p-0 main__img"">
        <div class=""main__wrapper"">
            <h1 class=""main__title"">Profile</h1>
            <span class=""main__subtitle"">Home  /   Profile</span>
        </div>
    </div>
</section>
<section class=""profile"">
    <div class=""custom-container d-flex justify-content-center"">
        <div class=""profile__wrapper"">
            <div class=""row"">
                <div class=""col-12 col-md-12 col-lg-12 col-sm-12 col-xl-12"">
                    <div class=""profile__title"">
                        <h2>");
#nullable restore
#line 21 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Account\Profile.cshtml"
                       Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    </div>\r\n                    <div class=\"profile__info\">\r\n                        <div class=\"profile__img\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 856, "\"", 891, 2);
            WriteAttributeValue("", 862, "/uploads/images/", 862, 16, true);
#nullable restore
#line 25 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Account\Profile.cshtml"
WriteAttributeValue("", 878, Model.ImgUrl, 878, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""user"">
                        </div>
                        <div class=""profile__details"">
                            <h3>Profile details</h3>
                            <ul>
                                <li>
                                    <span>FullName</span>
                                    <span>");
#nullable restore
#line 32 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Account\Profile.cshtml"
                                      Write(Model.Name == null || Model.Surname == null ? "----" : $"{Model.Name} {Model.Surname}");

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                                <li>\r\n                                    <span>UserName</span>\r\n                                    <span>");
#nullable restore
#line 36 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Account\Profile.cshtml"
                                      Write(Model.UserName == null ? "----" : Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                                <li>\r\n                                    <span>Email:</span>\r\n                                    <span>");
#nullable restore
#line 40 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Account\Profile.cshtml"
                                     Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                                <li>\r\n                                    <span>Phone:</span>\r\n                                    <span>");
#nullable restore
#line 44 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Account\Profile.cshtml"
                                      Write(Model.PhoneNumber == null ? "----" : Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MediClinicUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
