#pragma checksum "C:\Users\PC\Desktop\Svastara\VSProjects\Git\MatchOrganizer\MatchOrganizer\MatchOrganizer\Views\TeamMenagment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18e03c9b24111e6bd7a1d2c812d67cc737720522"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TeamMenagment_Index), @"mvc.1.0.view", @"/Views/TeamMenagment/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TeamMenagment/Index.cshtml", typeof(AspNetCore.Views_TeamMenagment_Index))]
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
#line 1 "C:\Users\PC\Desktop\Svastara\VSProjects\Git\MatchOrganizer\MatchOrganizer\MatchOrganizer\Views\_ViewImports.cshtml"
using MatchOrganizer;

#line default
#line hidden
#line 2 "C:\Users\PC\Desktop\Svastara\VSProjects\Git\MatchOrganizer\MatchOrganizer\MatchOrganizer\Views\_ViewImports.cshtml"
using MatchOrganizer.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18e03c9b24111e6bd7a1d2c812d67cc737720522", @"/Views/TeamMenagment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"808b7e1abff67aa57580f20a19defe5b3277340a", @"/Views/_ViewImports.cshtml")]
    public class Views_TeamMenagment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MatchOrganizer.ViewModels.TeamViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\PC\Desktop\Svastara\VSProjects\Git\MatchOrganizer\MatchOrganizer\MatchOrganizer\Views\TeamMenagment\Index.cshtml"
  
    /**/

    ViewBag.Title = "Teams";

#line default
#line hidden
            BeginContext(110, 497, true);
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-xs-12"">
            <a class=""btn btn-primary mb-3"" data-toggle=""modal"" data-target=""#create"" style=""margin-top:100px;margin-left:10px""><i class=""fas fa-plus""></i> Create new match</a>
        </div>
    </div>
    <div class=""table-responsive"">
        <table class=""table table-striped table-sm"" id=""table-polaznici"" style=""margin-top:10px"">
            <thead>
                <tr>
                    <th>");
            EndContext();
            BeginContext(608, 32, false);
#line 18 "C:\Users\PC\Desktop\Svastara\VSProjects\Git\MatchOrganizer\MatchOrganizer\MatchOrganizer\Views\TeamMenagment\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
            EndContext();
            BeginContext(640, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(672, 37, false);
#line 19 "C:\Users\PC\Desktop\Svastara\VSProjects\Git\MatchOrganizer\MatchOrganizer\MatchOrganizer\Views\TeamMenagment\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.NoPlayers));

#line default
#line hidden
            EndContext();
            BeginContext(709, 111, true);
            WriteLiteral("</th>\r\n                    <th>Actions</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 24 "C:\Users\PC\Desktop\Svastara\VSProjects\Git\MatchOrganizer\MatchOrganizer\MatchOrganizer\Views\TeamMenagment\Index.cshtml"
                 foreach (var team in Model)
                {

#line default
#line hidden
            BeginContext(885, 56, true);
            WriteLiteral("                    <tr>\r\n\r\n                        <td>");
            EndContext();
            BeginContext(942, 9, false);
#line 28 "C:\Users\PC\Desktop\Svastara\VSProjects\Git\MatchOrganizer\MatchOrganizer\MatchOrganizer\Views\TeamMenagment\Index.cshtml"
                       Write(team.Name);

#line default
#line hidden
            EndContext();
            BeginContext(951, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(987, 14, false);
#line 29 "C:\Users\PC\Desktop\Svastara\VSProjects\Git\MatchOrganizer\MatchOrganizer\MatchOrganizer\Views\TeamMenagment\Index.cshtml"
                       Write(team.NoPlayers);

#line default
#line hidden
            EndContext();
            BeginContext(1001, 134, true);
            WriteLiteral("</td>\r\n                        <td class=\"text-nowrap text-right\">\r\n                            <a class=\"btn btn-outline-info btn-sm\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1135, "\"", 1191, 1);
#line 31 "C:\Users\PC\Desktop\Svastara\VSProjects\Git\MatchOrganizer\MatchOrganizer\MatchOrganizer\Views\TeamMenagment\Index.cshtml"
WriteAttributeValue("", 1142, Url.Action("Details", new { @id = team.TeamId }), 1142, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1192, 109, true);
            WriteLiteral("><i class=\"fas fa-info-circle\"></i> Details</a>\r\n                        </td>\r\n\r\n                    </tr>\r\n");
            EndContext();
#line 35 "C:\Users\PC\Desktop\Svastara\VSProjects\Git\MatchOrganizer\MatchOrganizer\MatchOrganizer\Views\TeamMenagment\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1320, 794, true);
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>
<div class=""modal fade"" id=""create"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">

            <!-- Modal Header -->
            <div class=""modal-header"">
                <h4 class=""modal-title"">Marija Novakovic</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>

            <!-- Modal body -->
            <div class=""modal-body"">
                I'm 21 years old.

      
            <!-- Modal footer -->
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MatchOrganizer.ViewModels.TeamViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591