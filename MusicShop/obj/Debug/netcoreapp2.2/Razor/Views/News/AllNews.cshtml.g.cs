#pragma checksum "E:\Дипломная работа\MusicShopProject\MusicShop\Views\News\AllNews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a67d69369cb64f0f4c4cd1c922a61cac65208058"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_AllNews), @"mvc.1.0.view", @"/Views/News/AllNews.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/News/AllNews.cshtml", typeof(AspNetCore.Views_News_AllNews))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a67d69369cb64f0f4c4cd1c922a61cac65208058", @"/Views/News/AllNews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dae428e346fce6099e87ac68db095795ded0a31", @"/Views/_ViewImports.cshtml")]
    public class Views_News_AllNews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\Дипломная работа\MusicShopProject\MusicShop\Views\News\AllNews.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(119, 8, true);
            WriteLiteral("\r\n<ul>\r\n");
            EndContext();
#line 11 "E:\Дипломная работа\MusicShopProject\MusicShop\Views\News\AllNews.cshtml"
     
       foreach (var newsInfo in Model.allnews)
       {

#line default
#line hidden
            BeginContext(192, 75, true);
            WriteLiteral("                <li>\r\n                   <div>\r\n                       <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 267, "\"", 286, 1);
#line 16 "E:\Дипломная работа\MusicShopProject\MusicShop\Views\News\AllNews.cshtml"
WriteAttributeValue("", 273, newsInfo.img, 273, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(287, 31, true);
            WriteLiteral("/>\r\n                       <h3>");
            EndContext();
            BeginContext(319, 13, false);
#line 17 "E:\Дипломная работа\MusicShopProject\MusicShop\Views\News\AllNews.cshtml"
                      Write(newsInfo.news);

#line default
#line hidden
            EndContext();
            BeginContext(332, 57, true);
            WriteLiteral("</h3>\r\n                   </div>\r\n                </li>\r\n");
            EndContext();
#line 20 "E:\Дипломная работа\MusicShopProject\MusicShop\Views\News\AllNews.cshtml"
       }
    

#line default
#line hidden
            BeginContext(406, 9, true);
            WriteLiteral("</ul>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591