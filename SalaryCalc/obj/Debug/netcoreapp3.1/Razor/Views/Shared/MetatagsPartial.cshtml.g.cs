#pragma checksum "C:\Projects\dotnet\ASPNETCore\SalaryCalc\SalaryCalc\Views\Shared\MetatagsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0453b6b1484b23b3160187167922fb8ecea75af8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MetatagsPartial), @"mvc.1.0.view", @"/Views/Shared/MetatagsPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0453b6b1484b23b3160187167922fb8ecea75af8", @"/Views/Shared/MetatagsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5575d19220ae8aeea1de8472fe159f38474590df", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_MetatagsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<meta name=\"viewport\" content=\"width=device-width\" />\n\n");
#nullable restore
#line 3 "C:\Projects\dotnet\ASPNETCore\SalaryCalc\SalaryCalc\Views\Shared\MetatagsPartial.cshtml"
 if (ViewBag.Title != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <title>");
#nullable restore
#line 5 "C:\Projects\dotnet\ASPNETCore\SalaryCalc\SalaryCalc\Views\Shared\MetatagsPartial.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\n");
#nullable restore
#line 6 "C:\Projects\dotnet\ASPNETCore\SalaryCalc\SalaryCalc\Views\Shared\MetatagsPartial.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <title>");
#nullable restore
#line 9 "C:\Projects\dotnet\ASPNETCore\SalaryCalc\SalaryCalc\Views\Shared\MetatagsPartial.cshtml"
      Write(Config.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\n");
#nullable restore
#line 10 "C:\Projects\dotnet\ASPNETCore\SalaryCalc\SalaryCalc\Views\Shared\MetatagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Projects\dotnet\ASPNETCore\SalaryCalc\SalaryCalc\Views\Shared\MetatagsPartial.cshtml"
 if (ViewBag.Description != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <meta name=\"description\"");
            BeginWriteAttribute("content", " content=\"", 233, "\"", 263, 1);
#nullable restore
#line 13 "C:\Projects\dotnet\ASPNETCore\SalaryCalc\SalaryCalc\Views\Shared\MetatagsPartial.cshtml"
WriteAttributeValue("", 243, ViewBag.Description, 243, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n");
#nullable restore
#line 14 "C:\Projects\dotnet\ASPNETCore\SalaryCalc\SalaryCalc\Views\Shared\MetatagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Projects\dotnet\ASPNETCore\SalaryCalc\SalaryCalc\Views\Shared\MetatagsPartial.cshtml"
 if (ViewBag.Keywords != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <meta name=\"keywords\"");
            BeginWriteAttribute("content", " content=\"", 328, "\"", 355, 1);
#nullable restore
#line 17 "C:\Projects\dotnet\ASPNETCore\SalaryCalc\SalaryCalc\Views\Shared\MetatagsPartial.cshtml"
WriteAttributeValue("", 338, ViewBag.Keywords, 338, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n");
#nullable restore
#line 18 "C:\Projects\dotnet\ASPNETCore\SalaryCalc\SalaryCalc\Views\Shared\MetatagsPartial.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
