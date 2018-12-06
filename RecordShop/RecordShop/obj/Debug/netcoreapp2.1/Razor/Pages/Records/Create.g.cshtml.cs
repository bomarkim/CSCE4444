#pragma checksum "C:\Users\PC\Desktop\CSCE4444\RecordShop\RecordShop\Pages\Records\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fd14ef567776a438fdadb91308b709b56d4eac0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Records_Create), @"mvc.1.0.razor-page", @"/Pages/Records/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Records/Create.cshtml", typeof(AspNetCore.Pages_Records_Create), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd14ef567776a438fdadb91308b709b56d4eac0", @"/Pages/Records/Create.cshtml")]
    public class Pages_Records_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\PC\Desktop\CSCE4444\RecordShop\RecordShop\Pages\Records\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(137, 2941, true);
            WriteLiteral(@"
<h2>Create</h2>

<h4>Record</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Record.Genre"" class=""control-label"">Genre</label>
                <input asp-for=""Record.Genre"" class=""form-control"" />
                <span asp-validation-for=""Record.Genre"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Record.Name"" class=""control-label"">Title</label>
                <input asp-for=""Record.Name"" class=""form-control"" />
                <span asp-validation-for=""Record.Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Record.Artist"" class=""control-label"">Artist</label>
                <input asp-for=""Record.Artist"" class=""form-control"" />
                <span asp-validatio");
            WriteLiteral(@"n-for=""Record.Artist"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Record.Description"" class=""control-label"">Description</label>
                <input asp-for=""Record.Description"" class=""form-control"" />
                <span asp-validation-for=""Record.Description"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Record.Price"" class=""control-label"">Price</label>
                <input asp-for=""Record.Price"" class=""form-control"" />
                <span asp-validation-for=""Record.Price"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Record.ImageUrl"" class=""control-label"">Image Url</label>
                <input asp-for=""Record.ImageUrl"" class=""form-control"" />
                <span asp-validation-for=""Record.ImageUrl"" class=""text-danger""></span>
            </div>
            <div class=""f");
            WriteLiteral(@"orm-group"">
                <label asp-for=""Record.ImageThumbnailUrl"" class=""control-label"">Thumbnail Url</label>
                <input asp-for=""Record.ImageThumbnailUrl"" class=""form-control"" />
                <span asp-validation-for=""Record.ImageThumbnailUrl"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Record.isPreferredGenre"" class=""control-label"">Preferred Genre?</label>
                <input asp-for=""Record.isPreferredGenre"" class=""form-control"" />
                <span asp-validation-for=""Record.isPreferredGenre"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-default"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-page=""Index"">Back to List</a>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3096, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 69 "C:\Users\PC\Desktop\CSCE4444\RecordShop\RecordShop\Pages\Records\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecordShop.Records.CreateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecordShop.Records.CreateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecordShop.Records.CreateModel>)PageContext?.ViewData;
        public RecordShop.Records.CreateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
