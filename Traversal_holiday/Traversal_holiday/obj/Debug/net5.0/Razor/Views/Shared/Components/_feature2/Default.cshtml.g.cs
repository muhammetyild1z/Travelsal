#pragma checksum "C:\Users\muham\OneDrive\Masaüstü\Proje Ve Doyalar\projeler\.CORE\Traversal_holiday\Traversal_holiday\Views\Shared\Components\_feature2\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e10d41e4f7830e273058917a1b3ff60241f805d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__feature2_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_feature2/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e10d41e4f7830e273058917a1b3ff60241f805d", @"/Views/Shared/Components/_feature2/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d01115374c26545911a86b48b194d0289ff9a3e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__feature2_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EntityLayer.Concrete.Destination>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"\r\n     -gd-1 col-lg-6 mt-lg-0 mt-4\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 7 "C:\Users\muham\OneDrive\Masaüstü\Proje Ve Doyalar\projeler\.CORE\Traversal_holiday\Traversal_holiday\Views\Shared\Components\_feature2\Default.cshtml"
         foreach (var item in Model)
        {



#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"maghny-gd-1 col-6 mb-4\">\r\n                <div class=\"maghny-grid\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 292, "\"", 339, 2);
            WriteAttributeValue("", 299, "/Destination/Details/", 299, 21, true);
#nullable restore
#line 13 "C:\Users\muham\OneDrive\Masaüstü\Proje Ve Doyalar\projeler\.CORE\Traversal_holiday\Traversal_holiday\Views\Shared\Components\_feature2\Default.cshtml"
WriteAttributeValue("", 320, item.destinationId, 320, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <figure class=\"effect-lily border-radius\">\r\n                            <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 461, "\"", 489, 1);
#nullable restore
#line 15 "C:\Users\muham\OneDrive\Masaüstü\Proje Ve Doyalar\projeler\.CORE\Traversal_holiday\Traversal_holiday\Views\Shared\Components\_feature2\Default.cshtml"
WriteAttributeValue("", 467, item.destinationImage, 467, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 490, "\"", 496, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <figcaption>\r\n                                <div class=\"mb-4\">\r\n                                    <h4>");
#nullable restore
#line 18 "C:\Users\muham\OneDrive\Masaüstü\Proje Ve Doyalar\projeler\.CORE\Traversal_holiday\Traversal_holiday\Views\Shared\Components\_feature2\Default.cshtml"
                                   Write(item.destinationCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    <p>");
#nullable restore
#line 19 "C:\Users\muham\OneDrive\Masaüstü\Proje Ve Doyalar\projeler\.CORE\Traversal_holiday\Traversal_holiday\Views\Shared\Components\_feature2\Default.cshtml"
                                  Write(item.destinationDayNight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p>Fiyat ");
#nullable restore
#line 20 "C:\Users\muham\OneDrive\Masaüstü\Proje Ve Doyalar\projeler\.CORE\Traversal_holiday\Traversal_holiday\Views\Shared\Components\_feature2\Default.cshtml"
                                        Write(item.destinationPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺ </p>\r\n                                </div>\r\n\r\n                            </figcaption>\r\n                        </figure>\r\n                    </a>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 28 "C:\Users\muham\OneDrive\Masaüstü\Proje Ve Doyalar\projeler\.CORE\Traversal_holiday\Traversal_holiday\Views\Shared\Components\_feature2\Default.cshtml"


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EntityLayer.Concrete.Destination>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591