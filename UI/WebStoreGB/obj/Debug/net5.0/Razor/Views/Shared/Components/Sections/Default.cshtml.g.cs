#pragma checksum "E:\GeekBrains\ASP 01\WebStoreGB\UI\WebStoreGB\Views\Shared\Components\Sections\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1da73aa23941b0ac8a6697d3eb07f57a3bd890ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Sections_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Sections/Default.cshtml")]
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
#line 1 "E:\GeekBrains\ASP 01\WebStoreGB\UI\WebStoreGB\Views\_ViewImports.cshtml"
using WebStoreGB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\GeekBrains\ASP 01\WebStoreGB\UI\WebStoreGB\Views\_ViewImports.cshtml"
using WebStoreGB.Domain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\GeekBrains\ASP 01\WebStoreGB\UI\WebStoreGB\Views\_ViewImports.cshtml"
using WebStoreGB.Domain.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1da73aa23941b0ac8a6697d3eb07f57a3bd890ab", @"/Views/Shared/Components/Sections/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6372623376a06a5d98093964a4bb08040c4691ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Sections_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SectionViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Catalog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<h2>??????????????????</h2>\r\n<div class=\"panel-group category-products\" id=\"accordian\">\r\n    <!--category-productsr-->\r\n\r\n");
#nullable restore
#line 7 "E:\GeekBrains\ASP 01\WebStoreGB\UI\WebStoreGB\Views\Shared\Components\Sections\Default.cshtml"
     foreach (var parent_section in Model)
    {
        if (parent_section.ChildSections.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"panel panel-default\">\r\n                    <div class=\"panel-heading\">\r\n                        <h4 class=\"panel-title\">\r\n                            <a data-toggle=\"collapse\" data-parent=\"#accordian\"");
            BeginWriteAttribute("href", " href=\"", 496, "\"", 533, 2);
            WriteAttributeValue("", 503, "#", 503, 1, true);
#nullable restore
#line 14 "E:\GeekBrains\ASP 01\WebStoreGB\UI\WebStoreGB\Views\Shared\Components\Sections\Default.cshtml"
WriteAttributeValue("", 504, parent_section.GetHashCode(), 504, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <span class=\"badge pull-right\"><i class=\"fa fa-plus\"></i></span>\r\n                                ");
#nullable restore
#line 16 "E:\GeekBrains\ASP 01\WebStoreGB\UI\WebStoreGB\Views\Shared\Components\Sections\Default.cshtml"
                           Write(parent_section.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                        </h4>\r\n                    </div>\r\n                    <div");
            BeginWriteAttribute("id", " id=\"", 806, "\"", 840, 1);
#nullable restore
#line 20 "E:\GeekBrains\ASP 01\WebStoreGB\UI\WebStoreGB\Views\Shared\Components\Sections\Default.cshtml"
WriteAttributeValue("", 811, parent_section.GetHashCode(), 811, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"panel-collapse collapse\">\r\n                        <div class=\"panel-body\">\r\n                            <ul>\r\n");
#nullable restore
#line 23 "E:\GeekBrains\ASP 01\WebStoreGB\UI\WebStoreGB\Views\Shared\Components\Sections\Default.cshtml"
                                 foreach (var child_section in parent_section.ChildSections)
                                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                     <li>\r\n                                         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1da73aa23941b0ac8a6697d3eb07f57a3bd890ab6589", async() => {
                WriteLiteral("\r\n                                            ");
#nullable restore
#line 29 "E:\GeekBrains\ASP 01\WebStoreGB\UI\WebStoreGB\Views\Shared\Components\Sections\Default.cshtml"
                                       Write(child_section.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                                         ");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-SectionId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "E:\GeekBrains\ASP 01\WebStoreGB\UI\WebStoreGB\Views\Shared\Components\Sections\Default.cshtml"
                                                     WriteLiteral(child_section.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["SectionId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-SectionId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["SectionId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                     </li>\r\n");
#nullable restore
#line 32 "E:\GeekBrains\ASP 01\WebStoreGB\UI\WebStoreGB\Views\Shared\Components\Sections\Default.cshtml"
                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 37 "E:\GeekBrains\ASP 01\WebStoreGB\UI\WebStoreGB\Views\Shared\Components\Sections\Default.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"panel panel-default\">\r\n                    <div class=\"panel-heading\">\r\n                        <h4 class=\"panel-title\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1da73aa23941b0ac8a6697d3eb07f57a3bd890ab10217", async() => {
                WriteLiteral("\r\n                            ");
#nullable restore
#line 44 "E:\GeekBrains\ASP 01\WebStoreGB\UI\WebStoreGB\Views\Shared\Components\Sections\Default.cshtml"
                       Write(parent_section.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-SectionId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "E:\GeekBrains\ASP 01\WebStoreGB\UI\WebStoreGB\Views\Shared\Components\Sections\Default.cshtml"
                                                                                WriteLiteral(parent_section.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["SectionId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-SectionId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["SectionId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h4>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 48 "E:\GeekBrains\ASP 01\WebStoreGB\UI\WebStoreGB\Views\Shared\Components\Sections\Default.cshtml"
        }
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><!--/category-products-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SectionViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
