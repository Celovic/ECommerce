#pragma checksum "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Views\Cart\CartList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1845754e00aa579d43fce0cfa2e8c870342b699"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_CartList), @"mvc.1.0.view", @"/Views/Cart/CartList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1845754e00aa579d43fce0cfa2e8c870342b699", @"/Views/Cart/CartList.cshtml")]
    public class Views_Cart_CartList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ECommerce.WebApp.Models.ViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Views\Cart\CartList.cshtml"
  
    ViewData["Title"] = "CartList";
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>CartList</h1>\r\n<table>\r\n    <tr>\r\n        <td>Product Title</td>\r\n        <td>Description</td>\r\n        <td>Stock</td>\r\n        <td></td>\r\n    </tr>\r\n");
#nullable restore
#line 15 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Views\Cart\CartList.cshtml"
     foreach (var item in Model.Cart.CartLines)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Views\Cart\CartList.cshtml"
           Write(item.Product.ProductTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Views\Cart\CartList.cshtml"
           Write(item.Product.ProductDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Views\Cart\CartList.cshtml"
           Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</td>\r\n        </tr>\r\n");
#nullable restore
#line 23 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Views\Cart\CartList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ECommerce.WebApp.Models.ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
