#pragma checksum "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b33f24e26bb693f51dec97d9607d9d7e14fbcbca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Index), @"mvc.1.0.view", @"/Views/Movie/Index.cshtml")]
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
#line 1 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\_ViewImports.cshtml"
using WebProgrammingMovie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\_ViewImports.cshtml"
using WebProgrammingMovie.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
using WebProgrammingMovie.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b33f24e26bb693f51dec97d9607d9d7e14fbcbca", @"/Views/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7422cfb295da108120d5c08b49ae4abde604ee2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebProgrammingMovie.Models.MovieRating>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Rating", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 7 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
   ViewData["Title"] = "Create";
                Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""anime-details spad"">
    <div class=""container"">
        <div class=""anime__details__content"">
            <div class=""row"">
                <div class=""col-lg-3"">
                    <div class=""anime__details__pic set-bg"" data-setbg=""");
#nullable restore
#line 14 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
                                                                   Write(Model.movie.DetailPhotoURL);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <div class=\"comment\"><i class=\"fa fa-comments\"></i> ");
#nullable restore
#line 15 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
                                                                       Write(Model.movie.Rating.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"view\"><i class=\"fa fa-eye\"></i> ");
#nullable restore
#line 16 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
                                                               Write(Model.movie.View);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-9\">\r\n                    <div class=\"anime__details__text\">\r\n                        <div class=\"anime__details__title\">\r\n                            <h3>");
#nullable restore
#line 22 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
                           Write(Model.movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <span>");
#nullable restore
#line 23 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
                             Write(Model.movie.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </div>
                        <div class=""anime__details__rating"">
                            <div class=""rating"">
                                <a href=""#""><i class=""fa fa-star""></i></a>
                                <a href=""#""><i class=""fa fa-star""></i></a>
                                <a href=""#""><i class=""fa fa-star""></i></a>
                                <a href=""#""><i class=""fa fa-star""></i></a>
                                <a href=""#""><i class=""fa fa-star-half-o""></i></a>
                            </div>
                            <span>1.029 Votes</span>
                        </div>
                        <p>
                            ");
#nullable restore
#line 36 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
                       Write(Model.movie.Review);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </p>
                        <div class=""anime__details__widget"">
                            <div class=""row"">
                                <div class=""col-lg-6 col-md-6"">
                                    <ul>
                                        <li><span>");
#nullable restore
#line 42 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
                                             Write(Localizer["ReleaseDate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</span> ");
#nullable restore
#line 42 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
                                                                               Write(Model.movie.ReleaseDate.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                        <li><span>");
#nullable restore
#line 43 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
                                             Write(Localizer["Category"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</span> ");
#nullable restore
#line 43 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
                                                                            Write(Model.movie.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                        <li><span>");
#nullable restore
#line 44 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
                                             Write(Localizer["Views"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</span> ");
#nullable restore
#line 44 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
                                                                         Write(Model.movie.View);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                    </ul>\r\n                                </div>\r\n                                <div class=\"col-lg-6 col-md-6\">\r\n                                    <ul>\r\n                                        <li><span>");
#nullable restore
#line 49 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
                                             Write(Localizer["Score"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</span> ");
#nullable restore
#line 49 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
                                                                          Write((int)Model.RatingAvarage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                        <li><span>");
#nullable restore
#line 50 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
                                             Write(Localizer["IMDB"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</span> ");
#nullable restore
#line 50 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
                                                                        Write(Model.movie.IMDB);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                        <li><span>");
#nullable restore
#line 51 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
                                             Write(Localizer["Duration"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</span> ");
#nullable restore
#line 51 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
                                                                            Write(Model.movie.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Saat</li>

                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class=""anime__details__btn"">
                            <a href=""#"" class=""follow-btn""><i class=""fa fa-heart-o""></i> Follow</a>
                            <a href=""#"" class=""watch-btn"">
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-8 col-md-8"">
                <div class=""anime__details__review"">
                    <div class=""section-title"">
                        <h5>");
#nullable restore
#line 70 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
                       Write(Localizer["Comments"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    </div>\r\n");
#nullable restore
#line 72 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
                     foreach (var item in Model.ratinganduser)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"anime__review__item\">\r\n            <div class=\"anime__review__item__pic\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 3954, "\"", 3979, 1);
#nullable restore
#line 76 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
WriteAttributeValue("", 3960, item.user.PhotoURL, 3960, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3980, "\"", 3986, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n            <div class=\"anime__review__item__text\">\r\n                <h6>");
#nullable restore
#line 79 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
               Write(item.user.AdSoyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>   ");
#nullable restore
#line 79 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
                                          Write(item.rating.CommentDate.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h6>\r\n                <p>\r\n                    ");
#nullable restore
#line 81 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
               Write(item.rating.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n\r\n\r\n            </div>\r\n\r\n            <div>\r\n                <h6 style=\"color:white\">Puan: ");
#nullable restore
#line 88 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
                                         Write(item.rating.Score);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span></span></h6>\r\n            </div>\r\n            <div class=\"thumbnail\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 4442, "\"", 4449, 0);
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </div>\r\n        </div>");
#nullable restore
#line 93 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n");
#nullable restore
#line 97 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
                 if (User.IsInRole("Uye"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b33f24e26bb693f51dec97d9607d9d7e14fbcbca15871", async() => {
                WriteLiteral("Yorum Yap");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 99 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
                                                     WriteLiteral(Model.movie.Id);

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
#nullable restore
#line 99 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
                                                                                               }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


            </div>
            <div class=""col-lg-4"">
                <div class=""trending__product"">
                    <div class=""row"">
                        <div class=""col-lg-12"">
                            <div class=""section-title"">
                                <h4>");
#nullable restore
#line 109 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
                               Write(Localizer["Actors"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                            </div>
                        </div>

                    </div>
                    <section class=""hero"">
                        <div class=""container"">
                            <div class=""hero__slider owl-carousel"">
");
#nullable restore
#line 117 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
                                   foreach (var item in Model.movie.Actor)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"hero__items set-bg\" data-setbg=\"");
#nullable restore
#line 119 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
                                                               Write(item.PhotoURL);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                            <div class=\"row\">\r\n                                <div class=\"col-lg-6\">\r\n                                    <div class=\"hero__text\">\r\n                                        <div class=\"label\">");
#nullable restore
#line 123 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
                                                      Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                        <h2></h2>\r\n                                        <h2>");
#nullable restore
#line 125 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
                                       Write(item.ActorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                        <i class=\"fa fa-angle-right\"></i>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div> ");
#nullable restore
#line 130 "D:\Projects\.Net\ASP.NET-Core-5.0-MVC-Project\Views\Movie\Index.cshtml"
                               } 

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </section>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- Anime Section End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebProgrammingMovie.Models.MovieRating> Html { get; private set; }
    }
}
#pragma warning restore 1591
