#pragma checksum "C:\Users\Vasic\Desktop\MatchOrganizer\MatchOrganizer\MatchOrganizer\Views\Shared\_MessagePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5625f551390add6c055c8db2e77423fa6215803"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MessagePartial), @"mvc.1.0.view", @"/Views/Shared/_MessagePartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_MessagePartial.cshtml", typeof(AspNetCore.Views_Shared__MessagePartial))]
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
#line 1 "C:\Users\Vasic\Desktop\MatchOrganizer\MatchOrganizer\MatchOrganizer\Views\_ViewImports.cshtml"
using MatchOrganizer;

#line default
#line hidden
#line 2 "C:\Users\Vasic\Desktop\MatchOrganizer\MatchOrganizer\MatchOrganizer\Views\_ViewImports.cshtml"
using MatchOrganizer.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5625f551390add6c055c8db2e77423fa6215803", @"/Views/Shared/_MessagePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"808b7e1abff67aa57580f20a19defe5b3277340a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__MessagePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Vasic\Desktop\MatchOrganizer\MatchOrganizer\MatchOrganizer\Views\Shared\_MessagePartial.cshtml"
 if (ViewBag.Message != null)
{

#line default
#line hidden
            BeginContext(34, 8, true);
            WriteLiteral("    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 42, "\"", 99, 3);
            WriteAttributeValue("", 50, "alert", 50, 5, true);
#line 3 "C:\Users\Vasic\Desktop\MatchOrganizer\MatchOrganizer\MatchOrganizer\Views\Shared\_MessagePartial.cshtml"
WriteAttributeValue(" ", 55, ViewBag.Message.CssClass, 56, 25, false);

#line default
#line hidden
            WriteAttributeValue(" ", 81, "alert-dismissible", 82, 18, true);
            EndWriteAttribute();
            BeginContext(100, 158, true);
            WriteLiteral(" role=\"alert\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n        ");
            EndContext();
            BeginContext(259, 27, false);
#line 5 "C:\Users\Vasic\Desktop\MatchOrganizer\MatchOrganizer\MatchOrganizer\Views\Shared\_MessagePartial.cshtml"
   Write(ViewBag.Message.InfoMessage);

#line default
#line hidden
            EndContext();
            BeginContext(286, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 7 "C:\Users\Vasic\Desktop\MatchOrganizer\MatchOrganizer\MatchOrganizer\Views\Shared\_MessagePartial.cshtml"
}

#line default
#line hidden
            BeginContext(303, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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