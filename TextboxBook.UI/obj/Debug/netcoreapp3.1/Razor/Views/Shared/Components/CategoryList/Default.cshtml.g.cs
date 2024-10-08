#pragma checksum "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Shared\Components\CategoryList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "485fd3c90c01e17afc2abd0652517fabd095dfda4fb56f774f9185cf91ee615f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"485fd3c90c01e17afc2abd0652517fabd095dfda4fb56f774f9185cf91ee615f", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6228a790433c0cd72032ec024d0d94fa7a948fc6bd05bbc6074cf11a846bd008", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_CategoryList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TextboxBook.UI.Models.CategoryListViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Shared\Components\CategoryList\Default.cshtml"
  

    if (User.IsInRole("User") | !User.Identity.IsAuthenticated)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <div class=\"list-group\">\r\n\r\n\r\n\r\n");
#nullable restore
#line 12 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Shared\Components\CategoryList\Default.cshtml"
             foreach (var category in Model.categoryList)
            {
                var css = "list-group-item";
                if (category.Id == Model.currentCategory)
                {
                    css += " active";
                }

#line default
#line hidden
#nullable disable

            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 448, "\"", 491, 2);
            WriteAttributeValue("", 455, "/book/listbook?category=", 455, 24, true);
            WriteAttributeValue("", 479, 
#nullable restore
#line 19 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Shared\Components\CategoryList\Default.cshtml"
                                                  category.Id

#line default
#line hidden
#nullable disable
            , 479, 12, false);
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 492, "\"", 516, 2);
            WriteAttributeValue("", 500, 
#nullable restore
#line 19 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Shared\Components\CategoryList\Default.cshtml"
                                                                       css

#line default
#line hidden
#nullable disable
            , 500, 4, false);
            WriteAttributeValue(" ", 504, "border-info", 505, 12, true);
            EndWriteAttribute();
            WriteLiteral(">");
            Write(
#nullable restore
#line 19 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Shared\Components\CategoryList\Default.cshtml"
                                                                                         category.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</a>\r\n");
#nullable restore
#line 20 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Shared\Components\CategoryList\Default.cshtml"
            }

#line default
#line hidden
#nullable disable

            WriteLiteral("            <a href=\"/book/listbook?category=0\" class=\"list-group-item border-info\">All</a>\r\n        </div>\r\n");
#nullable restore
#line 23 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Shared\Components\CategoryList\Default.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <div class=\"list-group\">\r\n\r\n");
#nullable restore
#line 28 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Shared\Components\CategoryList\Default.cshtml"
             foreach (var category in Model.categoryList)
            {
                var css = "list-group-item";
                if (category.Id == Model.currentCategory)
                {
                    css += " active";
                }

#line default
#line hidden
#nullable disable

            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 996, "\"", 1040, 2);
            WriteAttributeValue("", 1003, "/admin/listbook?category=", 1003, 25, true);
            WriteAttributeValue("", 1028, 
#nullable restore
#line 35 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Shared\Components\CategoryList\Default.cshtml"
                                                   category.Id

#line default
#line hidden
#nullable disable
            , 1028, 12, false);
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 1041, "\"", 1065, 2);
            WriteAttributeValue("", 1049, 
#nullable restore
#line 35 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Shared\Components\CategoryList\Default.cshtml"
                                                                        css

#line default
#line hidden
#nullable disable
            , 1049, 4, false);
            WriteAttributeValue(" ", 1053, "border-info", 1054, 12, true);
            EndWriteAttribute();
            WriteLiteral(">");
            Write(
#nullable restore
#line 35 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Shared\Components\CategoryList\Default.cshtml"
                                                                                          category.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</a>\r\n");
#nullable restore
#line 36 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Shared\Components\CategoryList\Default.cshtml"
            }

#line default
#line hidden
#nullable disable

            WriteLiteral("            <a href=\"/admin/listbook?category=0\" class=\"list-group-item border-info\">All</a>\r\n        </div>\r\n");
#nullable restore
#line 39 "C:\Users\Mehmet\Desktop\TextboxBook\TextboxBook.UI\Views\Shared\Components\CategoryList\Default.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TextboxBook.UI.Models.CategoryListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
