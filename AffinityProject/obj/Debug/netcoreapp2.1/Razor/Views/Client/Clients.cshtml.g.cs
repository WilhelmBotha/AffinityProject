#pragma checksum "C:\Users\botha\source\repos\AffinityProject\AffinityProject\Views\Client\Clients.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0be5b4720ac10caba4ae863fd8468258840d0207"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_Clients), @"mvc.1.0.view", @"/Views/Client/Clients.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Client/Clients.cshtml", typeof(AspNetCore.Views_Client_Clients))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0be5b4720ac10caba4ae863fd8468258840d0207", @"/Views/Client/Clients.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89cba34d41757e8d848a36669bfbe59bc0c2f5a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_Clients : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AffinityProject.ViewModels.ClientViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\botha\source\repos\AffinityProject\AffinityProject\Views\Client\Clients.cshtml"
  
    ViewData["Title"] = "Clients";

#line default
#line hidden
            BeginContext(109, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(114, 17, false);
#line 6 "C:\Users\botha\source\repos\AffinityProject\AffinityProject\Views\Client\Clients.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(131, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(143, 19, false);
#line 7 "C:\Users\botha\source\repos\AffinityProject\AffinityProject\Views\Client\Clients.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(162, 66, true);
            WriteLiteral("</h3>\r\n\r\n<p>Use this area to provide additional information.</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AffinityProject.ViewModels.ClientViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591