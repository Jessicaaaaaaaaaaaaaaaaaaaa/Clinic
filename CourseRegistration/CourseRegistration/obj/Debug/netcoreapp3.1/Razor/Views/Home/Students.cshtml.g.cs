#pragma checksum "C:\Users\Owner\source\repos\CourseRegistration\CourseRegistration\Views\Home\Students.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7df5e3fbd6817030976aa77b3384205e5cbb8b42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Students), @"mvc.1.0.view", @"/Views/Home/Students.cshtml")]
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
#line 1 "C:\Users\Owner\source\repos\CourseRegistration\CourseRegistration\Views\_ViewImports.cshtml"
using CourseRegistration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Owner\source\repos\CourseRegistration\CourseRegistration\Views\_ViewImports.cshtml"
using CourseRegistration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7df5e3fbd6817030976aa77b3384205e5cbb8b42", @"/Views/Home/Students.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eb16f24ef85a29ef666c66fda47f537a0bb78eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Students : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Owner\source\repos\CourseRegistration\CourseRegistration\Views\Home\Students.cshtml"
  
    ViewData["Title"] = "Students";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Students</h1>

<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>Student Id</th>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Email Address</th>
            <th>Phone Number</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "C:\Users\Owner\source\repos\CourseRegistration\CourseRegistration\Views\Home\Students.cshtml"
         foreach (var item in Model.Students)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 22 "C:\Users\Owner\source\repos\CourseRegistration\CourseRegistration\Views\Home\Students.cshtml"
                           Write(item.StudentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\Owner\source\repos\CourseRegistration\CourseRegistration\Views\Home\Students.cshtml"
               Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\Owner\source\repos\CourseRegistration\CourseRegistration\Views\Home\Students.cshtml"
               Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\Owner\source\repos\CourseRegistration\CourseRegistration\Views\Home\Students.cshtml"
               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\Owner\source\repos\CourseRegistration\CourseRegistration\Views\Home\Students.cshtml"
               Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 28 "C:\Users\Owner\source\repos\CourseRegistration\CourseRegistration\Views\Home\Students.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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