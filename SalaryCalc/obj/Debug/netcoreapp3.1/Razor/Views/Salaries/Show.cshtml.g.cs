#pragma checksum "C:\Projects\dotnet\ASPNETCore\SalaryCalc\SalaryCalc\Views\Salaries\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8472ed39e774da2b57d34e45306c57f73351112e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Salaries_Show), @"mvc.1.0.view", @"/Views/Salaries/Show.cshtml")]
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
#line 2 "C:\Projects\dotnet\ASPNETCore\SalaryCalc\SalaryCalc\Views\_ViewImports.cshtml"
using SalaryCalc.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\dotnet\ASPNETCore\SalaryCalc\SalaryCalc\Views\_ViewImports.cshtml"
using SalaryCalc.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\dotnet\ASPNETCore\SalaryCalc\SalaryCalc\Views\_ViewImports.cshtml"
using SalaryCalc.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\dotnet\ASPNETCore\SalaryCalc\SalaryCalc\Views\_ViewImports.cshtml"
using SalaryCalc.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8472ed39e774da2b57d34e45306c57f73351112e", @"/Views/Salaries/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5575d19220ae8aeea1de8472fe159f38474590df", @"/Views/_ViewImports.cshtml")]
    public class Views_Salaries_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Salary>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div>\n    <h2>");
#nullable restore
#line 4 "C:\Projects\dotnet\ASPNETCore\SalaryCalc\SalaryCalc\Views\Salaries\Show.cshtml"
   Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n    <h2>");
#nullable restore
#line 5 "C:\Projects\dotnet\ASPNETCore\SalaryCalc\SalaryCalc\Views\Salaries\Show.cshtml"
   Write(Model.Sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Salary> Html { get; private set; }
    }
}
#pragma warning restore 1591
