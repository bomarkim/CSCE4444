#pragma checksum "C:\Users\PC\Desktop\CSCE4444\RecordShop\RecordShop\Pages\Records\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b40fccdbaca3a7bd4183d13a286e52ba3ce581d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Records_Index), @"mvc.1.0.razor-page", @"/Pages/Records/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Records/Index.cshtml", typeof(AspNetCore.Pages_Records_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b40fccdbaca3a7bd4183d13a286e52ba3ce581d8", @"/Pages/Records/Index.cshtml")]
    public class Pages_Records_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(7, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\PC\Desktop\CSCE4444\RecordShop\RecordShop\Pages\Records\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(135, 105, true);
            WriteLiteral("<h2>Index</h2>\r\n    <p>\r\n        <a asp-page=\"Create\">Create New</a>\r\n    </p>\r\n    <form>\r\n        <p>\r\n");
            EndContext();
            BeginContext(391, 423, true);
            WriteLiteral(@"            <div>
                Title: <input type=""text"" name=""SearchString"" style=""color: black;"" />
                <input type=""submit"" value=""Filter"" style=""background-color: #d1d1d1; color: black;"" />
            </div>
        </p>
    </form>
    <table class=""table"">
        <thead>
            <tr>
                
                    <th>
                        <h4>
                            ");
            EndContext();
            BeginContext(815, 50, false);
#line 29 "C:\Users\PC\Desktop\CSCE4444\RecordShop\RecordShop\Pages\Records\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Record[0].Name));

#line default
#line hidden
            EndContext();
            BeginContext(865, 123, true);
            WriteLiteral("\r\n                                            </h4>\r\n                </th>\r\n                <th>\r\n                    <h4> ");
            EndContext();
            BeginContext(989, 51, false);
#line 33 "C:\Users\PC\Desktop\CSCE4444\RecordShop\RecordShop\Pages\Records\Index.cshtml"
                    Write(Html.DisplayNameFor(model => model.Record[0].Genre));

#line default
#line hidden
            EndContext();
            BeginContext(1040, 77, true);
            WriteLiteral("</h4>\r\n                </th>\r\n                <th>\r\n                    <h4> ");
            EndContext();
            BeginContext(1118, 52, false);
#line 36 "C:\Users\PC\Desktop\CSCE4444\RecordShop\RecordShop\Pages\Records\Index.cshtml"
                    Write(Html.DisplayNameFor(model => model.Record[0].Artist));

#line default
#line hidden
            EndContext();
            BeginContext(1170, 77, true);
            WriteLiteral("</h4>\r\n                </th>\r\n                <th>\r\n                    <h4> ");
            EndContext();
            BeginContext(1248, 57, false);
#line 39 "C:\Users\PC\Desktop\CSCE4444\RecordShop\RecordShop\Pages\Records\Index.cshtml"
                    Write(Html.DisplayNameFor(model => model.Record[0].Description));

#line default
#line hidden
            EndContext();
            BeginContext(1305, 77, true);
            WriteLiteral("</h4>\r\n                </th>\r\n                <th>\r\n                    <h4> ");
            EndContext();
            BeginContext(1383, 51, false);
#line 42 "C:\Users\PC\Desktop\CSCE4444\RecordShop\RecordShop\Pages\Records\Index.cshtml"
                    Write(Html.DisplayNameFor(model => model.Record[0].Price));

#line default
#line hidden
            EndContext();
            BeginContext(1434, 30, true);
            WriteLiteral("</h4>\r\n                </th>\r\n");
            EndContext();
            BeginContext(1741, 47, true);
            WriteLiteral("                <th>\r\n                    <h4> ");
            EndContext();
            BeginContext(1789, 62, false);
#line 51 "C:\Users\PC\Desktop\CSCE4444\RecordShop\RecordShop\Pages\Records\Index.cshtml"
                    Write(Html.DisplayNameFor(model => model.Record[0].isPreferredGenre));

#line default
#line hidden
            EndContext();
            BeginContext(1851, 111, true);
            WriteLiteral("</h4>\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 57 "C:\Users\PC\Desktop\CSCE4444\RecordShop\RecordShop\Pages\Records\Index.cshtml"
             foreach (var item in Model.Record)
            {

#line default
#line hidden
            BeginContext(2026, 64, true);
            WriteLiteral("            <tr>\r\n\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2090, "\"", 2131, 2);
            WriteAttributeValue("", 2097, "Home/Album?RecordId=", 2097, 20, true);
#line 62 "C:\Users\PC\Desktop\CSCE4444\RecordShop\RecordShop\Pages\Records\Index.cshtml"
WriteAttributeValue("", 2117, item.RecordId, 2117, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2132, 5, true);
            WriteLiteral("><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2137, "\"", 2157, 1);
#line 62 "C:\Users\PC\Desktop\CSCE4444\RecordShop\RecordShop\Pages\Records\Index.cshtml"
WriteAttributeValue("", 2143, item.ImageUrl, 2143, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2158, 59, true);
            WriteLiteral(" width=\"150\" hieght=\"150\" /></a>\r\n                    <h5> ");
            EndContext();
            BeginContext(2218, 39, false);
#line 63 "C:\Users\PC\Desktop\CSCE4444\RecordShop\RecordShop\Pages\Records\Index.cshtml"
                    Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2257, 76, true);
            WriteLiteral("</h5>\r\n                </td>\r\n                <td>\r\n                    <h5>");
            EndContext();
            BeginContext(2334, 40, false);
#line 66 "C:\Users\PC\Desktop\CSCE4444\RecordShop\RecordShop\Pages\Records\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(2374, 76, true);
            WriteLiteral("</h5>\r\n                </td>\r\n                <td>\r\n                    <h5>");
            EndContext();
            BeginContext(2451, 41, false);
#line 69 "C:\Users\PC\Desktop\CSCE4444\RecordShop\RecordShop\Pages\Records\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Artist));

#line default
#line hidden
            EndContext();
            BeginContext(2492, 77, true);
            WriteLiteral("</h5>\r\n                </td>\r\n                <td>\r\n                    <h5> ");
            EndContext();
            BeginContext(2570, 46, false);
#line 72 "C:\Users\PC\Desktop\CSCE4444\RecordShop\RecordShop\Pages\Records\Index.cshtml"
                    Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2616, 77, true);
            WriteLiteral("</h5>\r\n                </td>\r\n                <td>\r\n                    <h5> ");
            EndContext();
            BeginContext(2694, 40, false);
#line 75 "C:\Users\PC\Desktop\CSCE4444\RecordShop\RecordShop\Pages\Records\Index.cshtml"
                    Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2734, 30, true);
            WriteLiteral("</h5>\r\n                </td>\r\n");
            EndContext();
            BeginContext(2977, 47, true);
            WriteLiteral("                <td>\r\n                    <h5> ");
            EndContext();
            BeginContext(3025, 51, false);
#line 84 "C:\Users\PC\Desktop\CSCE4444\RecordShop\RecordShop\Pages\Records\Index.cshtml"
                    Write(Html.DisplayFor(modelItem => item.isPreferredGenre));

#line default
#line hidden
            EndContext();
            BeginContext(3076, 122, true);
            WriteLiteral("</h5>\r\n                </td>\r\n                <td>\r\n                    <h4>\r\n                        <a asp-page=\"./Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 3198, "\"", 3227, 1);
#line 88 "C:\Users\PC\Desktop\CSCE4444\RecordShop\RecordShop\Pages\Records\Index.cshtml"
WriteAttributeValue("", 3213, item.RecordId, 3213, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3228, 60, true);
            WriteLiteral(">Edit</a> |\r\n                        <a asp-page=\"./Details\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 3288, "\"", 3317, 1);
#line 89 "C:\Users\PC\Desktop\CSCE4444\RecordShop\RecordShop\Pages\Records\Index.cshtml"
WriteAttributeValue("", 3303, item.RecordId, 3303, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3318, 62, true);
            WriteLiteral(">Details</a> |\r\n                        <a asp-page=\"./Delete\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 3380, "\"", 3409, 1);
#line 90 "C:\Users\PC\Desktop\CSCE4444\RecordShop\RecordShop\Pages\Records\Index.cshtml"
WriteAttributeValue("", 3395, item.RecordId, 3395, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3410, 82, true);
            WriteLiteral(">Delete</a>\r\n                    </h4>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 94 "C:\Users\PC\Desktop\CSCE4444\RecordShop\RecordShop\Pages\Records\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(3507, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecordShop.Records.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecordShop.Records.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecordShop.Records.IndexModel>)PageContext?.ViewData;
        public RecordShop.Records.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
