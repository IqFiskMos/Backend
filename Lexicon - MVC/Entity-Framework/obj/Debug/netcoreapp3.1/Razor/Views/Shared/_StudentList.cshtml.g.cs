#pragma checksum "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Shared\_StudentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab55a90159b0809fc145cf417fb00149a3b0ae68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__StudentList), @"mvc.1.0.view", @"/Views/Shared/_StudentList.cshtml")]
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
#line 2 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Shared\_StudentList.cshtml"
using EFW_Assignment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab55a90159b0809fc145cf417fb00149a3b0ae68", @"/Views/Shared/_StudentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bcc06bf5c395e15b91a662ed818e543d9729220", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__StudentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EFW_Assignment.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<tr>\r\n    <td>\r\n        ");
#nullable restore
#line 7 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Shared\_StudentList.cshtml"
   Write(Html.DisplayFor(modelItem => modelItem.StudentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 10 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Shared\_StudentList.cshtml"
   Write(Html.DisplayFor(modelItem => modelItem.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 13 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Shared\_StudentList.cshtml"
   Write(Html.DisplayFor(modelItem => modelItem.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td> \r\n    <td>\r\n        ");
#nullable restore
#line 16 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Shared\_StudentList.cshtml"
   Write(Html.DisplayFor(modelItem => modelItem.Qualification));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 19 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Shared\_StudentList.cshtml"
   Write(Html.DisplayFor(modelItem => modelItem.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 22 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Shared\_StudentList.cshtml"
   Write(Html.ActionLink("Edit", "EditStudent", new { id = Model.StudentId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n        ");
#nullable restore
#line 23 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Shared\_StudentList.cshtml"
   Write(Html.ActionLink("Details", "StudentDetails", new { id = Model.StudentId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n        ");
#nullable restore
#line 24 "C:\Users\cenny\Downloads\ASP-.NET-MVC-Entity-Framework-main\ASP-.NET-MVC-Entity-Framework-main\Views\Shared\_StudentList.cshtml"
   Write(Html.ActionLink("Delete", "DeleteStudent", new { id = Model.StudentId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n</tr>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EFW_Assignment.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
