#pragma checksum "D:\workspace\FGW-7436\7436-gch1108.2\lab1\lab1\Views\Demo\Hanoi.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6c20bc3005d2fbb9e2d70a7d33406347c29ff97f2f3b0721a300628070512216"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Demo_Hanoi), @"mvc.1.0.view", @"/Views/Demo/Hanoi.cshtml")]
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
#line 1 "D:\workspace\FGW-7436\7436-gch1108.2\lab1\lab1\Views\_ViewImports.cshtml"
using lab1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\workspace\FGW-7436\7436-gch1108.2\lab1\lab1\Views\_ViewImports.cshtml"
using lab1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6c20bc3005d2fbb9e2d70a7d33406347c29ff97f2f3b0721a300628070512216", @"/Views/Demo/Hanoi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4af28705fb0c3301c235da617f19c8e9a8c1a4861fbfaafc45f597fd2a3cb041", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Demo_Hanoi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Demo Controller</h1>\r\n<h2>Hanoi Action</h2>\r\n\r\n<p>");
#nullable restore
#line 4 "D:\workspace\FGW-7436\7436-gch1108.2\lab1\lab1\Views\Demo\Hanoi.cshtml"
Write(ViewBag.HN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<h6>We are living in ");
#nullable restore
#line 5 "D:\workspace\FGW-7436\7436-gch1108.2\lab1\lab1\Views\Demo\Hanoi.cshtml"
                Write(ViewData["CurrentYear"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
