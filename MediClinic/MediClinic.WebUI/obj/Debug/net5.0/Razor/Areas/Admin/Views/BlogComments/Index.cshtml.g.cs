#pragma checksum "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\BlogComments\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "248fdf1b12b5ece831ce245ef8ee64c07efea5d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_BlogComments_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/BlogComments/Index.cshtml")]
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
#line 4 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Core.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Domain.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Domain.Models.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Domain.Models.Entities.Membership;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.UsersModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.BlogCategoryModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.BlogPostModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.ContactPostModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.FaqsModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.AppointmentModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.BlogCommentModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.DoctorModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.DepartmentModule;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"248fdf1b12b5ece831ce245ef8ee64c07efea5d3", @"/Areas/Admin/Views/BlogComments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d635f936e2c23cf36b09870979634bba7f626fd6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_BlogComments_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedViewModel<BlogPostComment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("view"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\BlogComments\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""content-body"">
    <!-- row -->
    <div class=""container-fluid"">
        <div class=""table-wrapper"">
            <div class=""table-title"">
                <div class=""row"">
                    <div class=""col-sm-6"">
                        <h2><b>Personal Setting </b></h2>
                    </div>
                    <div class=""col-sm-6"">
                    </div>
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
                        <th>Comment</th>
                        <th></th>

                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 34 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\BlogComments\Index.cshtml"
                     foreach (var item in Model.Items)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td class=\"check-content\">\r\n                                <span class=\"custom-checkbox\">\r\n                                    <input type=\"checkbox\"");
            BeginWriteAttribute("id", " id=\"", 1373, "\"", 1395, 2);
            WriteAttributeValue("", 1378, "checkbox-", 1378, 9, true);
#nullable restore
#line 39 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\BlogComments\Index.cshtml"
WriteAttributeValue("", 1387, item.Id, 1387, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"options[]\" value=\"1\">\r\n                                    <label");
            BeginWriteAttribute("for", " for=\"", 1468, "\"", 1491, 2);
            WriteAttributeValue("", 1474, "checkbox-", 1474, 9, true);
#nullable restore
#line 40 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\BlogComments\Index.cshtml"
WriteAttributeValue("", 1483, item.Id, 1483, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></label>\r\n                                </span>\r\n                            </td>\r\n                            <td>");
#nullable restore
#line 43 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\BlogComments\Index.cshtml"
                           Write(item.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"crud-btn\">\r\n");
#nullable restore
#line 45 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\BlogComments\Index.cshtml"
                                 if (User.HasAccess("admin.blogpostcomments.delete"))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1842, "\"", 1874, 3);
            WriteAttributeValue("", 1852, "removeEntity(", 1852, 13, true);
#nullable restore
#line 47 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\BlogComments\Index.cshtml"
WriteAttributeValue("", 1865, item.Id, 1865, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1873, ")", 1873, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"delete\"><i class=\"fa fa-trash\" data-toggle=\"tooltip\" title=\"Delete\"></i></a>\r\n");
#nullable restore
#line 48 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\BlogComments\Index.cshtml"

                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\BlogComments\Index.cshtml"
                                 if (User.HasAccess("admin.blogpostcomments.details"))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "248fdf1b12b5ece831ce245ef8ee64c07efea5d312462", async() => {
                WriteLiteral("<i class=\"fa fa-eye\" data-toggle=\"tooltip\" title=\"Details\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\BlogComments\Index.cshtml"
                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\BlogComments\Index.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 58 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\BlogComments\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <div class=\"pagination-wrapper\">\r\n            ");
#nullable restore
#line 63 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\BlogComments\Index.cshtml"
       Write(Model.GetPagenation(Url, "Index", "Admin"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedViewModel<BlogPostComment>> Html { get; private set; }
    }
}
#pragma warning restore 1591