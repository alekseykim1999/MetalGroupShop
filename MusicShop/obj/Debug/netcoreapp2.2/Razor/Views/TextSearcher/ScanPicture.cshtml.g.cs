#pragma checksum "E:\Дипломная работа\MusicShopProject\MusicShop\Views\TextSearcher\ScanPicture.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3d57475a1cec4629b3ca99ce2211b921aca6915"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TextSearcher_ScanPicture), @"mvc.1.0.view", @"/Views/TextSearcher/ScanPicture.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TextSearcher/ScanPicture.cshtml", typeof(AspNetCore.Views_TextSearcher_ScanPicture))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3d57475a1cec4629b3ca99ce2211b921aca6915", @"/Views/TextSearcher/ScanPicture.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dae428e346fce6099e87ac68db095795ded0a31", @"/Views/_ViewImports.cshtml")]
    public class Views_TextSearcher_ScanPicture : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\Дипломная работа\MusicShopProject\MusicShop\Views\TextSearcher\ScanPicture.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(89, 36, true);
            WriteLiteral("\r\n\r\n<h1>Отсканированный текст</h1>\r\n");
            EndContext();
#line 11 "E:\Дипломная работа\MusicShopProject\MusicShop\Views\TextSearcher\ScanPicture.cshtml"
  
    var text = Model.ScannedText;

#line default
#line hidden
            BeginContext(167, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(172, 4, false);
#line 14 "E:\Дипломная работа\MusicShopProject\MusicShop\Views\TextSearcher\ScanPicture.cshtml"
Write(text);

#line default
#line hidden
            EndContext();
            BeginContext(176, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
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
