#pragma checksum "C:\Masters\DistributedInformationSystem\Assignment\ActiveSite_Cloud\CollegeFinder\CollegeFinder\Views\Home\popularpage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83a447c2f96a2502a5432f085dc6711fce98e25b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_popularpage), @"mvc.1.0.view", @"/Views/Home/popularpage.cshtml")]
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
#line 1 "C:\Masters\DistributedInformationSystem\Assignment\ActiveSite_Cloud\CollegeFinder\CollegeFinder\Views\_ViewImports.cshtml"
using CollegeFinder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Masters\DistributedInformationSystem\Assignment\ActiveSite_Cloud\CollegeFinder\CollegeFinder\Views\_ViewImports.cshtml"
using CollegeFinder.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83a447c2f96a2502a5432f085dc6711fce98e25b", @"/Views/Home/popularpage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"665cc7ea01044b16114004efe592f6791a11f61c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_popularpage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CollegeFinder.Models.Result>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Masters\DistributedInformationSystem\Assignment\ActiveSite_Cloud\CollegeFinder\CollegeFinder\Views\Home\popularpage.cshtml"
  
    ViewData["Title"] = "popularpage"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"<br /><br />
<h2>Popular Colleges</h2>
<table class=""PopularTable"">
    <thead>
        <tr color=""grey"">
            <th>College Name</th>
            <th>State</th>
            <th>City</th>
            <th>Admission Rate</th>
        </tr>
    </thead>
");
#nullable restore
#line 19 "C:\Masters\DistributedInformationSystem\Assignment\ActiveSite_Cloud\CollegeFinder\CollegeFinder\Views\Home\popularpage.cshtml"
     foreach (var result in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tbody>\r\n            <tr>\r\n                <td>");
#nullable restore
#line 23 "C:\Masters\DistributedInformationSystem\Assignment\ActiveSite_Cloud\CollegeFinder\CollegeFinder\Views\Home\popularpage.cshtml"
               Write(result.school.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td>");
#nullable restore
#line 24 "C:\Masters\DistributedInformationSystem\Assignment\ActiveSite_Cloud\CollegeFinder\CollegeFinder\Views\Home\popularpage.cshtml"
               Write(result.school.state);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Masters\DistributedInformationSystem\Assignment\ActiveSite_Cloud\CollegeFinder\CollegeFinder\Views\Home\popularpage.cshtml"
               Write(result.school.city);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Masters\DistributedInformationSystem\Assignment\ActiveSite_Cloud\CollegeFinder\CollegeFinder\Views\Home\popularpage.cshtml"
               Write(result.latest.admissions.admission_rate.overall);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            </tr>\r\n        </tbody>\r\n");
#nullable restore
#line 29 "C:\Masters\DistributedInformationSystem\Assignment\ActiveSite_Cloud\CollegeFinder\CollegeFinder\Views\Home\popularpage.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CollegeFinder.Models.Result>> Html { get; private set; }
    }
}
#pragma warning restore 1591
