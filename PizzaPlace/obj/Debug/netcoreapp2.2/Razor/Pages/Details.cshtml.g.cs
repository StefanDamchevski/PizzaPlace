#pragma checksum "D:\Academy\RazorPages\PizzaPlace\PizzaPlace\Pages\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a800472ef26a8f74c5eb63e37da4ab2627d0b073"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PizzaPlace.Pages.Pages_Details), @"mvc.1.0.razor-page", @"/Pages/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Details.cshtml", typeof(PizzaPlace.Pages.Pages_Details), @"{id}")]
namespace PizzaPlace.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Academy\RazorPages\PizzaPlace\PizzaPlace\Pages\_ViewImports.cshtml"
using PizzaPlace;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a800472ef26a8f74c5eb63e37da4ab2627d0b073", @"/Pages/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3171378dcb21dbf66f31162f00a18766721bd9c9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Academy\RazorPages\PizzaPlace\PizzaPlace\Pages\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(95, 55, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div class=\"container\">\r\n    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 150, "\"", 185, 1);
#line 10 "D:\Academy\RazorPages\PizzaPlace\PizzaPlace\Pages\Details.cshtml"
WriteAttributeValue("", 156, Model.MenuViewModel.ImageUrl, 156, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(186, 39, true);
            WriteLiteral(" />\r\n    <h1 style=\"text-align:center\">");
            EndContext();
            BeginContext(226, 25, false);
#line 11 "D:\Academy\RazorPages\PizzaPlace\PizzaPlace\Pages\Details.cshtml"
                             Write(Model.MenuViewModel.Title);

#line default
#line hidden
            EndContext();
            BeginContext(251, 42, true);
            WriteLiteral("</h1>\r\n\r\n    <p style=\"text-align:center\">");
            EndContext();
            BeginContext(294, 31, false);
#line 13 "D:\Academy\RazorPages\PizzaPlace\PizzaPlace\Pages\Details.cshtml"
                            Write(Model.MenuViewModel.Description);

#line default
#line hidden
            EndContext();
            BeginContext(325, 23, true);
            WriteLiteral("</p>\r\n\r\n    <h2>Price: ");
            EndContext();
            BeginContext(349, 25, false);
#line 15 "D:\Academy\RazorPages\PizzaPlace\PizzaPlace\Pages\Details.cshtml"
          Write(Model.MenuViewModel.Price);

#line default
#line hidden
            EndContext();
            BeginContext(374, 13, true);
            WriteLiteral("</h2>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaPlace.Pages.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PizzaPlace.Pages.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PizzaPlace.Pages.DetailsModel>)PageContext?.ViewData;
        public PizzaPlace.Pages.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
