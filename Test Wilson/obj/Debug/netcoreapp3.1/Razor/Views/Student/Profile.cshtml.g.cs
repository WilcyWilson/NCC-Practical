#pragma checksum "/mnt/50e70065-45a2-4ae9-983a-aca082f3c687/CSIT/Test Wilson/Views/Student/Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6476a5acba8c875394c29fcc5944dfd1b9644931"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Profile), @"mvc.1.0.view", @"/Views/Student/Profile.cshtml")]
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
#line 1 "/mnt/50e70065-45a2-4ae9-983a-aca082f3c687/CSIT/Test Wilson/Views/_ViewImports.cshtml"
using Test_Wilson;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/mnt/50e70065-45a2-4ae9-983a-aca082f3c687/CSIT/Test Wilson/Views/_ViewImports.cshtml"
using Test_Wilson.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6476a5acba8c875394c29fcc5944dfd1b9644931", @"/Views/Student/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55d80e9ed657fe4fdddfc00df2a2ceaed93b88cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentProfile>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n<ul>\n    <li>Name: ");
#nullable restore
#line 5 "/mnt/50e70065-45a2-4ae9-983a-aca082f3c687/CSIT/Test Wilson/Views/Student/Profile.cshtml"
         Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\n    <li>Age: ");
#nullable restore
#line 6 "/mnt/50e70065-45a2-4ae9-983a-aca082f3c687/CSIT/Test Wilson/Views/Student/Profile.cshtml"
        Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\n    <li>Sex: ");
#nullable restore
#line 7 "/mnt/50e70065-45a2-4ae9-983a-aca082f3c687/CSIT/Test Wilson/Views/Student/Profile.cshtml"
        Write(Model.Sex);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\n    <li>DOB: ");
#nullable restore
#line 8 "/mnt/50e70065-45a2-4ae9-983a-aca082f3c687/CSIT/Test Wilson/Views/Student/Profile.cshtml"
        Write(Model.DOB);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\n    <li>Address: ");
#nullable restore
#line 9 "/mnt/50e70065-45a2-4ae9-983a-aca082f3c687/CSIT/Test Wilson/Views/Student/Profile.cshtml"
            Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\n</ul>\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentProfile> Html { get; private set; }
    }
}
#pragma warning restore 1591
