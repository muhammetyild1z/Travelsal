#pragma checksum "C:\Users\muham\OneDrive\Masaüstü\Proje Ve Doyalar\projeler\.CORE\Traversal_holiday\Traversal_holiday\Areas\Member\Views\Shared\Components\Profile_Guides\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ec3af202aea34d5f5ab0d00190463fa4efad88e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Shared_Components_Profile_Guides_Default), @"mvc.1.0.view", @"/Areas/Member/Views/Shared/Components/Profile_Guides/Default.cshtml")]
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
#line 1 "C:\Users\muham\OneDrive\Masaüstü\Proje Ve Doyalar\projeler\.CORE\Traversal_holiday\Traversal_holiday\Areas\Member\Views\_ViewImports.cshtml"
using Traversal_holiday;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\muham\OneDrive\Masaüstü\Proje Ve Doyalar\projeler\.CORE\Traversal_holiday\Traversal_holiday\Areas\Member\Views\_ViewImports.cshtml"
using Traversal_holiday.Areas.Member.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ec3af202aea34d5f5ab0d00190463fa4efad88e", @"/Areas/Member/Views/Shared/Components/Profile_Guides/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee417238a1897958706cd1daf9f9a8a11e7afa3e", @"/Areas/Member/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Member_Views_Shared_Components_Profile_Guides_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EntityLayer.Concrete.Guide>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""col-12 col-xl-4"">
    <div class=""card h-100"">
        <div class=""card-header pb-0 p-3"">
            <h6 class=""mb-0"">Aktif Turlarınızın Rehberlerine Danışın</h6>
        </div>
        <div class=""card-body p-3"">
            <ul class=""list-group"">
");
#nullable restore
#line 11 "C:\Users\muham\OneDrive\Masaüstü\Proje Ve Doyalar\projeler\.CORE\Traversal_holiday\Traversal_holiday\Areas\Member\Views\Shared\Components\Profile_Guides\Default.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"list-group-item border-0 d-flex align-items-center px-0 mb-2\">\r\n                        <div class=\"avatar me-3\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 558, "\"", 580, 1);
#nullable restore
#line 15 "C:\Users\muham\OneDrive\Masaüstü\Proje Ve Doyalar\projeler\.CORE\Traversal_holiday\Traversal_holiday\Areas\Member\Views\Shared\Components\Profile_Guides\Default.cshtml"
WriteAttributeValue("", 564, item.guideImage, 564, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"kal\" class=\"border-radius-lg shadow\">\r\n                        </div>\r\n                        <div class=\"d-flex align-items-start flex-column justify-content-center\">\r\n                            <h6 class=\"mb-0 text-sm\">");
#nullable restore
#line 18 "C:\Users\muham\OneDrive\Masaüstü\Proje Ve Doyalar\projeler\.CORE\Traversal_holiday\Traversal_holiday\Areas\Member\Views\Shared\Components\Profile_Guides\Default.cshtml"
                                                Write(item.guideName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            <p class=\"mb-0 text-xs\">");
#nullable restore
#line 19 "C:\Users\muham\OneDrive\Masaüstü\Proje Ve Doyalar\projeler\.CORE\Traversal_holiday\Traversal_holiday\Areas\Member\Views\Shared\Components\Profile_Guides\Default.cshtml"
                                               Write(item.guideDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <a class=\"btn btn-link pe-3 ps-0 mb-0 ms-auto\" href=\"javascript:;\">Mesaj</a>\r\n                    </li>\r\n");
#nullable restore
#line 23 "C:\Users\muham\OneDrive\Masaüstü\Proje Ve Doyalar\projeler\.CORE\Traversal_holiday\Traversal_holiday\Areas\Member\Views\Shared\Components\Profile_Guides\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n              \r\n            </ul>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
