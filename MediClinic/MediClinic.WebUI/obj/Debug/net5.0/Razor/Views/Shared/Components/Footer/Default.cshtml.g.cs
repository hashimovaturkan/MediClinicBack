#pragma checksum "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Shared\Components\Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b17742fd9f07c1485fe99955ed7d91182228f7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/Default.cshtml")]
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
#line 3 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Views\_ViewImports.cshtml"
using MediClinic.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Views\_ViewImports.cshtml"
using MediClinic.Application.Core.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Views\_ViewImports.cshtml"
using MediClinic.Domain.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Views\_ViewImports.cshtml"
using MediClinic.Domain.Models.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Views\_ViewImports.cshtml"
using MediClinic.Application.Core.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Views\_ViewImports.cshtml"
using Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Views\_ViewImports.cshtml"
using MediClinic.Domain.Models.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Views\_ViewImports.cshtml"
using MediClinic.Domain.Models.Entities.Membership;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b17742fd9f07c1485fe99955ed7d91182228f7a", @"/Views/Shared/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9cacdcd74fff0c4b6024b4ab95c09d39c797628", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogPostDepartmentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "department", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "deatils", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("subscription"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("subscriptionfrm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<footer>\r\n    <div class=\"container footer\">\r\n        <div class=\"footer__about\">\r\n            <div class=\"footer-logo\">\r\n                <a href=\"#\">\r\n                    <img src=\"/assets/icons/logo-2.png\"");
            BeginWriteAttribute("alt", " alt=\"", 243, "\"", 249, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </a>
            </div>
            <p class=""about-text"">
                Lorem ipsum dolor sit. beatae quasi tempora maxime praesentium.
            </p>
            <p class=""about-text"">
                molestiae, autem ad dolorum eius? Facere accusantium nostrum quidem ea voluptatem veniam ipsum facilis!
            </p>
            <ul class=""footer-social-links"">
                <a href=""#"">
                <li><i class=""fab fa-facebook-f""></i></li>
                </a>
                <a href=""#"">
                <li><i class=""fab fa-pinterest-p""></i></li>
                </a>
                <a href=""#"">
                <li><i class=""fab fa-twitter""></i></li>
                </a>
                <a href=""#"">
                <li><i class=""fab fa-skype""></i></li>
                </a>
                <a href=""#"">
                <li><i class=""fab fa-linkedin-in""></i></li>
                </a>
            </ul>
        </div>
        <div class=""footer__depart");
            WriteLiteral(@"ments"">
            <div class=""footer-title"">
                <h2>
                    Departments
                    <span class=""line"">
                        <span class=""dot""></span>
                    </span>
                </h2>
            </div>
            <ul class=""footer-link-pages"">
");
#nullable restore
#line 44 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Shared\Components\Footer\Default.cshtml"
                 foreach (var item in Model.Departments)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b17742fd9f07c1485fe99955ed7d91182228f7a9052", async() => {
                WriteLiteral("\r\n                    <li><i class=\"fas fa-plus\"></i>");
#nullable restore
#line 47 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Shared\Components\Footer\Default.cshtml"
                                              Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Shared\Components\Footer\Default.cshtml"
                                                                          WriteLiteral(item.Id);

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
            WriteLiteral("\r\n");
#nullable restore
#line 49 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Shared\Components\Footer\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </ul>
        </div>
        <div class=""footer__lasted-news"">
            <div class=""footer-title"">
                <h2>
                    Lasted Blogs
                    <span class=""line"">
                        <span class=""dot""></span>
                    </span>
                </h2>
            </div>
            <div class=""footer-posts"">
");
#nullable restore
#line 62 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Shared\Components\Footer\Default.cshtml"
                 foreach (var item in Model.Blogs)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"footer-post\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2399, "\"", 2433, 2);
            WriteAttributeValue("", 2405, "/uploads/images/", 2405, 16, true);
#nullable restore
#line 65 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 2421, item.ImgUrl, 2421, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"photo\">\r\n                        <div class=\"footer-post__description\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b17742fd9f07c1485fe99955ed7d91182228f7a13547", async() => {
                WriteLiteral("\r\n                                <p class=\"footer-post-title\">\r\n                                    ");
#nullable restore
#line 69 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Shared\Components\Footer\Default.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </p>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Shared\Components\Footer\Default.cshtml"
                                                                            WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                            <span class=\"footer-post-date\">");
#nullable restore
#line 72 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Shared\Components\Footer\Default.cshtml"
                                                      Write(item.CreatedDate.ToString("dd MMMM, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 75 "C:\Users\HP\Downloads\mediclinic\mediclinic\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Shared\Components\Footer\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
        <div class=""footer__contact-us"">
            <div class=""footer-title"">
                <h2>
                    Contact Us
                    <span class=""line"">
                        <span class=""dot""></span>
                    </span>
                </h2>
            </div>
            <div class=""contact-box"">
                <img src=""/assets/icons/placeholder.png""");
            BeginWriteAttribute("alt", " alt=\"", 3420, "\"", 3426, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""contact-box__description"">
                    <p class=""contact-title"">
                        2130 Fulton Street San Diego
                    </p>
                    <span class=""contact-sub-title"">
                        CA 94117-1080 USA
                    </span>
                </div>
            </div>
            <div class=""contact-box"">
                <img src=""/assets/icons/call (1).png""");
            BeginWriteAttribute("alt", " alt=\"", 3875, "\"", 3881, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""contact-box__description"">
                    <p class=""contact-title"">
                        Mon to Fri : 08:30 - 18:00
                    </p>
                    <span class=""contact-sub-title"">
                        <a href=""tel:+898 68679 575"">+898 68679 575</a>
                    </span>
                </div>
            </div>
            <div class=""contact-box"">
                <img src=""/assets/icons/email (1).png""");
            BeginWriteAttribute("alt", " alt=\"", 4359, "\"", 4365, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""contact-box__description"">
                    <p class=""contact-title"">
                        Do you have a Question?
                    </p>
                    <span class=""contact-sub-title"">
                        <a href=""mailto:info@gmail.com"">
                            info@gmail.com
                        </a>
                    </span>
                </div>
            </div>
            <div class=""contact-box"">
                <img src=""/assets/icons/back-in-time (1).png""");
            BeginWriteAttribute("alt", " alt=\"", 4906, "\"", 4912, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""contact-box__description"">
                    <p class=""contact-title"">
                        Mon - Sat 8.00 - 18.00
                    </p>
                    <span class=""contact-sub-title"">
                        Sunday CLOSED
                    </span>
                </div>
            </div>
        </div>
        <div class=""content-subs mt-3"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b17742fd9f07c1485fe99955ed7d91182228f7a20141", async() => {
                WriteLiteral(@"
                <input class=""add-email"" type=""email"" name=""Email"" placeholder=""subscribe@me.now""
                    data-rule-required=""true""
                    data-rule-email=""true""
                    data-msg-required=""Please, enter email""
                    data-msg-email=""Invalid E-mail! Please, enter your email"">
                <button class=""submit-email"" type=""submit"">
                    <span class=""before-submit"">Subscribe</span>
                    <span class=""after-submit"">Thank you for subscribing!</span>
                </button>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogPostDepartmentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
