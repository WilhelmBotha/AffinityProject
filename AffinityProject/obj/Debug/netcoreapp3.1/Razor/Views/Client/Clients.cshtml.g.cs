#pragma checksum "C:\Users\wilhelm.GENDAC\Source\Repos\AffinityProject\AffinityProject\Views\Client\Clients.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3065e0726a3a6fb5909c7647bb30cfa93c83f602"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_Clients), @"mvc.1.0.view", @"/Views/Client/Clients.cshtml")]
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
#line 1 "C:\Users\wilhelm.GENDAC\Source\Repos\AffinityProject\AffinityProject\Views\_ViewImports.cshtml"
using AffinityProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wilhelm.GENDAC\Source\Repos\AffinityProject\AffinityProject\Views\_ViewImports.cshtml"
using AffinityProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3065e0726a3a6fb5909c7647bb30cfa93c83f602", @"/Views/Client/Clients.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89cba34d41757e8d848a36669bfbe59bc0c2f5a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_Clients : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AffinityProject.ViewModels.CustomerViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 3 "C:\Users\wilhelm.GENDAC\Source\Repos\AffinityProject\AffinityProject\Views\Client\Clients.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h3>");
#nullable restore
#line 4 "C:\Users\wilhelm.GENDAC\Source\Repos\AffinityProject\AffinityProject\Views\Client\Clients.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Name</th>\r\n        <th>Orders</th>\r\n    </tr>\r\n");
#nullable restore
#line 12 "C:\Users\wilhelm.GENDAC\Source\Repos\AffinityProject\AffinityProject\Views\Client\Clients.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 16 "C:\Users\wilhelm.GENDAC\Source\Repos\AffinityProject\AffinityProject\Views\Client\Clients.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 19 "C:\Users\wilhelm.GENDAC\Source\Repos\AffinityProject\AffinityProject\Views\Client\Clients.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 22 "C:\Users\wilhelm.GENDAC\Source\Repos\AffinityProject\AffinityProject\Views\Client\Clients.cshtml"
           Write(Html.DisplayFor(modelItem => item.Orders));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 25 "C:\Users\wilhelm.GENDAC\Source\Repos\AffinityProject\AffinityProject\Views\Client\Clients.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AffinityProject.ViewModels.CustomerViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
