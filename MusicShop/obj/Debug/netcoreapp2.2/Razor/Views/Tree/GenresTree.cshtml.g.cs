#pragma checksum "E:\Дипломная работа\MusicShopProject\MusicShop\Views\Tree\GenresTree.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64da1f8542d936ea39c8da1dde6a4f395afea12d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tree_GenresTree), @"mvc.1.0.view", @"/Views/Tree/GenresTree.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tree/GenresTree.cshtml", typeof(AspNetCore.Views_Tree_GenresTree))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64da1f8542d936ea39c8da1dde6a4f395afea12d", @"/Views/Tree/GenresTree.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dae428e346fce6099e87ac68db095795ded0a31", @"/Views/_ViewImports.cshtml")]
    public class Views_Tree_GenresTree : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/tree_view_style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/balkangraph/orgchart.js/orgchart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("tree_background"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\Дипломная работа\MusicShopProject\MusicShop\Views\Tree\GenresTree.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 8, true);
            WriteLiteral("<html>\r\n");
            EndContext();
            BeginContext(35, 314, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64da1f8542d936ea39c8da1dde6a4f395afea12d5436", async() => {
                BeginContext(41, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(47, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "64da1f8542d936ea39c8da1dde6a4f395afea12d5819", async() => {
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
                BeginContext(121, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(127, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64da1f8542d936ea39c8da1dde6a4f395afea12d7238", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(192, 150, true);
                WriteLiteral("\r\n    <script src=\"https://balkangraph.com/js/latest/orgchart.js\"></script>\r\n    <script src=\"https://code.jquery.com/jquery-3.3.1.min.js\"></script>\r\n");
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
            BeginContext(349, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(351, 4979, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64da1f8542d936ea39c8da1dde6a4f395afea12d9446", async() => {
                BeginContext(381, 4942, true);
                WriteLiteral(@"
    <div class=""tree_header"">
        <br />
        <h1 class=""tree_header_text"">
            Genres
        </h1>
    </div>
    <div id=""tree""  class=""tree_block""/>
    <script>
        window.onload = function () {

            var chart = new OrgChart(document.getElementById(""tree""),
                {
                nodeBinding: {
                    field_0: ""Name"",
                    img_0:""Photo1""
                    },
                    collapse: {
                        level: 1,
                        allChildren: true
                    },
                    expand: {
                        level: 1,
                        allChildren: true
                    },
                mouseScrool: OrgChart.action.scroll,
                showYScroll: OrgChart.scroll.visible,
                showXScroll: OrgChart.scroll.visible,
                template: ""diva"",
                align: OrgChart.ORIENTATION
                });

        
            chart.load([
 ");
                WriteLiteral(@"               { id: 0, Name: ""Music Industry"", Photo1: ""/img/Genres/0.jpg"" },


                { id: 01, pid: 0, Name: ""Rock"", Photo1: ""/img/Genres/Rock/01.jpg"" },
                { id: 011, pid: 01, Name: ""Metal"", Photo1: ""/img/Genres/Rock/011.jpg"" },
                { id: 0111, pid: 011, Name: ""Heavy Metal"", Photo1: ""/img/Genres/Rock/0111.jpg"" },
                { id: 0112, pid: 011, Name: ""Thrash Metal"", Photo1: ""/img/Genres/Rock/0112.jpg"" },
                { id: 0113, pid: 011, Name: ""Death Metal"", Photo1: ""/img/Genres/Rock/0113.jpg"" },
                { id: 01131, pid: 0113, Name: ""Brutal Death Metal"", Photo1: ""/img/Genres/Rock/01131.jpg"" },
                { id: 01132, pid: 0113, Name: ""Technical Death Metal"", Photo1: ""/img/Genres/Rock/01132.jpg"" },
                { id: 01133, pid: 0113, Name: ""Melodic Death Metal"", Photo1: ""/img/Genres/Rock/01133.jpg"" },
                { id: 012, pid: 01, Name: ""Hard Rock"", Photo1: ""/img/Genres/Rock/012.jpg"" },
                { id: 0121, pid: 012, Nam");
                WriteLiteral(@"e: ""Power Pop"", Photo1: ""/img/Genres/Rock/0121.jpg"" },
                { id: 0122, pid: 012, Name: ""Grunge"", Photo1: ""/img/Genres/Rock/0122.jpg"" },
                { id: 013, pid: 01, Name: ""Punk Rock"", Photo1: ""/img/Genres/Rock/013.jpg"" },
                { id: 0131, pid: 013, Name: ""Anarcho Punk"", Photo1: ""/img/Genres/Rock/0131.jpg"" },
                { id: 0132, pid: 013, Name: ""Crust Punk"", Photo1: ""/img/Genres/Rock/0132.jpg"" },
                { id: 0133, pid: 013, Name: ""Skate Punk"", Photo1: ""/img/Genres/Rock/0133.jpg"" },


                { id: 02, pid: 0, Name: ""Hip Hop"", Photo1: ""/img/Genres/Hip-Hop/02.jpg"" },
                { id: 021, pid: 02, Name: ""Gangster Rap"", Photo1: ""/img/Genres/Hip-Hop/021.jpg"" },
                { id: 0211, pid: 021, Name: ""Mafia Rap"", Photo1: ""/img/Genres/Hip-Hop/0211.jpg"" },
                { id: 022, pid: 02, Name: ""Hardcore Rap"", Photo1: ""/img/Genres/Hip-Hop/022.jpg"" },
                { id: 0221, pid: 022, Name: ""Horrorcore"", Photo1: ""/img/Genres/Hip-Hop/0");
                WriteLiteral(@"221.jpg"" },
                { id: 023, pid: 02, Name: ""Trap Rap"", Photo1: ""/img/Genres/Hip-Hop/023.jpg"" },
                { id: 0231, pid: 023, Name: ""Mumble Rap"", Photo1: ""/img/Genres/Hip-Hop/0231.jpg"" },
                { id: 0232, pid: 023, Name: ""Drill"", Photo1: ""/img/Genres/Hip-Hop/0232.jpg"" },


                { id: 03, pid: 0, Name: ""Jazz"", Photo1: ""/img/Genres/Jazz/03.jpg"" },
                { id: 031, pid: 03, Name: ""Traditional Jazz"", Photo1: ""/img/Genres/Jazz/031.jpg"" },
                { id: 032, pid: 03, Name: ""Swing"", Photo1: ""/img/Genres/Jazz/032.jpg"" },
                { id: 0321, pid: 032, Name: ""Electro Swing"", Photo1: ""/img/Genres/Jazz/0321.jpg"" },
                { id: 0322, pid: 032, Name: ""New Jack Swing"", Photo1: ""/img/Genres/Jazz/0322.jpg"" },
                { id: 03221, pid: 0322, Name: ""Hip Hop Soul"", Photo1: ""/img/Genres/Jazz/03221.jpg"" },
                { id: 033, pid: 03, Name: ""Bebop"", Photo1: ""/img/Genres/Jazz/0333.jpg"" },
                { id: 034, pid: 03, Name");
                WriteLiteral(@": ""Soul Jazz"", Photo1: ""/img/Genres/Jazz/034.jpg"" },
                { id: 0341, pid: 034, Name: ""Funk"", Photo1: ""/img/Genres/Jazz/0341.jpg"" },
                { id: 0342, pid: 034, Name: ""Disco"", Photo1: ""/img/Genres/Jazz/0342.jpg"" },


                { id: 04, pid: 0, Name: ""Blues"", Photo1: ""/img/Genres/Blues/04.jpg"" },
                { id: 041, pid: 04, Name: ""Delta Blues"", Photo1: ""/img/Genres/Blues/041.jpg"" },
                { id: 0411, pid: 041, Name: ""Electric Blues"", Photo1: ""/img/Genres/Blues/0411.jpg"" },
                { id: 042, pid: 04, Name: ""Chicago Blues"", Photo1: ""/img/Genres/Blues/042.jpg"" },
                { id: 043, pid: 04, Name: ""Swamp Blues"", Photo1: ""/img/Genres/Blues/043.jpg"" },




     
              

                

            ]);
        };



    </script>


   

   
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5330, 378, true);
            WriteLiteral(@"
</html>

<script>
    var toggler = document.getElementsByClassName(""caret"");
    var i;

    for (i = 0; i < toggler.length; i++) {
        toggler[i].addEventListener(""click"", function () {
            this.parentElement.querySelector("".nested"").classList.toggle(""active"");
            this.classList.toggle(""caret-down"");
        });
    }
</script>





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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
