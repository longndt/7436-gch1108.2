#pragma checksum "D:\workspace\FGW-7436\7436-gch1108.2\lab2\lab2b\Views\Home\RazorDemo.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "03780600bba14e5f9726e7a8b9e0e2ecc543233b04392f6e4874724d1c00cdba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RazorDemo), @"mvc.1.0.view", @"/Views/Home/RazorDemo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"03780600bba14e5f9726e7a8b9e0e2ecc543233b04392f6e4874724d1c00cdba", @"/Views/Home/RazorDemo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"cb71f95865a6a91d52cd606e38aab20b155283b4127895fee13be5668feeb1fb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_RazorDemo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\workspace\FGW-7436\7436-gch1108.2\lab2\lab2b\Views\Home\RazorDemo.cshtml"
  
    Layout = "~/Views/Shared/_DemoLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 5 "D:\workspace\FGW-7436\7436-gch1108.2\lab2\lab2b\Views\Home\RazorDemo.cshtml"
Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 10 "D:\workspace\FGW-7436\7436-gch1108.2\lab2\lab2b\Views\Home\RazorDemo.cshtml"
  
    //single line comment
    /* multiple
     * lines
     * comment
     */
    int currentYear = DateTime.Now.Year;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 18 "D:\workspace\FGW-7436\7436-gch1108.2\lab2\lab2b\Views\Home\RazorDemo.cshtml"
Write(currentYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h3>Email: longndt");
            WriteLiteral("@fpt.edu.vn</h3>\r\n\r\n");
#nullable restore
#line 21 "D:\workspace\FGW-7436\7436-gch1108.2\lab2\lab2b\Views\Home\RazorDemo.cshtml"
  
    var x = 10;
    var y = 20;
    var total = x + y;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>Total: ");
#nullable restore
#line 26 "D:\workspace\FGW-7436\7436-gch1108.2\lab2\lab2b\Views\Home\RazorDemo.cshtml"
      Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n");
#nullable restore
#line 28 "D:\workspace\FGW-7436\7436-gch1108.2\lab2\lab2b\Views\Home\RazorDemo.cshtml"
  
    double grade = 6.8;
    string result = "";
    if (grade >= 5.0)
        result = "Pass";
    else
        result = "Fail";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>Grade: ");
#nullable restore
#line 36 "D:\workspace\FGW-7436\7436-gch1108.2\lab2\lab2b\Views\Home\RazorDemo.cshtml"
      Write(grade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Result: ");
#nullable restore
#line 37 "D:\workspace\FGW-7436\7436-gch1108.2\lab2\lab2b\Views\Home\RazorDemo.cshtml"
       Write(result);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<ul>\r\n");
#nullable restore
#line 40 "D:\workspace\FGW-7436\7436-gch1108.2\lab2\lab2b\Views\Home\RazorDemo.cshtml"
      
        for (int i = 1; i <= 10; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 43 "D:\workspace\FGW-7436\7436-gch1108.2\lab2\lab2b\Views\Home\RazorDemo.cshtml"
           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 44 "D:\workspace\FGW-7436\7436-gch1108.2\lab2\lab2b\Views\Home\RazorDemo.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n");
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
