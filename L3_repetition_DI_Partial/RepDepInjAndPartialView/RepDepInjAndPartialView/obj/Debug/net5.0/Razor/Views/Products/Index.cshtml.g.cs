#pragma checksum "D:\Nataliya\.NET\ASP.Net_MVC\win20-aspnetmvc-main\win20-aspnetmvc-main\lektion-3 local identity\repetition\RepDepInjAndPartialView\RepDepInjAndPartialView\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cfb4a315be604d9046a788f26489e4b5e2aa0ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
#line 1 "D:\Nataliya\.NET\ASP.Net_MVC\win20-aspnetmvc-main\win20-aspnetmvc-main\lektion-3 local identity\repetition\RepDepInjAndPartialView\RepDepInjAndPartialView\Views\_ViewImports.cshtml"
using RepDepInjAndPartialView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Nataliya\.NET\ASP.Net_MVC\win20-aspnetmvc-main\win20-aspnetmvc-main\lektion-3 local identity\repetition\RepDepInjAndPartialView\RepDepInjAndPartialView\Views\_ViewImports.cshtml"
using RepDepInjAndPartialView.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cfb4a315be604d9046a788f26489e4b5e2aa0ca", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"281bc8b089a7b038444f877afca4bd803603af60", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RepDepInjAndPartialView.Models.ProductList>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "D:\Nataliya\.NET\ASP.Net_MVC\win20-aspnetmvc-main\win20-aspnetmvc-main\lektion-3 local identity\repetition\RepDepInjAndPartialView\RepDepInjAndPartialView\Views\Products\Index.cshtml"
   ViewData["Title"] = "Products"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Products</h1>\n\n\n");
#nullable restore
#line 9 "D:\Nataliya\.NET\ASP.Net_MVC\win20-aspnetmvc-main\win20-aspnetmvc-main\lektion-3 local identity\repetition\RepDepInjAndPartialView\RepDepInjAndPartialView\Views\Products\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Nataliya\.NET\ASP.Net_MVC\win20-aspnetmvc-main\win20-aspnetmvc-main\lektion-3 local identity\repetition\RepDepInjAndPartialView\RepDepInjAndPartialView\Views\Products\Index.cshtml"
Write(await Html.PartialAsync("_ProductCarourselPartial", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Nataliya\.NET\ASP.Net_MVC\win20-aspnetmvc-main\win20-aspnetmvc-main\lektion-3 local identity\repetition\RepDepInjAndPartialView\RepDepInjAndPartialView\Views\Products\Index.cshtml"
                                                          ;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RepDepInjAndPartialView.Models.ProductList>> Html { get; private set; }
    }
}
#pragma warning restore 1591
