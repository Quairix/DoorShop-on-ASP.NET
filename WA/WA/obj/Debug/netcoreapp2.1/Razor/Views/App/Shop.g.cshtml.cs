#pragma checksum "C:\ASP\WA\WA\Views\App\Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96350b014224953ac2f7a38a69161d4dca68920f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_App_Shop), @"mvc.1.0.view", @"/Views/App/Shop.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/App/Shop.cshtml", typeof(AspNetCore.Views_App_Shop))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96350b014224953ac2f7a38a69161d4dca68920f", @"/Views/App/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1f1bd65858032b35f4108a488d3655cd6639fd2", @"/Views/_ViewImports.cshtml")]
    public class Views_App_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\ASP\WA\WA\Views\App\Shop.cshtml"
  
    ViewBag.Title = "Shop page";

#line default
#line hidden
            BeginContext(70, 27, true);
            WriteLiteral("\r\n<div class=\"col-md-11\">\r\n");
            EndContext();
#line 7 "C:\ASP\WA\WA\Views\App\Shop.cshtml"
     foreach (var p in Model)
    {

#line default
#line hidden
            BeginContext(135, 94, true);
            WriteLiteral("        <div class=\"col-md-3 h-100\">\r\n            <div class=\"well well-sm\">\r\n                ");
            EndContext();
            BeginContext(229, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "efb01c4adcc4402281a6196eb162657d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 239, "~/img/", 239, 6, true);
#line 11 "C:\ASP\WA\WA\Views\App\Shop.cshtml"
AddHtmlAttributeValue("", 245, p.DoorId, 245, 11, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 256, ".jpg", 256, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 11 "C:\ASP\WA\WA\Views\App\Shop.cshtml"
AddHtmlAttributeValue("", 290, p.Title, 290, 8, false);

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
            BeginContext(302, 48, true);
            WriteLiteral("\r\n                <h3 style=\"text-align:center\">");
            EndContext();
            BeginContext(351, 7, false);
#line 12 "C:\ASP\WA\WA\Views\App\Shop.cshtml"
                                         Write(p.Title);

#line default
#line hidden
            EndContext();
            BeginContext(358, 72, true);
            WriteLiteral("</h3>\r\n                <p style=\"text-align:center; font-size:smaller;\">");
            EndContext();
            BeginContext(431, 10, false);
#line 13 "C:\ASP\WA\WA\Views\App\Shop.cshtml"
                                                            Write(p.Category);

#line default
#line hidden
            EndContext();
            BeginContext(441, 66, true);
            WriteLiteral("</p>\r\n                <ul>\r\n                    <li>Manufacturer: ");
            EndContext();
            BeginContext(508, 14, false);
#line 15 "C:\ASP\WA\WA\Views\App\Shop.cshtml"
                                 Write(p.Manufacturer);

#line default
#line hidden
            EndContext();
            BeginContext(522, 33, true);
            WriteLiteral("</li>\r\n                    <li>\r\n");
            EndContext();
#line 17 "C:\ASP\WA\WA\Views\App\Shop.cshtml"
                         if (p.DoorDescription == null)
                        {

#line default
#line hidden
            BeginContext(643, 14, true);
            WriteLiteral("No description");
            EndContext();
#line 18 "C:\ASP\WA\WA\Views\App\Shop.cshtml"
                                                    }
                        else
                        { 

#line default
#line hidden
            BeginContext(730, 17, false);
#line 20 "C:\ASP\WA\WA\Views\App\Shop.cshtml"
                           Write(p.DoorDescription);

#line default
#line hidden
            EndContext();
#line 20 "C:\ASP\WA\WA\Views\App\Shop.cshtml"
                                                         }

#line default
#line hidden
            BeginContext(757, 57, true);
            WriteLiteral("                    </li>\r\n                    <li>Size: ");
            EndContext();
            BeginContext(815, 6, false);
#line 22 "C:\ASP\WA\WA\Views\App\Shop.cshtml"
                         Write(p.Size);

#line default
#line hidden
            EndContext();
            BeginContext(821, 38, true);
            WriteLiteral("</li>\r\n                    <li>Color: ");
            EndContext();
            BeginContext(860, 8, false);
#line 23 "C:\ASP\WA\WA\Views\App\Shop.cshtml"
                          Write(p.Colors);

#line default
#line hidden
            EndContext();
            BeginContext(868, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
            BeginContext(925, 24, true);
            WriteLiteral("                    <li>");
            EndContext();
            BeginContext(950, 7, false);
#line 25 "C:\ASP\WA\WA\Views\App\Shop.cshtml"
                   Write(p.Price);

#line default
#line hidden
            EndContext();
            BeginContext(957, 143, true);
            WriteLiteral("</li>\r\n                </ul>\r\n                <button id=\"BuyButton\" class=\"btn btn-success\">Buy</button>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 30 "C:\ASP\WA\WA\Views\App\Shop.cshtml"
    }

#line default
#line hidden
            BeginContext(1107, 18, true);
            WriteLiteral("</div>\r\n<p>Count: ");
            EndContext();
            BeginContext(1126, 13, false);
#line 32 "C:\ASP\WA\WA\Views\App\Shop.cshtml"
     Write(Model.Count());

#line default
#line hidden
            EndContext();
            BeginContext(1139, 4, true);
            WriteLiteral("</p>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
