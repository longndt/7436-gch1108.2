#pragma checksum "D:\workspace\FGW-7436\7436-gch1108.2\lab2\lab2b\Views\Helper\Register.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "efd9f4c484ba46cd701d42bebb8d338b427074373aad99f160e19720591c2e94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Helper_Register), @"mvc.1.0.view", @"/Views/Helper/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"efd9f4c484ba46cd701d42bebb8d338b427074373aad99f160e19720591c2e94", @"/Views/Helper/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"cb71f95865a6a91d52cd606e38aab20b155283b4127895fee13be5668feeb1fb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Helper_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<lab2b.Models.User>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<ul>\r\n    <li>User Name: ");
#nullable restore
#line 4 "D:\workspace\FGW-7436\7436-gch1108.2\lab2\lab2b\Views\Helper\Register.cshtml"
              Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Full Name: ");
#nullable restore
#line 5 "D:\workspace\FGW-7436\7436-gch1108.2\lab2\lab2b\Views\Helper\Register.cshtml"
              Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Age: ");
#nullable restore
#line 6 "D:\workspace\FGW-7436\7436-gch1108.2\lab2\lab2b\Views\Helper\Register.cshtml"
        Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<lab2b.Models.User> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591