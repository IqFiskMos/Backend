#pragma checksum "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Teacher\EditTeacher.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edd7e575b7736dd50c5fdfd737982f13bde4d76f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_EditTeacher), @"mvc.1.0.view", @"/Views/Teacher/EditTeacher.cshtml")]
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
#line 2 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\_ViewImports.cshtml"
using EFW_Assignment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edd7e575b7736dd50c5fdfd737982f13bde4d76f", @"/Views/Teacher/EditTeacher.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bcc06bf5c395e15b91a662ed818e543d9729220", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_EditTeacher : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EFW_Assignment.Models.Teacher>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TeacherEditAndCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Teacher\EditTeacher.cshtml"
  
    ViewBag.Title = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Create"] = false;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Edit \'");
#nullable restore
#line 9 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Teacher\EditTeacher.cshtml"
     Write(Html.Display("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' Details</h2>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Teacher\EditTeacher.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Teacher\EditTeacher.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "edd7e575b7736dd50c5fdfd737982f13bde4d76f4788", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 15 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Teacher\EditTeacher.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData = ViewData;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("view-data", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Teacher\EditTeacher.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    ");
#nullable restore
#line 19 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Teacher\EditTeacher.cshtml"
Write(Html.ActionLink("Back to List", "TeacherView"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EFW_Assignment.Models.Teacher> Html { get; private set; }
    }
}
#pragma warning restore 1591
