#pragma checksum "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/Home/bright_idea.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffde3cec1073a206e65a3ad2555b7bffc4a65bb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_bright_idea), @"mvc.1.0.view", @"/Views/Home/bright_idea.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/bright_idea.cshtml", typeof(AspNetCore.Views_Home_bright_idea))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffde3cec1073a206e65a3ad2555b7bffc4a65bb1", @"/Views/Home/bright_idea.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3089d01e8107546353dc71acbeb0ef609963fe45", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_bright_idea : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Idea>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:red;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/IdeaProcess"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/Home/bright_idea.cshtml"
  
	ViewData["Title"] = "Bright Ideas";

#line default
#line hidden
            BeginContext(42, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(55, 57, true);
            WriteLiteral("\n<div class=\"row\">\n\t<div class=\"col-sm-4\"><br>\n\t\t<h2>Hi, ");
            EndContext();
            BeginContext(113, 25, false);
#line 9 "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/Home/bright_idea.cshtml"
           Write(ViewBag.LoggedInUser.Name);

#line default
#line hidden
            EndContext();
            BeginContext(138, 176, true);
            WriteLiteral("!</h2>\n\t</div>\n\t<div class=\"col-sm-4\">\n\t</div>\n\t<div class=\"col-sm-4\"><br>\n\t\t<p><a href=\"/Logout\" class=\"btn btn-link\">Logout</a></p>\n\t</div>\n</div>\n\n<div class=\"form-group\">\n\t");
            EndContext();
            BeginContext(314, 455, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffde3cec1073a206e65a3ad2555b7bffc4a65bb15406", async() => {
                BeginContext(356, 51, true);
                WriteLiteral("\n\t\t<div class=\"row\">\n\t\t\t<div class=\"col-sm-8\">\n\t\t\t\t");
                EndContext();
                BeginContext(407, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffde3cec1073a206e65a3ad2555b7bffc4a65bb15846", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 22 "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/Home/bright_idea.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdeaPost);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(469, 161, true);
                WriteLiteral("\n\t\t\t\t<textarea name=\"IdeaPost\" cols=\"30\" rows=\"3\" class=\"form-control\"></textarea>\n\t\t\t</div>\n\t\t\t\n\t\t\t<div class=\"col-sm-2\">\n\t\t\t\t<input name=\"UserID\" type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 630, "\"", 666, 1);
#line 27 "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/Home/bright_idea.cshtml"
WriteAttributeValue("", 638, ViewBag.LoggedInUser.UserID, 638, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(667, 95, true);
                WriteLiteral(">\n\t\t\t\t<input type=\"submit\" value=\"Add Idea!\" class=\"btn btn-outline-dark\">\n\t\t\t</div>\n\t\t</div>\n\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(769, 9, true);
            WriteLiteral("\n</div>\n\n");
            EndContext();
#line 34 "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/Home/bright_idea.cshtml"
 if (ViewBag.allIdeas != null)
{
	foreach(Idea i in ViewBag.allIdeas)
	{
		bool isLiked = false;
		bool isCreated = false;
		if(i.Creator.UserID ==ViewBag.LoggedInUser.UserID)
		{
			isCreated = true;
		}
		string persons = "person";
		foreach(var a in i.Users)
		{
			if(a.UserID == ViewBag.LoggedInUser.UserID)
			{
				isLiked = true;
			}
		}
		if(i.Users.Count == 1)
		{
			persons = "person likes";
		}
		else
		{
			persons = "people like";
		}
		Console.WriteLine(@persons);

#line default
#line hidden
            BeginContext(1261, 55, true);
            WriteLiteral("\t\t<div class=\"row\">\n\t\t\t<div class=\"col-sm-2\">\n\t\t\t\t<p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1316, "\"", 1339, 2);
            WriteAttributeValue("", 1323, "/users/", 1323, 7, true);
#line 63 "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/Home/bright_idea.cshtml"
WriteAttributeValue("", 1330, i.UserID, 1330, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1340, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1342, 14, false);
#line 63 "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/Home/bright_idea.cshtml"
                                         Write(i.Creator.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1356, 111, true);
            WriteLiteral("</a> says:</p>\n\t\t\t</div>\n\t\t\t<div class=\"col-sm-8\">\n\t\t\t\t<textarea cols=\"30\" rows=\"3\" class=\"border border-dark\">");
            EndContext();
            BeginContext(1468, 10, false);
#line 66 "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/Home/bright_idea.cshtml"
                                                                   Write(i.IdeaPost);

#line default
#line hidden
            EndContext();
            BeginContext(1478, 16, true);
            WriteLiteral("</textarea><br>\n");
            EndContext();
#line 67 "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/Home/bright_idea.cshtml"
                 if(isLiked)
				{

#line default
#line hidden
            BeginContext(1517, 7, true);
            WriteLiteral("\t\t\t\t\t<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1524, "\"", 1548, 2);
            WriteAttributeValue("", 1531, "/unLike/", 1531, 8, true);
#line 69 "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/Home/bright_idea.cshtml"
WriteAttributeValue("", 1539, i.IdeaID, 1539, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1549, 35, true);
            WriteLiteral(" class=\"btn btn-link\">unLike</a> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1584, "\"", 1614, 2);
            WriteAttributeValue("", 1591, "/bright_ideas/", 1591, 14, true);
#line 69 "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/Home/bright_idea.cshtml"
WriteAttributeValue("", 1605, i.IdeaID, 1605, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1615, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1617, 7, false);
#line 69 "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/Home/bright_idea.cshtml"
                                                                                                             Write(i.Likes);

#line default
#line hidden
            EndContext();
            BeginContext(1624, 11, true);
            WriteLiteral("</a> <span>");
            EndContext();
            BeginContext(1636, 7, false);
#line 69 "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/Home/bright_idea.cshtml"
                                                                                                                                Write(persons);

#line default
#line hidden
            EndContext();
            BeginContext(1643, 15, true);
            WriteLiteral(" this.</span>\t\n");
            EndContext();
#line 70 "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/Home/bright_idea.cshtml"
				}
				else
				{

#line default
#line hidden
            BeginContext(1679, 7, true);
            WriteLiteral("\t\t\t\t\t<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1686, "\"", 1709, 2);
            WriteAttributeValue("", 1693, "/Likes/", 1693, 7, true);
#line 73 "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/Home/bright_idea.cshtml"
WriteAttributeValue("", 1700, i.IdeaID, 1700, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1710, 33, true);
            WriteLiteral(" class=\"btn btn-link\">Like</a> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1743, "\"", 1773, 2);
            WriteAttributeValue("", 1750, "/bright_ideas/", 1750, 14, true);
#line 73 "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/Home/bright_idea.cshtml"
WriteAttributeValue("", 1764, i.IdeaID, 1764, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1774, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1776, 7, false);
#line 73 "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/Home/bright_idea.cshtml"
                                                                                                          Write(i.Likes);

#line default
#line hidden
            EndContext();
            BeginContext(1783, 11, true);
            WriteLiteral("</a> <span>");
            EndContext();
            BeginContext(1795, 7, false);
#line 73 "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/Home/bright_idea.cshtml"
                                                                                                                             Write(persons);

#line default
#line hidden
            EndContext();
            BeginContext(1802, 15, true);
            WriteLiteral(" this. </span>\n");
            EndContext();
#line 74 "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/Home/bright_idea.cshtml"
				}

#line default
#line hidden
            BeginContext(1823, 4, true);
            WriteLiteral("\t\t\t\t");
            EndContext();
#line 75 "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/Home/bright_idea.cshtml"
                 if(isCreated)
				{

#line default
#line hidden
            BeginContext(1848, 54, true);
            WriteLiteral("\t\t\t\t<span><a style=\"vertical-align: middle; color:red\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1902, "\"", 1926, 2);
            WriteAttributeValue("", 1909, "/Delete/", 1909, 8, true);
#line 77 "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/Home/bright_idea.cshtml"
WriteAttributeValue("", 1917, i.IdeaID, 1917, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1927, 36, true);
            WriteLiteral("><strong> X</strong></a></span><br>\n");
            EndContext();
#line 78 "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/Home/bright_idea.cshtml"
				}
				else
				{

#line default
#line hidden
            BeginContext(1984, 10, true);
            WriteLiteral("\t\t\t\t\t<br>\n");
            EndContext();
#line 82 "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/Home/bright_idea.cshtml"
				}

#line default
#line hidden
            BeginContext(2000, 24, true);
            WriteLiteral("\t\t\t</div>\n\n\t\t</div><br>\n");
            EndContext();
#line 86 "/Users/1drslattery/Desktop/Rob/education/coding_dojo/c#_apps/BrightIdeas/Views/Home/bright_idea.cshtml"
	}
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Idea> Html { get; private set; }
    }
}
#pragma warning restore 1591
