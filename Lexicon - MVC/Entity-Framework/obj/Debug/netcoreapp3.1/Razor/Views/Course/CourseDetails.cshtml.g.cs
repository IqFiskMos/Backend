#pragma checksum "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Course\CourseDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "356c57986c6d6c35a7398fe2826498fd7877f549"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_CourseDetails), @"mvc.1.0.view", @"/Views/Course/CourseDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"356c57986c6d6c35a7398fe2826498fd7877f549", @"/Views/Course/CourseDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bcc06bf5c395e15b91a662ed818e543d9729220", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_CourseDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Course\CourseDetails.cshtml"
  
    ViewBag.Title = "Course Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Details of \'");
#nullable restore
#line 5 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Course\CourseDetails.cshtml"
           Write(Html.Display("CourseName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' Course</h2>\r\n<h5 class=\"text-info\">Student List under \'");
#nullable restore
#line 6 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Course\CourseDetails.cshtml"
                                     Write(Html.Display("CourseName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' course</h5>\r\n<table class=\"table\" border=\"1\">\r\n    <tr>\r\n        <th>Student Id</th>\r\n        <th>Student Name</th>\r\n        <th>Student Qualification</th>\r\n        <th>Student City</th>\r\n    </tr>\r\n");
#nullable restore
#line 14 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Course\CourseDetails.cshtml"
     foreach (var item in ViewBag.StudentData as IEnumerable<EFW_Assignment.Models.CourseVM>)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Course\CourseDetails.cshtml"
           Write(item.slist.StudentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Course\CourseDetails.cshtml"
           Write(item.slist.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Course\CourseDetails.cshtml"
           Write(item.slist.Qualification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Course\CourseDetails.cshtml"
           Write(item.slist.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 22 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Course\CourseDetails.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<br />\r\n<h5 class=\"text-info\">Teacher List under \'");
#nullable restore
#line 25 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Course\CourseDetails.cshtml"
                                     Write(Html.Display("CourseName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' course</h5>\r\n<table class=\"table\" border=\"1\">\r\n    <tr>\r\n        <th>Teacher Id</th>\r\n        <th>Teacher Name</th>\r\n    </tr>\r\n");
#nullable restore
#line 31 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Course\CourseDetails.cshtml"
     foreach (var item in ViewBag.TeacherData as IEnumerable<EFW_Assignment.Models.CourseVM>)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Course\CourseDetails.cshtml"
           Write(item.teacherlist.TeacherId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Course\CourseDetails.cshtml"
           Write(item.teacherlist.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>           \r\n        </tr>\r\n");
#nullable restore
#line 37 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Course\CourseDetails.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<br />\r\n<h5 class=\"text-info\">    Assignment List under \'");
#nullable restore
#line 40 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Course\CourseDetails.cshtml"
                                            Write(Html.Display("CourseName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' course</h5>\r\n    <table class=\"table\" border=\"1\">\r\n        <tr>\r\n            <th>Assignment Id</th>\r\n            <th>Assignment Name</th>\r\n        </tr>\r\n");
#nullable restore
#line 46 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Course\CourseDetails.cshtml"
         foreach (var item in ViewBag.AssignmentData as IEnumerable<EFW_Assignment.Models.CourseVM>)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 49 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Course\CourseDetails.cshtml"
               Write(item.assignmentlist.AssignmentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 50 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Course\CourseDetails.cshtml"
               Write(item.assignmentlist.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 52 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Course\CourseDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n    <br />\r\n    <div>\r\n        ");
#nullable restore
#line 56 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Course\CourseDetails.cshtml"
   Write(Html.ActionLink("Back to List", "CourseView"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
