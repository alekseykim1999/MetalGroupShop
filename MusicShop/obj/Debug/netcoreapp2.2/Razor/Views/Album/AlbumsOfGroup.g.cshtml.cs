#pragma checksum "D:\Институт\MusicShopProject\MusicShop\Views\Album\AlbumsOfGroup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc39324ba00853894c823ac270e2835b1b381d18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Album_AlbumsOfGroup), @"mvc.1.0.view", @"/Views/Album/AlbumsOfGroup.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Album/AlbumsOfGroup.cshtml", typeof(AspNetCore.Views_Album_AlbumsOfGroup))]
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
#line 1 "D:\Институт\MusicShopProject\MusicShop\Views\_ViewImports.cshtml"
using MusicShop.ViewModel;

#line default
#line hidden
#line 2 "D:\Институт\MusicShopProject\MusicShop\Views\_ViewImports.cshtml"
using MusicShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc39324ba00853894c823ac270e2835b1b381d18", @"/Views/Album/AlbumsOfGroup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dae428e346fce6099e87ac68db095795ded0a31", @"/Views/_ViewImports.cshtml")]
    public class Views_Album_AlbumsOfGroup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(124, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(131, 17, false);
#line 8 "D:\Институт\MusicShopProject\MusicShop\Views\Album\AlbumsOfGroup.cshtml"
Write(ViewBag.GroupName);

#line default
#line hidden
            EndContext();
            BeginContext(148, 38, true);
            WriteLiteral("</h1>\r\n\r\n<div class=\"row mt-5 mb-2\">\r\n");
            EndContext();
#line 11 "D:\Институт\MusicShopProject\MusicShop\Views\Album\AlbumsOfGroup.cshtml"
      
        foreach (Album album in Model.AllAlbums)
        {
            

#line default
#line hidden
            BeginContext(268, 29, false);
#line 14 "D:\Институт\MusicShopProject\MusicShop\Views\Album\AlbumsOfGroup.cshtml"
       Write(Html.Partial("Albums", album));

#line default
#line hidden
            EndContext();
#line 14 "D:\Институт\MusicShopProject\MusicShop\Views\Album\AlbumsOfGroup.cshtml"
                                          
        }
    

#line default
#line hidden
            BeginContext(317, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
