#pragma checksum "D:\workspace\FGW-7436\7436-gch1108.2\lab2\lab2b\Views\User\UserList.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "16f66369e919f9a98fe41709ff5a4a182c050b7c4ae4ac42c45160319476f481"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UserList), @"mvc.1.0.view", @"/Views/User/UserList.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\workspace\FGW-7436\7436-gch1108.2\lab2\lab2b\Views\_ViewImports.cshtml"
using lab2b;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\workspace\FGW-7436\7436-gch1108.2\lab2\lab2b\Views\_ViewImports.cshtml"
using lab2b.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"16f66369e919f9a98fe41709ff5a4a182c050b7c4ae4ac42c45160319476f481", @"/Views/User/UserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"cb71f95865a6a91d52cd606e38aab20b155283b4127895fee13be5668feeb1fb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<lab2b.Models.User>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>User Name</th>\r\n        <th>Full Name</th>\r\n        <th>Age</th>\r\n    </tr>\r\n");
#nullable restore
#line 9 "D:\workspace\FGW-7436\7436-gch1108.2\lab2\lab2b\Views\User\UserList.cshtml"
     foreach(var user in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 12 "D:\workspace\FGW-7436\7436-gch1108.2\lab2\lab2b\Views\User\UserList.cshtml"
           Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 13 "D:\workspace\FGW-7436\7436-gch1108.2\lab2\lab2b\Views\User\UserList.cshtml"
           Write(user.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 14 "D:\workspace\FGW-7436\7436-gch1108.2\lab2\lab2b\Views\User\UserList.cshtml"
           Write(user.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 16 "D:\workspace\FGW-7436\7436-gch1108.2\lab2\lab2b\Views\User\UserList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n ");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<lab2b.Models.User>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
