#pragma checksum "/Users/fanandong/Desktop/side project#1/bookeeping/Views/Budget/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8602e0ec3949aa4d22977c367f8e6dae01157e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Budget_Details), @"mvc.1.0.view", @"/Views/Budget/Details.cshtml")]
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
#line 1 "/Users/fanandong/Desktop/side project#1/bookeeping/Views/_ViewImports.cshtml"
using bookeeping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/fanandong/Desktop/side project#1/bookeeping/Views/_ViewImports.cshtml"
using bookeeping.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/fanandong/Desktop/side project#1/bookeeping/Views/_ViewImports.cshtml"
using bookeeping.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/fanandong/Desktop/side project#1/bookeeping/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8602e0ec3949aa4d22977c367f8e6dae01157e4", @"/Views/Budget/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7259ca7ab28e12c4c75f3bf93706aacf1bc18206", @"/Views/_ViewImports.cshtml")]
    public class Views_Budget_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Budget>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/fanandong/Desktop/side project#1/bookeeping/Views/Budget/Details.cshtml"
  
    ViewData["Title"] = "Bubget Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br>\n<div class=\"content\">\n    <table>\n        <tr>\n            <th>項目</th>\n            <th>金額</th>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 14 "/Users/fanandong/Desktop/side project#1/bookeeping/Views/Budget/Details.cshtml"
           Write(nameof(Model.Food));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 15 "/Users/fanandong/Desktop/side project#1/bookeeping/Views/Budget/Details.cshtml"
           Write(Model.Food);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 18 "/Users/fanandong/Desktop/side project#1/bookeeping/Views/Budget/Details.cshtml"
           Write(nameof(Model.Transport));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 19 "/Users/fanandong/Desktop/side project#1/bookeeping/Views/Budget/Details.cshtml"
           Write(Model.Transport);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 22 "/Users/fanandong/Desktop/side project#1/bookeeping/Views/Budget/Details.cshtml"
           Write(nameof(Model.Shopping));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 23 "/Users/fanandong/Desktop/side project#1/bookeeping/Views/Budget/Details.cshtml"
           Write(Model.Shopping);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 26 "/Users/fanandong/Desktop/side project#1/bookeeping/Views/Budget/Details.cshtml"
           Write(nameof(Model.Entertainment));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 27 "/Users/fanandong/Desktop/side project#1/bookeeping/Views/Budget/Details.cshtml"
           Write(Model.Entertainment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 30 "/Users/fanandong/Desktop/side project#1/bookeeping/Views/Budget/Details.cshtml"
           Write(nameof(Model.Personal));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 31 "/Users/fanandong/Desktop/side project#1/bookeeping/Views/Budget/Details.cshtml"
           Write(Model.Personal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 34 "/Users/fanandong/Desktop/side project#1/bookeeping/Views/Budget/Details.cshtml"
           Write(nameof(Model.Learning));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 35 "/Users/fanandong/Desktop/side project#1/bookeeping/Views/Budget/Details.cshtml"
           Write(Model.Learning);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 38 "/Users/fanandong/Desktop/side project#1/bookeeping/Views/Budget/Details.cshtml"
           Write(nameof(Model.Other));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 39 "/Users/fanandong/Desktop/side project#1/bookeeping/Views/Budget/Details.cshtml"
           Write(Model.Other);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n    </table>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Budget> Html { get; private set; }
    }
}
#pragma warning restore 1591