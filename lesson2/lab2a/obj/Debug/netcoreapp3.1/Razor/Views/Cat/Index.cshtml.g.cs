#pragma checksum "D:\workspace\FGW-7436\7436-gch1108.2\lab2\lab2a\Views\Cat\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9950d4a25410cc1599282da55661770afa81cc8bea5c76d0b305640c0b78cb98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cat_Index), @"mvc.1.0.view", @"/Views/Cat/Index.cshtml")]
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
#line 1 "D:\workspace\FGW-7436\7436-gch1108.2\lab2\lab2a\Views\_ViewImports.cshtml"
using lab2a;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\workspace\FGW-7436\7436-gch1108.2\lab2\lab2a\Views\_ViewImports.cshtml"
using lab2a.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"9950d4a25410cc1599282da55661770afa81cc8bea5c76d0b305640c0b78cb98", @"/Views/Cat/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"48fe30f71a25bbe978b3b482550199a9932017426b954738c92d3536df95a1aa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cat_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>");
#nullable restore
#line 1 "D:\workspace\FGW-7436\7436-gch1108.2\lab2\lab2a\Views\Cat\Index.cshtml"
Write(ViewBag.Cat.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<img");
            BeginWriteAttribute("src", " src=\"", 32, "\"", 59, 1);
#nullable restore
#line 2 "D:\workspace\FGW-7436\7436-gch1108.2\lab2\lab2a\Views\Cat\Index.cshtml"
WriteAttributeValue("", 38, ViewBag.Cat.ImageUrl, 38, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"300\" height=\"300\" />\r\n<h3>Age: ");
#nullable restore
#line 3 "D:\workspace\FGW-7436\7436-gch1108.2\lab2\lab2a\Views\Cat\Index.cshtml"
    Write(ViewBag.Cat.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Breed: ");
#nullable restore
#line 4 "D:\workspace\FGW-7436\7436-gch1108.2\lab2\lab2a\Views\Cat\Index.cshtml"
      Write(ViewBag.Cat.Breed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>");
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
