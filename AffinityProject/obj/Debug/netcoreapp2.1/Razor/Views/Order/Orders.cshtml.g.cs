#pragma checksum "C:\Users\botha\source\repos\AffinityProject\AffinityProject\Views\Order\Orders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccffb0bf49284cad03844d3cb9011c524b608938"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Orders), @"mvc.1.0.view", @"/Views/Order/Orders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Orders.cshtml", typeof(AspNetCore.Views_Order_Orders))]
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
#line 1 "C:\Users\botha\source\repos\AffinityProject\AffinityProject\Views\_ViewImports.cshtml"
using AffinityProject;

#line default
#line hidden
#line 2 "C:\Users\botha\source\repos\AffinityProject\AffinityProject\Views\_ViewImports.cshtml"
using AffinityProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccffb0bf49284cad03844d3cb9011c524b608938", @"/Views/Order/Orders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89cba34d41757e8d848a36669bfbe59bc0c2f5a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Orders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AffinityProject.ViewModels.OrderViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(70, 17, false);
#line 3 "C:\Users\botha\source\repos\AffinityProject\AffinityProject\Views\Order\Orders.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(87, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(99, 19, false);
#line 4 "C:\Users\botha\source\repos\AffinityProject\AffinityProject\Views\Order\Orders.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(118, 369, true);
            WriteLiteral(@"</h3>

<address>
    One Microsoft Way<br />
    Redmond, WA 98052-6399<br />
    <abbr title=""Phone"">P:</abbr>
    425.555.0100
</address>

<address>
    <strong>Support:</strong> <a href=""mailto:Support@example.com"">Support@example.com</a><br />
    <strong>Marketing:</strong> <a href=""mailto:Marketing@example.com"">Marketing@example.com</a>
</address>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AffinityProject.ViewModels.OrderViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
