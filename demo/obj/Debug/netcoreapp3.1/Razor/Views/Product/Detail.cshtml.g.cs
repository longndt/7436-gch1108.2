#pragma checksum "D:\workspace\FGW-7436\7436-gch1108.2\demo\Views\Product\Detail.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "dcdb95d290a927bcffa49b443100590e9c4dcb9a2d553ef25cc8097966de3a08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\workspace\FGW-7436\7436-gch1108.2\demo\Views\_ViewImports.cshtml"
using demo

#nullable disable
    ;
#nullable restore
#line 2 "D:\workspace\FGW-7436\7436-gch1108.2\demo\Views\_ViewImports.cshtml"
using demo.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"dcdb95d290a927bcffa49b443100590e9c4dcb9a2d553ef25cc8097966de3a08", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4be62084da2e7d55a36b887b1f289a6e27c5879c3bf4b29760457d0f4996cf0e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container col-md-8 text-center card bg-light\">\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 144, "\"", 162, 1);
            WriteAttributeValue("", 150, 
#nullable restore
#line 6 "D:\workspace\FGW-7436\7436-gch1108.2\demo\Views\Product\Detail.cshtml"
                       Model.Image

#line default
#line hidden
#nullable disable
            , 150, 12, false);
            EndWriteAttribute();
            WriteLiteral(" width=\"300\" height=\"350\" alt=\"product image\" />\r\n        </div>\r\n        <div class=\"col\">\r\n            <h1 class=\"text text-primary\">");
            Write(
#nullable restore
#line 9 "D:\workspace\FGW-7436\7436-gch1108.2\demo\Views\Product\Detail.cshtml"
                                           Model.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h1>\r\n            <h3 class=\"text text-danger\">$");
            Write(
#nullable restore
#line 10 "D:\workspace\FGW-7436\7436-gch1108.2\demo\Views\Product\Detail.cshtml"
                                           Model.Price

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h3>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
