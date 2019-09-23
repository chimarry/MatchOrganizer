#pragma checksum "C:\Users\Vasic\Desktop\MatchOrganizer\MatchOrganizer\MatchOrganizer\Views\Matches\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90b330772aa342a673e366502ae14e3243a3ad0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Matches_Index), @"mvc.1.0.view", @"/Views/Matches/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Matches/Index.cshtml", typeof(AspNetCore.Views_Matches_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90b330772aa342a673e366502ae14e3243a3ad0f", @"/Views/Matches/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"808b7e1abff67aa57580f20a19defe5b3277340a", @"/Views/_ViewImports.cshtml")]
    public class Views_Matches_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MatchOrganizer.ViewModels.Matches.IndexMatchViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Vasic\Desktop\MatchOrganizer\MatchOrganizer\MatchOrganizer\Views\Matches\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(163, 130, true);
            WriteLiteral("<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-xs-12\">\r\n            <a class=\"btn btn-primary mb-3\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 293, "\"", 321, 1);
#line 9 "C:\Users\Vasic\Desktop\MatchOrganizer\MatchOrganizer\MatchOrganizer\Views\Matches\Index.cshtml"
WriteAttributeValue("", 300, Url.Action("Create"), 300, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(322, 613, true);
            WriteLiteral(@" style=""margin-top:100px;margin-left:10px""><i class=""fas fa-plus""></i> Create new match</a>

        </div>
    </div>
    <div class=""table-responsive"">
        <table class=""table table-striped table-sm"" id=""table-matches"" style=""margin-top:10px"">
            <thead>
                <tr>
                    <th></th>
                    <th>Host</th>
                    <th>Guest</th>
                    <th>Time</th>
                    <th>Place</th>
                    <th>Result</th>
                    <th>Actions</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 27 "C:\Users\Vasic\Desktop\MatchOrganizer\MatchOrganizer\MatchOrganizer\Views\Matches\Index.cshtml"
                 foreach (var match in Model)
                {

#line default
#line hidden
            BeginContext(1001, 124, true);
            WriteLiteral("                    <tr>\r\n                        <td><div class=\"dot dot-running\"></div></td>\r\n                        <td>");
            EndContext();
            BeginContext(1126, 18, false);
#line 31 "C:\Users\Vasic\Desktop\MatchOrganizer\MatchOrganizer\MatchOrganizer\Views\Matches\Index.cshtml"
                       Write(match.HostTeamName);

#line default
#line hidden
            EndContext();
            BeginContext(1144, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1180, 19, false);
#line 32 "C:\Users\Vasic\Desktop\MatchOrganizer\MatchOrganizer\MatchOrganizer\Views\Matches\Index.cshtml"
                       Write(match.GuestTeamName);

#line default
#line hidden
            EndContext();
            BeginContext(1199, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1235, 15, false);
#line 33 "C:\Users\Vasic\Desktop\MatchOrganizer\MatchOrganizer\MatchOrganizer\Views\Matches\Index.cshtml"
                       Write(match.StartTime);

#line default
#line hidden
            EndContext();
            BeginContext(1250, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1286, 11, false);
#line 34 "C:\Users\Vasic\Desktop\MatchOrganizer\MatchOrganizer\MatchOrganizer\Views\Matches\Index.cshtml"
                       Write(match.Place);

#line default
#line hidden
            EndContext();
            BeginContext(1297, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1333, 11, false);
#line 35 "C:\Users\Vasic\Desktop\MatchOrganizer\MatchOrganizer\MatchOrganizer\Views\Matches\Index.cshtml"
                       Write(match.Score);

#line default
#line hidden
            EndContext();
            BeginContext(1344, 103, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a class=\"btn btn-outline-info btn-sm\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1447, "\"", 1476, 1);
#line 37 "C:\Users\Vasic\Desktop\MatchOrganizer\MatchOrganizer\MatchOrganizer\Views\Matches\Index.cshtml"
WriteAttributeValue("", 1454, Url.Action("Details"), 1454, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1477, 109, true);
            WriteLiteral("><i class=\"fas fa-info-circle\"></i> Details</a>\r\n                        </td>\r\n\r\n                    </tr>\r\n");
            EndContext();
#line 41 "C:\Users\Vasic\Desktop\MatchOrganizer\MatchOrganizer\MatchOrganizer\Views\Matches\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1605, 923, true);
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>
<div class=""modal fade"" id=""modal"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">

            <!-- Modal Header -->
            <div class=""modal-header"">

                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>

            <!-- Modal body -->
            <div class=""modal-body"" id=""createModal"">
            </div>
            <!-- Modal footer -->
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>
<script>
    var Create = function () {
        var url = ""/Matches/Create"";
        $(""#createModal"").load(url, function () {
            $(""#modal"").modal(""show"");
        })
    }
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MatchOrganizer.ViewModels.Matches.IndexMatchViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
