#pragma checksum "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\StudentCourse\CreateStudentCourse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcbb5dd6100f28a0fcb77b078402f75d00d08669"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StudentCourse_CreateStudentCourse), @"mvc.1.0.view", @"/Views/StudentCourse/CreateStudentCourse.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcbb5dd6100f28a0fcb77b078402f75d00d08669", @"/Views/StudentCourse/CreateStudentCourse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bcc06bf5c395e15b91a662ed818e543d9729220", @"/Views/_ViewImports.cshtml")]
    public class Views_StudentCourse_CreateStudentCourse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EFW_Assignment.Models.StudentCourse>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/StudentCourse/CreateStudentCourse"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\StudentCourse\CreateStudentCourse.cshtml"
  
    ViewBag.Title = "Add StudentCourse";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\StudentCourse\CreateStudentCourse.cshtml"
 if (ViewBag.ErrorMsg != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>");
#nullable restore
#line 9 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\StudentCourse\CreateStudentCourse.cshtml"
   Write(ViewBag.ErrorMsg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <p>Check List again and create.</p>\r\n    <div>\r\n        ");
#nullable restore
#line 12 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\StudentCourse\CreateStudentCourse.cshtml"
   Write(Html.ActionLink("Back to List", "StudentCourseView"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 14 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\StudentCourse\CreateStudentCourse.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Add New</h2>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcbb5dd6100f28a0fcb77b078402f75d00d086695732", async() => {
                WriteLiteral("\r\n\r\n    Student Name ");
#nullable restore
#line 21 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\StudentCourse\CreateStudentCourse.cshtml"
            Write(Html.DropDownListFor(model => model.StudentId, ViewBag.StudentNames as SelectList, new { @class = "dropdown" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <br />\r\n    Select Course<ul style=\"list-style-type:none;\">\r\n");
#nullable restore
#line 25 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\StudentCourse\CreateStudentCourse.cshtml"
         foreach (var course in ViewBag.CourseNames)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <li>\r\n                <input type=\"checkbox\" name=\"CourseIds\"");
                BeginWriteAttribute("value", " value=\"", 737, "\"", 761, 1);
#nullable restore
#line 28 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\StudentCourse\CreateStudentCourse.cshtml"
WriteAttributeValue("", 745, course.CourseId, 745, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                ");
#nullable restore
#line 29 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\StudentCourse\CreateStudentCourse.cshtml"
           Write(course.CourseName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 31 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\StudentCourse\CreateStudentCourse.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\r\n    <input type=\"submit\" value=\"Assign Course To Student\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("<div>\r\n    <br />\r\n    ");
#nullable restore
#line 38 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\StudentCourse\CreateStudentCourse.cshtml"
Write(Html.ActionLink("Back to List", "StudentCourseView"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 40 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\StudentCourse\CreateStudentCourse.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EFW_Assignment.Models.StudentCourse> Html { get; private set; }
    }
}
#pragma warning restore 1591