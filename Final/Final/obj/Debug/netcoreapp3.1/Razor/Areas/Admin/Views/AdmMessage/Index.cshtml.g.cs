#pragma checksum "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Areas\Admin\Views\AdmMessage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "936d2d5134f7e3bc9b24a90182809a5f02734e47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdmMessage_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AdmMessage/Index.cshtml")]
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
#line 1 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Areas\Admin\Views\_ViewImports.cshtml"
using Final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Areas\Admin\Views\_ViewImports.cshtml"
using Final.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Areas\Admin\Views\_ViewImports.cshtml"
using Final.Services.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"936d2d5134f7e3bc9b24a90182809a5f02734e47", @"/Areas/Admin/Views/AdmMessage/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ced6fc61e636d8bf11e8742b689f95aaf941104a", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdmMessage_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Areas\Admin\Views\AdmMessage\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h2 class=""intro-y text-lg font-medium mt-10"">
    Tags
</h2>
<div class=""grid grid-cols-12 gap-6 mt-5"">
    <div class=""intro-y col-span-12 flex flex-wrap sm:flex-no-wrap items-center mt-2"">
        <div class=""dropdown relative"">
            <button class=""dropdown-toggle button px-2 box text-gray-700"">
                <span class=""w-5 h-5 flex items-center justify-center""> <i class=""w-4 h-4"" data-feather=""plus""></i> </span>
            </button>
            <div class=""dropdown-box mt-10 absolute w-40 top-0 left-0 z-20"">
                <div class=""dropdown-box__content box p-2"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 690, "\"", 697, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"flex items-center block p-2 transition duration-300 ease-in-out bg-white hover:bg-gray-200 rounded-md\"> <i data-feather=\"printer\" class=\"w-4 h-4 mr-2\"></i> Print </a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 896, "\"", 903, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"flex items-center block p-2 transition duration-300 ease-in-out bg-white hover:bg-gray-200 rounded-md\"> <i data-feather=\"file-text\" class=\"w-4 h-4 mr-2\"></i> Export to Excel </a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1114, "\"", 1121, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""flex items-center block p-2 transition duration-300 ease-in-out bg-white hover:bg-gray-200 rounded-md""> <i data-feather=""file-text"" class=""w-4 h-4 mr-2""></i> Export to PDF </a>
                </div>
            </div>
        </div>
        <div class=""hidden md:block mx-auto text-gray-600"">Showing 1 to 10 of 150 entries</div>
        <div class=""w-full sm:w-auto mt-3 sm:mt-0 sm:ml-auto md:ml-0"">
            <div class=""w-56 relative text-gray-700"">
                <input type=""text"" class=""input w-56 box pr-10 placeholder-theme-13"" placeholder=""Search..."">
                <i class=""w-4 h-4 absolute my-auto inset-y-0 mr-3 right-0"" data-feather=""search""></i>
            </div>
        </div>
    </div>
    <!-- BEGIN: Data List -->
    <div class=""intro-y col-span-12 overflow-auto lg:overflow-visible"">
        <table class=""table table-report -mt-2"">
            <thead>
                <tr>
                    <th class=""whitespace-no-wrap"">#</th>
                    <th class=""white");
            WriteLiteral(@"space-no-wrap"">NAME</th>
                    <th class=""whitespace-no-wrap"">Email</th>
                    <th class=""whitespace-no-wrap"">Text</th>
                    <th class=""text-center whitespace-no-wrap"">ACTIONS</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 45 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Areas\Admin\Views\AdmMessage\Index.cshtml"
                  int i = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Areas\Admin\Views\AdmMessage\Index.cshtml"
                 foreach (var item in Model)
                {
                    i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"intro-x\">\r\n                        <td>\r\n                            ");
#nullable restore
#line 51 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Areas\Admin\Views\AdmMessage\Index.cshtml"
                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">");
#nullable restore
#line 53 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Areas\Admin\Views\AdmMessage\Index.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">");
#nullable restore
#line 54 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Areas\Admin\Views\AdmMessage\Index.cshtml"
                                           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">");
#nullable restore
#line 55 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Areas\Admin\Views\AdmMessage\Index.cshtml"
                                           Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">");
#nullable restore
#line 56 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Areas\Admin\Views\AdmMessage\Index.cshtml"
                                           Write(item.CreatedDate.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 58 "C:\Users\kerim\Dropbox\My PC (LAPTOP-I6SA5SMH)\Desktop\Final Asp\Yekun\Final\Final\Areas\Admin\Views\AdmMessage\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            </tbody>
        </table>
    </div>
    <!-- END: Data List -->
    <!-- BEGIN: Pagination -->
    <!-- END: Pagination -->
</div>
<!-- BEGIN: Delete Confirmation Modal -->
<div class=""modal"" id=""delete-confirmation-modal"">
    <div class=""modal__content"">
        <div class=""p-5 text-center"">
            <i data-feather=""x-circle"" class=""w-16 h-16 text-theme-6 mx-auto mt-3""></i>
            <div class=""text-3xl mt-5"">Are you sure?</div>
            <div class=""text-gray-600 mt-2"">Do you really want to delete these records? This process cannot be undone.</div>
        </div>
        <div class=""px-5 pb-8 text-center"">
            <button type=""button"" data-dismiss=""modal"" class=""button w-24 border text-gray-700 mr-1"">Cancel</button>
            <button type=""button"" class=""button w-24 bg-theme-6 text-white"">Delete</button>
        </div>
    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message>> Html { get; private set; }
    }
}
#pragma warning restore 1591
