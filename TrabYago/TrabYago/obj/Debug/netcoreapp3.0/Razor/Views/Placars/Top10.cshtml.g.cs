#pragma checksum "C:\Users\Daniel\Documents\GitHub\NolascoPad2Backup\TrabalhoYago\TrabYago\TrabYago\Views\Placars\Top10.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e449749af446fa45e8daf0cb9bb40fb827add67b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Placars_Top10), @"mvc.1.0.view", @"/Views/Placars/Top10.cshtml")]
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
#line 1 "C:\Users\Daniel\Documents\GitHub\NolascoPad2Backup\TrabalhoYago\TrabYago\TrabYago\Views\_ViewImports.cshtml"
using TrabYago;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Daniel\Documents\GitHub\NolascoPad2Backup\TrabalhoYago\TrabYago\TrabYago\Views\_ViewImports.cshtml"
using TrabYago.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e449749af446fa45e8daf0cb9bb40fb827add67b", @"/Views/Placars/Top10.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ab8d4411c9d94c26795a3efcd7110bc5c125d4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Placars_Top10 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TrabYago.Models.Placar>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Daniel\Documents\GitHub\NolascoPad2Backup\TrabalhoYago\TrabYago\TrabYago\Views\Placars\Top10.cshtml"
  
    ViewData["Title"] = "Top 10 Placares";
    int i = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Top 10 Placares</h1>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th></th>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\Daniel\Documents\GitHub\NolascoPad2Backup\TrabalhoYago\TrabYago\TrabYago\Views\Placars\Top10.cshtml"
           Write(Html.DisplayNameFor(model => model.JogadorNome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\Daniel\Documents\GitHub\NolascoPad2Backup\TrabalhoYago\TrabYago\TrabYago\Views\Placars\Top10.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalPontos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\Daniel\Documents\GitHub\NolascoPad2Backup\TrabalhoYago\TrabYago\TrabYago\Views\Placars\Top10.cshtml"
           Write(Html.DisplayNameFor(model => model.DataPontuacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n");
#nullable restore
#line 27 "C:\Users\Daniel\Documents\GitHub\NolascoPad2Backup\TrabalhoYago\TrabYago\TrabYago\Views\Placars\Top10.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 29 "C:\Users\Daniel\Documents\GitHub\NolascoPad2Backup\TrabalhoYago\TrabYago\TrabYago\Views\Placars\Top10.cshtml"
           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                 - \r\n            </th>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "C:\Users\Daniel\Documents\GitHub\NolascoPad2Backup\TrabalhoYago\TrabYago\TrabYago\Views\Placars\Top10.cshtml"
           Write(Html.DisplayFor(modelItem => item.JogadorNome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\Daniel\Documents\GitHub\NolascoPad2Backup\TrabalhoYago\TrabYago\TrabYago\Views\Placars\Top10.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalPontos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\Daniel\Documents\GitHub\NolascoPad2Backup\TrabalhoYago\TrabYago\TrabYago\Views\Placars\Top10.cshtml"
           Write(Html.DisplayFor(modelItem => item.DataPontuacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 42 "C:\Users\Daniel\Documents\GitHub\NolascoPad2Backup\TrabalhoYago\TrabYago\TrabYago\Views\Placars\Top10.cshtml"
        i++;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TrabYago.Models.Placar>> Html { get; private set; }
    }
}
#pragma warning restore 1591
