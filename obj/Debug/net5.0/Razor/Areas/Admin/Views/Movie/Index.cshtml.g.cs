#pragma checksum "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6caa4abfb8cbda4f38423ba1f2a7cc2b87b1f90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Movie_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Movie/Index.cshtml")]
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
#line 1 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\_ViewImports.cshtml"
using WebProgrammingMovie.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\_ViewImports.cshtml"
using WebProgrammingMovie.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\_ViewImports.cshtml"
using WebProgrammingMovie.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\_ViewImports.cshtml"
using WebProgrammingMovie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6caa4abfb8cbda4f38423ba1f2a7cc2b87b1f90", @"/Areas/Admin/Views/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0bd7a275966d9f8a04f66af5d793210657c58eb", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebProgrammingMovie.Models.Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:cornflowerblue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: cornflowerblue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
   ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h3 style=\"color:white\">");
#nullable restore
#line 8 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
                   Write(Localizer["Movie"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6caa4abfb8cbda4f38423ba1f2a7cc2b87b1f906908", async() => {
#nullable restore
#line 11 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
                                                   Write(SharedLocalizer["Create"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th style=\"color:white\">\r\n                ");
#nullable restore
#line 17 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
           Write(Localizer["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style=\"color:white\">\r\n                ");
#nullable restore
#line 20 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
           Write(Localizer["Review"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style=\"color:white\">\r\n                ");
#nullable restore
#line 23 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
           Write(Localizer["View"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style=\"color:white\">\r\n                ");
#nullable restore
#line 26 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
           Write(Localizer["Category"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style=\"color:white\">\r\n                ");
#nullable restore
#line 29 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
           Write(Localizer["Director"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style=\"color:white\">\r\n                ");
#nullable restore
#line 32 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
           Write(Localizer["SliderPhoto"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style=\"color:white\">\r\n                ");
#nullable restore
#line 35 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
           Write(Localizer["DetailPhoto"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style=\"color:white\">\r\n                ");
#nullable restore
#line 38 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
           Write(Localizer["ReleaseDate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style=\"color:white\">\r\n                ");
#nullable restore
#line 41 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
           Write(Localizer["Duration"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style=\"color:white\">\r\n                ");
#nullable restore
#line 44 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IMDB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style=\"color:white\">\r\n                ");
#nullable restore
#line 47 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
           Write(Localizer["Country"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 53 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td style=\"color:white\">\r\n        ");
#nullable restore
#line 57 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td style=\"color:white\">\r\n        ");
#nullable restore
#line 60 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Review));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td style=\"color:white\">\r\n        ");
#nullable restore
#line 63 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.View));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td style=\"color:white\">\r\n        ");
#nullable restore
#line 66 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td style=\"color:white\">\r\n        ");
#nullable restore
#line 69 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Director.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td style=\"color:white\">\r\n        ");
#nullable restore
#line 72 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.SliderPhotoURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td style=\"color:white\">\r\n        ");
#nullable restore
#line 75 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.DetailPhotoURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td style=\"color:white\">\r\n        ");
#nullable restore
#line 78 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td style=\"color:white\">\r\n        ");
#nullable restore
#line 81 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td style=\"color:white\">\r\n        ");
#nullable restore
#line 84 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.IMDB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td style=\"color:white\">\r\n        ");
#nullable restore
#line 87 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6caa4abfb8cbda4f38423ba1f2a7cc2b87b1f9016849", async() => {
#nullable restore
#line 90 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
                                                                              Write(SharedLocalizer["Edit"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
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
            WriteLiteral(" |\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6caa4abfb8cbda4f38423ba1f2a7cc2b87b1f9019445", async() => {
#nullable restore
#line 91 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
                                                                                 Write(SharedLocalizer["Detail"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
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
            WriteLiteral(" |\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6caa4abfb8cbda4f38423ba1f2a7cc2b87b1f9022049", async() => {
#nullable restore
#line 92 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
                                                                                Write(SharedLocalizer["Delete"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
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
            WriteLiteral("\r\n    </td>\r\n</tr>");
#nullable restore
#line 94 "C:\Users\MuhammetÇağatay\Desktop\Ödevler\web-programming\Web-Programlama\WebProgrammingMovie\Areas\Admin\Views\Movie\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<CommonResources> SharedLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebProgrammingMovie.Models.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
