#pragma checksum "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11c10f25736f4eab2e799f1d27e83751729e178a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Roles_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Roles/Index.cshtml")]
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
#line 4 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Core.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Domain.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Domain.Models.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Domain.Models.Entities.Membership;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.UsersModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.BlogCategoryModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.BlogPostModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.ContactPostModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.FaqsModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.AppointmentModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.BlogCommentModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.DoctorModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.DepartmentModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.RolesModule;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11c10f25736f4eab2e799f1d27e83751729e178a", @"/Areas/Admin/Views/Roles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41acf7729a735fd3b807901ddd4d7195679f5fd0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Roles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedViewModel<MediClinicRole>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Roles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "roles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("view"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Index.cshtml"
  
    ViewData["Title"] = "Index";

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
                    <div class=""col-sm-6"">
                        <h2><b>Users</b></h2>
                    </div>
                    <div class=""col-sm-6"">
");
#nullable restore
#line 16 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Index.cshtml"
                         if (User.HasAccess("admin.roles.create"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11c10f25736f4eab2e799f1d27e83751729e178a10597", async() => {
                WriteLiteral("<i class=\"fa fa-plus \"></i> <span>Add New Size</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Index.cshtml"

                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Index.cshtml"
                         if (User.HasAccess("admin.roles.delete"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a id=\"deleteAll\" class=\"btn btn-danger\"><i class=\"fa fa-trash\"></i> <span>Delete</span></a>\r\n");
#nullable restore
#line 24 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
            <table class=""table table-striped table-hover"">
                <thead>
                    <tr>
                        <th>
                            <span class=""custom-checkbox"">
                                <input type=""checkbox"" id=""selectAll"">
                                <label for=""selectAll""></label>
                            </span>
                        </th>
                        <th>Role</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 42 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Index.cshtml"
                     foreach (var item in Model.Items)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td class=\"check-content\">\r\n                                <span class=\"custom-checkbox\">\r\n                                    <input type=\"checkbox\"");
            BeginWriteAttribute("id", " id=\"", 1859, "\"", 1881, 2);
            WriteAttributeValue("", 1864, "checkbox-", 1864, 9, true);
#nullable restore
#line 47 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Index.cshtml"
WriteAttributeValue("", 1873, item.Id, 1873, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-checkbox=\"");
#nullable restore
#line 47 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Index.cshtml"
                                                                                            Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"selectDelete\">\r\n                                    <label");
            BeginWriteAttribute("for", " for=\"", 1973, "\"", 1996, 2);
            WriteAttributeValue("", 1979, "checkbox-", 1979, 9, true);
#nullable restore
#line 48 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Index.cshtml"
WriteAttributeValue("", 1988, item.Id, 1988, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></label>\r\n                                </span>\r\n                            </td>\r\n                            <td>");
#nullable restore
#line 51 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"crud-btn\">\r\n");
#nullable restore
#line 53 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Index.cshtml"
                                 if (User.HasAccess("admin.roles.edit"))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11c10f25736f4eab2e799f1d27e83751729e178a16470", async() => {
                WriteLiteral("<i class=\"fa fa-edit\" data-toggle=\"tooltip\" title=\"Edit\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Index.cshtml"
                                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 56 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Index.cshtml"
                                 if (User.HasAccess("admin.roles.delete"))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2661, "\"", 2693, 3);
            WriteAttributeValue("", 2671, "removeEntity(", 2671, 13, true);
#nullable restore
#line 59 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Index.cshtml"
WriteAttributeValue("", 2684, item.Id, 2684, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2692, ")", 2692, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"delete\"><i class=\"fa fa-trash\" data-toggle=\"tooltip\" title=\"Delete\"></i></a>\r\n");
#nullable restore
#line 60 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Index.cshtml"
                                 if (User.HasAccess("admin.roles.details"))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11c10f25736f4eab2e799f1d27e83751729e178a20958", async() => {
                WriteLiteral("<i class=\"fa fa-eye\" data-toggle=\"tooltip\" title=\"Details\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Index.cshtml"
                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 64 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 67 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <div class=\"pagination-wrapper\">\r\n            ");
#nullable restore
#line 72 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Index.cshtml"
       Write(Model.GetPagenation(Url, "Index", "Admin"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedViewModel<MediClinicRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591