#pragma checksum "C:\Users\muham\OneDrive\Masaüstü\Proje Ve Doyalar\projeler\.CORE\Traversal_holiday\Traversal_holiday\Views\Shared\Components\_testimonial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c5b2fd100d5c932980f72e7f43fca97064dcbbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__testimonial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_testimonial/Default.cshtml")]
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
#nullable restore
#line 1 "C:\Users\muham\OneDrive\Masaüstü\Proje Ve Doyalar\projeler\.CORE\Traversal_holiday\Traversal_holiday\Views\_ViewImports.cshtml"
using Traversal_holiday;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\muham\OneDrive\Masaüstü\Proje Ve Doyalar\projeler\.CORE\Traversal_holiday\Traversal_holiday\Views\_ViewImports.cshtml"
using Traversal_holiday.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c5b2fd100d5c932980f72e7f43fca97064dcbbc", @"/Views/Shared/Components/_testimonial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d01115374c26545911a86b48b194d0289ff9a3e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__testimonial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EntityLayer.Concrete.TestiMonial>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<section class=""w3l-clients"" id=""clients"">
    <!-- /grids -->
    <div class=""cusrtomer-layout py-5"">
        <div class=""container py-lg-4 py-md-3 pb-lg-0"">
            <div class=""heading text-center mx-auto"">
                <h6 class=""sub-title text-center"">
                    İşte müşterilerimizin söyledikleri
                </h6>
                <h3 class=""hny-title mb-md-5 mb-4"">Görüşünüz bizim için değerli</h3>
            </div>
            <!-- /grids -->
            <div class=""testimonial-width"">
                <div id=""owl-demo1"" class=""owl-two owl-carousel owl-theme"">
");
#nullable restore
#line 17 "C:\Users\muham\OneDrive\Masaüstü\Proje Ve Doyalar\projeler\.CORE\Traversal_holiday\Traversal_holiday\Views\Shared\Components\_testimonial\Default.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""item"">
                            <div class=""testimonial-content"">
                                <div class=""testimonial"">
                                    <blockquote>
                                        <span class=""fa fa-quote-left"" aria-hidden=""true""></span>
                                       ");
#nullable restore
#line 24 "C:\Users\muham\OneDrive\Masaüstü\Proje Ve Doyalar\projeler\.CORE\Traversal_holiday\Traversal_holiday\Views\Shared\Components\_testimonial\Default.cshtml"
                                  Write(item.testiMonialComment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </blockquote>\r\n                                    <div class=\"testi-des\">\r\n                                        <div class=\"test-img\">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 1334, "\"", 1368, 1);
#nullable restore
#line 28 "C:\Users\muham\OneDrive\Masaüstü\Proje Ve Doyalar\projeler\.CORE\Traversal_holiday\Traversal_holiday\Views\Shared\Components\_testimonial\Default.cshtml"
WriteAttributeValue("", 1340, item.testiMonialClientImage, 1340, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" alt=\"client-img\">\r\n                                        </div>\r\n                                        <div class=\"peopl align-self\">\r\n                                            <h3> ");
#nullable restore
#line 31 "C:\Users\muham\OneDrive\Masaüstü\Proje Ve Doyalar\projeler\.CORE\Traversal_holiday\Traversal_holiday\Views\Shared\Components\_testimonial\Default.cshtml"
                                            Write(item.testiMonialClient);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
            WriteLiteral("                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 38 "C:\Users\muham\OneDrive\Masaüstü\Proje Ve Doyalar\projeler\.CORE\Traversal_holiday\Traversal_holiday\Views\Shared\Components\_testimonial\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- /grids -->\r\n    </div>\r\n    <!-- //grids -->\r\n</section>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EntityLayer.Concrete.TestiMonial>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
