#pragma checksum "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b3bacf3be8d6c1524aa1ea66c51c2e4d8840ba6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_Details), @"mvc.1.0.view", @"/Views/Doctor/Details.cshtml")]
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
#line 3 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\_ViewImports.cshtml"
using MediClinic.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\_ViewImports.cshtml"
using MediClinic.Application.Core.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\_ViewImports.cshtml"
using MediClinic.Domain.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\_ViewImports.cshtml"
using MediClinic.Domain.Models.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\_ViewImports.cshtml"
using MediClinic.Application.Core.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\_ViewImports.cshtml"
using Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\_ViewImports.cshtml"
using MediClinic.Domain.Models.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\_ViewImports.cshtml"
using MediClinic.Domain.Models.Entities.Membership;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b3bacf3be8d6c1524aa1ea66c51c2e4d8840ba6", @"/Views/Doctor/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9cacdcd74fff0c4b6024b4ab95c09d39c797628", @"/Views/_ViewImports.cshtml")]
    public class Views_Doctor_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Doctor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/uploads/images/team-member-2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("doctor-details__img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("doctor"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("appointmentdoctorfrm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"doctor-details-main\">\r\n    <div class=\"custom-container-fluid p-0 main__img\">\r\n        <div class=\"main__wrapper\">\r\n            <h1 class=\"main__title\">Jordan Kelley</h1>\r\n            <span class=\"main__subtitle\">Home  /  ");
#nullable restore
#line 10 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Details.cshtml"
                                             Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
        </div>
    </div>
</section>
<section class=""doctor-details"">
    <div class=""custom-container"">
        <div class=""row"">
            <div class=""col-12 col-md-4 col-lg-4 col-sm-12 col-xl-4"">
                <div class=""doctor-details__info"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5b3bacf3be8d6c1524aa1ea66c51c2e4d8840ba67806", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
            WriteLiteral("\r\n                    <h3 class=\"doctor-details__name\">");
#nullable restore
#line 20 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Details.cshtml"
                                                Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 21 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Details.cshtml"
                     foreach (var item in Model.DoctorDepartmentRelation)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"doctor-details__position\">");
#nullable restore
#line 23 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Details.cshtml"
                                                          Write(item.Department.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 24 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""doctor-details__bio"">
                        <div class=""doctor-details__contact"">
                            <i class=""fa fa-phone doctor-details__icon""></i>
                            <a target=""_self"" class=""doctor-details__link""");
            BeginWriteAttribute("href", " href=\"", 1243, "\"", 1266, 2);
            WriteAttributeValue("", 1250, "tel:", 1250, 4, true);
#nullable restore
#line 28 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Details.cshtml"
WriteAttributeValue("", 1254, Model.Phone, 1254, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                ");
#nullable restore
#line 29 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Details.cshtml"
                           Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </a>
                        </div>
                        <div class=""doctor-details__contact"">
                            <i class=""fa fa-envelope doctor-details__icon""></i>
                            <a target=""_self"" class=""doctor-details__link"" href=""mailto:clinic@qodeinteractive.com"">
                                ");
#nullable restore
#line 35 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Details.cshtml"
                           Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                        </div>\r\n                    </div>\r\n                    <ul class=\"doctor-details__social\">\r\n");
#nullable restore
#line 40 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Details.cshtml"
                         foreach (var item in Model.SocialMedia)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Details.cshtml"
                             if (item.Name != "mail")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a");
            BeginWriteAttribute("href", " href=\"", 2058, "\"", 2075, 1);
#nullable restore
#line 44 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Details.cshtml"
WriteAttributeValue("", 2065, item?.Url, 2065, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 2079, "\"", 2104, 3);
            WriteAttributeValue("", 2087, "fa", 2087, 2, true);
            WriteAttributeValue(" ", 2089, "fa-", 2090, 4, true);
#nullable restore
#line 44 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Details.cshtml"
WriteAttributeValue("", 2093, item?.Name, 2093, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a></li>\r\n");
#nullable restore
#line 45 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Details.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-12 col-md-8 col-lg-8 col-sm-12 col-xl-8\">\r\n                <div class=\"doctor-details__desc\">\r\n                    <div>\r\n                        ");
#nullable restore
#line 53 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Details.cshtml"
                   Write(Html.Raw(Model.AboutContent));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                    <div>
                        <div class=""doctor-details__row"">
                            <span class=""doctor-details__info-title"">Specialty</span>
                            <span class=""doctor-details__info-desc"">");
#nullable restore
#line 58 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Details.cshtml"
                                                               Write(Model.Speciality);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </div>
                        <div class=""doctor-details__row"">
                            <span class=""doctor-details__info-title"">Education</span>
                            <span class=""doctor-details__info-desc"">
                                ");
#nullable restore
#line 63 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Details.cshtml"
                           Write(Html.Raw(Model.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </span>
                        </div>
                        <div class=""doctor-details__row"">
                            <span class=""doctor-details__info-title"">Experience</span>
                            <span class=""doctor-details__info-desc"">
                                ");
#nullable restore
#line 69 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Details.cshtml"
                           Write(Html.Raw(Model.Experience));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </span>
                        </div>
                        <div class=""doctor-details__row"">
                            <span class=""doctor-details__info-title"">
                                Work Days
                            </span>
                            <span class=""doctor-details__info-desc"">
");
#nullable restore
#line 77 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Details.cshtml"
                                 foreach (var item in Model.DoctorWorkTimeRelation)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div>");
#nullable restore
#line 79 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Details.cshtml"
                                    Write(item.WorkTime.WeekDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 79 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Details.cshtml"
                                                            Write(item.WorkTime.StartedTime.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 79 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Details.cshtml"
                                                                                                           Write(item.WorkTime.EndedTime.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 80 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Details.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </span>
                        </div>
                    </div>
                    <div class=""doctor-details__appointment"">
                        <h3 class=""subtitle"">Online Appoinment</h3>
                        <h2 class=""title"">
                            Make An Appointment
                        </h2>
                        <span>
                            <svg viewBox=""0 0 300.08 300.08"" width=""70px""><path fill=""#16426d"" d=""m293.26 184.14h-82.877l-12.692-76.138c-.546-3.287-3.396-5.701-6.718-5.701-.034 0-.061 0-.089 0-3.369.027-6.199 2.523-6.677 5.845l-12.507 87.602-14.874-148.69c-.355-3.43-3.205-6.056-6.643-6.138-.048 0-.096 0-.143 0-3.39 0-6.274 2.489-6.752 5.852l-19.621 137.368h-9.405l-12.221-42.782c-.866-3.028-3.812-5.149-6.8-4.944-3.13.109-5.777 2.332-6.431 5.395l-8.941 42.332h-73.049c-3.771 0-6.82 3.049-6.82 6.82 0 3.778 3.049 6.82 6.82 6.82h78.566c3.219 0 6.002-2.251 6.67-5.408l4.406-20.856 6.09 21.313c.839 2.939 3.526 4.951 6.568 4.951h20.46c3.396 ");
            WriteLiteral(@"0 6.274-2.489 6.752-5.845l12.508-87.596 14.874 148.683c.355 3.437 3.205 6.056 6.643 6.138h.143c3.39 0 6.274-2.489 6.752-5.845l14.227-99.599 6.397 38.362c.546 3.287 3.396 5.702 6.725 5.702h88.66c3.771 0 6.82-3.049 6.82-6.82-.001-3.772-3.05-6.821-6.821-6.821z""></path></svg>
                        </span>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b3bacf3be8d6c1524aa1ea66c51c2e4d8840ba620225", async() => {
                WriteLiteral(@"
                            <input class=""doctor-details__input"" type=""text"" name=""Name"" placeholder=""Your Name"">
                            <input class=""doctor-details__input"" type=""text"" name=""Phone"" placeholder=""Your Phone"">
                            <input class=""doctor-details__input"" type=""email"" name=""Email"" placeholder=""Your E-mail"">
                            <textarea class=""doctor-details__input doctor-details__input--textbox"" name=""Message""");
                BeginWriteAttribute("id", " id=\"", 5938, "\"", 5943, 0);
                EndWriteAttribute();
                WriteLiteral(" cols=\"30\" rows=\"10\" placeholder=\"Tell us about Pasent\"></textarea>\r\n                            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 6061, "\"", 6078, 1);
#nullable restore
#line 97 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Details.cshtml"
WriteAttributeValue("", 6069, Model.Id, 6069, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"DoctorId\">\r\n                            <button class=\"btn btn--black\" style=\"border:none;\">Submit Query</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            DefineSection("addjs", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            
             $(""#appointmentdoctorfrm"").submit(function (e) {
                 e.preventDefault();
                    if (!$(e.currentTarget).valid())
                    return;

                    const formData = new FormData(e.currentTarget);
                    $.ajax({
                        url: '");
#nullable restore
#line 118 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Doctor\Details.cshtml"
                         Write(Url.Action("DoctorAppointment", "Doctor"));

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
                            console.log(data)
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
     ");
                WriteLiteral("               }).always(function () {\r\n                        console.log(\"after sending\")\r\n\r\n\r\n                    });\r\n                });\r\n\r\n            })\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Doctor> Html { get; private set; }
    }
}
#pragma warning restore 1591
