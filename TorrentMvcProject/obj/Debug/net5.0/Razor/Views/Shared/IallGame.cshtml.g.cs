#pragma checksum "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Shared\IallGame.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52a3f13492d30d3332285d1d8c69584ab6399a1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_IallGame), @"mvc.1.0.view", @"/Views/Shared/IallGame.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52a3f13492d30d3332285d1d8c69584ab6399a1c", @"/Views/Shared/IallGame.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_IallGame : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"row-item-main\">\r\n    <div class=\"row-container\">\r\n        <div class=\"game-list min-h\">\r\n");
#nullable restore
#line 6 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Shared\IallGame.cshtml"
               foreach (var el in Model._allGameItems)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"game-item\"");
            BeginWriteAttribute("href", " href=\"", 220, "\"", 246, 2);
            WriteAttributeValue("", 227, "/Game/Game/", 227, 11, true);
#nullable restore
#line 8 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Shared\IallGame.cshtml"
WriteAttributeValue("", 238, el.name, 238, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img class=\"game-img\"");
            BeginWriteAttribute("src", " src=", 295, "", 311, 1);
#nullable restore
#line 9 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Shared\IallGame.cshtml"
WriteAttributeValue("", 300, el.mainImg, 300, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"game-text\">");
#nullable restore
#line 10 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Shared\IallGame.cshtml"
                                          Write(el.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </a>\r\n");
#nullable restore
#line 12 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Shared\IallGame.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n\r\n\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 469, "\"", 489, 1);
#nullable restore
#line 18 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Shared\IallGame.cshtml"
WriteAttributeValue("", 476, ViewBag.next, 476, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"com-bnt\">Next</a>\r\n");
#nullable restore
#line 19 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Shared\IallGame.cshtml"
          
            if (@ViewBag.ID > 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 583, "\"", 603, 1);
#nullable restore
#line 21 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Shared\IallGame.cshtml"
WriteAttributeValue("", 590, ViewBag.back, 590, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"com-bnt\" style=\"background-color:#464646; \">Last</a> ");
#nullable restore
#line 21 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Shared\IallGame.cshtml"
                                                                                                    }
            else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a class=\"com-bnt\" style=\"background-color: #f1f5f7; \">Last</a>\r\n");
#nullable restore
#line 24 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Shared\IallGame.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"height: 20px;\"></div>\r\n    </div>\r\n</div>");
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