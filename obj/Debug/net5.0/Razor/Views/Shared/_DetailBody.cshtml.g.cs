#pragma checksum "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BaoCaoThucTap\TTTN\Views\Shared\_DetailBody.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37690e31eb9d5060d7359e128a31b2e161182b35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__DetailBody), @"mvc.1.0.view", @"/Views/Shared/_DetailBody.cshtml")]
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
#line 1 "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BaoCaoThucTap\TTTN\Views\Shared\_DetailBody.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37690e31eb9d5060d7359e128a31b2e161182b35", @"/Views/Shared/_DetailBody.cshtml")]
    #nullable restore
    public class Views_Shared__DetailBody : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BT2MWG.Models.Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BaoCaoThucTap\TTTN\Views\Shared\_DetailBody.cshtml"
  
    
    String i = (String)Url.ActionContext.RouteData.Values["id"];
    int j = Int32.Parse(i);

    CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   
    string af = Model[j].Price.ToString("#,###", cul.NumberFormat);

    decimal priceNew = Model[j].Price - (Model[j].Price * Model[j].Discount) / 100;

    string aff = priceNew.ToString("#,###", cul.NumberFormat);
    //Footer & Header
    


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"detail-body-column-2-product-name\">\r\n    <div class=\"title\">\r\n        <h3>");
#nullable restore
#line 23 "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BaoCaoThucTap\TTTN\Views\Shared\_DetailBody.cshtml"
       Write(Model[j].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n\r\n    <div class=\"price-section\">\r\n        <span class=\"current-price\">");
#nullable restore
#line 27 "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BaoCaoThucTap\TTTN\Views\Shared\_DetailBody.cshtml"
                               Write(aff);

#line default
#line hidden
#nullable disable
            WriteLiteral("₫</span>\r\n        <span class=\"old-price\">");
#nullable restore
#line 28 "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BaoCaoThucTap\TTTN\Views\Shared\_DetailBody.cshtml"
                           Write(af);

#line default
#line hidden
#nullable disable
            WriteLiteral("₫</span>\r\n        <span class=\"discount\">");
#nullable restore
#line 29 "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BaoCaoThucTap\TTTN\Views\Shared\_DetailBody.cshtml"
                          Write(Model[j].Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n\r\n    </div>\r\n    <span class=\"product-id\">#");
#nullable restore
#line 32 "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BaoCaoThucTap\TTTN\Views\Shared\_DetailBody.cshtml"
                         Write(Model[j].ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    <div class=\"discount-detail\">\r\n        <p>Khuyến mãi</p>\r\n        <ul class=\"promotion-list\">\r\n");
#nullable restore
#line 36 "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BaoCaoThucTap\TTTN\Views\Shared\_DetailBody.cshtml"
             foreach (var item in @Model[j].Promotion)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 38 "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BaoCaoThucTap\TTTN\Views\Shared\_DetailBody.cshtml"
               Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 39 "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BaoCaoThucTap\TTTN\Views\Shared\_DetailBody.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n    <div class=\"button-section\">\r\n        <button class=\"button button-buy\">MUA NGAY</button>\r\n        <button class=\"button button-see\">XEM CỬA HÀNG CÒN HÀNG</button>\r\n    </div>\r\n\r\n");
            WriteLiteral("    ");
#nullable restore
#line 48 "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BaoCaoThucTap\TTTN\Views\Shared\_DetailBody.cshtml"
Write(await Html.PartialAsync("_Policy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("    ");
#nullable restore
#line 51 "C:\Users\Snorlax\OneDrive\Desktop\Cuong\BaoCaoThucTap\TTTN\Views\Shared\_DetailBody.cshtml"
Write(await Component.InvokeAsync("ProductDetailBox"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BT2MWG.Models.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
