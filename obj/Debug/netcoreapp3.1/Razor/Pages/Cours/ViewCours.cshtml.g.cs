#pragma checksum "C:\Users\The_ghost\Desktop\PFA_Project\Pages\Cours\ViewCours.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c392401138dba541251d6ccd434dbe4a4805a57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PFA_Project.Pages.Cours.Pages_Cours_ViewCours), @"mvc.1.0.razor-page", @"/Pages/Cours/ViewCours.cshtml")]
namespace PFA_Project.Pages.Cours
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
#line 1 "C:\Users\The_ghost\Desktop\PFA_Project\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\The_ghost\Desktop\PFA_Project\Pages\_ViewImports.cshtml"
using PFA_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\The_ghost\Desktop\PFA_Project\Pages\_ViewImports.cshtml"
using PFA_Project.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c392401138dba541251d6ccd434dbe4a4805a57", @"/Pages/Cours/ViewCours.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b29200b83117a13bfa8b4fdcd5d351847518eda6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cours_ViewCours : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    .container {padding: 30px;}
</style>


    <div class=""nav-scroller bg-white box-shadow"">
            <nav class=""nav nav-underline"">
            <a class=""nav-link"" href=""/Cours/CoursList"">List</a>
            </nav>
    </div>
    
     <div class=""container"">
        <div class=""row"">
            <div class=""col-1"">
                <br>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8c392401138dba541251d6ccd434dbe4a4805a574513", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 20 "C:\Users\The_ghost\Desktop\PFA_Project\Pages\Cours\ViewCours.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.cr.IdCours);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("             \r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 635, "\"", 663, 2);
            WriteAttributeValue("", 642, "\\sourse\\", 642, 8, true);
#nullable restore
#line 24 "C:\Users\The_ghost\Desktop\PFA_Project\Pages\Cours\ViewCours.cshtml"
WriteAttributeValue("", 650, Model.cr.URL, 650, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" download>\r\n                    <img src=\"\\img\\Download.png\" alt=\"DWNL04D\" width=\"75\" height=\"75\">\r\n                </a>\r\n");
            WriteLiteral("            </div>\r\n            <div class=\"col-11\">\r\n                <div class=\"container p-3 my-3 bg-success text-white\">\r\n                     <h1>");
#nullable restore
#line 33 "C:\Users\The_ghost\Desktop\PFA_Project\Pages\Cours\ViewCours.cshtml"
                    Write(Model.cr.CoursName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n                </div>   \r\n            </div>\r\n            \r\n\r\n\r\n  <div class=\"container\">\r\n  <div class=\"row\">\r\n    <div class=\"col-7\">\r\n");
            WriteLiteral("        <div class=\"container\" >\r\n            <embed");
            BeginWriteAttribute("src", " src=\"", 1235, "\"", 1262, 2);
            WriteAttributeValue("", 1241, "\\sourse\\", 1241, 8, true);
#nullable restore
#line 44 "C:\Users\The_ghost\Desktop\PFA_Project\Pages\Cours\ViewCours.cshtml"
WriteAttributeValue("", 1249, Model.cr.URL, 1249, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\" height=\"800px\" type=\'application/pdf\'/>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-5\">\r\n      <div class=\"container\">\r\n        <div class=\"row\">\r\n");
            WriteLiteral("              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c392401138dba541251d6ccd434dbe4a4805a578105", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 52 "C:\Users\The_ghost\Desktop\PFA_Project\Pages\Cours\ViewCours.cshtml"
                 foreach (var cmnt in Model.commentaires){
                      

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\The_ghost\Desktop\PFA_Project\Pages\Cours\ViewCours.cshtml"
                       if(cmnt.IdCours == Model.cr.IdCours){

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <div class=""media text-muted pt-3"">
                            <img data-src=""holder.js/32x32?theme=thumb&amp;bg=007bff&amp;fg=007bff&amp;size=1"" alt=""32x32"" class=""mr-2 rounded"" style=""width: 32px; height: 32px;"" src=""data:image/svg+xml;charset=UTF-8,%3Csvg%20width%3D%2232%22%20height%3D%2232%22%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20viewBox%3D%220%200%2032%2032%22%20preserveAspectRatio%3D%22none%22%3E%3Cdefs%3E%3Cstyle%20type%3D%22text%2Fcss%22%3E%23holder_1729513e11a%20text%20%7B%20fill%3A%23007bff%3Bfont-weight%3Abold%3Bfont-family%3AArial%2C%20Helvetica%2C%20Open%20Sans%2C%20sans-serif%2C%20monospace%3Bfont-size%3A2pt%20%7D%20%3C%2Fstyle%3E%3C%2Fdefs%3E%3Cg%20id%3D%22holder_1729513e11a%22%3E%3Crect%20width%3D%2232%22%20height%3D%2232%22%20fill%3D%22%23007bff%22%3E%3C%2Frect%3E%3Cg%3E%3Ctext%20x%3D%2211.5390625%22%20y%3D%2216.9%22%3E32x32%3C%2Ftext%3E%3C%2Fg%3E%3C%2Fg%3E%3C%2Fsvg%3E"" data-holder-rendered=""true"">
                            <p class=""media-body pb");
                WriteLiteral("-3 mb-0 small lh-125 border-bottom border-gray\">\r\n");
#nullable restore
#line 57 "C:\Users\The_ghost\Desktop\PFA_Project\Pages\Cours\ViewCours.cshtml"
                                 foreach (var user in Model.users){     
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\The_ghost\Desktop\PFA_Project\Pages\Cours\ViewCours.cshtml"
                                     if(cmnt.IdAuteur == user.Id){

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <strong class=\"d-block text-gray-dark\">");
#nullable restore
#line 59 "C:\Users\The_ghost\Desktop\PFA_Project\Pages\Cours\ViewCours.cshtml"
                                                                      Write(user.Nom);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <i>");
#nullable restore
#line 59 "C:\Users\The_ghost\Desktop\PFA_Project\Pages\Cours\ViewCours.cshtml"
                                                                                   Write(user.Prenom);

#line default
#line hidden
#nullable disable
                WriteLiteral("</i></strong>\r\n");
#nullable restore
#line 60 "C:\Users\The_ghost\Desktop\PFA_Project\Pages\Cours\ViewCours.cshtml"

                                  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\The_ghost\Desktop\PFA_Project\Pages\Cours\ViewCours.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
#nullable restore
#line 63 "C:\Users\The_ghost\Desktop\PFA_Project\Pages\Cours\ViewCours.cshtml"
                           Write(cmnt.Body);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n");
#nullable restore
#line 66 "C:\Users\The_ghost\Desktop\PFA_Project\Pages\Cours\ViewCours.cshtml"
                      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\The_ghost\Desktop\PFA_Project\Pages\Cours\ViewCours.cshtml"
                       
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <!-- -->
                            <div class=""input-group"">
                                <div class=""input-group-prepend"">
                                    <span class=""input-group-text"">Commantaire</span>
                                </div>
                                <textarea class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 3531, "\"", 3539, 0);
                EndWriteAttribute();
                WriteLiteral("  name=\"body\"></textarea>\r\n                            </div>\r\n                            <input class=\"btn btn-success\" type=\"Submit\" value=\"Poster\"/>\r\n              ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("        </div>\r\n      </div>\r\n   </div>\r\n   <br><br>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.ViewCoursModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.ViewCoursModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.ViewCoursModel>)PageContext?.ViewData;
        public MyApp.Namespace.ViewCoursModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591