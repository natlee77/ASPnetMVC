#pragma checksum "D:\Nataliya\.NET\ASP.Net_MVC\Code\L2_partialView\PartialView\Views\Shared\_ProductCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b60d948e8b81c504d6c9cd3b3cd803df90776149"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductCard), @"mvc.1.0.view", @"/Views/Shared/_ProductCard.cshtml")]
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
#line 1 "D:\Nataliya\.NET\ASP.Net_MVC\Code\L2_partialView\PartialView\Views\_ViewImports.cshtml"
using PartialView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Nataliya\.NET\ASP.Net_MVC\Code\L2_partialView\PartialView\Views\_ViewImports.cshtml"
using PartialView.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b60d948e8b81c504d6c9cd3b3cd803df90776149", @"/Views/Shared/_ProductCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7447ae80986a5cd61172c7f6e8f771eaf552cff", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PartialView.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n<div class=\"col\">\r\n    <div class=\"card\">\r\n        <img src=\" \" class=\"card-img-top\" alt=\"...\">\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 10 "D:\Nataliya\.NET\ASP.Net_MVC\Code\L2_partialView\PartialView\Views\Shared\_ProductCard.cshtml"
                              Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p class=\"card-text\">  ");
#nullable restore
#line 11 "D:\Nataliya\.NET\ASP.Net_MVC\Code\L2_partialView\PartialView\Views\Shared\_ProductCard.cshtml"
                              Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PartialView.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591