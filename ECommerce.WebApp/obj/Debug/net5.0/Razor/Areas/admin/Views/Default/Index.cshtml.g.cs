#pragma checksum "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97601bf7c16a8e1ea7d587f3c7a608c2691afc7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_admin_Views_Default_Index), @"mvc.1.0.view", @"/Areas/admin/Views/Default/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97601bf7c16a8e1ea7d587f3c7a608c2691afc7a", @"/Areas/admin/Views/Default/Index.cshtml")]
    public class Areas_admin_Views_Default_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ECommerce.WebApp.Models.ViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table id=\"customers\" class=\"table table-responsive\" style=\"text-align:center\">\r\n    <tr>\r\n        <th>Title</th>\r\n        <th>Description</th>\r\n        <th>Stock</th>\r\n        <th>Process</th>\r\n    </tr>\r\n");
#nullable restore
#line 14 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
     foreach (var item in Model.Products)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
         if (item.StockQuantity == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"bg-danger\">\r\n                <td>");
#nullable restore
#line 19 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
               Write(item.ProductTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
               Write(item.ProductDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
               Write(item.StockQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 679, "\"", 723, 2);
            WriteAttributeValue("", 686, "/admin/Product/Update/", 686, 22, true);
#nullable restore
#line 23 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
WriteAttributeValue("", 708, item.ProductId, 708, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Update</a>\r\n                    <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 782, "\"", 826, 2);
            WriteAttributeValue("", 789, "/admin/Product/Delete/", 789, 22, true);
#nullable restore
#line 24 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
WriteAttributeValue("", 811, item.ProductId, 811, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 27 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
               Write(item.ProductTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
               Write(item.ProductDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
               Write(item.StockQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 1143, "\"", 1187, 2);
            WriteAttributeValue("", 1150, "/admin/Product/Update/", 1150, 22, true);
#nullable restore
#line 35 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
WriteAttributeValue("", 1172, item.ProductId, 1172, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Update</a>\r\n                    <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1246, "\"", 1290, 2);
            WriteAttributeValue("", 1253, "/admin/Product/Delete/", 1253, 22, true);
#nullable restore
#line 36 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
WriteAttributeValue("", 1275, item.ProductId, 1275, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 39 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n    <br />\r\n    <tr>\r\n        <th>Category Id</th>\r\n        <th>Category Name</th>\r\n        <th>Process</th>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 50 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
     foreach (var item in Model.Categories)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 53 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
           Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 54 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>\r\n                <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 1714, "\"", 1768, 2);
            WriteAttributeValue("", 1721, "/admin/Category/UpdateCategory/", 1721, 31, true);
#nullable restore
#line 56 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
WriteAttributeValue("", 1752, item.CategoryId, 1752, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Update</a>\r\n                <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1823, "\"", 1877, 2);
            WriteAttributeValue("", 1830, "/admin/Category/DeleteCategory/", 1830, 31, true);
#nullable restore
#line 57 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
WriteAttributeValue("", 1861, item.CategoryId, 1861, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 61 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
