#pragma checksum "D:\MeusProjetos\LanchesMac\LanchesMac\Views\Lanche\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b1f3a9d78e8dfcb8ef145fe32d2911c592bc64e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lanche_List), @"mvc.1.0.view", @"/Views/Lanche/List.cshtml")]
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
#line 1 "D:\MeusProjetos\LanchesMac\LanchesMac\Views\_ViewImports.cshtml"
using LanchesMac;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MeusProjetos\LanchesMac\LanchesMac\Views\_ViewImports.cshtml"
using LanchesMac.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b1f3a9d78e8dfcb8ef145fe32d2911c592bc64e", @"/Views/Lanche/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5eaea5eb06b4f2d63f8b5aef9f2ab88fe446ee42", @"/Views/_ViewImports.cshtml")]
    public class Views_Lanche_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LanchesMac.Models.Lanche>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div> <h2>Todos os lanches</h2> </div>\r\n\r\n");
#nullable restore
#line 5 "D:\MeusProjetos\LanchesMac\LanchesMac\Views\Lanche\List.cshtml"
 foreach(var lanche in Model){


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h4>Lanche: ");
#nullable restore
#line 8 "D:\MeusProjetos\LanchesMac\LanchesMac\Views\Lanche\List.cshtml"
               Write(lanche.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 186, "\"", 209, 1);
#nullable restore
#line 9 "D:\MeusProjetos\LanchesMac\LanchesMac\Views\Lanche\List.cshtml"
WriteAttributeValue("", 192, lanche.ImagemUrl, 192, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <p>Preço: ");
#nullable restore
#line 10 "D:\MeusProjetos\LanchesMac\LanchesMac\Views\Lanche\List.cshtml"
             Write(lanche.Preco.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n");
#nullable restore
#line 12 "D:\MeusProjetos\LanchesMac\LanchesMac\Views\Lanche\List.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LanchesMac.Models.Lanche>> Html { get; private set; }
    }
}
#pragma warning restore 1591
