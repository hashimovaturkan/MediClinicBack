#pragma checksum "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea304c5a132684e10df6211e854976aa14b05c85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_Index), @"mvc.1.0.view", @"/Views/Doctor/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea304c5a132684e10df6211e854976aa14b05c85", @"/Views/Doctor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9cacdcd74fff0c4b6024b4ab95c09d39c797628", @"/Views/_ViewImports.cshtml")]
    public class Views_Doctor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Doctor>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("team-cart__image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("img1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("team-cart__icon--center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/uploads/images/team-custom-icon-2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("team-cart__icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "doctor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("team-cart__name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("find-doctor__box"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("finddoctorfrm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""main"">
    <div class=""custom-container-fluid p-0 main__img"">
        <div class=""main__wrapper"">
            <h1 class=""main__title"">Our Doctors</h1>
            <span class=""main__subtitle"">Home  /  Our Doctors</span>
        </div>
    </div>
</section>
<section class=""our-doctors my-8"">
    <div class=""custom-container"">
        <h2 class=""doctors__title"">Our Best Doctors</h2>
        <p class=""doctors__subtitle"">Exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo non habent claritatem insitamconsequat duis autem facilisis at vero eros</p>
        <div class=""doctors__wrapper"">
            <div class=""row"">
");
#nullable restore
#line 20 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Index.cshtml"
                 foreach (var doctor in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-12 col-md-6 col-lg-3 col-sm-12 col-xl-3\">\r\n                        <div class=\"team-cart\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea304c5a132684e10df6211e854976aa14b05c8510511", async() => {
                WriteLiteral("\r\n                                <div class=\"team-cart__image-wrapper\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ea304c5a132684e10df6211e854976aa14b05c8510879", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1184, "~/uploads/images/", 1184, 17, true);
#nullable restore
#line 26 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Index.cshtml"
AddHtmlAttributeValue("", 1201, doctor.ImgUrl, 1201, 14, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ea304c5a132684e10df6211e854976aa14b05c8512675", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    <span class=\"team-cart__icon-wrapper\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ea304c5a132684e10df6211e854976aa14b05c8514057", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    </span>\r\n                                </div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Index.cshtml"
                                                                              WriteLiteral(doctor.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <h5 class=\"text-center my-3\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea304c5a132684e10df6211e854976aa14b05c8517663", async() => {
#nullable restore
#line 33 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Index.cshtml"
                                                                                                                                                      Write(doctor.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Index.cshtml"
                                                                                                           WriteLiteral(doctor.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h5>\r\n");
            WriteLiteral("\r\n                            <h6 class=\"team-cart__work\">");
#nullable restore
#line 39 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Index.cshtml"
                                                   Write(doctor.DoctorDepartmentRelation.Select(e => e.Department.Title).FirstOrDefault());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            <p class=\"team-cart__desc\">\r\n                                ");
#nullable restore
#line 41 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Index.cshtml"
                           Write(doctor.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                            <ul class=\"team-cart__media\">\r\n");
#nullable restore
#line 44 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Index.cshtml"
                                 foreach (var item in doctor.SocialMedia)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Index.cshtml"
                                     if (item.Name == "mail")
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"social-btn social-btn--mail\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 2791, "\"", 2817, 3);
            WriteAttributeValue("", 2798, "mailto:${", 2798, 9, true);
#nullable restore
#line 49 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Index.cshtml"
WriteAttributeValue("", 2807, item.Url, 2807, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2816, "}", 2816, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""12"" height=""12"" fill=""black"" class=""bi bi-envelope"" viewBox=""0 0 16 16"">
                                                    <path d=""M0 4a2 2 0 0 1 2-2h12a2 2 0 0 1 2 2v8a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2V4zm2-1a1 1 0 0 0-1 1v.217l7 4.2 7-4.2V4a1 1 0 0 0-1-1H2zm13 2.383-4.758 2.855L15 11.114v-5.73zm-.034 6.878L9.271 8.82 8 9.583 6.728 8.82l-5.694 3.44A1 1 0 0 0 2 13h12a1 1 0 0 0 .966-.739zM1 11.114l4.758-2.876L1 5.383v5.73z"" />
                                                </svg>
                                            </a>
                                        </li>
");
#nullable restore
#line 55 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Index.cshtml"
                                    }
                                    else 

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Index.cshtml"
                                          if (item.Name == "instagram")
                               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"social-btn social-btn--instagram\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 3763, "\"", 3779, 1);
#nullable restore
#line 59 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Index.cshtml"
WriteAttributeValue("", 3770, item.Url, 3770, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""12"" height=""12"" fill=""black"" class=""bi bi-instagram"" viewBox=""0 0 16 16"">
                                            <path d=""M8 0C5.829 0 5.556.01 4.703.048 3.85.088 3.269.222 2.76.42a3.917 3.917 0 0 0-1.417.923A3.927 3.927 0 0 0 .42 2.76C.222 3.268.087 3.85.048 4.7.01 5.555 0 5.827 0 8.001c0 2.172.01 2.444.048 3.297.04.852.174 1.433.372 1.942.205.526.478.972.923 1.417.444.445.89.719 1.416.923.51.198 1.09.333 1.942.372C5.555 15.99 5.827 16 8 16s2.444-.01 3.298-.048c.851-.04 1.434-.174 1.943-.372a3.916 3.916 0 0 0 1.416-.923c.445-.445.718-.891.923-1.417.197-.509.332-1.09.372-1.942C15.99 10.445 16 10.173 16 8s-.01-2.445-.048-3.299c-.04-.851-.175-1.433-.372-1.941a3.926 3.926 0 0 0-.923-1.417A3.911 3.911 0 0 0 13.24.42c-.51-.198-1.092-.333-1.943-.372C10.443.01 10.172 0 7.998 0h.003zm-.717 1.442h.718c2.136 0 2.389.007 3.232.046.78.035 1.204.166 1.486.275.373.145.64.319.92.599.28.28.453.546.598.92.11.281.24.705.275 1.485.03");
            WriteLiteral(@"9.843.047 1.096.047 3.231s-.008 2.389-.047 3.232c-.035.78-.166 1.203-.275 1.485a2.47 2.47 0 0 1-.599.919c-.28.28-.546.453-.92.598-.28.11-.704.24-1.485.276-.843.038-1.096.047-3.232.047s-2.39-.009-3.233-.047c-.78-.036-1.203-.166-1.485-.276a2.478 2.478 0 0 1-.92-.598 2.48 2.48 0 0 1-.6-.92c-.109-.281-.24-.705-.275-1.485-.038-.843-.046-1.096-.046-3.233 0-2.136.008-2.388.046-3.231.036-.78.166-1.204.276-1.486.145-.373.319-.64.599-.92.28-.28.546-.453.92-.598.282-.11.705-.24 1.485-.276.738-.034 1.024-.044 2.515-.045v.002zm4.988 1.328a.96.96 0 1 0 0 1.92.96.96 0 0 0 0-1.92zm-4.27 1.122a4.109 4.109 0 1 0 0 8.217 4.109 4.109 0 0 0 0-8.217zm0 1.441a2.667 2.667 0 1 1 0 5.334 2.667 2.667 0 0 1 0-5.334z"" />
                                        </svg>
                                    </a>
                                </li>
");
#nullable restore
#line 65 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Index.cshtml"
                            }
                            else 

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Index.cshtml"
                                  if (item.Name == "linkedin")
                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"social-btn social-btn--linkedin\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 5857, "\"", 5873, 1);
#nullable restore
#line 69 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Index.cshtml"
WriteAttributeValue("", 5864, item.Url, 5864, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""12"" height=""12"" fill=""black"" class=""bi bi-linkedin"" viewBox=""0 0 16 16"">
                                    <path d=""M0 1.146C0 .513.526 0 1.175 0h13.65C15.474 0 16 .513 16 1.146v13.708c0 .633-.526 1.146-1.175 1.146H1.175C.526 16 0 15.487 0 14.854V1.146zm4.943 12.248V6.169H2.542v7.225h2.401zm-1.2-8.212c.837 0 1.358-.554 1.358-1.248-.015-.709-.52-1.248-1.342-1.248-.822 0-1.359.54-1.359 1.248 0 .694.521 1.248 1.327 1.248h.016zm4.908 8.212V9.359c0-.216.016-.432.08-.586.173-.431.568-.878 1.232-.878.869 0 1.216.662 1.216 1.634v3.865h2.401V9.25c0-2.22-1.184-3.252-2.764-3.252-1.274 0-1.845.7-2.165 1.193v.025h-.016a5.54 5.54 0 0 1 .016-.025V6.169h-2.4c.03.678 0 7.225 0 7.225h2.4z"" />
                                </svg>
                            </a>
                        </li>
");
#nullable restore
#line 75 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Index.cshtml"
                     
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <li class=\"social-btn social-btn--tel\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 6912, "\"", 6936, 2);
            WriteAttributeValue("", 6919, "tel:", 6919, 4, true);
#nullable restore
#line 79 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Index.cshtml"
WriteAttributeValue("", 6923, doctor.Phone, 6923, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""12"" height=""12"" fill=""black"" class=""bi bi-telephone"" viewBox=""0 0 16 16"">
                                            <path d=""M3.654 1.328a.678.678 0 0 0-1.015-.063L1.605 2.3c-.483.484-.661 1.169-.45 1.77a17.568 17.568 0 0 0 4.168 6.608 17.569 17.569 0 0 0 6.608 4.168c.601.211 1.286.033 1.77-.45l1.034-1.034a.678.678 0 0 0-.063-1.015l-2.307-1.794a.678.678 0 0 0-.58-.122l-2.19.547a1.745 1.745 0 0 1-1.657-.459L5.482 8.062a1.745 1.745 0 0 1-.46-1.657l.548-2.19a.678.678 0 0 0-.122-.58L3.654 1.328zM1.884.511a1.745 1.745 0 0 1 2.612.163L6.29 2.98c.329.423.445.974.315 1.494l-.547 2.19a.678.678 0 0 0 .178.643l2.457 2.457a.678.678 0 0 0 .644.178l2.189-.547a1.745 1.745 0 0 1 1.494.315l2.306 1.794c.829.645.905 1.87.163 2.611l-1.034 1.034c-.74.74-1.846 1.065-2.877.702a18.634 18.634 0 0 1-7.01-4.42 18.634 18.634 0 0 1-4.42-7.009c-.362-1.03-.037-2.137.703-2.877L1.885.511z"" />
                                        </svg>
         ");
            WriteLiteral("                           </a>\r\n                                </li>\r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 88 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</section>
<section class=""find-doctor"">
    <div class=""custom-container"">
        <div class=""find-doctor__wrapper"">
            <h3 class=""find-doctor__title""> Need Help Finding The Right Doctor? </h3>
            <p class=""find-doctor__text"">Get helpful information on what’s important to you when choosing your doctors.</p>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea304c5a132684e10df6211e854976aa14b05c8531393", async() => {
                WriteLiteral(@"
                <input class=""find-doctor__input"" type=""text"" name=""Name"" placeholder=""Name*"">
                <input class=""find-doctor__input"" type=""email"" name=""Email"" placeholder=""E-mail*"">
                <button class=""btn btn--black"" style=""border:none;"">Contact us</button>
                <span class=""find-doctor__btn""></span>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            DefineSection("addjs", async() => {
                WriteLiteral(@"
    <script>
         $(document).ready(function () {
             $(""#finddoctorfrm"").submit(function (e) {
                 e.preventDefault();
                 console.log(""a"")
                    if (!$(e.currentTarget).valid())
                    return;

                    const formData = new FormData(e.currentTarget);

                    $.ajax({
                        url: '");
#nullable restore
#line 120 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Index.cshtml"
                         Write(Url.Action("FindDoctor", "Doctor"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                        type: 'POST',
                        data: formData,
                        contentType: false,
                        processData: false,
                        dataType: 'json',
                        beforeSend: function () {
                            console.log(""before sending"")
                        },
                        success: function (data) {

                            if (data.error == false) {
                                toastr.success(data.message, 'Successfully!');
                                e.currentTarget.reset();
                            }
                            else {
                                toastr.error(data.message, 'Error!');
                            }

                        },
                        error: function (data) {
                            toastr.error(""Something is wrong. Please try again.."", 'Error!');
                        }
                    }).always(function () {
     ");
                WriteLiteral("                   console.log(\"after sending\")\r\n\r\n\r\n                    });\r\n                });\r\n\r\n            })\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Doctor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
