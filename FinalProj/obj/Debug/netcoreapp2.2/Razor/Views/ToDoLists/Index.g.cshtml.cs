#pragma checksum "C:\Users\Ang\Desktop\TMS\FINAL PROJ\FinalProj\FinalProj\Views\ToDoLists\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c712c46412d95aa480c8b8ecf960940877d24577"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToDoLists_Index), @"mvc.1.0.view", @"/Views/ToDoLists/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ToDoLists/Index.cshtml", typeof(AspNetCore.Views_ToDoLists_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c712c46412d95aa480c8b8ecf960940877d24577", @"/Views/ToDoLists/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7e219eab7baa6aa2e333b6ae739d3c200988b83", @"/Views/_ViewImports.cshtml")]
    public class Views_ToDoLists_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FinalProj.Models.ToDoList>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/img/addsign.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Sample Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("180px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Ang\Desktop\TMS\FINAL PROJ\FinalProj\FinalProj\Views\ToDoLists\Index.cshtml"
  
    ViewData["Title"] = "Announcement Page";
    Layout = "~/Views/Shared/_LayoutNote.cshtml";

#line default
#line hidden
            BeginContext(153, 197, true);
            WriteLiteral("<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js\"></script>\r\n\r\n<br />\r\n<h1 class=\"text-center\">To Do List Today</h1>\r\n<hr />\r\n<div id=\"myModal\" class=\"modal\" data-url=\'");
            EndContext();
            BeginContext(351, 32, false);
#line 12 "C:\Users\Ang\Desktop\TMS\FINAL PROJ\FinalProj\FinalProj\Views\ToDoLists\Index.cshtml"
                                     Write(Url.Action("Create","ToDoLists"));

#line default
#line hidden
            EndContext();
            BeginContext(383, 29, true);
            WriteLiteral("\'>\r\n</div>\r\n<div>\r\n    <ol>\r\n");
            EndContext();
#line 16 "C:\Users\Ang\Desktop\TMS\FINAL PROJ\FinalProj\FinalProj\Views\ToDoLists\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(461, 16, true);
            WriteLiteral("            <li>");
            EndContext();
            BeginContext(477, 168, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c712c46412d95aa480c8b8ecf960940877d245776002", async() => {
                BeginContext(522, 10, true);
                WriteLiteral("<b>Title: ");
                EndContext();
                BeginContext(533, 10, false);
#line 18 "C:\Users\Ang\Desktop\TMS\FINAL PROJ\FinalProj\FinalProj\Views\ToDoLists\Index.cshtml"
                                                                  Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(543, 24, true);
                WriteLiteral("</b><br /> Description: ");
                EndContext();
                BeginContext(568, 16, false);
#line 18 "C:\Users\Ang\Desktop\TMS\FINAL PROJ\FinalProj\FinalProj\Views\ToDoLists\Index.cshtml"
                                                                                                     Write(item.Description);

#line default
#line hidden
                EndContext();
                BeginContext(584, 16, true);
                WriteLiteral("<br />Priority: ");
                EndContext();
                BeginContext(601, 13, false);
#line 18 "C:\Users\Ang\Desktop\TMS\FINAL PROJ\FinalProj\FinalProj\Views\ToDoLists\Index.cshtml"
                                                                                                                                      Write(item.Priority);

#line default
#line hidden
                EndContext();
                BeginContext(614, 15, true);
                WriteLiteral("<br /> Status: ");
                EndContext();
                BeginContext(630, 11, false);
#line 18 "C:\Users\Ang\Desktop\TMS\FINAL PROJ\FinalProj\FinalProj\Views\ToDoLists\Index.cshtml"
                                                                                                                                                                   Write(item.Status);

#line default
#line hidden
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
#line 18 "C:\Users\Ang\Desktop\TMS\FINAL PROJ\FinalProj\FinalProj\Views\ToDoLists\Index.cshtml"
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
            BeginContext(645, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 19 "C:\Users\Ang\Desktop\TMS\FINAL PROJ\FinalProj\FinalProj\Views\ToDoLists\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(663, 44, true);
            WriteLiteral("        <a class=\"btn-block \">\r\n            ");
            EndContext();
            BeginContext(707, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c712c46412d95aa480c8b8ecf960940877d2457710398", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(775, 385, true);
            WriteLiteral(@"
        </a>
    </ol>
</div>

<script type=""text/javascript"">
    $(document).ready(function () {
        $('.btn-block').click(function () {
            var url = $('#myModal').data('url');
            $.get(url, function (data) {
                $(""#myModal"").html(data);
                $(""#myModal"").modal('show');
            });
        });
    });
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FinalProj.Models.ToDoList>> Html { get; private set; }
    }
}
#pragma warning restore 1591
