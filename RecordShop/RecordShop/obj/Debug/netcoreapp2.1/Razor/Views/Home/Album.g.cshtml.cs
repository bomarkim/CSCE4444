#pragma checksum "D:\jmwen\repos\CSCE4444\RecordShop\RecordShop\Views\Home\Album.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29643208acf2ab6bb8db2b169096756b6761572b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Album), @"mvc.1.0.view", @"/Views/Home/Album.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Album.cshtml", typeof(AspNetCore.Views_Home_Album))]
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
#line 1 "D:\jmwen\repos\CSCE4444\RecordShop\RecordShop\Views\_ViewImports.cshtml"
using RecordShop;

#line default
#line hidden
#line 2 "D:\jmwen\repos\CSCE4444\RecordShop\RecordShop\Views\_ViewImports.cshtml"
using RecordShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29643208acf2ab6bb8db2b169096756b6761572b", @"/Views/Home/Album.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c844b471d2511417ec217df785062bd378af6d32", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Album : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\jmwen\repos\CSCE4444\RecordShop\RecordShop\Views\Home\Album.cshtml"
  
    ViewData["Title"] = "Records Shop - ALBUM NAME";

#line default
#line hidden
            BeginContext(61, 48, true);
            WriteLiteral("\r\n<div ng-app=\"record\" ng-controller=\"AlbumCtrl\"");
            EndContext();
            BeginWriteAttribute("ng-init", " ng-init=\"", 109, "\"", 136, 3);
            WriteAttributeValue("", 119, "init(", 119, 5, true);
#line 5 "D:\jmwen\repos\CSCE4444\RecordShop\RecordShop\Views\Home\Album.cshtml"
WriteAttributeValue("", 124, ViewBag.ID, 124, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 135, ")", 135, 1, true);
            EndWriteAttribute();
            BeginContext(137, 1140, true);
            WriteLiteral(@" class=""ng-cloak"">
    <div class=""container"">
        <div class=""row"">
            <h1>
                {{album.name}}
            </h1>
        </div>
        <div class=""row"">
            <div class=""col-md-8"">
                <div class=""row"">
                    <img src=""{{album.imageUrl}}"" height=""200"" width=""200"" />
                </div>
                <div class=""row"">
                    <p>
                        {{album.description}}
                    </p>
                </div>

            </div>
            <div class=""col-md-4"">
                <h1>{{album.name}}</h1>
                <h2>Price: {{album.price}}</h2>
                <p>{{album.distributer}}</p>
                <button class=""btn red darken-3 btn-lg flex-fill"" type=""button"">Add to cart</button>
            </div>


        </div>
    </div>
    <nav aria-label=""breadcrumb"">
        <ol class=""breadcrumb red darken-3"">
            <li class=""breadcrumb-item""><a href=""/Home"">Home</a></li>
     ");
            WriteLiteral("       <li class=\"breadcrumb-item active\" aria-current=\"page\">{{album.name}}</li>\r\n        </ol>\r\n    </nav>\r\n</div>");
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
