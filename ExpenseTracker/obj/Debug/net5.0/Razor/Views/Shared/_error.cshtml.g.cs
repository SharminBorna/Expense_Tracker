#pragma checksum "C:\Users\MSI PC\Desktop\New folder\ExpenseTracker\ExpenseTracker\Views\Shared\_error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "793c93e3446d069f71e2676e5835567061eb3568"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__error), @"mvc.1.0.view", @"/Views/Shared/_error.cshtml")]
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
#line 1 "C:\Users\MSI PC\Desktop\New folder\ExpenseTracker\ExpenseTracker\Views\_ViewImports.cshtml"
using ExpenseTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MSI PC\Desktop\New folder\ExpenseTracker\ExpenseTracker\Views\_ViewImports.cshtml"
using ExpenseTracker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"793c93e3446d069f71e2676e5835567061eb3568", @"/Views/Shared/_error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7d2bc418d006ee1a17f8c977b1f7a33b7f0c16f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""alert alert-warning alert-dismissible fade show"">
    <strong>Database Operation Failed!!!</strong>
    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
        <span aria-hidden=""true"">&times;</span>
    </button>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
