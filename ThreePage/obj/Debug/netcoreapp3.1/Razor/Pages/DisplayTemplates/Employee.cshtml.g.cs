#pragma checksum "C:\Users\Administrator\Desktop\Three\Three\ThreePage\Pages\DisplayTemplates\Employee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9759e9db7d8e8f2178042b2192ee764704539dcc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ThreePage.Pages.DisplayTemplates.Pages_DisplayTemplates_Employee), @"mvc.1.0.view", @"/Pages/DisplayTemplates/Employee.cshtml")]
namespace ThreePage.Pages.DisplayTemplates
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
#line 1 "C:\Users\Administrator\Desktop\Three\Three\ThreePage\Pages\_ViewImports.cshtml"
using ThreePage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9759e9db7d8e8f2178042b2192ee764704539dcc", @"/Pages/DisplayTemplates/Employee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04d8122cdb43cbfb1bea31914125f4ff4e83ea8e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_DisplayTemplates_Employee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ThreePage.Models.Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<tr>\r\n    <td>");
#nullable restore
#line 4 "C:\Users\Administrator\Desktop\Three\Three\ThreePage\Pages\DisplayTemplates\Employee.cshtml"
   Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 5 "C:\Users\Administrator\Desktop\Three\Three\ThreePage\Pages\DisplayTemplates\Employee.cshtml"
   Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 6 "C:\Users\Administrator\Desktop\Three\Three\ThreePage\Pages\DisplayTemplates\Employee.cshtml"
   Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    \r\n    <td>\r\n\r\n    </td>\r\n</tr>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ThreePage.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
