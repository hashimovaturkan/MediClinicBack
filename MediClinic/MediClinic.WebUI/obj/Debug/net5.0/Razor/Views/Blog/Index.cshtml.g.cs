#pragma checksum "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6495da7102c8226f328a701fd46e8bc13af05378"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6495da7102c8226f328a701fd46e8bc13af05378", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9cacdcd74fff0c4b6024b4ab95c09d39c797628", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogPostCategoriesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("blog-cart__img-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Doctor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("blog-cart__info-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("blog-cart__title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""blog__main"">
    <div class=""custom-container-fluid p-0 main__img"">
        <div class=""main__wrapper main__wrapper--left"">
            <h1 class=""main__title"">Blogs</h1>
        </div>
    </div>
</section>
<section class=""blog"">
    <div class=""custom-container"">
        <ul class=""blog__categories"">
            <li><a href=""#"" data-filter=""all"">All</a><span>");
#nullable restore
#line 16 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Blog\Index.cshtml"
                                                             Model.BlogPosts.Items.Count();

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n");
#nullable restore
#line 17 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Blog\Index.cshtml"
             foreach (var category in Model.BlogCategories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a href=\"#\" data-filter=\"");
#nullable restore
#line 19 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Blog\Index.cshtml"
                                               MediClinic.Application.Core.Extensions.Extension.ReplaceWhitespace(category.Name, "");

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 19 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Blog\Index.cshtml"
                                                                                                                                   Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><span>");
#nullable restore
#line 19 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Blog\Index.cshtml"
                                                                                                                                                                  Model.BlogPosts.Items.Where(e => e.BlogCategoryId == category.Id).Select(e => e.Id).Count();

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n");
#nullable restore
#line 20 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Blog\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 23 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Blog\Index.cshtml"
             foreach (var blog in Model.BlogPosts.Items)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-12 col-md-6 col-lg-4 col-sm-12 col-xl-4\" data-target=\"");
#nullable restore
#line 25 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Blog\Index.cshtml"
                                                                                        MediClinic.Application.Core.Extensions.Extension.ReplaceWhitespace(blog.BlogCategory?.Name, "");

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    <div class=\"blog-cart\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6495da7102c8226f328a701fd46e8bc13af0537810426", async() => {
                WriteLiteral("\r\n                            <img class=\"blog-cart__img\"");
                BeginWriteAttribute("src", " src=\"", 1403, "\"", 1439, 3);
                WriteAttributeValue("", 1409, "./uploads/images/", 1409, 17, true);
#nullable restore
#line 28 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1426, blog.ImgUrl, 1426, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1438, "?", 1438, 1, true);
                EndWriteAttribute();
                WriteLiteral(" alt=\"photo\">\r\n                        ");
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
#line 27 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Blog\Index.cshtml"
                                                                        WriteLiteral(blog.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <div class=\"blog-cart__info\">\r\n                            <a href=\"#\" class=\"blog-cart__info-item\">");
#nullable restore
#line 31 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Blog\Index.cshtml"
                                                                Write(blog.BlogCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <span class=\"blog-cart__info-item\">");
#nullable restore
#line 32 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Blog\Index.cshtml"
                                                          Write(blog.PublishedDate?.ToString("dd MMMM, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <span>\r\n                                By\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6495da7102c8226f328a701fd46e8bc13af0537814583", async() => {
#nullable restore
#line 35 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Blog\Index.cshtml"
                                                                                                                                       Write(blog.Doctor.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Blog\Index.cshtml"
                                                                                  WriteLiteral(blog.Doctor.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </span>\r\n                        </div>\r\n                        <div class=\"blog-cart__body\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6495da7102c8226f328a701fd46e8bc13af0537817585", async() => {
#nullable restore
#line 39 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Blog\Index.cshtml"
                                                                                                                      Write(blog.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
#line 39 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Blog\Index.cshtml"
                                                                                                     WriteLiteral(blog.Id);

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
            WriteLiteral("\r\n                            <p>\r\n                                ");
#nullable restore
#line 41 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Blog\Index.cshtml"
                           Write(blog.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                            <div class=\"blog-cart__footer\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6495da7102c8226f328a701fd46e8bc13af0537820901", async() => {
                WriteLiteral("Learn more");
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
#line 44 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Blog\Index.cshtml"
                                                                                WriteLiteral(blog.Id);

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
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 49 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Blog\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"pagination-up\">\r\n            <div class=\"pagination-wrapper\">\r\n                ");
#nullable restore
#line 52 "C:\Users\turkan.hashimova\Desktop\MediClinicBack\MediClinicBack\MediClinic\MediClinic.WebUI\Views\Blog\Index.cshtml"
           Write(Model.BlogPosts.GetPagenation(Url, "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogPostCategoriesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
