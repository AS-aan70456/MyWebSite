#pragma checksum "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Game\Game.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8abf0e08e67eec51a14ab891c14d95ce479ccaa9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_Game), @"mvc.1.0.view", @"/Views/Game/Game.cshtml")]
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
#line 1 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Game\Game.cshtml"
using TorrentMvcProject.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8abf0e08e67eec51a14ab891c14d95ce479ccaa9", @"/Views/Game/Game.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_Game : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("outLine-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Ваше имя"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Ваш e-mail(необизательно)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("TextCom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Ваш комментарий"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Game", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("commentar-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/noavatar.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row-item-main\">\r\n    <div class=\"row-container\">\r\n\r\n        <div class=\"main-title\">");
#nullable restore
#line 8 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Game\Game.cshtml"
                           Write(Model.Game.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" [");
#nullable restore
#line 8 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Game\Game.cshtml"
                                             Write(Model.Game.version);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | Rus] скачать торрент</div>\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 290, "\"", 315, 1);
#nullable restore
#line 9 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Game\Game.cshtml"
WriteAttributeValue("", 296, Model.Game.mainImg, 296, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"main-img\">\r\n        <div class=\"impression\">\r\n            <button class=\"Like\"");
            BeginWriteAttribute("type", " type=\"", 402, "\"", 409, 0);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 410, "\"", 417, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-regular fa-thumbs-up\"></i>");
#nullable restore
#line 11 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Game\Game.cshtml"
                                                                                   Write(Model.Game.dizlike);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n            <button class=\"dizLike\"");
            BeginWriteAttribute("type", " type=\"", 523, "\"", 530, 0);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 531, "\"", 538, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-regular fa-thumbs-down\"></i>");
#nullable restore
#line 12 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Game\Game.cshtml"
                                                                                        Write(Model.Game.like);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n        </div>\r\n        <div class=\"descriptions\">");
#nullable restore
#line 14 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Game\Game.cshtml"
                             Write(Model.Game.desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"games-img\">\r\n            <img class=\"games-img-item\"");
            BeginWriteAttribute("src", " src=\"", 754, "\"", 776, 1);
#nullable restore
#line 16 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Game\Game.cshtml"
WriteAttributeValue("", 760, Model.Game.img1, 760, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img class=\"games-img-item\"");
            BeginWriteAttribute("src", " src=\"", 819, "\"", 841, 1);
#nullable restore
#line 17 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Game\Game.cshtml"
WriteAttributeValue("", 825, Model.Game.img2, 825, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img class=\"games-img-item\"");
            BeginWriteAttribute("src", " src=\"", 884, "\"", 906, 1);
#nullable restore
#line 18 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Game\Game.cshtml"
WriteAttributeValue("", 890, Model.Game.img3, 890, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img class=\"games-img-item\"");
            BeginWriteAttribute("src", " src=\"", 949, "\"", 971, 1);
#nullable restore
#line 19 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Game\Game.cshtml"
WriteAttributeValue("", 955, Model.Game.img4, 955, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
        </div>
        <div class=""main-youtub"">
            <a href=""https://www.youtube.com/watch?v=SpCUuyZZTp8&t=4896s&ab_channel=%D0%92%D0%BB%D0%B0%D0%B4%D0%B8%D0%BB%D0%B5%D0%BD%D0%9C%D0%B8%D0%BD%D0%B8%D0%BD"">Трейлер игри</a>
        </div>
        <div class=""game-info"">
            <div class=""game-info-item"">
                <div class=""info-item-title"">Информация    	       </div>
                <div class=""info-item-desc"">Дата выхода:   	       <div class=""info-item-vaule"">__");
#nullable restore
#line 27 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Game\Game.cshtml"
                                                                                                Write(Model.Game.ReleaseDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\t </div></div>\r\n                <div class=\"info-item-desc\">Жанр:          \t       <div class=\"info-item-vaule\">__");
#nullable restore
#line 28 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Game\Game.cshtml"
                                                                                                Write(Model.Game.teg);

#line default
#line hidden
#nullable disable
            WriteLiteral("             </div></div>\r\n                <div class=\"info-item-desc\">Разработчик и издатель:<div class=\"info-item-vaule\">__");
#nullable restore
#line 29 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Game\Game.cshtml"
                                                                                             Write(Model.Game.developer);

#line default
#line hidden
#nullable disable
            WriteLiteral("       </div></div>\r\n                <div class=\"info-item-desc\">Текст:         \t       <div class=\"info-item-vaule\">__");
#nullable restore
#line 30 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Game\Game.cshtml"
                                                                                                Write(Model.Game.languages);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"       </div></div>
            </div>
            <div class=""game-info-item"">
                <div class=""info-item-title"">Системные требования  </div>
                <div class=""info-item-desc"">Windows:       	       <div class=""info-item-vaule"">__");
#nullable restore
#line 34 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Game\Game.cshtml"
                                                                                                Write(Model.Game.Windows);

#line default
#line hidden
#nullable disable
            WriteLiteral("         </div></div>\r\n                <div class=\"info-item-desc\">Процессор:     \t       <div class=\"info-item-vaule\">__");
#nullable restore
#line 35 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Game\Game.cshtml"
                                                                                                Write(Model.Game.CPU);

#line default
#line hidden
#nullable disable
            WriteLiteral("             </div></div>\r\n                <div class=\"info-item-desc\">Оперативная память:    <div class=\"info-item-vaule\">__");
#nullable restore
#line 36 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Game\Game.cshtml"
                                                                                             Write(Model.Game.RAM);

#line default
#line hidden
#nullable disable
            WriteLiteral("             </div></div>\r\n                <div class=\"info-item-desc\">Видеокарта:    \t       <div class=\"info-item-vaule\">__");
#nullable restore
#line 37 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Game\Game.cshtml"
                                                                                                Write(Model.Game.videoCard);

#line default
#line hidden
#nullable disable
            WriteLiteral("       </div></div>\r\n                <div class=\"info-item-desc\">Место на диске:\t       <div class=\"info-item-vaule\">__");
#nullable restore
#line 38 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Game\Game.cshtml"
                                                                                                Write(Model.Game.Windows);

#line default
#line hidden
#nullable disable
            WriteLiteral("         </div></div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"summarize\">Размер : ");
#nullable restore
#line 42 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Game\Game.cshtml"
                                   Write(Model.Game.Windows);

#line default
#line hidden
#nullable disable
            WriteLiteral(" гб</div>\r\n        <div class=\"torrent\">\r\n            <div class=\"torren-bnt\"><a  href=\"https://img/Frostpunk/Torrent.torrent\"");
            BeginWriteAttribute("download", " download=\"", 2991, "\"", 3002, 0);
            EndWriteAttribute();
            WriteLiteral(@">Скачать torrent</a></div>
        </div>
    </div>
</div>

<div class=""row-item-main"">
    <div class=""row-container"">
        <div class=""main-title"">#Похоже игри : </div>
        <div class=""likeGames"">
            <div class=""likeGames-box"">
                <div class=""likeGames-item"">
                    <img class=""likeGames-img"" src=""/img/FrestPunk/f4.jpg"">
                    <div class=""likeGames-Title"">Названия игри</div>
                </div>
                <div class=""likeGames-item"">
                    <img class=""likeGames-img"" src=""/img/FrestPunk/f4.jpg"">
                    <div class=""likeGames-Title"">Названия игри</div>
                </div>
                <div class=""likeGames-item"">
                    <img class=""likeGames-img"" src=""/img/FrestPunk/f4.jpg"">
                    <div class=""likeGames-Title"">Названия игри</div>
                </div>
            </div>
            <div class=""likeGames-box"">
                <div class=""likeGames-item"">
         ");
            WriteLiteral(@"           <img class=""likeGames-img"" src=""/img/FrestPunk/f4.jpg"">
                    <div class=""likeGames-Title"">Названия игри</div>
                </div>
                <div class=""likeGames-item"">
                    <img class=""likeGames-img"" src=""/img/FrestPunk/f4.jpg"">
                    <div class=""likeGames-Title"">Названия игри</div>
                </div>
                <div class=""likeGames-item"">
                    <img class=""likeGames-img"" src=""/img/FrestPunk/f4.jpg"">
                    <div class=""likeGames-Title"">Названия игри</div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""row-item-main"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8abf0e08e67eec51a14ab891c14d95ce479ccaa918350", async() => {
                WriteLiteral("\r\n        <div class=\"main-title\">#Добавить свой комментарий:</div>\r\n        <div class=\"outLine\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8abf0e08e67eec51a14ab891c14d95ce479ccaa918727", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 89 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Game\Game.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.newComment.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8abf0e08e67eec51a14ab891c14d95ce479ccaa920417", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 91 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Game\Game.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.newComment.Gmail);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n        </div>\r\n\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8abf0e08e67eec51a14ab891c14d95ce479ccaa922130", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 96 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Game\Game.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.newComment.Text);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n        <div style=\"padding-bottom: 15px;\"><input class=\"com-bnt\" type=\"submit\" value=\"Добавить\" input></div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
#nullable restore
#line 102 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Game\Game.cshtml"
  
    foreach (var els in Model.allComment)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row-item-main\">\r\n            <div class=\"row-container\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8abf0e08e67eec51a14ab891c14d95ce479ccaa925781", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <div class=\"commentar-content\">\r\n                    <div class=\"commentar-Title\">");
#nullable restore
#line 109 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Game\Game.cshtml"
                                            Write(els.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"commentar-Text\">");
#nullable restore
#line 110 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Game\Game.cshtml"
                                           Write(els.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 114 "C:\Users\User\source\repos\TorrentMvcProject\TorrentMvcProject\Views\Game\Game.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
