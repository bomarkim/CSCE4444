#pragma checksum "D:\jmwen\repos\CSCE4444\RecordShop\RecordShop\Pages\Records\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0593145dc604e24f4d2f26bdf5bbcc707262592e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Records_Details), @"mvc.1.0.razor-page", @"/Pages/Records/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Records/Details.cshtml", typeof(AspNetCore.Pages_Records_Details), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0593145dc604e24f4d2f26bdf5bbcc707262592e", @"/Pages/Records/Details.cshtml")]
    public class Pages_Records_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "D:\jmwen\repos\CSCE4444\RecordShop\RecordShop\Pages\Records\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(132, 112, true);
            WriteLiteral("\n<h2>Details</h2>\n\n<div>\n    <h4>Record</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(245, 48, false);
#line 16 "D:\jmwen\repos\CSCE4444\RecordShop\RecordShop\Pages\Records\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Record.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(293, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(334, 44, false);
#line 19 "D:\jmwen\repos\CSCE4444\RecordShop\RecordShop\Pages\Records\Details.cshtml"
       Write(Html.DisplayFor(model => model.Record.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(378, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(419, 47, false);
#line 22 "D:\jmwen\repos\CSCE4444\RecordShop\RecordShop\Pages\Records\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Record.Name));

#line default
#line hidden
            EndContext();
            BeginContext(466, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(507, 43, false);
#line 25 "D:\jmwen\repos\CSCE4444\RecordShop\RecordShop\Pages\Records\Details.cshtml"
       Write(Html.DisplayFor(model => model.Record.Name));

#line default
#line hidden
            EndContext();
            BeginContext(550, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(591, 49, false);
#line 28 "D:\jmwen\repos\CSCE4444\RecordShop\RecordShop\Pages\Records\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Record.Artist));

#line default
#line hidden
            EndContext();
            BeginContext(640, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(681, 45, false);
#line 31 "D:\jmwen\repos\CSCE4444\RecordShop\RecordShop\Pages\Records\Details.cshtml"
       Write(Html.DisplayFor(model => model.Record.Artist));

#line default
#line hidden
            EndContext();
            BeginContext(726, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(767, 54, false);
#line 34 "D:\jmwen\repos\CSCE4444\RecordShop\RecordShop\Pages\Records\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Record.Description));

#line default
#line hidden
            EndContext();
            BeginContext(821, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(862, 50, false);
#line 37 "D:\jmwen\repos\CSCE4444\RecordShop\RecordShop\Pages\Records\Details.cshtml"
       Write(Html.DisplayFor(model => model.Record.Description));

#line default
#line hidden
            EndContext();
            BeginContext(912, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(953, 48, false);
#line 40 "D:\jmwen\repos\CSCE4444\RecordShop\RecordShop\Pages\Records\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Record.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1001, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1042, 44, false);
#line 43 "D:\jmwen\repos\CSCE4444\RecordShop\RecordShop\Pages\Records\Details.cshtml"
       Write(Html.DisplayFor(model => model.Record.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1086, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1127, 51, false);
#line 46 "D:\jmwen\repos\CSCE4444\RecordShop\RecordShop\Pages\Records\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Record.ImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1178, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1219, 47, false);
#line 49 "D:\jmwen\repos\CSCE4444\RecordShop\RecordShop\Pages\Records\Details.cshtml"
       Write(Html.DisplayFor(model => model.Record.ImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1266, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1307, 60, false);
#line 52 "D:\jmwen\repos\CSCE4444\RecordShop\RecordShop\Pages\Records\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Record.ImageThumbnailUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1367, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1408, 56, false);
#line 55 "D:\jmwen\repos\CSCE4444\RecordShop\RecordShop\Pages\Records\Details.cshtml"
       Write(Html.DisplayFor(model => model.Record.ImageThumbnailUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1464, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1505, 59, false);
#line 58 "D:\jmwen\repos\CSCE4444\RecordShop\RecordShop\Pages\Records\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Record.isPreferredGenre));

#line default
#line hidden
            EndContext();
            BeginContext(1564, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1605, 55, false);
#line 61 "D:\jmwen\repos\CSCE4444\RecordShop\RecordShop\Pages\Records\Details.cshtml"
       Write(Html.DisplayFor(model => model.Record.isPreferredGenre));

#line default
#line hidden
            EndContext();
            BeginContext(1660, 62, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    <a asp-page=\"./Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1722, "\"", 1759, 1);
#line 66 "D:\jmwen\repos\CSCE4444\RecordShop\RecordShop\Pages\Records\Details.cshtml"
WriteAttributeValue("", 1737, Model.Record.RecordId, 1737, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1760, 62, true);
            WriteLiteral(">Edit</a> |\n    <a asp-page=\"./Index\">Back to List</a>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecordShop.Records.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecordShop.Records.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecordShop.Records.DetailsModel>)PageContext?.ViewData;
        public RecordShop.Records.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
