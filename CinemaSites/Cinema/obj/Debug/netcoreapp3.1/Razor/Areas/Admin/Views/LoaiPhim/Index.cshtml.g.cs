#pragma checksum "D:\ASP\cinema\CinemaSites\CinemaSites\CinemaSites\Cinema\Areas\Admin\Views\LoaiPhim\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "127d629acba8da8dd8f9592297c5aa493604e5f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_LoaiPhim_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/LoaiPhim/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"127d629acba8da8dd8f9592297c5aa493604e5f6", @"/Areas/Admin/Views/LoaiPhim/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b65113a58e3e17bb2f9e308a8b7c6ffbab3d3a8e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_LoaiPhim_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cinema.Areas.Admin.Models.LoaiPhimModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\ASP\cinema\CinemaSites\CinemaSites\CinemaSites\Cinema\Areas\Admin\Views\LoaiPhim\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid mt-3\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "127d629acba8da8dd8f9592297c5aa493604e5f66025", async() => {
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
            WriteLiteral("\r\n</div>\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "127d629acba8da8dd8f9592297c5aa493604e5f67162", async() => {
                WriteLiteral("Làm mới");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
            WriteLiteral("\r\n</p>\r\n<div class=\"container-fluid mt-3\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "127d629acba8da8dd8f9592297c5aa493604e5f68963", async() => {
                WriteLiteral(@"
        <div class=""row align-items-center"">
            <div class=""col-auto"">
                <label for=""str"" class=""col-form-label"">Nhập từ khóa</label>
            </div>
            <div class=""col-auto"">
                <input type=""text"" name=""str"" id=""str"" class=""form-control"" ");
#nullable restore
#line 20 "D:\ASP\cinema\CinemaSites\CinemaSites\CinemaSites\Cinema\Areas\Admin\Views\LoaiPhim\Index.cshtml"
                                                                        Write(Context.Request.Query["str"] != "" ? ("value=" + Context.Request.Query["str"]) : null);

#line default
#line hidden
#nullable disable
                WriteLiteral(" >\r\n            </div>\r\n            \r\n            <div class=\"col-auto\">\r\n                <button class=\"btn btn-primary\" type=\"submit\">Tìm</button>\r\n            </div>\r\n        </div>\r\n        <div class=\"container-fluid mt-3\">\r\n            <h4>Có ");
#nullable restore
#line 28 "D:\ASP\cinema\CinemaSites\CinemaSites\CinemaSites\Cinema\Areas\Admin\Views\LoaiPhim\Index.cshtml"
               Write(((ICollection<LoaiPhimModel>)ViewBag.ListLoaiPhim).Count);

#line default
#line hidden
#nullable disable
                WriteLiteral(" loại phim</h4>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n   \r\n</div>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "D:\ASP\cinema\CinemaSites\CinemaSites\CinemaSites\Cinema\Areas\Admin\Views\LoaiPhim\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TenLoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 45 "D:\ASP\cinema\CinemaSites\CinemaSites\CinemaSites\Cinema\Areas\Admin\Views\LoaiPhim\Index.cshtml"
         foreach (LoaiPhimModel item in ViewBag.ListLoaiPhim)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "D:\ASP\cinema\CinemaSites\CinemaSites\CinemaSites\Cinema\Areas\Admin\Views\LoaiPhim\Index.cshtml"
               Write(item.TenLoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "127d629acba8da8dd8f9592297c5aa493604e5f613030", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "D:\ASP\cinema\CinemaSites\CinemaSites\CinemaSites\Cinema\Areas\Admin\Views\LoaiPhim\Index.cshtml"
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
            WriteLiteral("\r\n                    <button name=\"delete_loai\" class=\"btn btn-warning\" data-id=\"");
#nullable restore
#line 54 "D:\ASP\cinema\CinemaSites\CinemaSites\CinemaSites\Cinema\Areas\Admin\Views\LoaiPhim\Index.cshtml"
                                                                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Xóa</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 57 "D:\ASP\cinema\CinemaSites\CinemaSites\CinemaSites\Cinema\Areas\Admin\Views\LoaiPhim\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 61 "D:\ASP\cinema\CinemaSites\CinemaSites\CinemaSites\Cinema\Areas\Admin\Views\LoaiPhim\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <script>
        $('input[data-sucess=""create-loaiphim""]').click(function (e) {

            e.preventDefault();
            const post_url = $(""#create-loaiphim"").attr(""action"");
            const request_method = $(""#create-loaiphim"").attr(""method"");
            const form_data = $(""#create-loaiphim"").serialize();
            $.ajax({
                url: post_url,
                type: request_method,
                data: form_data
            }).done(function (response) {
                if (response) {
                    modalIntify({
                        title: 'THÀNH CÔNG',
                        messenge: 'Thêm loại phim thành công'
                    });
                    $('#modal-tb').modal('show');
                    $('#modal-tb').click(function (e) {
                        if (e.target.closest('#modal-tb') || e.target.closest('xRemove')) {
                            location.reload();
                        }
                    });

                } els");
                WriteLiteral(@"e {
                    modalIntify({
                        title: 'THẤT BẠI',
                        messenge: 'Thêm loại phim thất bại'
                    });
                    $('#modal-tb').modal('show');
                }
            });
        });
    </script>
    <script>
        $('input[data-sucess=""edit-loaiphim""]').click(function (e) {

            e.preventDefault();
            const post_url = $(""#edit-loaiphim"").attr(""action"");
            const request_method = $(""#edit-loaiphim"").attr(""method"");
            const form_data = $(""#edit-loaiphim"").serialize();
            $.ajax({
                url: post_url,
                type: request_method,
                data: form_data
            }).done(function (response) {
                if (response) {
                    modalIntify({
                        title: 'THÀNH CÔNG',
                        messenge: 'Sửa loại phim thành công'
                    });
                    $('#modal-tb').modal('show')");
                WriteLiteral(@";
                    $('#modal-tb').click(function (e) {
                        if (e.target.closest('#modal-tb') || e.target.closest('xRemove')) {
                            location.reload();
                        }
                    });

                } else {
                    modalIntify({
                        title: 'THẤT BẠI',
                        messenge: 'Sửa loại phim thất bại'
                    });
                    $('#modal-tb').modal('show');
                }
            });
        });
    </script>
    <script>
        $('button[name=delete_loai]').click(function () {
            var id = $(this).attr('data-id');
            $.ajax({
                method: ""DELETE"",
                url: ""../../../api/LoaiPhim_API/DeleteLoaiPhimModel/"" + id,
            })
                .done(function (reponse) {
                    if (response = !null) {
                        modalIntify({
                            title: 'Thông báo',
                 ");
                WriteLiteral(@"           messenge: 'Xóa thành công'
                        });
                        $('#modal-tb').modal('show');
                        $('#modal-tb').click(function (e) {
                            if (e.target.closest('#modal-tb') || e.target.closest('xRemove')) {
                                location.reload();
                            }
                        });

                    } else {
                        modalIntify({
                            title: 'Thông báo',
                            messenge: 'Xóa thất bại'
                        });
                        $('#modal-tb').modal('show');
                    }
                });

        })
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cinema.Areas.Admin.Models.LoaiPhimModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
