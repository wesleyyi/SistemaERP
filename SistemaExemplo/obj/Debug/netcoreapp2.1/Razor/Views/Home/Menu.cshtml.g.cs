#pragma checksum "C:\Users\wesle\source\repos\SistemaExemplo\SistemaExemplo\Views\Home\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b60741065d9ea390fb37975f2cbd45aed2da9039"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Menu), @"mvc.1.0.view", @"/Views/Home/Menu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Menu.cshtml", typeof(AspNetCore.Views_Home_Menu))]
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
#line 1 "C:\Users\wesle\source\repos\SistemaExemplo\SistemaExemplo\Views\_ViewImports.cshtml"
using SistemaExemplo;

#line default
#line hidden
#line 2 "C:\Users\wesle\source\repos\SistemaExemplo\SistemaExemplo\Views\_ViewImports.cshtml"
using SistemaExemplo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b60741065d9ea390fb37975f2cbd45aed2da9039", @"/Views/Home/Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a36d895805f9e595eaefca6825a64db58a8388c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\wesle\source\repos\SistemaExemplo\SistemaExemplo\Views\Home\Menu.cshtml"
  
    ViewData["Title"] = "Menu";

#line default
#line hidden
            BeginContext(42, 258, true);
            WriteLiteral(@"
<h2>Lista de  empresas</h2>

<table class=""table table-striped"">
    <thead>
        <tr>
            <th>Id_Empresa</th>
            <th>Nome_Empresa</th>
            <th>CNPJ</th>
            <th>#</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 18 "C:\Users\wesle\source\repos\SistemaExemplo\SistemaExemplo\Views\Home\Menu.cshtml"
         foreach (var item in (List<MenuModel>)ViewBag.ListaMenu)
        {

#line default
#line hidden
            BeginContext(378, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(417, 14, false);
#line 21 "C:\Users\wesle\source\repos\SistemaExemplo\SistemaExemplo\Views\Home\Menu.cshtml"
               Write(item.IdEmpresa);

#line default
#line hidden
            EndContext();
            BeginContext(431, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(459, 16, false);
#line 22 "C:\Users\wesle\source\repos\SistemaExemplo\SistemaExemplo\Views\Home\Menu.cshtml"
               Write(item.NomeEmpresa);

#line default
#line hidden
            EndContext();
            BeginContext(475, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(503, 9, false);
#line 23 "C:\Users\wesle\source\repos\SistemaExemplo\SistemaExemplo\Views\Home\Menu.cshtml"
               Write(item.Cnpj);

#line default
#line hidden
            EndContext();
            BeginContext(512, 72, true);
            WriteLiteral("</td>\r\n                <td><button type=\"button\" class=\"btn btn-warning\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 584, "\"", 617, 3);
            WriteAttributeValue("", 594, "Editar(", 594, 7, true);
#line 24 "C:\Users\wesle\source\repos\SistemaExemplo\SistemaExemplo\Views\Home\Menu.cshtml"
WriteAttributeValue("", 601, item.IdEmpresa, 601, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 616, ")", 616, 1, true);
            EndWriteAttribute();
            BeginContext(618, 42, true);
            WriteLiteral(">Editar</button></td>\r\n            </tr>\r\n");
            EndContext();
#line 26 "C:\Users\wesle\source\repos\SistemaExemplo\SistemaExemplo\Views\Home\Menu.cshtml"
        }

#line default
#line hidden
            BeginContext(671, 129, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<script>\r\n    function Editar(Id) {\r\n        window.location.href = \"Cadastro/\" + Id;\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
