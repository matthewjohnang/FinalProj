#pragma checksum "C:\Users\Ang\Desktop\TMS\FINAL PROJ\FinalProj\FinalProj\Views\Feedbacks\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbc002fbb7bdcadb58873de3cd6d22ef53c997e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Feedbacks_List), @"mvc.1.0.view", @"/Views/Feedbacks/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Feedbacks/List.cshtml", typeof(AspNetCore.Views_Feedbacks_List))]
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
#line 1 "C:\Users\Ang\Desktop\TMS\FINAL PROJ\FinalProj\FinalProj\Views\_ViewImports.cshtml"
using FinalProj;

#line default
#line hidden
#line 2 "C:\Users\Ang\Desktop\TMS\FINAL PROJ\FinalProj\FinalProj\Views\_ViewImports.cshtml"
using FinalProj.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbc002fbb7bdcadb58873de3cd6d22ef53c997e5", @"/Views/Feedbacks/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7e219eab7baa6aa2e333b6ae739d3c200988b83", @"/Views/_ViewImports.cshtml")]
    public class Views_Feedbacks_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FinalProj.Models.Feedback>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Ang\Desktop\TMS\FINAL PROJ\FinalProj\FinalProj\Views\Feedbacks\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(136, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\Ang\Desktop\TMS\FINAL PROJ\FinalProj\FinalProj\Views\Feedbacks\List.cshtml"
   int rowNo = 0; 

#line default
#line hidden
            BeginContext(159, 226, true);
            WriteLiteral("\r\n<br />\r\n<center><h1>Received Messages</h1></center>\r\n<hr />\r\n<br />\r\n\r\n<br />\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Number\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(386, 41, false);
#line 23 "C:\Users\Ang\Desktop\TMS\FINAL PROJ\FinalProj\FinalProj\Views\Feedbacks\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(427, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(483, 40, false);
#line 26 "C:\Users\Ang\Desktop\TMS\FINAL PROJ\FinalProj\FinalProj\Views\Feedbacks\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Body));

#line default
#line hidden
            EndContext();
            BeginContext(523, 152, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n               Sender\r\n            </th>\r\n            <th>Action</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 35 "C:\Users\Ang\Desktop\TMS\FINAL PROJ\FinalProj\FinalProj\Views\Feedbacks\List.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(724, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(774, 10, false);
#line 39 "C:\Users\Ang\Desktop\TMS\FINAL PROJ\FinalProj\FinalProj\Views\Feedbacks\List.cshtml"
            Write(rowNo += 1);

#line default
#line hidden
            EndContext();
            BeginContext(785, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(841, 40, false);
#line 42 "C:\Users\Ang\Desktop\TMS\FINAL PROJ\FinalProj\FinalProj\Views\Feedbacks\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(881, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(937, 39, false);
#line 45 "C:\Users\Ang\Desktop\TMS\FINAL PROJ\FinalProj\FinalProj\Views\Feedbacks\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Body));

#line default
#line hidden
            EndContext();
            BeginContext(976, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1032, 43, false);
#line 48 "C:\Users\Ang\Desktop\TMS\FINAL PROJ\FinalProj\FinalProj\Views\Feedbacks\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Owner.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1075, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
            BeginContext(1270, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1286, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbc002fbb7bdcadb58873de3cd6d22ef53c997e57377", async() => {
                BeginContext(1333, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\Ang\Desktop\TMS\FINAL PROJ\FinalProj\FinalProj\Views\Feedbacks\List.cshtml"
                                         WriteLiteral(item.ID);

#line default
#line hidden
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
            EndContext();
            BeginContext(1343, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 56 "C:\Users\Ang\Desktop\TMS\FINAL PROJ\FinalProj\FinalProj\Views\Feedbacks\List.cshtml"
        }

#line default
#line hidden
            BeginContext(1390, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FinalProj.Models.Feedback>> Html { get; private set; }
    }
}
#pragma warning restore 1591
