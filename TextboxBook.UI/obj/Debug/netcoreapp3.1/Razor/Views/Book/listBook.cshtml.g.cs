#pragma checksum "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Book\listBook.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "805ee713a6f69107d29f88d079fcbd786b4fa772f84958876f6388ffb323430d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_listBook), @"mvc.1.0.view", @"/Views/Book/listBook.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"805ee713a6f69107d29f88d079fcbd786b4fa772f84958876f6388ffb323430d", @"/Views/Book/listBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6228a790433c0cd72032ec024d0d94fa7a948fc6bd05bbc6074cf11a846bd008", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Book_listBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TextboxBook.UI.Models.BookListViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/BookList.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-xs btn-primary col-md-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddCartItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::TextboxEBook.UI.TagHelpers.PaggingTagHelpers __TextboxEBook_UI_TagHelpers_PaggingTagHelpers;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Book\listBook.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "805ee713a6f69107d29f88d079fcbd786b4fa772f84958876f6388ffb323430d6683", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-2\">\r\n            ");
            Write(
#nullable restore
#line 13 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Book\listBook.cshtml"
             await Component.InvokeAsync("CategoryList")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"
        </div>
        <div class=""col-md-10 mx-auto"">
            <table class=""table table-hover"">
                <thead>
                    <tr>
                        <th scope=""col"" class=""listebasligi text-center"">Id</th>
                        <th scope=""col"" class=""listebasligi text-center"">İmg</th>
                        <th scope=""col"" class=""listebasligi text-center"">Book Name</th>
                        <th scope=""col"" class=""listebasligi text-center"">Author</th>
                        <th scope=""col"" class=""listebasligi text-center"">Category</th>
                        <th scope=""col"" class=""listebasligi text-center"">Year</th>
                        <th scope=""col"" class=""listebasligi text-center"">Publisher</th>
                        <th scope=""col"" class=""listebasligi text-center"">Languages</th>
                        <th scope=""col"" class=""listebasligi text-center"">Unit Price</th>
                        <th scope=""col"" class=""listebasligi text-center"">Information</t");
            WriteLiteral("h>\r\n");
#nullable restore
#line 29 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Book\listBook.cshtml"
                         if (User.Identity.IsAuthenticated && User.IsInRole("User"))
                        {

#line default
#line hidden
#nullable disable

            WriteLiteral("                            <th scope=\"col\" class=\"listebasligi text-center\">AddtoCart</th>\r\n");
#nullable restore
#line 32 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Book\listBook.cshtml"

                        }

#line default
#line hidden
#nullable disable

            WriteLiteral("                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Book\listBook.cshtml"
                     foreach (var item in Model.Book)
                    {

#line default
#line hidden
#nullable disable

            WriteLiteral("                        <tr>\r\n                            <td class=\"align-middle\">\r\n                                <p class=\"listeyazisi\">");
            Write(
#nullable restore
#line 41 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Book\listBook.cshtml"
                                                        item.Id

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                            </td>\r\n                            <td class=\"align-middle\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 2042, "\"", 2061, 1);
            WriteAttributeValue("", 2048, 
#nullable restore
#line 44 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Book\listBook.cshtml"
                                           item.BookImg

#line default
#line hidden
#nullable disable
            , 2048, 13, false);
            EndWriteAttribute();
            WriteLiteral(" width=\"64\" class=\"img-fluid bookimg\" />\r\n                            </td>\r\n                            <td class=\"align-middle\">\r\n                                <p class=\"listeyazisi text-center\">");
            Write(
#nullable restore
#line 47 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Book\listBook.cshtml"
                                                                    item.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                            </td>\r\n                            <td class=\"align-middle\">\r\n                                <p class=\"listeyazisi text-center\">");
            Write(
#nullable restore
#line 50 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Book\listBook.cshtml"
                                                                    item.Author.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                            </td>\r\n                            <td class=\"align-middle\">\r\n                                <p class=\"listeyazisi text-center\">");
            Write(
#nullable restore
#line 53 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Book\listBook.cshtml"
                                                                    item.Category.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                            </td>\r\n                            <td class=\"align-middle\">\r\n                                <p class=\"listeyazisi text-center\">");
            Write(
#nullable restore
#line 56 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Book\listBook.cshtml"
                                                                    item.ProductionDate.ToString()

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                            </td>\r\n                            <td class=\"align-middle\">\r\n                                <p class=\"listeyazisi text-center\">");
            Write(
#nullable restore
#line 59 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Book\listBook.cshtml"
                                                                    item.Publisher.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                            </td>\r\n                            <td class=\"align-middle\">\r\n                                <p class=\"listeyazisi text-center\">");
            Write(
#nullable restore
#line 62 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Book\listBook.cshtml"
                                                                    item.Language.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                            </td>\r\n                            <td class=\"align-middle\">\r\n                                <p class=\"listeyazisi text-center\">");
            Write(
#nullable restore
#line 65 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Book\listBook.cshtml"
                                                                    item.UnitPrice.ToString()

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                            </td>\r\n                            <td class=\"align-middle\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "805ee713a6f69107d29f88d079fcbd786b4fa772f84958876f6388ffb323430d15020", async() => {
                WriteLiteral(" Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 68 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Book\listBook.cshtml"
                                                                                            item.Id

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 68 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Book\listBook.cshtml"
                                                                                                                            item.Category.Id

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CategoryId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-CategoryId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CategoryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n");
#nullable restore
#line 70 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Book\listBook.cshtml"
                             if (User.Identity.IsAuthenticated && User.IsInRole("User"))
                            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                                <td class=\"align-middle\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "805ee713a6f69107d29f88d079fcbd786b4fa772f84958876f6388ffb323430d18854", async() => {
                WriteLiteral("\r\n                                        <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 4064, "\"", 4080, 1);
                WriteAttributeValue("", 4072, 
#nullable restore
#line 74 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Book\listBook.cshtml"
                                                                               item.Id

#line default
#line hidden
#nullable disable
                , 4072, 8, false);
                EndWriteAttribute();
                WriteLiteral(@" />
                                        <input class=""form-control"" type=""number"" name=""quantity"" value=""1"" min=""1"" step=""1"" />
                                        <button type=""submit"" class=""btn text-white"" style=""background-color: #FF8800""> AddToCart</button>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n");
#nullable restore
#line 79 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Book\listBook.cshtml"
                            }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 83 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Book\listBook.cshtml"
                    }

#line default
#line hidden
#nullable disable

            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"mx-auto\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("product-list-pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "805ee713a6f69107d29f88d079fcbd786b4fa772f84958876f6388ffb323430d22284", async() => {
            }
            );
            __TextboxEBook_UI_TagHelpers_PaggingTagHelpers = CreateTagHelper<global::TextboxEBook.UI.TagHelpers.PaggingTagHelpers>();
            __tagHelperExecutionContext.Add(__TextboxEBook_UI_TagHelpers_PaggingTagHelpers);
            __TextboxEBook_UI_TagHelpers_PaggingTagHelpers.CurrentCategory = 
#nullable restore
#line 91 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Book\listBook.cshtml"
                                                   Model.CurrentCategory

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("current-category", __TextboxEBook_UI_TagHelpers_PaggingTagHelpers.CurrentCategory, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __TextboxEBook_UI_TagHelpers_PaggingTagHelpers.CurrentPage = 
#nullable restore
#line 92 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Book\listBook.cshtml"
                                               Model.CurrentPage

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("current-page", __TextboxEBook_UI_TagHelpers_PaggingTagHelpers.CurrentPage, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __TextboxEBook_UI_TagHelpers_PaggingTagHelpers.PageCount = 
#nullable restore
#line 93 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Book\listBook.cshtml"
                                             Model.PageCount

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("page-count", __TextboxEBook_UI_TagHelpers_PaggingTagHelpers.PageCount, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __TextboxEBook_UI_TagHelpers_PaggingTagHelpers.PageSize = 
#nullable restore
#line 94 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Book\listBook.cshtml"
                                            Model.PageSize

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("page-size", __TextboxEBook_UI_TagHelpers_PaggingTagHelpers.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TextboxBook.UI.Models.BookListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
