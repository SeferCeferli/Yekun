#pragma checksum "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Views\Shared\Components\VcFooter\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bb4d5ffe2d3ad5b29da79630e73431c8a92f6e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_VcFooter_Default), @"mvc.1.0.view", @"/Views/Shared/Components/VcFooter/Default.cshtml")]
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
#line 1 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Views\_ViewImports.cshtml"
using Final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Views\_ViewImports.cshtml"
using Final.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Views\_ViewImports.cshtml"
using Final.Services.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bb4d5ffe2d3ad5b29da79630e73431c8a92f6e9", @"/Views/Shared/Components/VcFooter/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ced6fc61e636d8bf11e8742b689f95aaf941104a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_VcFooter_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmFooter>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "About", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Advertisment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Sitemap", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Views\Shared\Components\VcFooter\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<footer>
    <!-- Footer Start -->
    <div class=""footer"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3"">
                    <div class=""widget"">
                        <h5 class=""widget-title"">ABOUT US</h5>
                        <div class=""widget_about"">
                            <p>");
#nullable restore
#line 15 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Views\Shared\Components\VcFooter\Default.cshtml"
                          Write(Model.Settings.Info);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <ul class=\"social-area\">\r\n");
#nullable restore
#line 17 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Views\Shared\Components\VcFooter\Default.cshtml"
                                 foreach (var item in Model.socials)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 671, "\"", 688, 1);
#nullable restore
#line 20 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Views\Shared\Components\VcFooter\Default.cshtml"
WriteAttributeValue("", 678, item.Link, 678, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 689, "\"", 706, 1);
#nullable restore
#line 20 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Views\Shared\Components\VcFooter\Default.cshtml"
WriteAttributeValue("", 696, item.Name, 696, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 707, "\"", 726, 1);
#nullable restore
#line 20 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Views\Shared\Components\VcFooter\Default.cshtml"
WriteAttributeValue("", 715, item.Color, 715, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 727, "\"", 797, 3);
            WriteAttributeValue("", 735, "color:", 735, 6, true);
#nullable restore
#line 20 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Views\Shared\Components\VcFooter\Default.cshtml"
WriteAttributeValue("", 741, item.Color, 741, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 752, ";width:40px;height:40px;display:inline-block;", 752, 45, true);
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("style", " style=\"", 801, "\"", 930, 5);
            WriteAttributeValue("", 809, "background:", 809, 11, true);
#nullable restore
#line 20 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Views\Shared\Components\VcFooter\Default.cshtml"
WriteAttributeValue("", 820, item.Background, 820, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 836, ";color:", 836, 7, true);
#nullable restore
#line 20 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Views\Shared\Components\VcFooter\Default.cshtml"
WriteAttributeValue("", 843, item.Color, 843, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 854, ";width:40px;height:40px;border-radius:50%;line-height:40px;text-align:center", 854, 76, true);
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 931, "\"", 949, 1);
#nullable restore
#line 20 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Views\Shared\Components\VcFooter\Default.cshtml"
WriteAttributeValue("", 939, item.Icon, 939, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a>\r\n                                    </li>\r\n");
#nullable restore
#line 22 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Views\Shared\Components\VcFooter\Default.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                            </ul>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3"">
                    <div class=""widget widget_tag_cloud"">
                        <h5 class=""widget-title"">TAGS</h5>
                        <div class=""tagcloud"">
");
#nullable restore
#line 33 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Views\Shared\Components\VcFooter\Default.cshtml"
                             foreach (var item in Model.Tags.Take(8))
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a>");
#nullable restore
#line 36 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Views\Shared\Components\VcFooter\Default.cshtml"
                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 37 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Views\Shared\Components\VcFooter\Default.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </div>
                <div class=""col-lg-3"">
                    <div class=""widget"">
                        <h5 class=""widget-title"">CONTACTS</h5>
                        <ul class=""contact_info_list"">
                            <li><i class=""fa fa-map-marker""></i> ");
#nullable restore
#line 46 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Views\Shared\Components\VcFooter\Default.cshtml"
                                                            Write(Model.Settings.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li><i class=\"fa fa-phone\"></i> ");
#nullable restore
#line 47 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Views\Shared\Components\VcFooter\Default.cshtml"
                                                       Write(Model.Settings.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li><i class=\"fa fa-envelope-o\"></i> ");
#nullable restore
#line 48 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Views\Shared\Components\VcFooter\Default.cshtml"
                                                            Write(Model.Settings.Email1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br> ");
#nullable restore
#line 48 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Views\Shared\Components\VcFooter\Default.cshtml"
                                                                                        Write(Model.Settings.Email2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                        </ul>
                    </div>
                </div>
                <div class=""col-lg-3"">
                    <div class=""widget widget_recent_post"">
                        <h5 class=""widget-title"">POPULAR NEWS</h5>
");
#nullable restore
#line 55 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Views\Shared\Components\VcFooter\Default.cshtml"
                         foreach (var item in Model.news.Take(2))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"Latest-post-list-wrap\" style=\"margin-bottom: 25px;\">\r\n                                <div class=\"Gallery\">\r\n                                    <div class=\"gallery-left\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1bb4d5ffe2d3ad5b29da79630e73431c8a92f6e914353", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2756, "~/Uploads/Images/", 2756, 17, true);
#nullable restore
#line 60 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Views\Shared\Components\VcFooter\Default.cshtml"
AddHtmlAttributeValue("", 2773, item.MainImage, 2773, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                    <div class=""gallery-body"">
                                        <div class=""details"">
                                            <div class=""post-meta-single"">
                                                <ul>
                                                    <li><i class=""fa fa-clock-o""></i>");
#nullable restore
#line 66 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Views\Shared\Components\VcFooter\Default.cshtml"
                                                                                Write(item.CreatedDate.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                </ul>\r\n                                            </div>\r\n                                            <h6 class=\"title\"><a href=\"blog-details.html\">");
#nullable restore
#line 69 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Views\Shared\Components\VcFooter\Default.cshtml"
                                                                                     Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></h6>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 74 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Views\Shared\Components\VcFooter\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"footer-bottom text-center\">\r\n                    <ul class=\"widget_nav_menu\">\r\n                        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bb4d5ffe2d3ad5b29da79630e73431c8a92f6e917971", async() => {
                WriteLiteral("About");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bb4d5ffe2d3ad5b29da79630e73431c8a92f6e919365", async() => {
                WriteLiteral("Advertisment");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bb4d5ffe2d3ad5b29da79630e73431c8a92f6e920766", async() => {
                WriteLiteral("Sitemap");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bb4d5ffe2d3ad5b29da79630e73431c8a92f6e922162", async() => {
                WriteLiteral("Contact");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                    </ul>\r\n                    <p>Copyright ??2021 Nextpage</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- Footer End -->\r\n</footer>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmFooter> Html { get; private set; }
    }
}
#pragma warning restore 1591
