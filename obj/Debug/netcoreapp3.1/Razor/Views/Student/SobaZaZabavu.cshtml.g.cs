#pragma checksum "C:\Users\Republic of Gamers\VisualStudioProjects\source\repos\Grupa3-Sekemin\Implementacija\Sekemin\Views\Student\SobaZaZabavu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ff3bc721742c53e4986ae52eadb6f1e2fb4d573"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_SobaZaZabavu), @"mvc.1.0.view", @"/Views/Student/SobaZaZabavu.cshtml")]
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
#line 1 "C:\Users\Republic of Gamers\VisualStudioProjects\source\repos\Grupa3-Sekemin\Implementacija\Sekemin\Views\_ViewImports.cshtml"
using Sekemin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Republic of Gamers\VisualStudioProjects\source\repos\Grupa3-Sekemin\Implementacija\Sekemin\Views\_ViewImports.cshtml"
using Sekemin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ff3bc721742c53e4986ae52eadb6f1e2fb4d573", @"/Views/Student/SobaZaZabavu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20e6b21db649294a6855a9d41c5f625c27328fa3", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_SobaZaZabavu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sekemin.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Republic of Gamers\VisualStudioProjects\source\repos\Grupa3-Sekemin\Implementacija\Sekemin\Views\Student\SobaZaZabavu.cshtml"
  
    ViewData["Title"] = "SobaZaZabavu";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div style=""margin-top: 10px; width: 100%"">
    <h1 style=""position: center"">Rezervacija sobe za zabavu</h1>
</div>

<div style=""margin-top: 50px; width: 100%"">
    <label>Datum rezervacije:</label>
    <input type=""date"" id=""datumRezervacijeSobe"" style=""margin-left: 20px"" />
</div>

<br />

<div style=""width: 100%"">
    <label>Vrijeme početka:</label>
    <input type=""time"" id=""pocetakRezervacijeSobe"" style=""margin-left: 32px"" />
</div>

<br />

<div style=""width: 100%"">
    <label>Vrijeme završetka:</label>
    <input type=""time"" id=""krajRezervacijeSobe"" style=""margin-left: 23px"" />
</div>

<br />
<br />

<div style=""width: 100%"">
    <button type =""button"" style=""margin-left: 150px"">Rezerviši</button>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sekemin.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591