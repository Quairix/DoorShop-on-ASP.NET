#pragma checksum "C:\ASP\WA\WA\Views\App\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21a07ac24abe87e6114cac19615e2a35cfa3a71d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_App_Product), @"mvc.1.0.view", @"/Views/App/Product.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/App/Product.cshtml", typeof(AspNetCore.Views_App_Product))]
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
#line 1 "C:\ASP\WA\WA\Views\_ViewImports.cshtml"
using WA.Controllers;

#line default
#line hidden
#line 2 "C:\ASP\WA\WA\Views\_ViewImports.cshtml"
using WA.ViewModels;

#line default
#line hidden
#line 3 "C:\ASP\WA\WA\Views\_ViewImports.cshtml"
using WA.Data.Entities;

#line default
#line hidden
#line 4 "C:\ASP\WA\WA\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 5 "C:\ASP\WA\WA\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#line 6 "C:\ASP\WA\WA\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http.Features;

#line default
#line hidden
#line 7 "C:\ASP\WA\WA\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#line 8 "C:\ASP\WA\WA\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21a07ac24abe87e6114cac19615e2a35cfa3a71d", @"/Views/App/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7f6fc283f0e843425f29dfb1e0b9b71af5b3f51", @"/Views/_ViewImports.cshtml")]
    public class Views_App_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:300px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "C:\ASP\WA\WA\Views\App\Product.cshtml"
  
    ViewBag.Title = Model.Title;

#line default
#line hidden
            BeginContext(91, 397, true);
            WriteLiteral(@"<div class=""banner"">
    <div class=""herounit herounit-secondary"" style=""background-image: url('/img/banner-image-contact-1.png');"">
        <div class=""container fullHeight"">
            <div class=""row fullHeight"">
                <div class=""herounit-wrapper fullHeight col-xs-12"">
                    <div class=""herounit-wrap txt-center"">
                        <h1 class=""page_title"">");
            EndContext();
            BeginContext(489, 11, false);
#line 12 "C:\ASP\WA\WA\Views\App\Product.cshtml"
                                          Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(500, 653, true);
            WriteLiteral(@"</h1>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""content-container"">
        <div class=""products-page"">
            <div class=""col-sm-10 col-md-10 col-xs-10 col-sm-offset-1 col-md-offset-1 col-xs-offset-1"">
                <div class=""row"">
                    <div style=""display:inline-block;  margin:10px;"">
                        <h3><a href=""../Shop/"" style=""color:gray;"">&lt;&lt; Back to the Shop page</a></h3>
                    </div>
                    <div style=""display:inline-block; float:right; margin:10px;"">
                        <h3>View Product: ");
            EndContext();
            BeginContext(1154, 13, false);
#line 26 "C:\ASP\WA\WA\Views\App\Product.cshtml"
                                     Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1167, 368, true);
            WriteLiteral(@"</h3>
                    </div>
                </div>
                <div class=""product_div"">
                    <div class=""row vertical-align"">
                        <div style=""display:inline-block; width:30%; margin-left:10%; line-height:2;"">
                            <ul>
                                <li>
                                    ");
            EndContext();
            BeginContext(1536, 21, false);
#line 34 "C:\ASP\WA\WA\Views\App\Product.cshtml"
                               Write(Localizer["Category"]);

#line default
#line hidden
            EndContext();
            BeginContext(1557, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(1560, 14, false);
#line 34 "C:\ASP\WA\WA\Views\App\Product.cshtml"
                                                       Write(Model.Category);

#line default
#line hidden
            EndContext();
            BeginContext(1574, 77, true);
            WriteLiteral("\r\n                                </li>\r\n                                <li>");
            EndContext();
            BeginContext(1652, 25, false);
#line 36 "C:\ASP\WA\WA\Views\App\Product.cshtml"
                               Write(Localizer["Manufacturer"]);

#line default
#line hidden
            EndContext();
            BeginContext(1677, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(1680, 18, false);
#line 36 "C:\ASP\WA\WA\Views\App\Product.cshtml"
                                                           Write(Model.Manufacturer);

#line default
#line hidden
            EndContext();
            BeginContext(1698, 47, true);
            WriteLiteral("</li>\r\n\r\n                                <li>\r\n");
            EndContext();
#line 39 "C:\ASP\WA\WA\Views\App\Product.cshtml"
                                     if (Model.DoorDescription == null)
                                    {
                                        

#line default
#line hidden
            BeginContext(1903, 46, true);
            WriteLiteral("\r\n                                            ");
            EndContext();
            BeginContext(1950, 26, false);
#line 42 "C:\ASP\WA\WA\Views\App\Product.cshtml"
                                       Write(Localizer["NoDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(1976, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
#line 43 "C:\ASP\WA\WA\Views\App\Product.cshtml"
                                               
                                    }
                                    else
                                    {
                                        

#line default
#line hidden
            BeginContext(2193, 46, true);
            WriteLiteral("\r\n                                            ");
            EndContext();
            BeginContext(2240, 21, false);
#line 48 "C:\ASP\WA\WA\Views\App\Product.cshtml"
                                       Write(Model.DoorDescription);

#line default
#line hidden
            EndContext();
            BeginContext(2261, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
#line 49 "C:\ASP\WA\WA\Views\App\Product.cshtml"
                                               
                                    }

#line default
#line hidden
            BeginContext(2351, 75, true);
            WriteLiteral("                                </li>\r\n                                <li>");
            EndContext();
            BeginContext(2427, 17, false);
#line 52 "C:\ASP\WA\WA\Views\App\Product.cshtml"
                               Write(Localizer["Size"]);

#line default
#line hidden
            EndContext();
            BeginContext(2444, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(2447, 10, false);
#line 52 "C:\ASP\WA\WA\Views\App\Product.cshtml"
                                                   Write(Model.Size);

#line default
#line hidden
            EndContext();
            BeginContext(2457, 43, true);
            WriteLiteral("</li>\r\n                                <li>");
            EndContext();
            BeginContext(2501, 18, false);
#line 53 "C:\ASP\WA\WA\Views\App\Product.cshtml"
                               Write(Localizer["Color"]);

#line default
#line hidden
            EndContext();
            BeginContext(2519, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(2522, 12, false);
#line 53 "C:\ASP\WA\WA\Views\App\Product.cshtml"
                                                    Write(Model.Colors);

#line default
#line hidden
            EndContext();
            BeginContext(2534, 45, true);
            WriteLiteral("</li>\r\n\r\n                                <li>");
            EndContext();
            BeginContext(2580, 11, false);
#line 55 "C:\ASP\WA\WA\Views\App\Product.cshtml"
                               Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2591, 190, true);
            WriteLiteral(" $</li>\r\n                            </ul>\r\n                        </div>\r\n                        <div style=\"display:inline-block; width:50%;\" align=\"right\">\r\n                            ");
            EndContext();
            BeginContext(2781, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bb5de8e9485d42f59d11491c17b48d03", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2813, "~/img/", 2813, 6, true);
#line 59 "C:\ASP\WA\WA\Views\App\Product.cshtml"
AddHtmlAttributeValue("", 2819, Model.DoorId, 2819, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 59 "C:\ASP\WA\WA\Views\App\Product.cshtml"
AddHtmlAttributeValue("", 2864, Model.Title, 2864, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2880, 172, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n                <div Align=\"right\" style=\"margin-right:20px;\">\r\n                    ");
            EndContext();
            BeginContext(3052, 345, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1595668510c34d10a024cc60aee7026b", async() => {
                BeginContext(3072, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 67 "C:\ASP\WA\WA\Views\App\Product.cshtml"
                         if (User.IsInRole("Admin"))
                        {

#line default
#line hidden
                BeginContext(3157, 49, true);
                WriteLiteral("                            <button type=\"submit\"");
                EndContext();
                BeginWriteAttribute("asp-for", " asp-for=", 3206, "", 3224, 1);
#line 69 "C:\ASP\WA\WA\Views\App\Product.cshtml"
WriteAttributeValue("", 3215, Model.Id, 3215, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3224, 41, true);
                WriteLiteral(" class=\"btn btn-danger\">Delete</button>\r\n");
                EndContext();
#line 70 "C:\ASP\WA\WA\Views\App\Product.cshtml"
                        }

#line default
#line hidden
                BeginContext(3292, 50, true);
                WriteLiteral("                        <div class=\"text-success\">");
                EndContext();
                BeginContext(3343, 19, false);
#line 71 "C:\ASP\WA\WA\Views\App\Product.cshtml"
                                             Write(ViewBag.UserMessage);

#line default
#line hidden
                EndContext();
                BeginContext(3362, 28, true);
                WriteLiteral("</div>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3397, 84, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
