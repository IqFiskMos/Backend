#pragma checksum "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Assignment\AssignmentView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "968b49fb3539cbeec7ebe891dbeab9fdc30ef5bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Assignment_AssignmentView), @"mvc.1.0.view", @"/Views/Assignment/AssignmentView.cshtml")]
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
#line 1 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\_ViewImports.cshtml"
using EFW_Assignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Assignment\AssignmentView.cshtml"
using EFW_Assignment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"968b49fb3539cbeec7ebe891dbeab9fdc30ef5bf", @"/Views/Assignment/AssignmentView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bcc06bf5c395e15b91a662ed818e543d9729220", @"/Views/_ViewImports.cshtml")]
    public class Views_Assignment_AssignmentView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EFW_Assignment.Models.Assignment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AssignmentList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Assignment\AssignmentView.cshtml"
  
    ViewBag.Title = "Assignment List";

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    ");
#nullable restore
#line 10 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Assignment\AssignmentView.cshtml"
Write(Html.ActionLink("Add New Assignment", "CreateAssignment"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            Id\r\n        </th>\r\n        <th>\r\n            Assignment Name\r\n        </th>\r\n");
            WriteLiteral("        <th>\r\n            Course Id\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n");
#nullable restore
#line 28 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Assignment\AssignmentView.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "968b49fb3539cbeec7ebe891dbeab9fdc30ef5bf4891", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 30 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Assignment\AssignmentView.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 31 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Assignment\AssignmentView.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EFW_Assignment.Models.Assignment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
