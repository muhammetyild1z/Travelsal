#pragma checksum "C:\Users\muham\OneDrive\Masaüstü\Proje Ve Doyalar\projeler\.CORE\Traversal_holiday\Traversal_holiday\Views\Shared\Components\_guides\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21157b79ff7c7b2bb92dbc71badd26920cd28efc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__guides_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_guides/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21157b79ff7c7b2bb92dbc71badd26920cd28efc", @"/Views/Shared/Components/_guides/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d01115374c26545911a86b48b194d0289ff9a3e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__guides_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EntityLayer.Concrete.Guide>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<section class=""w3l-team"" id=""team"">
    <div class=""team-block py-5"">
        <div class=""container py-lg-5"">
            <div class=""title-content text-center mb-lg-3 mb-4"">
                <h6 class=""sub-title""> Ekibimiz</h6>
                <h3 class=""hny-title"">Rehberlerimizle Tanışın</h3>
            </div>
            <div class=""row"">

");
#nullable restore
#line 13 "C:\Users\muham\OneDrive\Masaüstü\Proje Ve Doyalar\projeler\.CORE\Traversal_holiday\Traversal_holiday\Views\Shared\Components\_guides\Default.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-3 col-6 mt-lg-5 mt-4\">\r\n                        <div class=\"box16\">\r\n\r\n\r\n                            <a href=\"#url\"><img");
            BeginWriteAttribute("src", " src=\"", 624, "\"", 646, 1);
#nullable restore
#line 19 "C:\Users\muham\OneDrive\Masaüstü\Proje Ve Doyalar\projeler\.CORE\Traversal_holiday\Traversal_holiday\Views\Shared\Components\_guides\Default.cshtml"
WriteAttributeValue("", 630, item.guideImage, 630, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 647, "\"", 653, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid \" /></a>\r\n                            <div class=\"box-content\">\r\n                                <h3 class=\"title mb-2\"><a href=\"#url\">");
#nullable restore
#line 21 "C:\Users\muham\OneDrive\Masaüstü\Proje Ve Doyalar\projeler\.CORE\Traversal_holiday\Traversal_holiday\Views\Shared\Components\_guides\Default.cshtml"
                                                                 Write(item.guideName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                <span class=\"post\">");
#nullable restore
#line 22 "C:\Users\muham\OneDrive\Masaüstü\Proje Ve Doyalar\projeler\.CORE\Traversal_holiday\Traversal_holiday\Views\Shared\Components\_guides\Default.cshtml"
                                              Write(item.guideDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                <ul class=""social"">
                                    <li>
                                        <a href=""#"" class=""facebook"">
                                            <span class=""fa fa-facebook-f""></span>
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""#"" class=""twitter"">
                                            <span class=""fa fa-twitter""></span>
                                        </a>
                                    </li>
                                </ul>
                            </div>

                        </div>
                    </div>
");
#nullable restore
#line 39 "C:\Users\muham\OneDrive\Masaüstü\Proje Ve Doyalar\projeler\.CORE\Traversal_holiday\Traversal_holiday\Views\Shared\Components\_guides\Default.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EntityLayer.Concrete.Guide>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
