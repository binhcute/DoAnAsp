#pragma checksum "D:\DoAnHK5\ASP.NetCore\DoAnAsp\DoAnGiay\DoAnGiay\Areas\Admin\Views\Color\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa07a2de50246e41320e7fa52ca09662eb9b3f48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Color_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Color/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa07a2de50246e41320e7fa52ca09662eb9b3f48", @"/Areas/Admin/Views/Color/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e643d0c0890e7b3b944dc025e62ea32f48377e0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Color_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoAnGiay.Areas.Admin.Models.ColorModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\DoAnHK5\ASP.NetCore\DoAnAsp\DoAnGiay\DoAnGiay\Areas\Admin\Views\Color\Index.cshtml"
  
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
#line 22 "D:\DoAnHK5\ASP.NetCore\DoAnAsp\DoAnGiay\DoAnGiay\Areas\Admin\Views\Color\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </th>\r\n                                        <th class=\"hidden-480\">\r\n                                            ");
#nullable restore
#line 25 "D:\DoAnHK5\ASP.NetCore\DoAnAsp\DoAnGiay\DoAnGiay\Areas\Admin\Views\Color\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </th>\r\n                                        <th></th>\r\n                                    </tr>\r\n                                </thead>\r\n\r\n                                <tbody>\r\n");
#nullable restore
#line 32 "D:\DoAnHK5\ASP.NetCore\DoAnAsp\DoAnGiay\DoAnGiay\Areas\Admin\Views\Color\Index.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <tr>
                                            <td class=""center"">
                                                <label class=""pos-rel"">
                                                    <input type=""checkbox"" class=""ace"" />
                                                    <span class=""lbl""></span>
                                                </label>
                                            </td>
                                            <td>
                                                ");
#nullable restore
#line 42 "D:\DoAnHK5\ASP.NetCore\DoAnAsp\DoAnGiay\DoAnGiay\Areas\Admin\Views\Color\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td class=\"hidden-480\">\r\n                                                ");
#nullable restore
#line 45 "D:\DoAnHK5\ASP.NetCore\DoAnAsp\DoAnGiay\DoAnGiay\Areas\Admin\Views\Color\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n\r\n                                            <td>\r\n\r\n");
            WriteLiteral("                                                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2776, "\"", 2898, 5);
            WriteAttributeValue("", 2786, "showModal(\'", 2786, 11, true);
#nullable restore
#line 53 "D:\DoAnHK5\ASP.NetCore\DoAnAsp\DoAnGiay\DoAnGiay\Areas\Admin\Views\Color\Index.cshtml"
WriteAttributeValue("", 2797, Url.Action("Details","Color",new { id = $"{item.IdColor}" },Context.Request.Scheme), 2797, 84, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2881, "\',\'Chi", 2881, 6, true);
            WriteAttributeValue(" ", 2887, "tiết", 2888, 5, true);
            WriteAttributeValue(" ", 2892, "màu\')", 2893, 6, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-xs btn-success\" ata-rel=\"tooltip\" title=\"Details\">\r\n                                                    <i class=\"ace-icon fa fa-folder-open bigger-120\"></i>\r\n                                                </a>\r\n");
            WriteLiteral("                                                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3418, "\"", 3538, 5);
            WriteAttributeValue("", 3428, "showModal(\'", 3428, 11, true);
#nullable restore
#line 59 "D:\DoAnHK5\ASP.NetCore\DoAnAsp\DoAnGiay\DoAnGiay\Areas\Admin\Views\Color\Index.cshtml"
WriteAttributeValue("", 3439, Url.Action("Edit","Color",new { id = $"{item.IdColor}" },Context.Request.Scheme), 3439, 81, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3520, "\',\'Chỉnh", 3520, 8, true);
            WriteAttributeValue(" ", 3528, "sửa", 3529, 4, true);
            WriteAttributeValue(" ", 3532, "màu\')", 3533, 6, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-xs btn-info\" data-rel=\"tooltip\" title=\"Edit\">\r\n                                                    <i class=\"ace-icon fa fa-pencil bigger-120\"></i>\r\n                                                </a>\r\n");
            WriteLiteral("                                                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 4135, "\"", 4251, 4);
            WriteAttributeValue("", 4145, "showModal(\'", 4145, 11, true);
#nullable restore
#line 65 "D:\DoAnHK5\ASP.NetCore\DoAnAsp\DoAnGiay\DoAnGiay\Areas\Admin\Views\Color\Index.cshtml"
WriteAttributeValue("", 4156, Url.Action("Delete","Color",new { id = $"{item.IdColor}" },Context.Request.Scheme), 4156, 83, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4239, "\',\'Xóa", 4239, 6, true);
            WriteAttributeValue(" ", 4245, "màu\')", 4246, 6, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-xs btn-danger"" data-rel=""tooltip"" title=""Delete"">
                                                    <i class=""ace-icon fa fa-trash-o bigger-120""></i>
                                                </a>
                                            </td>
                                        </tr>
");
#nullable restore
#line 70 "D:\DoAnHK5\ASP.NetCore\DoAnAsp\DoAnGiay\DoAnGiay\Areas\Admin\Views\Color\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                            <p>\r\n                                \r\n                                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 4794, "\"", 4885, 4);
            WriteAttributeValue("", 4804, "showModal(\'", 4804, 11, true);
#nullable restore
#line 75 "D:\DoAnHK5\ASP.NetCore\DoAnAsp\DoAnGiay\DoAnGiay\Areas\Admin\Views\Color\Index.cshtml"
WriteAttributeValue("", 4815, Url.Action("Create","Color",null,Context.Request.Scheme), 4815, 57, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4872, "\',\'Thêm", 4872, 7, true);
            WriteAttributeValue(" ", 4879, "Màu\')", 4880, 6, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-success text-white"">
                                    Thêm màu
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DoAnGiay.Areas.Admin.Models.ColorModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
