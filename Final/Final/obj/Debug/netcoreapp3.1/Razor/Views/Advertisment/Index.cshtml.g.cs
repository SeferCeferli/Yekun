#pragma checksum "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Final\Final\Views\Advertisment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4cc0105f04122c91c06f50138dae18ee57b22ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Advertisment_Index), @"mvc.1.0.view", @"/Views/Advertisment/Index.cshtml")]
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
#line 1 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Final\Final\Views\_ViewImports.cshtml"
using Final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Final\Final\Views\_ViewImports.cshtml"
using Final.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Final\Final\Views\_ViewImports.cshtml"
using Final.Services.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4cc0105f04122c91c06f50138dae18ee57b22ae", @"/Views/Advertisment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ced6fc61e636d8bf11e8742b689f95aaf941104a", @"/Views/_ViewImports.cshtml")]
    public class Views_Advertisment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Advertisment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Assets/image/reklam5.jpeg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Final\Final\Views\Advertisment\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Page Title Start -->
<section id=""Page-Title"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""breadcrumb-inner"">
                    <h5 class=""page-title"">Advertisment</h5>
                    <ul class=""page-list"">
                        <li><a href=""index.html"">Home</a></li>
                        <li>Advertisment</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Page Title End -->
<!-- Advertisment Start -->
<section id=""Advertisment"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3"">
                <div class=""media"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d4cc0105f04122c91c06f50138dae18ee57b22ae5124", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-6\">\r\n                <div class=\"page advertise\">\r\n");
#nullable restore
#line 34 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Final\Final\Views\Advertisment\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h1>");
#nullable restore
#line 36 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Final\Final\Views\Advertisment\Index.cshtml"
                       Write(Html.Raw(item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <p>\r\n                            ");
#nullable restore
#line 38 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Final\Final\Views\Advertisment\Index.cshtml"
                       Write(Html.Raw(item.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n");
#nullable restore
#line 40 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Final\Final\Views\Advertisment\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-3\">\r\n                <div class=\"media\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d4cc0105f04122c91c06f50138dae18ee57b22ae7746", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- Advertisment End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Advertisment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
