#pragma checksum "E:\Дипломная работа\MusicShopProject\MusicShop\Views\Album\Main.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "772e5e5cc52bf33e53ca640864e2e76e63061520"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Album_Main), @"mvc.1.0.view", @"/Views/Album/Main.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Album/Main.cshtml", typeof(AspNetCore.Views_Album_Main))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"772e5e5cc52bf33e53ca640864e2e76e63061520", @"/Views/Album/Main.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dae428e346fce6099e87ac68db095795ded0a31", @"/Views/_ViewImports.cshtml")]
    public class Views_Album_Main : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 503, true);
            WriteLiteral(@"<h1>Good Day, User!</h1>
<h5>
    We gald to meet you on our muic portal. On this site you can search your favourite singer, group or album
</h5>
<div style=""text-align:left; margin-left:30px; margin-top:30px;"">
    Here is top artists for current day
</div>

<div id=""result"" style=""text-align:left; margin-left:30px; margin-top:10px;"">
</div>
<div id=""diagramm"" style=""
        width: 700px;
        height: 600px;
        margin-left: 500px;
        margin-top:-340px;
"">
</div>


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
