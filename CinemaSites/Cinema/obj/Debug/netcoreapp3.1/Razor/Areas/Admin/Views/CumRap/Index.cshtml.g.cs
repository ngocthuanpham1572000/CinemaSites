#pragma checksum "D:\ASP\cinema\CinemaSites\CinemaSites\CinemaSites\Cinema\Areas\Admin\Views\CumRap\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0c817ae86a4550c361b89a9a493da0e6cb4b829"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_CumRap_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/CumRap/Index.cshtml")]
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
#line 1 "D:\ASP\cinema\CinemaSites\CinemaSites\CinemaSites\Cinema\Areas\Admin\Views\_ViewImports.cshtml"
using Cinema.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP\cinema\CinemaSites\CinemaSites\CinemaSites\Cinema\Areas\Admin\Views\_ViewImports.cshtml"
using Cinema.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ASP\cinema\CinemaSites\CinemaSites\CinemaSites\Cinema\Areas\Admin\Views\_ViewImports.cshtml"
using Cinema;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0c817ae86a4550c361b89a9a493da0e6cb4b829", @"/Areas/Admin/Views/CumRap/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b65113a58e3e17bb2f9e308a8b7c6ffbab3d3a8e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_CumRap_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cinema.Areas.Admin.Models.CumRapModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ASP\cinema\CinemaSites\CinemaSites\CinemaSites\Cinema\Areas\Admin\Views\CumRap\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"content-wrapper\">\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b0c817ae86a4550c361b89a9a493da0e6cb4b8296010", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    \r\n\r\n    \r\n    <div class=\"row\">\r\n        <div class=\"col-md-12 stretch-card\">\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n");
#nullable restore
#line 17 "D:\ASP\cinema\CinemaSites\CinemaSites\CinemaSites\Cinema\Areas\Admin\Views\CumRap\Index.cshtml"
                     if (ViewContext.RouteData.Values["id"] != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0c817ae86a4550c361b89a9a493da0e6cb4b8297628", async() => {
                WriteLiteral("Tạo cụm rạp mới");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 20 "D:\ASP\cinema\CinemaSites\CinemaSites\CinemaSites\Cinema\Areas\Admin\Views\CumRap\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <br />\r\n                    <br />\r\n                    \r\n\r\n                    <p class=\"card-title\">Tìm kiếm</p>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0c817ae86a4550c361b89a9a493da0e6cb4b8299785", async() => {
                WriteLiteral(@"
                        <div class=""col-md-12"">
                            <label for=""s_name"" class=""col-form-label"">Nhập từ khoá</label>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-8"">
                                <input type=""text"" name=""s_name"" class=""form-control""
                                       ");
#nullable restore
#line 34 "D:\ASP\cinema\CinemaSites\CinemaSites\CinemaSites\Cinema\Areas\Admin\Views\CumRap\Index.cshtml"
                                   Write(Context.Request.Query["s_name"] != "" ? ("value=" + Context.Request.Query["s_name"]) : null);

#line default
#line hidden
#nullable disable
                WriteLiteral(@">
                            </div>

                            <div class=""col-md-4"">
                                <button class=""btn btn-info"" type=""submit"">Tìm</button>
                            </div>

                        </div>
                        <br />
                        <p>Có ");
#nullable restore
#line 43 "D:\ASP\cinema\CinemaSites\CinemaSites\CinemaSites\Cinema\Areas\Admin\Views\CumRap\Index.cshtml"
                          Write(((ICollection<CumRapModel>)ViewBag.lstCumRap).Count);

#line default
#line hidden
#nullable disable
                WriteLiteral(" cụm rạp</p>\r\n\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <br />
                    <br />

                    <p class=""card-title"">Danh sách cụm rạp</p>
                    <table class=""table table-striped"">
                        <thead>
                            <tr>
                                <th>
                                    Tên cụm
                                </th>
                                <th hidden>
                                    Trạng thái
                                </th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 63 "D:\ASP\cinema\CinemaSites\CinemaSites\CinemaSites\Cinema\Areas\Admin\Views\CumRap\Index.cshtml"
                             foreach (var item in ViewBag.lstCumRap)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 67 "D:\ASP\cinema\CinemaSites\CinemaSites\CinemaSites\Cinema\Areas\Admin\Views\CumRap\Index.cshtml"
                                   Write(item.TenCum);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td hidden>\r\n                                        ");
#nullable restore
#line 70 "D:\ASP\cinema\CinemaSites\CinemaSites\CinemaSites\Cinema\Areas\Admin\Views\CumRap\Index.cshtml"
                                   Write(item.TrangThai);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0c817ae86a4550c361b89a9a493da0e6cb4b82914715", async() => {
                WriteLiteral("Sửa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "D:\ASP\cinema\CinemaSites\CinemaSites\CinemaSites\Cinema\Areas\Admin\Views\CumRap\Index.cshtml"
                                                                     WriteLiteral(item.Id);

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
            WriteLiteral("\r\n\r\n                                        <button name=\"delete\" type=\"submit\" class=\"btn btn-warning\" data-id=\"");
#nullable restore
#line 75 "D:\ASP\cinema\CinemaSites\CinemaSites\CinemaSites\Cinema\Areas\Admin\Views\CumRap\Index.cshtml"
                                                                                                        Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Xoá</button>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 78 "D:\ASP\cinema\CinemaSites\CinemaSites\CinemaSites\Cinema\Areas\Admin\Views\CumRap\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 93 "D:\ASP\cinema\CinemaSites\CinemaSites\CinemaSites\Cinema\Areas\Admin\Views\CumRap\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"  
    <script>
        $('button[name=delete]').click(function (e) {
            e.preventDefault();
            var id = $(this).attr('data-id');
            console.log(id);
            const post_url = ""../../../api/CumRapAPI/"" + id;
            const request_method = ""DELETE"";
            $.ajax({
                url: post_url,
                type: request_method
            }).done(function (response) {
                if (response) {
                    modalIntify({
                        title: 'THÀNH CÔNG',
                        messenge: 'Xóa cụm rạp  ' + response.tenCum + '  thành công!'
                    });
                    $('#modal-tb').modal('show');
                    $('#modal-tb').click(function (e) {
                        if (e.target.closest('#modal-tb') || e.target.closest('xRemove')) {
                            location.reload();
                        }
                    });

                } else {
                    modalIntify({
        ");
                WriteLiteral(@"                title: 'THẤT BẠI',
                        messenge: 'Xóa cụm rạp thất bại!'
                    });
                    $('#modal-tb').modal('show');
                }
            });
        });
    </script>



    <script>
        $('#create-cumrap').submit(function (e) {
            e.preventDefault();
            const post_url = $(this).attr(""action"");
            const request_method = $(this).attr(""method"");
            const form_data = $(this).serialize();
            $.ajax({
                url: post_url,
                type: request_method,
                data: form_data
            }).done(function (response) {
                if (response) {
                    modalIntify({
                        title: 'Thông báo',
                        messenge: 'Thêm cụm rạp thành công!'
                    });
                    $('#modal-tb').modal('show');
                    $('#modal-tb').click(function (e) {
                        if (e.target.close");
                WriteLiteral(@"st('#modal-tb') || e.target.closest('xRemove')) {
                            location.reload();
                        }
                    });

                } else {
                    modalIntify({
                        title: 'Thông báo',
                        messenge: 'Thêm cụm rạp thất bại!'
                    });
                    $('#modal-tb').modal('show');
                }
            });
        });
    </script>

   

    <script>
        $('#edit-cumrap').submit(function (e) {
            e.preventDefault();
            const post_url = $(this).attr(""action"");
            const request_method = $(this).attr(""method"");
            const form_data = $(this).serialize();
            $.ajax({
                url: post_url,
                type: request_method,
                data: form_data
            }).done(function (response) {
                if (response) {
                    modalIntify({
                        title: 'Thông báo',
            ");
                WriteLiteral(@"            messenge: 'Chỉnh sửa cụm rạp thành công'
                    });
                    $('#modal-tb').modal('show');
                    $('#modal-tb').click(function (e) {
                        if (e.target.closest('#modal-tb') || e.target.closest('xRemove')) {
                            location.replace('../../../Admin/CumRap/Index');

                        }
                    });

                } else {
                    modalIntify({
                        title: 'Thông báo',
                        messenge: 'Chỉnh sửa cụm rạp thất bại'
                    });
                    $('#modal-tb').modal('show');
                }
            });
        });
    </script>





");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cinema.Areas.Admin.Models.CumRapModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
