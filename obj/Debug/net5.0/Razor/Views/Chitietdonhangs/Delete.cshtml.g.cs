#pragma checksum "C:\Users\Asus\Desktop\Ky7\MaNguonMo\ShopPhone\Views\Chitietdonhangs\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb7e88c58b9c76cbe358f4319f5bed69a59aa18f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chitietdonhangs_Delete), @"mvc.1.0.view", @"/Views/Chitietdonhangs/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb7e88c58b9c76cbe358f4319f5bed69a59aa18f", @"/Views/Chitietdonhangs/Delete.cshtml")]
    public class Views_Chitietdonhangs_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopPhone.Models.Chitietdonhang>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Asus\Desktop\Ky7\MaNguonMo\ShopPhone\Views\Chitietdonhangs\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Chitietdonhang</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "C:\Users\Asus\Desktop\Ky7\MaNguonMo\ShopPhone\Views\Chitietdonhangs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SoLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "C:\Users\Asus\Desktop\Ky7\MaNguonMo\ShopPhone\Views\Chitietdonhangs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SoLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\Users\Asus\Desktop\Ky7\MaNguonMo\ShopPhone\Views\Chitietdonhangs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DonGia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Users\Asus\Desktop\Ky7\MaNguonMo\ShopPhone\Views\Chitietdonhangs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DonGia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Users\Asus\Desktop\Ky7\MaNguonMo\ShopPhone\Views\Chitietdonhangs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaDonNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\Asus\Desktop\Ky7\MaNguonMo\ShopPhone\Views\Chitietdonhangs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaDonNavigation.MaDon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "C:\Users\Asus\Desktop\Ky7\MaNguonMo\ShopPhone\Views\Chitietdonhangs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaSanPhamNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "C:\Users\Asus\Desktop\Ky7\MaNguonMo\ShopPhone\Views\Chitietdonhangs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaSanPhamNavigation.MaSanPham));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd class>
    </dl>
    
    <form asp-action=""Delete"">
        <input type=""hidden"" asp-for=""MaSanPham"" />
        <input type=""hidden"" asp-for=""MaDon"" />
        <input type=""submit"" value=""Delete"" class=""btn btn-danger"" /> |
        <a asp-action=""Index"">Back to List</a>
    </form>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopPhone.Models.Chitietdonhang> Html { get; private set; }
    }
}
#pragma warning restore 1591
