#pragma checksum "C:\Projects\dotnet\ASP.NET Core\SalaryCalc\SalaryCalc\Views\Salaries\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b31afb130a7b60f90756801cac5302fcea3a3d8"
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
#line 2 "C:\Projects\dotnet\ASP.NET Core\SalaryCalc\SalaryCalc\Views\_ViewImports.cshtml"
using SalaryCalc.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\dotnet\ASP.NET Core\SalaryCalc\SalaryCalc\Views\_ViewImports.cshtml"
using SalaryCalc.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\dotnet\ASP.NET Core\SalaryCalc\SalaryCalc\Views\_ViewImports.cshtml"
using SalaryCalc.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\dotnet\ASP.NET Core\SalaryCalc\SalaryCalc\Views\_ViewImports.cshtml"
using SalaryCalc.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b31afb130a7b60f90756801cac5302fcea3a3d8", @"/Views/Salaries/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ae2490e9c998b4cf66490f54cc87e787c15e48c", @"/Views/_ViewImports.cshtml")]
    public class Views_Salaries_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Salary>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    <h2>");
#nullable restore
#line 4 "C:\Projects\dotnet\ASP.NET Core\SalaryCalc\SalaryCalc\Views\Salaries\Show.cshtml"
   Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <h2>");
#nullable restore
#line 5 "C:\Projects\dotnet\ASP.NET Core\SalaryCalc\SalaryCalc\Views\Salaries\Show.cshtml"
   Write(Model.Sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n</div>");
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
