<<<<<<< HEAD
#pragma checksum "E:\HK5_ASP.NET\CinemaSites\Cinema\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2203b68a7f47253488f75a365ddc0a9cb735276"
=======
#pragma checksum "F:\DOAN\ASP\CinemaSites\Cinema\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2203b68a7f47253488f75a365ddc0a9cb735276"
>>>>>>> 9d0fc5a3af840b352ca1f26dc0ed09dc1043136d
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
<<<<<<< HEAD
#line 1 "E:\HK5_ASP.NET\CinemaSites\Cinema\Views\_ViewImports.cshtml"
=======
#line 1 "F:\DOAN\ASP\CinemaSites\Cinema\Views\_ViewImports.cshtml"
>>>>>>> 9d0fc5a3af840b352ca1f26dc0ed09dc1043136d
using Cinema;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "E:\HK5_ASP.NET\CinemaSites\Cinema\Views\_ViewImports.cshtml"
=======
#line 2 "F:\DOAN\ASP\CinemaSites\Cinema\Views\_ViewImports.cshtml"
>>>>>>> 9d0fc5a3af840b352ca1f26dc0ed09dc1043136d
using Cinema.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2203b68a7f47253488f75a365ddc0a9cb735276", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88b38380ea0d4f64bad62cefdedd00944e4c52ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2203b68a7f47253488f75a365ddc0a9cb7352763190", async() => {
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 6 "E:\HK5_ASP.NET\CinemaSites\Cinema\Views\Shared\_Layout.cshtml"
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2203b68a7f47253488f75a365ddc0a9cb7352763181", async() => {
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 6 "F:\DOAN\ASP\CinemaSites\Cinema\Views\Shared\_Layout.cshtml"
>>>>>>> 9d0fc5a3af840b352ca1f26dc0ed09dc1043136d
Write(await Html.PartialAsync("_HeadPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
<<<<<<< HEAD
#line 7 "E:\HK5_ASP.NET\CinemaSites\Cinema\Views\Shared\_Layout.cshtml"
=======
#line 7 "F:\DOAN\ASP\CinemaSites\Cinema\Views\Shared\_Layout.cshtml"
>>>>>>> 9d0fc5a3af840b352ca1f26dc0ed09dc1043136d
Write(RenderSection("css", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    \r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2203b68a7f47253488f75a365ddc0a9cb7352764645", async() => {
                WriteLiteral("\r\n \r\n        ");
#nullable restore
#line 13 "E:\HK5_ASP.NET\CinemaSites\Cinema\Views\Shared\_Layout.cshtml"
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2203b68a7f47253488f75a365ddc0a9cb7352764630", async() => {
                WriteLiteral("\r\n \r\n        ");
#nullable restore
#line 13 "F:\DOAN\ASP\CinemaSites\Cinema\Views\Shared\_Layout.cshtml"
>>>>>>> 9d0fc5a3af840b352ca1f26dc0ed09dc1043136d
   Write(await Html.PartialAsync("_HeaderPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n       \r\n        ");
#nullable restore
<<<<<<< HEAD
#line 15 "E:\HK5_ASP.NET\CinemaSites\Cinema\Views\Shared\_Layout.cshtml"
=======
#line 15 "F:\DOAN\ASP\CinemaSites\Cinema\Views\Shared\_Layout.cshtml"
>>>>>>> 9d0fc5a3af840b352ca1f26dc0ed09dc1043136d
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
<<<<<<< HEAD
#line 16 "E:\HK5_ASP.NET\CinemaSites\Cinema\Views\Shared\_Layout.cshtml"
=======
#line 16 "F:\DOAN\ASP\CinemaSites\Cinema\Views\Shared\_Layout.cshtml"
>>>>>>> 9d0fc5a3af840b352ca1f26dc0ed09dc1043136d
   Write(await Html.PartialAsync("_FooterPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
#nullable restore
<<<<<<< HEAD
#line 18 "E:\HK5_ASP.NET\CinemaSites\Cinema\Views\Shared\_Layout.cshtml"
=======
#line 18 "F:\DOAN\ASP\CinemaSites\Cinema\Views\Shared\_Layout.cshtml"
>>>>>>> 9d0fc5a3af840b352ca1f26dc0ed09dc1043136d
Write(await Html.PartialAsync("_ScriptPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
<<<<<<< HEAD
#line 19 "E:\HK5_ASP.NET\CinemaSites\Cinema\Views\Shared\_Layout.cshtml"
=======
#line 19 "F:\DOAN\ASP\CinemaSites\Cinema\Views\Shared\_Layout.cshtml"
>>>>>>> 9d0fc5a3af840b352ca1f26dc0ed09dc1043136d
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
