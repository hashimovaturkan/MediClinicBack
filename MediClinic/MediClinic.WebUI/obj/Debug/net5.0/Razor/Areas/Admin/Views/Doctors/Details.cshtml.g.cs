#pragma checksum "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Doctors\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fd0a3f5ab8382bd376a809004aed8d739e8b888"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Doctors_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Doctors/Details.cshtml")]
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
#line 4 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Core.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Domain.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Domain.Models.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Domain.Models.Entities.Membership;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.UsersModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.BlogCategoryModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.BlogPostModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.ContactPostModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.FaqsModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.AppointmentModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.BlogCommentModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.DoctorModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.DepartmentModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.RolesModule;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fd0a3f5ab8382bd376a809004aed8d739e8b888", @"/Areas/Admin/Views/Doctors/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41acf7729a735fd3b807901ddd4d7195679f5fd0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Doctors_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Doctor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("120"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Doctors\Details.cshtml"
      
        ViewData["Title"] = "Details";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <div class=""content-body"">
        <!-- row -->
        <div class=""container-fluid"">
            <div class=""table-wrapper"">
                <div class=""table-title"">
                    <div class=""row"">
                        <div class=""col-sm-12"">
                            <h2 class=""text-center"">Doctor <b>Details</b></h2>
                        </div>
                    </div>
                </div>
            </div>
            <table class=""table table-striped table-hover"">

                <tbody>
                    <tr>
                        <th>Image</th>
                        <td>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3fd0a3f5ab8382bd376a809004aed8d739e8b8889389", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 747, "~/uploads/images/", 747, 17, true);
#nullable restore
#line 26 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Doctors\Details.cshtml"
AddHtmlAttributeValue("", 764, Model.ImgUrl, 764, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Name</th>\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Doctors\Details.cshtml"
                       Write(Model?.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>About Content</th>\r\n                        <td>");
#nullable restore
#line 35 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Doctors\Details.cshtml"
                       Write(Model.AboutContent?.PlainText());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Email</th>\r\n                        <td>");
#nullable restore
#line 39 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Doctors\Details.cshtml"
                       Write(Model?.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Education</th>\r\n                        <td>");
#nullable restore
#line 43 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Doctors\Details.cshtml"
                       Write(Model?.Education);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Experience</th>\r\n                        <td>");
#nullable restore
#line 47 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Doctors\Details.cshtml"
                       Write(Model?.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Speciality</th>\r\n                        <td>");
#nullable restore
#line 51 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Doctors\Details.cshtml"
                       Write(Model?.Speciality);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Phone</th>\r\n                        <td>");
#nullable restore
#line 55 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Doctors\Details.cshtml"
                       Write(Model?.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Room</th>\r\n                        <td>");
#nullable restore
#line 59 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Doctors\Details.cshtml"
                       Write(Model?.Room);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Description</th>\r\n                        <td>");
#nullable restore
#line 63 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Doctors\Details.cshtml"
                       Write(Model?.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Social Media</th>\r\n");
#nullable restore
#line 67 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Doctors\Details.cshtml"
                         foreach (var item in Model?.SocialMedia)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 69 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Doctors\Details.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" --------- ");
#nullable restore
#line 69 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Doctors\Details.cshtml"
                                                Write(item.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 70 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Doctors\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\r\n                    <tr>\r\n                        <th>Departments</th>\r\n");
#nullable restore
#line 74 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Doctors\Details.cshtml"
                         foreach (var item in Model?.DoctorDepartmentRelation)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 76 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Doctors\Details.cshtml"
                           Write(item.Department.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 77 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Doctors\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\r\n                    <tr>\r\n                        <th>Work Time</th>\r\n");
#nullable restore
#line 81 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Doctors\Details.cshtml"
                         foreach (var item in Model?.DoctorWorkTimeRelation)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 83 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Doctors\Details.cshtml"
                           Write(item.WorkTime.WeekDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 84 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Doctors\Details.cshtml"
                           Write(item.WorkTime.StartedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 84 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Doctors\Details.cshtml"
                                                        Write(item.WorkTime.EndedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 85 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Doctors\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\r\n\r\n                </tbody>\r\n            </table>\r\n            <div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fd0a3f5ab8382bd376a809004aed8d739e8b88818817", async() => {
                WriteLiteral("<i class=\"fa fa-edit\" data-toggle=\"tooltip\" title=\"Edit\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "C:\Users\HP\Desktop\Medi\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Doctors\Details.cshtml"
                                       WriteLiteral(Model?.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fd0a3f5ab8382bd376a809004aed8d739e8b88821179", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Doctor> Html { get; private set; }
    }
}
#pragma warning restore 1591
