#pragma checksum "C:\Users\Asus\Desktop\Ky7\MaNguonMo\ShopPhone\Areas\Admin\Views\AdminSanpham\GetSanPham.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07e7f3b38da70c397f5fbeb0170cad239a176def"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminSanpham_GetSanPham), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminSanpham/GetSanPham.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07e7f3b38da70c397f5fbeb0170cad239a176def", @"/Areas/Admin/Views/AdminSanpham/GetSanPham.cshtml")]
    public class Areas_Admin_Views_AdminSanpham_GetSanPham : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShopPhone.Models.Sanpham>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminSanpham", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Asus\Desktop\Ky7\MaNguonMo\ShopPhone\Areas\Admin\Views\AdminSanpham\GetSanPham.cshtml"
  
    ViewData["Title"] = "Home";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""app-content content"">
    <div class=""content-wrapper"">
        <div class=""content-wrapper-before""></div>
        <div class=""content-header row"">
            <div class=""content-header-left col-md-4 col-12 mb-2"">
                <h3 class=""content-header-title"">Tables</h3>
            </div>
            <div class=""content-header-right col-md-8 col-12"">
                <div class=""breadcrumbs-top float-md-right"">
                    <div class=""breadcrumb-wrapper mr-1"">
                        <ol class=""breadcrumb"">
                            <li class=""breadcrumb-item"">
                                <a href=""index.html"">Home</a>
                            </li>
                            <li class=""breadcrumb-item active"">
                                Tables
                            </li>
                        </ol>
                    </div>
                </div>
            </div>
        </div>
        <div class=""content-body"">
            <!-- Basic ");
            WriteLiteral("Tables start -->\r\n            <div class=\"row\">\r\n                <div class=\"col-12\">\r\n                    <div class=\"card\">\r\n                        <div class=\"card-header\">\r\n                            <p>\r\n                                ");
#nullable restore
#line 37 "C:\Users\Asus\Desktop\Ky7\MaNguonMo\ShopPhone\Areas\Admin\Views\AdminSanpham\GetSanPham.cshtml"
                           Write(Html.ActionLink("Th??m s???n ph???m", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </p>
                            <h4 class=""card-title"">Danh s??ch s???n ph???m:</h4>
                            <a class=""heading-elements-toggle""><i class=""la la-ellipsis-v font-medium-3""></i></a>
                            <div class=""heading-elements"">
                                <ul class=""list-inline mb-0"">
                                    <li><a data-action=""collapse""><i class=""ft-minus""></i></a></li>
                                    <li><a data-action=""reload""><i class=""ft-rotate-cw""></i></a></li>
                                    <li><a data-action=""expand""><i class=""ft-maximize""></i></a></li>
                                    <li><a data-action=""close""><i class=""ft-x""></i></a></li>
                                </ul>
                            </div>
                        </div>
                        <div class=""card-content collapse show"">
                            <div class=""card-body"">
                                <div class=""tab");
            WriteLiteral(@"le-responsive"">
                                    <table class=""table"">
                                        <thead>
                                            <tr>
                                                <th>M?? s???n ph???m</th>
                                                <th>T??n s???n ph???m</th>
                                                <th>M?? h??ng</th>
                                                <th>???nh</th>
                                                <th>M?? t???</th>
                                                <th>S??? l?????ng</th>
                                                <th>????n gi??</th>
                                                <th>Ch???c n??ng</th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 67 "C:\Users\Asus\Desktop\Ky7\MaNguonMo\ShopPhone\Areas\Admin\Views\AdminSanpham\GetSanPham.cshtml"
                                             foreach (var item in Model)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\r\n                                                    <th scope=\"row\">");
#nullable restore
#line 70 "C:\Users\Asus\Desktop\Ky7\MaNguonMo\ShopPhone\Areas\Admin\Views\AdminSanpham\GetSanPham.cshtml"
                                                               Write(item.MaSanPham);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                    <td>");
#nullable restore
#line 71 "C:\Users\Asus\Desktop\Ky7\MaNguonMo\ShopPhone\Areas\Admin\Views\AdminSanpham\GetSanPham.cshtml"
                                                   Write(item.TenSanPham);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 72 "C:\Users\Asus\Desktop\Ky7\MaNguonMo\ShopPhone\Areas\Admin\Views\AdminSanpham\GetSanPham.cshtml"
                                                   Write(item.MaDanhMuc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "07e7f3b38da70c397f5fbeb0170cad239a176def10149", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3938, "~/images/", 3938, 9, true);
#nullable restore
#line 74 "C:\Users\Asus\Desktop\Ky7\MaNguonMo\ShopPhone\Areas\Admin\Views\AdminSanpham\GetSanPham.cshtml"
AddHtmlAttributeValue("", 3947, item.Anh, 3947, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>");
#nullable restore
#line 76 "C:\Users\Asus\Desktop\Ky7\MaNguonMo\ShopPhone\Areas\Admin\Views\AdminSanpham\GetSanPham.cshtml"
                                                   Write(item.MoTa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 77 "C:\Users\Asus\Desktop\Ky7\MaNguonMo\ShopPhone\Areas\Admin\Views\AdminSanpham\GetSanPham.cshtml"
                                                   Write(item.SoLuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 78 "C:\Users\Asus\Desktop\Ky7\MaNguonMo\ShopPhone\Areas\Admin\Views\AdminSanpham\GetSanPham.cshtml"
                                                   Write(item.GiaTien);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07e7f3b38da70c397f5fbeb0170cad239a176def13016", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "C:\Users\Asus\Desktop\Ky7\MaNguonMo\ShopPhone\Areas\Admin\Views\AdminSanpham\GetSanPham.cshtml"
                                                                                                                              WriteLiteral(item.MaSanPham);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07e7f3b38da70c397f5fbeb0170cad239a176def15737", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "C:\Users\Asus\Desktop\Ky7\MaNguonMo\ShopPhone\Areas\Admin\Views\AdminSanpham\GetSanPham.cshtml"
                                                                                                                                WriteLiteral(item.MaSanPham);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    </td>\r\n                                                </tr>\r\n");
#nullable restore
#line 84 "C:\Users\Asus\Desktop\Ky7\MaNguonMo\ShopPhone\Areas\Admin\Views\AdminSanpham\GetSanPham.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </tbody>\r\n                                    </table>\r\n                                </div>\r\n                            </div>\r\n                            ");
#nullable restore
#line 89 "C:\Users\Asus\Desktop\Ky7\MaNguonMo\ShopPhone\Areas\Admin\Views\AdminSanpham\GetSanPham.cshtml"
                       Write(Html.Raw(TempData["msgdelete"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShopPhone.Models.Sanpham>> Html { get; private set; }
    }
}
#pragma warning restore 1591
