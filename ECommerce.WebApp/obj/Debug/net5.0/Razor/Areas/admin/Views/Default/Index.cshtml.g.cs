#pragma checksum "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35aafd06c5535d0ad853098476c8731011160da2"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35aafd06c5535d0ad853098476c8731011160da2", @"/Areas/admin/Views/Default/Index.cshtml")]
    public class Areas_admin_Views_Default_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ECommerce.WebApp.Models.ViewModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::ECommerce.WebApp.PagingTagHelpers.PagingTagHelper __ECommerce_WebApp_PagingTagHelpers_PagingTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
 using (Html.BeginForm("Index", "Default", "admin", FormMethod.Get))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
Write(Html.TextBox("searchString"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Search\" />\r\n");
#nullable restore
#line 12 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table id=""customers"" class=""table table-responsive"" style=""text-align:center"">
    <tr>
        <th>Title</th>
        <th>Description</th>
        <th>Stock</th>
        <th>Product Process</th>
        <th>Category Id</th>
        <th>Category Name</th>
        <th>Category Process</th>
    </tr>

");
#nullable restore
#line 24 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
     foreach (var item in Model.Products)
    {

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
         if (item.StockQuantity == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"bg-danger\">\r\n                <td>");
#nullable restore
#line 30 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
               Write(item.ProductTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
               Write(item.ProductDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
               Write(item.StockQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 1030, "\"", 1074, 2);
            WriteAttributeValue("", 1037, "/admin/Product/Update/", 1037, 22, true);
#nullable restore
#line 34 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
WriteAttributeValue("", 1059, item.ProductId, 1059, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Update</a>\r\n                    <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1133, "\"", 1177, 2);
            WriteAttributeValue("", 1140, "/admin/Product/Delete/", 1140, 22, true);
#nullable restore
#line 35 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
WriteAttributeValue("", 1162, item.ProductId, 1162, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                </td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
               Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
               Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 1376, "\"", 1430, 2);
            WriteAttributeValue("", 1383, "/admin/Category/UpdateCategory/", 1383, 31, true);
#nullable restore
#line 40 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
WriteAttributeValue("", 1414, item.CategoryId, 1414, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Update</a>\r\n                    <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1489, "\"", 1543, 2);
            WriteAttributeValue("", 1496, "/admin/Category/DeleteCategory/", 1496, 31, true);
#nullable restore
#line 41 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
WriteAttributeValue("", 1527, item.CategoryId, 1527, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 44 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 48 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
               Write(item.ProductTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 49 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
               Write(item.ProductDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 50 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
               Write(item.StockQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 1860, "\"", 1904, 2);
            WriteAttributeValue("", 1867, "/admin/Product/Update/", 1867, 22, true);
#nullable restore
#line 52 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
WriteAttributeValue("", 1889, item.ProductId, 1889, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Update</a>\r\n                    <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1963, "\"", 2007, 2);
            WriteAttributeValue("", 1970, "/admin/Product/Delete/", 1970, 22, true);
#nullable restore
#line 53 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
WriteAttributeValue("", 1992, item.ProductId, 1992, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                </td>\r\n                <td>");
#nullable restore
#line 55 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
               Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 56 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
               Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 2206, "\"", 2260, 2);
            WriteAttributeValue("", 2213, "/admin/Category/UpdateCategory/", 2213, 31, true);
#nullable restore
#line 58 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
WriteAttributeValue("", 2244, item.CategoryId, 2244, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Update</a>\r\n                    <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 2319, "\"", 2373, 2);
            WriteAttributeValue("", 2326, "/admin/Category/DeleteCategory/", 2326, 31, true);
#nullable restore
#line 59 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
WriteAttributeValue("", 2357, item.CategoryId, 2357, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 62 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("product-list-pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35aafd06c5535d0ad853098476c8731011160da212717", async() => {
            }
            );
            __ECommerce_WebApp_PagingTagHelpers_PagingTagHelper = CreateTagHelper<global::ECommerce.WebApp.PagingTagHelpers.PagingTagHelper>();
            __tagHelperExecutionContext.Add(__ECommerce_WebApp_PagingTagHelpers_PagingTagHelper);
#nullable restore
#line 65 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
__ECommerce_WebApp_PagingTagHelpers_PagingTagHelper.CurrentCategory = Model.CurrentCategory;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("current-category", __ECommerce_WebApp_PagingTagHelpers_PagingTagHelper.CurrentCategory, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 66 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
__ECommerce_WebApp_PagingTagHelpers_PagingTagHelper.CurrentPage = Model.CurrentPage;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("current-page", __ECommerce_WebApp_PagingTagHelpers_PagingTagHelper.CurrentPage, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 67 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
__ECommerce_WebApp_PagingTagHelpers_PagingTagHelper.PageCount = Model.PageCount;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-count", __ECommerce_WebApp_PagingTagHelpers_PagingTagHelper.PageCount, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 68 "C:\Users\celal\OneDrive\Masaüstü\RequestProject\ECommerce.WebApp\Areas\admin\Views\Default\Index.cshtml"
__ECommerce_WebApp_PagingTagHelpers_PagingTagHelper.PageSize = Model.PageSize;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-size", __ECommerce_WebApp_PagingTagHelpers_PagingTagHelper.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
