#pragma checksum "D:\Nataliya\.NET\ASP.Net_MVC\Code\L7_adminPortal\adminPortal\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c96b217b69cca20a50f653b5725a5b438397c54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "D:\Nataliya\.NET\ASP.Net_MVC\Code\L7_adminPortal\adminPortal\Views\_ViewImports.cshtml"
using adminPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Nataliya\.NET\ASP.Net_MVC\Code\L7_adminPortal\adminPortal\Views\_ViewImports.cshtml"
using adminPortal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Nataliya\.NET\ASP.Net_MVC\Code\L7_adminPortal\adminPortal\Views\_ViewImports.cshtml"
using adminPortal.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Nataliya\.NET\ASP.Net_MVC\Code\L7_adminPortal\adminPortal\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c96b217b69cca20a50f653b5725a5b438397c54", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccb7317e685a36195b51845afe7d9619e4e05393", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IdentityRole>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h1>All users</h1>\r\n");
#nullable restore
#line 5 "D:\Nataliya\.NET\ASP.Net_MVC\Code\L7_adminPortal\adminPortal\Views\User\Index.cshtml"
 foreach (var user in ViewBag.Users)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"mb-4\">\r\n        ");
#nullable restore
#line 8 "D:\Nataliya\.NET\ASP.Net_MVC\Code\L7_adminPortal\adminPortal\Views\User\Index.cshtml"
   Write(user.GetDisplayName());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 9 "D:\Nataliya\.NET\ASP.Net_MVC\Code\L7_adminPortal\adminPortal\Views\User\Index.cshtml"
   Write(Html.DropDownListFor(model => model.Id, new SelectList(ViewBag.Roles, "Id", "Name"), "Välja Roll"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 11 "D:\Nataliya\.NET\ASP.Net_MVC\Code\L7_adminPortal\adminPortal\Views\User\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<AppUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<AppUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IdentityRole> Html { get; private set; }
    }
}
#pragma warning restore 1591
