#pragma checksum "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\StudentCourse\EditStudentCourse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e70143fb78b61924cf28ebdf8109136af9e13e85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StudentCourse_EditStudentCourse), @"mvc.1.0.view", @"/Views/StudentCourse/EditStudentCourse.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e70143fb78b61924cf28ebdf8109136af9e13e85", @"/Views/StudentCourse/EditStudentCourse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bcc06bf5c395e15b91a662ed818e543d9729220", @"/Views/_ViewImports.cshtml")]
    public class Views_StudentCourse_EditStudentCourse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EFW_Assignment.Models.StudentCourse>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\StudentCourse\EditStudentCourse.cshtml"
  
    ViewBag.Title = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Create"] = false;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Edit Details</h2>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\StudentCourse\EditStudentCourse.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\StudentCourse\EditStudentCourse.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\r\n    <hr />\r\n    ");
#nullable restore
#line 17 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\StudentCourse\EditStudentCourse.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 18 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\StudentCourse\EditStudentCourse.cshtml"
Write(Html.HiddenFor(model => model.StudentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    \r\n    \r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 24 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\StudentCourse\EditStudentCourse.cshtml"
   Write(Html.LabelFor(model => model.StudentId, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            \r\n                ");
#nullable restore
#line 27 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\StudentCourse\EditStudentCourse.cshtml"
           Write(Html.EditorFor(model => model.StudentId, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 28 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\StudentCourse\EditStudentCourse.cshtml"
       Write(Html.ValidationMessageFor(model => model.StudentId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 33 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\StudentCourse\EditStudentCourse.cshtml"
   Write(Html.LabelFor(model => model.CourseId, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n           \r\n       \r\n                ");
#nullable restore
#line 37 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\StudentCourse\EditStudentCourse.cshtml"
           Write(Html.EditorFor(model => model.CourseId, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 38 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\StudentCourse\EditStudentCourse.cshtml"
       Write(Html.ValidationMessageFor(model => model.CourseId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Save\" class=\"btn btn-default bg-success\" />\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 49 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\StudentCourse\EditStudentCourse.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    ");
#nullable restore
#line 52 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\StudentCourse\EditStudentCourse.cshtml"
Write(Html.ActionLink("Back to List", "StudentCourseView"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EFW_Assignment.Models.StudentCourse> Html { get; private set; }
    }
}
#pragma warning restore 1591