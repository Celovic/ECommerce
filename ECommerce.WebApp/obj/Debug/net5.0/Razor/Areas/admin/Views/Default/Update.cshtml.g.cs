#pragma checksum "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e457c8cd15f00f80412e0b7082b4295c13c83521"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_admin_Views_Default_Update), @"mvc.1.0.view", @"/Areas/admin/Views/Default/Update.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e457c8cd15f00f80412e0b7082b4295c13c83521", @"/Areas/admin/Views/Default/Update.cshtml")]
    public class Areas_admin_Views_Default_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ECommerce.WebApp.Models.ViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Update.cshtml"
  
    ViewData["Title"] = "Update";
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3 style=\"text-align:center;\">Add to Blog</h3>\r\n");
#nullable restore
#line 8 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Update.cshtml"
 using (Html.BeginForm())
{



#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 14 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Update.cshtml"
             foreach (var item in Model.Products)

            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-12\" style=\"margin-top:10px;margin-bottom:10px;\">\r\n                    <input type=\"text\" name=\"ProductTitle\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 497, "\"", 523, 1);
#nullable restore
#line 18 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Update.cshtml"
WriteAttributeValue("", 505, item.ProductTitle, 505, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"col-md-12\" style=\"margin-top:10px;margin-bottom:10px;\">\r\n                    <textarea name=\"ProductDescription\" class=\"form-control\">");
#nullable restore
#line 21 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Update.cshtml"
                                                                        Write(item.ProductDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n                </div>\r\n                <div class=\"col-md-12\" style=\"margin-top:10px;margin-bottom:10px;\">\r\n                    <input type=\"number\" name=\"StockQuantity\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 943, "\"", 970, 1);
#nullable restore
#line 24 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Update.cshtml"
WriteAttributeValue("", 951, item.StockQuantity, 951, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n");
#nullable restore
#line 26 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Update.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-12\" style=\"margin-top:10px;margin-bottom:10px;\">\r\n                <button type=\"submit\" class=\"btn btn-primary\"> Update</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 32 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Update.cshtml"


}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
