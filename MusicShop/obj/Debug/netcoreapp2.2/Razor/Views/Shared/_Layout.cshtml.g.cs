#pragma checksum "E:\Дипломная работа\MusicShopProject\MusicShop\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d8b0f7ae5b1f69321e8a8a7863d658b502ce49e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "E:\Дипломная работа\MusicShopProject\MusicShop\Views\_ViewImports.cshtml"
using MusicShop.ViewModel;

#line default
#line hidden
#line 2 "E:\Дипломная работа\MusicShopProject\MusicShop\Views\_ViewImports.cshtml"
using MusicShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d8b0f7ae5b1f69321e8a8a7863d658b502ce49e", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dae428e346fce6099e87ac68db095795ded0a31", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(27, 630, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d8b0f7ae5b1f69321e8a8a7863d658b502ce49e5287", async() => {
                BeginContext(33, 296, true);
                WriteLiteral(@"
    <meta http-equiv=""Content-Security-Policy"" content=""upgrade-insecure-requests"">
    <script src=""http://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js""></script>
    <meta name=""viewport"" content=""width=device-width"" />
    <title class=""title_name"">Music Portal</title>
    ");
                EndContext();
                BeginContext(329, 72, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9d8b0f7ae5b1f69321e8a8a7863d658b502ce49e5974", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(401, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(407, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9d8b0f7ae5b1f69321e8a8a7863d658b502ce49e7393", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(471, 179, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n    <script src=\"https://www.google.com/jsapi\"></script>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(657, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(659, 3832, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d8b0f7ae5b1f69321e8a8a7863d658b502ce49e9798", async() => {
                BeginContext(665, 2088, true);
                WriteLiteral(@"
    <script>
        google.load(""visualization"", ""1"", { packages: [""corechart""] });
        google.setOnLoadCallback(drawChart);
        var array = [];
        array.push([""Artist"", ""Population""]);

        $(document).ready(function () {
            $.getJSON(""http://ws.audioscrobbler.com/2.0/?method=user.getTopArtists&user=test&api_key=fc86b923e70297743cd18dbb9a4bdcc9&limit=10&format=json&callback=?"", function (json) {
                var html = '';
                $.each(json.topartists.artist, function (i, item)
                {
                    array.push([item.name, parseInt(item.playcount)]);
                    html += ""<div style='margin-top: 10px;'><a href="" + item.url + "" target='_blank'>"" + item.name + "" - "" + ""Play count : "" + item.playcount + ""</a></div>"";
                });
                $('#result').append(html);
            });
        });

        function drawChart() {
            var data = google.visualization.arrayToDataTable(array);
            var options");
                WriteLiteral(@" = {
                title: 'Music Population',
                is3D: true,
                pieResidueSliceLabel: 'Other',
                backgroundColor: { fill: 'transparent' }
            };
            var chart = new google.visualization.PieChart(document.getElementById('diagramm'));
            chart.draw(data, options);
        }

    </script>
    <div class=""main"">
        <div class=""header"">
            <div class=""main_title"">Welcome</div>
            <div class=""search"">
                <p>
                    <input list=""text"" class=""texbox"" oninput=""MyFunction()"" id=""thistext"" placeholder=""Поиск..."">
                    <datalist id=""text"">
                        <option>Search Element</option>
                    </datalist>
                </p>
                <button class=""main_button""><i class=""fa fa-search""></i></button>
            </div>
        </div>
        <div class=""mleft"">
            <div class=""gap"">
            </div>
            <h3 class=""groups");
                WriteLiteral("_title\">Artists</h3>\r\n            <ul>\r\n");
                EndContext();
#line 64 "E:\Дипломная работа\MusicShopProject\MusicShop\Views\Shared\_Layout.cshtml"
                  
                    foreach (var band in Model.AllBands)
                    {

#line default
#line hidden
                BeginContext(2854, 135, true);
                WriteLiteral("                        <li>\r\n                            <hr />\r\n                            <div>\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 2989, "\'", 3032, 2);
                WriteAttributeValue("", 2996, "/Album/AlbumsOfGroup?bandId=", 2996, 28, true);
#line 70 "E:\Дипломная работа\MusicShopProject\MusicShop\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3024, band.id, 3024, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 3033, "\"", 3046, 1);
#line 70 "E:\Дипломная работа\MusicShopProject\MusicShop\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3038, band.id, 3038, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3047, 104, true);
                WriteLiteral(">\r\n                                    <div class=\"band_name\">\r\n                                        ");
                EndContext();
                BeginContext(3152, 14, false);
#line 72 "E:\Дипломная работа\MusicShopProject\MusicShop\Views\Shared\_Layout.cshtml"
                                   Write(band.GroupName);

#line default
#line hidden
                EndContext();
                BeginContext(3166, 187, true);
                WriteLiteral("\r\n                                    </div>\r\n                                </a>\r\n                            </div>\r\n                            <hr />\r\n                        </li>\r\n");
                EndContext();
#line 78 "E:\Дипломная работа\MusicShopProject\MusicShop\Views\Shared\_Layout.cshtml"
                    }
                

#line default
#line hidden
                BeginContext(3395, 844, true);
                WriteLiteral(@"            </ul>
        </div>
        <div class=""fast_search"">
            <div class=""navigation"">
                <a href=""/Album/Main""> Main Page </a>
            </div>
            <div class=""navigation"">
                <a href=""/News/AllNews""> News </a>
            </div>
            <div class=""navigation"">
                <a href=""/Dictionary/AllAlbums""> Dictionary </a>
            </div>
            <div class=""navigation"">
                <a href=""/Tree/GenresTree""> Genres </a>
            </div>
            <div class=""navigation"">
                <a href=""/TextSearcher/SearchPage""> Scan Text </a>
            </div>
            <div class=""navigation"">
                <a href=""/MusicConverter/LoadTrack""> Read Notes </a>
            </div>
        </div>
        <div class=""mright"">
            ");
                EndContext();
                BeginContext(4240, 12, false);
#line 103 "E:\Дипломная работа\MusicShopProject\MusicShop\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(4252, 185, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"footer\">\r\n            <font color=\"red\">\r\n                <p>2020 Created by Aleksey</p>\r\n            </font>\r\n        </div>\r\n\r\n    </div>\r\n\r\n    ");
                EndContext();
                BeginContext(4437, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d8b0f7ae5b1f69321e8a8a7863d658b502ce49e16034", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4482, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4491, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
