#pragma checksum "D:\jmwen\repos\CSCE4444\RecordShop\RecordShop\Views\Home\RecordList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "534699f5284d8e5b7484c1b96db958ab671552e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RecordList), @"mvc.1.0.view", @"/Views/Home/RecordList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/RecordList.cshtml", typeof(AspNetCore.Views_Home_RecordList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"534699f5284d8e5b7484c1b96db958ab671552e1", @"/Views/Home/RecordList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c844b471d2511417ec217df785062bd378af6d32", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RecordList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\jmwen\repos\CSCE4444\RecordShop\RecordShop\Views\Home\RecordList.cshtml"
  
    ViewData["Title"] = "RecordList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(95, 497, true);
            WriteLiteral(@"<div ng-app=""record"" ng-controller=""SiteCtrl"">
    <h2>RecordList</h2>
    <ul>
        <li ng-repeat=""r in listOfAlbums"">
            <h4>{{r.name}}</h4>
            <a href=""album"">{{r.img}}</a>
        </li>
    </ul>

    <nav aria-label=""breadcrumb"">
        <ol class=""breadcrumb red darken-3"">
            <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
            <li class=""breadcrumb-item active"" aria-current=""page"">Record List</li>
        </ol>
    </nav>
</div>");
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