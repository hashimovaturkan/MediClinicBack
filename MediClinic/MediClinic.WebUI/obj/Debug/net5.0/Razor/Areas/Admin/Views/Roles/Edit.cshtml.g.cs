#pragma checksum "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f621592b8650eca5ff6ded9ef687561489059a30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Roles_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/Roles/Edit.cshtml")]
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
#line 4 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Core.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Domain.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Domain.Models.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Domain.Models.Entities.Membership;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.UsersModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.BlogCategoryModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.BlogPostModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.ContactPostModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.FaqsModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.AppointmentModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.BlogCommentModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.DoctorModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.DepartmentModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MediClinic.Application.Modules.Admin.RolesModule;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f621592b8650eca5ff6ded9ef687561489059a30", @"/Areas/Admin/Views/Roles/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41acf7729a735fd3b807901ddd4d7195679f5fd0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Roles_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleRoleClaimsDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("selectClaimIds"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/jquery-image-input/image-input.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/ckeditor5/ckeditor.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/jquery-image-input/jquery.image-input.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    var k = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"content-body\">\r\n    <!-- row -->\r\n    <div class=\"container-fluid\">\r\n        <h1 class=\"mb-5\">Role Edit</h1>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f621592b8650eca5ff6ded9ef687561489059a3011906", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f621592b8650eca5ff6ded9ef687561489059a3012185", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 15 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        <label name=\"Name\" class=\"control-label\">Role Name</label>\r\n                        <input name=\"Name\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 625, "\"", 659, 1);
#nullable restore
#line 18 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Edit.cshtml"
WriteAttributeValue("", 633, Model.MediClinicRole.Name, 633, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f621592b8650eca5ff6ded9ef687561489059a3014556", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 19 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MediClinicRole.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                    <div>\r\n                        <div id=\"claimsBox\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f621592b8650eca5ff6ded9ef687561489059a3016394", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 23 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.RoleClaims;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            <label class=\"control-label\">Role Claims</label>\r\n");
#nullable restore
#line 25 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Edit.cshtml"
                             foreach (var item in Model?.MediClinicRoleClaims)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"form-group claimIdAdd\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f621592b8650eca5ff6ded9ef687561489059a3018584", async() => {
                    WriteLiteral("\r\n                                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f621592b8650eca5ff6ded9ef687561489059a3018893", async() => {
#nullable restore
#line 29 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Edit.cshtml"
                                                                            Write(item.ClaimType);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Edit.cshtml"
                                                    WriteLiteral(item.ClaimType);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1295, "Claims_", 1295, 7, true);
#nullable restore
#line 28 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Edit.cshtml"
AddHtmlAttributeValue("", 1302, k, 1302, 4, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 1306, "_", 1306, 1, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginWriteTagHelperAttribute();
                WriteLiteral("Claims[");
#nullable restore
#line 28 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Edit.cshtml"
                                                               WriteLiteral(k);

#line default
#line hidden
#nullable disable
                WriteLiteral("]");
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("name", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1334, "form-control", 1334, 12, true);
                AddHtmlAttributeValue(" ", 1346, "selectClaimIds-", 1347, 16, true);
#nullable restore
#line 28 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Edit.cshtml"
AddHtmlAttributeValue("", 1362, k, 1362, 2, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
#nullable restore
#line 28 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.RoleClaims;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    <i class=\"fa fa-trash removeClaim deleteItem\" data-toggle=\"tooltip\" title=\"Delete\"></i>\r\n                                </div>\r\n");
#nullable restore
#line 33 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Edit.cshtml"
                                k = k + 1;
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </div>
                        <button type=""button"" class=""btn btn-rounded btn-info addClaim"">
                            <span class=""btn-icon-left text-info"">
                                <i class=""fa fa-plus color-info""></i>
                            </span>Add Role Claim
                        </button>
                    </div>
                    <input type=""hidden"" name=""Id""");
                BeginWriteAttribute("value", " value=\"", 2218, "\"", 2250, 1);
#nullable restore
#line 42 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Edit.cshtml"
WriteAttributeValue("", 2226, Model.MediClinicRole.Id, 2226, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <div class=\"form-group\">\r\n                        <button type=\"submit\" class=\"btn btn-success mt-5\">Save</button>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f621592b8650eca5ff6ded9ef687561489059a3027594", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("addcss", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f621592b8650eca5ff6ded9ef687561489059a3028907", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <style>\r\n        .removeClaim {\r\n            color: red;\r\n        }\r\n\r\n        .addClaim {\r\n            background-color: #86c6f3;\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
            DefineSection("addjs", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f621592b8650eca5ff6ded9ef687561489059a3030423", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f621592b8650eca5ff6ded9ef687561489059a3031523", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    \r\n    <script>\r\n        $(document).ready(function () {\r\n            var l = ");
#nullable restore
#line 78 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Areas\Admin\Views\Roles\Edit.cshtml"
               Write(k);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
            $("".addClaim"").click(function (e) {
                e.preventDefault();
                var a = '<div class=""form-group claimIdAdd""><select class=""form-control selectClaimIds-' + l + ' valid"" data-val=""true"" data-val-required=""The Claim is required."" id=""Claims_' + l + '_"" name=""Claims[' + l + ']""></select><i class=""fa fa-trash removeClaim deleteItem"" data-toggle=""tooltip"" title=""Delete""></i></div>';
                $(""#claimsBox"").append(a);
                $("".selectClaimIds-"" + l + """").append($("".selectClaimIds"").html());
                l = l + 1;
                $("".removeClaim"").click(function (e) {
                    $(this).parent("".claimIdAdd"").css(""display"", ""none"");
                    $(this).parent("".claimIdAdd"").find(""select option:selected"").val(null);
                })
            })

            $("".removeClaim"").click(function (e) {
                $(this).parent("".claimIdAdd"").css(""display"", ""none"");
                $(this).parent("".claimIdAdd"").find(""select o");
                WriteLiteral("ption:selected\").val(null);\r\n            })\r\n        })\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleRoleClaimsDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
