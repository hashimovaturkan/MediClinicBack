#pragma checksum "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Account\Setting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44ec319f42361d948a599382cc374f2f1fd0c201"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Setting), @"mvc.1.0.view", @"/Views/Account/Setting.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44ec319f42361d948a599382cc374f2f1fd0c201", @"/Views/Account/Setting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9cacdcd74fff0c4b6024b4ab95c09d39c797628", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Setting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MediClinicUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("photo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 120px; height: 120px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("changeImgFrm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("account"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("accountsettingfrm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form form--password"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("passwordsettingfrm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("password"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Account\Setting.cshtml"
  
    ViewData["Title"] = "Setting";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""setting__main"">
    <div class=""custom-container-fluid p-0 main__img"">
        <div class=""main__wrapper"">
            <h1 class=""main__title"">Profile Setting</h1>
            <span class=""main__subtitle"">Home  /   Profile Setting</span>
        </div>
    </div>
</section>
<section class=""setting"">
    <div class=""custom-container"">
        <div class=""setting__wrapper"">
            <div class=""row"">
                <div class=""col-12 col-md-12 col-lg-4 col-sm-12 col-xl-3"">
                    <aside class=""aside-form"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44ec319f42361d948a599382cc374f2f1fd0c20110568", async() => {
                WriteLiteral("\r\n                            <div class=\"aside-form__img\">\r\n                                <span>\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "44ec319f42361d948a599382cc374f2f1fd0c20110968", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 864, "~/uploads/images/", 864, 17, true);
#nullable restore
#line 23 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Account\Setting.cshtml"
AddHtmlAttributeValue("", 881, Model.ImgUrl, 881, 13, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    <span class=""aside-form__pen"">
                                        <input type=""file"" style=""display:none"" id=""form-file"" name=""file"">
                                        <label for=""form-file"" style=""cursor: pointer;"">
                                            <?xml version=""1.0"" encoding=""utf-8"" ?>
                                            <svg version=""1.1"" id=""Layer_1"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px"" viewBox=""0 0 117.74 122.88"" style=""enable-background:new 0 0 117.74 122.88"" xml:space=""preserve""><style type=""text/css"">
                                                                                                                                                                                                                                                                               .st0 {
                                                                                                   ");
                WriteLiteral(@"                                                                                                                                                                                fill-rule: evenodd;
                                                                                                                                                                                                                                                                                   clip-rule: evenodd;
                                                                                                                                                                                                                                                                               }
</style><g><path class=""st0"" d=""M94.62,2c-1.46-1.36-3.14-2.09-5.02-1.99c-1.88,0-3.56,0.73-4.92,2.2L73.59,13.72l31.07,30.03l11.19-11.72 c1.36-1.36,1.88-3.14,1.88-5.02s-0.73-3.66-2.09-4.92L94.62,2L94.62,2L94.62,2z M41.44,109.58c-4.08,1.36-8.26,2.62-12.35,3.98");
                WriteLiteral(@" c-4.08,1.36-8.16,2.72-12.35,4.08c-9.73,3.14-15.07,4.92-16.22,5.23c-1.15,0.31-0.42-4.18,1.99-13.6l7.74-29.61l0.64-0.66 l30.56,30.56L41.44,109.58L41.44,109.58L41.44,109.58z M22.2,67.25l42.99-44.82l31.07,29.92L52.75,97.8L22.2,67.25L22.2,67.25z"" /></g></svg>
                                        </label>
                                    </span>
                                </span>
                                <h2 id=""settingTitle"">");
#nullable restore
#line 37 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Account\Setting.cshtml"
                                                  Write($"{Model.Name} {Model.Surname}");

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <ul class=""aside-form__list"">
                            <li>
                                <a href=""#"" data-value=""account"" class=""profile-btn"">
                                    <i class=""flaticon-mail-box""></i>
                                    Account
                                </a>
                            </li>
                            <li>
                                <a href=""#"" data-value=""password"" class=""profile-btn"">
                                    <i class=""flaticon-tools-1""></i>
                                    Password
                                </a>
                            </li>
                        </ul>
                    </aside>
                </div>
                <div class=""col-12 col-md-12 col-lg-8 col-sm-12 col-xl-9 form__wrapper"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44ec319f42361d948a599382cc374f2f1fd0c20118040", async() => {
                WriteLiteral(@"
                        <div class=""heading heading--center"">
                            <h2 class=""heading__title"">Account Settings</h2>
                            <p class=""heading__text"">You can change your account's properties...</p>
                        </div>
                        <div class=""form__content"">
                            <div class=""row order__item-1"">
                                <div class=""col-12 col-sm-12 col-md-12 col-lg-6 col-xl-6 pb-32"">
                                    <span class=""form__item-title"">Name</span>
                                    <div class=""form__item"">
                                        <input type=""text"" name=""Name"" id=""form-item"" class=""form__input""");
                BeginWriteAttribute("value", " value=\"", 5245, "\"", 5264, 1);
#nullable restore
#line 67 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Account\Setting.cshtml"
WriteAttributeValue("", 5253, Model.Name, 5253, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        <label class=\"form__placeholder\" for=\"form-item\" tabindex=\"0\">Name</label>\r\n");
                WriteLiteral(@"                                    </div>
                                </div>
                                <div class=""col-12 col-sm-12 col-md-12 col-lg-6 col-xl-6 pb-32"">
                                    <span class=""form__item-title"">Surname</span>
                                    <div class=""form__item"">
                                        <input type=""text"" name=""Surname"" id=""form-item-2"" class=""form__input""");
                BeginWriteAttribute("value", " value=\"", 5927, "\"", 5949, 1);
#nullable restore
#line 75 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Account\Setting.cshtml"
WriteAttributeValue("", 5935, Model.Surname, 5935, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        <label class=\"form__placeholder\" for=\"form-item-2\" tabindex=\"1\">Surname</label>\r\n");
                WriteLiteral(@"                                    </div>
                                </div>
                            </div>
                            <div class=""row order__item-2"">
                                <div class=""col-12 col-sm-12 col-md-12 col-lg-6 col-xl-6 pb-32"">
                                    <span class=""form__item-title"">Email</span>
                                    <div class=""form__item"">
                                        <input type=""email"" name=""Email"" id=""form-item-3"" class=""form__input""");
                BeginWriteAttribute("value", " value=\"", 6714, "\"", 6734, 1);
#nullable restore
#line 85 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Account\Setting.cshtml"
WriteAttributeValue("", 6722, Model.Email, 6722, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"
                                               data-rule-required=""true""
                                               data-rule-email=""true""
                                               data-msg-required=""Please, enter email""
                                               data-msg-email=""Invalid E-mail! Please, enter your email"" >
                                        <label class=""form__placeholder"" for=""form-item-3"" tabindex=""0"">Email</label>
");
                WriteLiteral(@"                                    </div>
                                </div>
                                <div class=""col-12 col-sm-12 col-md-12 col-lg-6 col-xl-6 pb-32"">
                                    <span class=""form__item-title"">UserName</span>
                                    <div class=""form__item"">
                                        <input type=""text"" name=""UserName"" id=""form-item-4"" class=""form__input""");
                BeginWriteAttribute("value", " value=\"", 7745, "\"", 7768, 1);
#nullable restore
#line 97 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Account\Setting.cshtml"
WriteAttributeValue("", 7753, Model.UserName, 7753, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                                               data-rule-required=\"true\" data-msg-required=\"Please, enter your username\">\r\n                                        <label class=\"form__placeholder\" for=\"form-item-4\" tabindex=\"0\">UserName</label>\r\n");
                WriteLiteral(@"                                    </div>
                                </div>
                            </div>
                            <div class=""row order__item-3"">
                                <div class=""col-12 col-sm-12 col-md-12 col-lg-6 col-xl-6 pb-32"">
                                    <span class=""form__item-title"">Phone Number</span>
                                    <div class=""form__item"">
                                        <input type=""tel"" name=""PhoneNumber"" id=""form-item-4"" class=""form__input""");
                BeginWriteAttribute("value", " value=\"", 8673, "\"", 8699, 1);
#nullable restore
#line 108 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Account\Setting.cshtml"
WriteAttributeValue("", 8681, Model.PhoneNumber, 8681, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        <label class=\"form__placeholder\" for=\"form-item-4\" tabindex=\"0\">Phone Number</label>\r\n");
                WriteLiteral(@"                                    </div>
                                </div>
                                <div class=""col-12 col-sm-12 col-md-12 col-lg-6 col-xl-6 pb-32"">
                                    
                                </div>
                            </div>
                            <div class=""row order__item-5"">
                                <div class=""col-12 col-sm-12 col-md-12 col-lg-12 col-xl-12 "">
                                    <button class=""btn btn--blue mt-40"" type=""submit"" style=""border:none;"">Update</button>
                                </div>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44ec319f42361d948a599382cc374f2f1fd0c20126601", async() => {
                WriteLiteral(@"
                        <div class=""heading heading--center"">
                            <h2 class=""heading__title"">Password Settings</h2>
                            <p class=""heading__text"">You can change your account's password...</p>
                        </div>
                        <div class=""form__content"">
                            <div class=""row order__item-1"">
                                <div class=""col-12 col-sm-12 col-md-12 col-lg-6 col-xl-6 pb-32"">
                                    <span class=""form__item-title"">Old Password</span>
                                    <div class=""form__item"">
                                        <div class=""form__icon-box"">
                                            <i class=""icon-eye_two_tone form__icon"" id=""togglePassword""><span class=""path1""></span><span class=""path2""></span><span class=""path3""></span></i>
                                        </div>
                                        <input type=""password"" name=""OldPass""");
                WriteLiteral(@" id=""form-item-5"" class=""form__input"">
                                        <label class=""form__placeholder"" for=""form-item-5"" tabindex=""0"">Old Password</label>
                                        <div class=""form__helper d-none"">??ifr?? bo?? qoyula bilm??z.</div>
                                    </div>
                                </div>
                            </div>
                            <div class=""row order__item-2"">
                                <div class=""col-12 col-sm-12 col-md-12 col-lg-6 col-xl-6 pb-32"">
                                    <span class=""form__item-title"">New Password</span>
                                    <div class=""form__item"">
                                        <div class=""form__icon-box"">
                                            <i class=""icon-eye_two_tone form__icon"" id=""togglePassword""><span class=""path1""></span><span class=""path2""></span><span class=""path3""></span></i>
                                        </div>
               ");
                WriteLiteral(@"                         <input type=""password"" name=""NewPass"" id=""form-item-5"" class=""form__input"">
                                        <label class=""form__placeholder"" for=""form-item-5"" tabindex=""0"">New Password</label>
                                        <div class=""form__helper d-none"">??ifr?? bo?? qoyula bilm??z.</div>
                                    </div>
                                </div>
                                <div class=""col-12 col-sm-12 col-md-12 col-lg-6 col-xl-6 pb-32"">
                                    <span class=""form__item-title"">Confirm Password</span>
                                    <div class=""form__item"">
                                        <div class=""form__icon-box"">
                                            <i class=""icon-eye_two_tone form__icon"" id=""togglePassword""><span class=""path1""></span><span class=""path2""></span><span class=""path3""></span></i>
                                        </div>
                                        <input");
                WriteLiteral(@" type=""password"" name=""NewPassAgain"" id=""form-item-6"" class=""form__input"">
                                        <label class=""form__placeholder"" for=""form-item-6"" tabindex=""1"">Confirm Password</label>
                                    </div>
                                </div>
                            </div>
                            <div class=""row order__item-3"">
                                <div class=""col-12 col-sm-12 col-md-12 col-lg-12 col-xl-12 "">
                                    <button class=""btn btn--blue mt-40"" type=""submit"" style=""border:none;"">Update</button>
                                </div>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            DefineSection("addjs", async() => {
                WriteLiteral(@"
    <script>
         $(document).ready(function () {
             $(""#accountsettingfrm"").submit(function (e) {
                e.preventDefault();
                if (!$(e.currentTarget).valid())
                    return;

                var frm = new FormData(e.currentTarget);

                $.ajax({
                    url: '");
#nullable restore
#line 190 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Account\Setting.cshtml"
                     Write(Url.Action("Setting", "Account"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                    type: ""Post"",
                    data: frm,
                    contentType: false,
                    dataType: ""json"",
                    processData: false,
                    beforeSend: function (response) {
                        console.log(""before sending"")
                    },
                    success: function (response) {
                        if (response.error == false) {
                            toastr.success(response.message, ""Successfully!"")
                            $(""#settingTitle"").text($(""#form-item"").val() + "" "" + $(""#form-item-2"").val());
                        }
                        else {
                            toastr.error(response.message, ""Error!"")
                        }

                    },
                    error: function (response) {
                        toastr.error(""Please, try again..."", ""Error!"")
                    }

                }).always(function () {
                    console.log(");
                WriteLiteral(@"""after sending"")
                });


            }).validate({
                errorElement: 'div',
                errorClass: ""form__helper"",
                validClass: ""valid""
            });
         })

        $(document).ready(function () {
            $(""#form-file"").change(function () {
                $(""#changeImgFrm"").submit();
            })
             $(""#changeImgFrm"").submit(function (e) {
                 e.preventDefault();
                if (!$(e.currentTarget).valid())
                    return;

                var frm = new FormData(e.currentTarget);

                $.ajax({
                    url: '");
#nullable restore
#line 237 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Account\Setting.cshtml"
                     Write(Url.Action("ChangeImage", "Account"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                    type: ""Post"",
                    data: frm,
                    contentType: false,
                    dataType: ""json"",
                    processData: false,
                    beforeSend: function (response) {
                        console.log(""before sending"")
                    },
                    success: function (response) {
                        if (response.error == false) {

                            toastr.success(response.message, ""Successfully!"")
                            location.reload();

                        }
                        else {
                            toastr.error(response.message, ""Error!"")
                        }

                    },
                    error: function (response) {
                        toastr.error(""Please, try again..."", ""Error!"")
                    }

                }).always(function () {
                    console.log(""after sending"")
                });


            })");
                WriteLiteral(@".validate({
                errorElement: 'div',
                errorClass: ""form__helper"",
                validClass: ""valid""
            });
        })

        $(document).ready(function () {
         $(""#passwordsettingfrm"").submit(function (e) {
                e.preventDefault();
                if (!$(e.currentTarget).valid())
                    return;

                var frm = new FormData(e.currentTarget);

                $.ajax({
                    url: '");
#nullable restore
#line 283 "C:\Users\HP\Downloads\MediMain\MediMain\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Account\Setting.cshtml"
                     Write(Url.Action("ChangePassword", "Account"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                    type: ""Post"",
                    data: frm,
                    contentType: false,
                    dataType: ""json"",
                    processData: false,
                    beforeSend: function (response) {
                        console.log(""before sending"")
                    },
                    success: function (response) {
                        if (response.error == false) {
                            toastr.success(response.message, ""Successfully!"")
                            e.currentTarget.reset();
                            window.location.href = ""/"";
                        }
                        else {
                            toastr.error(response.message, ""Error!"")
                        }

                    },
                    error: function (response) {
                        toastr.error(""Please, try again..."", ""Error!"")
                    }

                }).always(function () {
                    console.lo");
                WriteLiteral("g(\"after sending\")\r\n                });\r\n\r\n\r\n            }).validate({\r\n                errorElement: \'div\',\r\n                errorClass: \"form__helper\",\r\n                validClass: \"valid\"\r\n            });\r\n         })\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MediClinicUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
