#pragma checksum "D:\DoAnHK5\ASP.NetCore\DoAnAsp\DoAnGiay\DoAnGiay\Areas\Admin\Views\TypeShoe\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "163350cbca7688471d407b81649d2f3e9622f920"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_TypeShoe_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/TypeShoe/Index.cshtml")]
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
#line 1 "D:\DoAnHK5\ASP.NetCore\DoAnAsp\DoAnGiay\DoAnGiay\Areas\Admin\Views\_ViewImports.cshtml"
using DoAnGiay.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"163350cbca7688471d407b81649d2f3e9622f920", @"/Areas/Admin/Views/TypeShoe/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e643d0c0890e7b3b944dc025e62ea32f48377e0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_TypeShoe_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoAnGiay.Areas.Admin.Models.TypeShoeModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\DoAnHK5\ASP.NetCore\DoAnAsp\DoAnGiay\DoAnGiay\Areas\Admin\Views\TypeShoe\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-xs-12"">
        <!-- PAGE CONTENT BEGINS -->
        <div class=""row"">
            <div class=""col-xs-12"">
                <table id=""simple-table"" class=""table  table-bordered table-hover"">
                    <thead>
                        <tr>
                            <th class=""center"">
                                <label class=""pos-rel"">
                                    <input type=""checkbox"" class=""ace"" />
                                    <span class=""lbl""></span>
                                </label>
                            </th>
                            <th>
                                ");
#nullable restore
#line 22 "D:\DoAnHK5\ASP.NetCore\DoAnAsp\DoAnGiay\DoAnGiay\Areas\Admin\Views\TypeShoe\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th class=\"hidden-480\">\r\n                                ");
#nullable restore
#line 25 "D:\DoAnHK5\ASP.NetCore\DoAnAsp\DoAnGiay\DoAnGiay\Areas\Admin\Views\TypeShoe\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n\r\n                    <tbody>\r\n");
#nullable restore
#line 32 "D:\DoAnHK5\ASP.NetCore\DoAnAsp\DoAnGiay\DoAnGiay\Areas\Admin\Views\TypeShoe\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <tr>
                                <td class=""center"">
                                    <label class=""pos-rel"">
                                        <input type=""checkbox"" class=""ace"" />
                                        <span class=""lbl""></span>
                                    </label>
                                </td>
                                <td>
                                    ");
#nullable restore
#line 42 "D:\DoAnHK5\ASP.NetCore\DoAnAsp\DoAnGiay\DoAnGiay\Areas\Admin\Views\TypeShoe\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"hidden-480\">\r\n                                    ");
#nullable restore
#line 45 "D:\DoAnHK5\ASP.NetCore\DoAnAsp\DoAnGiay\DoAnGiay\Areas\Admin\Views\TypeShoe\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td>\r\n\r\n");
            WriteLiteral("                                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2339, "\"", 2468, 6);
            WriteAttributeValue("", 2349, "showModal(\'", 2349, 11, true);
#nullable restore
#line 53 "D:\DoAnHK5\ASP.NetCore\DoAnAsp\DoAnGiay\DoAnGiay\Areas\Admin\Views\TypeShoe\Index.cshtml"
WriteAttributeValue("", 2360, Url.Action("Details","TypeShoe",new { id = $"{item.IdType}" },Context.Request.Scheme), 2360, 86, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2446, "\',\'Chi", 2446, 6, true);
            WriteAttributeValue(" ", 2452, "loại", 2453, 5, true);
            WriteAttributeValue(" ", 2457, "sản", 2458, 4, true);
            WriteAttributeValue(" ", 2461, "phẩm\')", 2462, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-xs btn-success\" ata-rel=\"tooltip\" title=\"Details\">\r\n                                        <i class=\"ace-icon fa fa-folder-open bigger-120\"></i>\r\n                                    </a>\r\n");
            WriteLiteral("                                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3004, "\"", 3132, 6);
            WriteAttributeValue("", 3014, "showModal(\'", 3014, 11, true);
#nullable restore
#line 59 "D:\DoAnHK5\ASP.NetCore\DoAnAsp\DoAnGiay\DoAnGiay\Areas\Admin\Views\TypeShoe\Index.cshtml"
WriteAttributeValue("", 3025, Url.Action("Edit","TypeShoe",new { id = $"{item.IdType}" },Context.Request.Scheme), 3025, 83, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3108, "\',\'Chỉnh", 3108, 8, true);
            WriteAttributeValue(" ", 3116, "loại", 3117, 5, true);
            WriteAttributeValue(" ", 3121, "sản", 3122, 4, true);
            WriteAttributeValue(" ", 3125, "phẩm\')", 3126, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-xs btn-info\" data-rel=\"tooltip\" title=\"Edit\">\r\n                                        <i class=\"ace-icon fa fa-pencil bigger-120\"></i>\r\n                                    </a>\r\n");
            WriteLiteral("                                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3666, "\"", 3785, 4);
            WriteAttributeValue("", 3676, "showModal(\'", 3676, 11, true);
#nullable restore
#line 65 "D:\DoAnHK5\ASP.NetCore\DoAnAsp\DoAnGiay\DoAnGiay\Areas\Admin\Views\TypeShoe\Index.cshtml"
WriteAttributeValue("", 3687, Url.Action("Delete","TypeShoe",new { id = $"{item.IdType}" },Context.Request.Scheme), 3687, 85, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3772, "\',\'Xóa", 3772, 6, true);
            WriteAttributeValue(" ", 3778, "loại\')", 3779, 7, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-xs btn-danger"" data-rel=""tooltip"" title=""Delete"">
                                        <i class=""ace-icon fa fa-trash-o bigger-120""></i>
                                    </a>
                                </td>
                            </tr>
");
#nullable restore
#line 70 "D:\DoAnHK5\ASP.NetCore\DoAnAsp\DoAnGiay\DoAnGiay\Areas\Admin\Views\TypeShoe\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n                <p>\r\n\r\n                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 4188, "\"", 4283, 4);
            WriteAttributeValue("", 4198, "showModal(\'", 4198, 11, true);
#nullable restore
#line 75 "D:\DoAnHK5\ASP.NetCore\DoAnAsp\DoAnGiay\DoAnGiay\Areas\Admin\Views\TypeShoe\Index.cshtml"
WriteAttributeValue("", 4209, Url.Action("Create","TypeShoe",null,Context.Request.Scheme), 4209, 60, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4269, "\',\'Thêm", 4269, 7, true);
            WriteAttributeValue(" ", 4276, "Loại\')", 4277, 7, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-success text-white"">
                        Thêm loại
                    </a>
                </p>
            </div><!-- /.span -->
        </div><!-- /.row -->
        <!-- PAGE CONTENT ENDS -->
    </div><!-- /.col -->
</div><!-- /.row -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DoAnGiay.Areas.Admin.Models.TypeShoeModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
