#pragma checksum "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/Home/users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3b2795b6ae35c7f0a7c7715d7df1e8fa3ca6625"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_users), @"mvc.1.0.view", @"/Views/Home/users.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/users.cshtml", typeof(AspNetCore.Views_Home_users))]
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
#line 1 "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/_ViewImports.cshtml"
using BrightIdeas;

#line default
#line hidden
#line 2 "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/_ViewImports.cshtml"
using BrightIdeas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3b2795b6ae35c7f0a7c7715d7df1e8fa3ca6625", @"/Views/Home/users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3089d01e8107546353dc71acbeb0ef609963fe45", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/Home/users.cshtml"
  
	ViewData["Title"] = "Bright Ideas";

#line default
#line hidden
            BeginContext(42, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(55, 279, true);
            WriteLiteral(@"
<div class=""row"">
	<div class=""col-sm-4""><br>
	</div>
	<div class=""col-sm-4"">
	</div>
	<div class=""col-sm-4""><br>
		<p><a href=""/bright_idea"" class=""btn btn-link"">Bright Ideas</a> | <a href=""/Logout"" class=""btn btn-link"">Logout</a></p>
	</div>
</div>

<p><strong>Name:</strong> ");
            EndContext();
            BeginContext(335, 25, false);
#line 17 "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/Home/users.cshtml"
                     Write(ViewBag.SelectedUser.Name);

#line default
#line hidden
            EndContext();
            BeginContext(360, 32, true);
            WriteLiteral("</p>\n<p><strong>Alias:</strong> ");
            EndContext();
            BeginContext(393, 26, false);
#line 18 "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/Home/users.cshtml"
                      Write(ViewBag.SelectedUser.Alias);

#line default
#line hidden
            EndContext();
            BeginContext(419, 32, true);
            WriteLiteral("</p>\n<p><strong>Email:</strong> ");
            EndContext();
            BeginContext(452, 26, false);
#line 19 "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/Home/users.cshtml"
                      Write(ViewBag.SelectedUser.Email);

#line default
#line hidden
            EndContext();
            BeginContext(478, 55, true);
            WriteLiteral("</p>\n\n<hr>\n\n<p><strong>Total Number of Posts:</strong> ");
            EndContext();
            BeginContext(534, 26, false);
#line 23 "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/Home/users.cshtml"
                                      Write(ViewBag.SelectedUser.Posts);

#line default
#line hidden
            EndContext();
            BeginContext(560, 48, true);
            WriteLiteral("</p>\n<p><strong>Total Number of Likes:</strong> ");
            EndContext();
            BeginContext(609, 32, false);
#line 24 "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/Home/users.cshtml"
                                      Write(ViewBag.SelectedUser.Ideas.Count);

#line default
#line hidden
            EndContext();
            BeginContext(641, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
