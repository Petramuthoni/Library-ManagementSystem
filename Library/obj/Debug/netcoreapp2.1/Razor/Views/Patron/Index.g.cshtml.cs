#pragma checksum "C:\Users\petra\source\repos\Library\Library\Views\Patron\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da8d116b0ac6e6b95904793db947587bc34b09e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patron_Index), @"mvc.1.0.view", @"/Views/Patron/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Patron/Index.cshtml", typeof(AspNetCore.Views_Patron_Index))]
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
#line 1 "C:\Users\petra\source\repos\Library\Library\Views\_ViewImports.cshtml"
using Library;

#line default
#line hidden
#line 2 "C:\Users\petra\source\repos\Library\Library\Views\_ViewImports.cshtml"
using Library.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da8d116b0ac6e6b95904793db947587bc34b09e3", @"/Views/Patron/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadb7a731bfbb305c411bc5eb7a307dbd6008a89", @"/Views/_ViewImports.cshtml")]
    public class Views_Patron_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Patron.PatronIndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Patron", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(47, 464, true);
            WriteLiteral(@"<h3>ptron Index</h3>

<div id=""patronIndex"">
    <table class=""table table-striped table-condensed table-bordered""id=""patronIndexTable"">
        <thead>
            <tr>

                <th>Profile Link</th>
                <th>Last Name</th>
                <th>First Name</th>
                <th>Library Card Id</th>
                <th>Overdue Fees</th>
                <th>Home Library</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 18 "C:\Users\petra\source\repos\Library\Library\Views\Patron\Index.cshtml"
             foreach (var patron in Model.Patrons) {

#line default
#line hidden
            BeginContext(565, 40, true);
            WriteLiteral("            <tr>\r\n                <td>  ");
            EndContext();
            BeginContext(605, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbce40a266084a18be819915b3fbb263", async() => {
                BeginContext(678, 9, true);
                WriteLiteral("(profile)");
                EndContext();
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
#line 20 "C:\Users\petra\source\repos\Library\Library\Views\Patron\Index.cshtml"
                                                                       WriteLiteral(patron.Id);

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
            BeginContext(691, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(719, 15, false);
#line 21 "C:\Users\petra\source\repos\Library\Library\Views\Patron\Index.cshtml"
               Write(patron.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(734, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(762, 16, false);
#line 22 "C:\Users\petra\source\repos\Library\Library\Views\Patron\Index.cshtml"
               Write(patron.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(778, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(806, 20, false);
#line 23 "C:\Users\petra\source\repos\Library\Library\Views\Patron\Index.cshtml"
               Write(patron.LibraryCardId);

#line default
#line hidden
            EndContext();
            BeginContext(826, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(854, 18, false);
#line 24 "C:\Users\petra\source\repos\Library\Library\Views\Patron\Index.cshtml"
               Write(patron.OverdueFees);

#line default
#line hidden
            EndContext();
            BeginContext(872, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(900, 24, false);
#line 25 "C:\Users\petra\source\repos\Library\Library\Views\Patron\Index.cshtml"
               Write(patron.HomeLibraryBranch);

#line default
#line hidden
            EndContext();
            BeginContext(924, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 27 "C:\Users\petra\source\repos\Library\Library\Views\Patron\Index.cshtml"

            }

#line default
#line hidden
            BeginContext(967, 43, true);
            WriteLiteral("\r\n        </tbody>\r\n    </table> \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Models.Patron.PatronIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
