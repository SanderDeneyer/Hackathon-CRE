#pragma checksum "C:\Users\sande\Documents\Odisee\2TI\Marketing & Innovation\Hackaton\Hackaton\Hackaton\Views\Home\RiskStatusShow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6452476afed58888aa089c43d1c9b7c037733e09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RiskStatusShow), @"mvc.1.0.view", @"/Views/Home/RiskStatusShow.cshtml")]
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
#line 1 "C:\Users\sande\Documents\Odisee\2TI\Marketing & Innovation\Hackaton\Hackaton\Hackaton\Views\_ViewImports.cshtml"
using Hackaton;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sande\Documents\Odisee\2TI\Marketing & Innovation\Hackaton\Hackaton\Hackaton\Views\_ViewImports.cshtml"
using Hackaton.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6452476afed58888aa089c43d1c9b7c037733e09", @"/Views/Home/RiskStatusShow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7010bba5a1f0a478ec35f1c2e433b35a3851e689", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RiskStatusShow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Hackaton.Models.RiskStatus>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sande\Documents\Odisee\2TI\Marketing & Innovation\Hackaton\Hackaton\Hackaton\Views\Home\RiskStatusShow.cshtml"
  
    ViewData["Title"] = "RiskStatusShow";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>RiskStatusShow</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\sande\Documents\Odisee\2TI\Marketing & Innovation\Hackaton\Hackaton\Hackaton\Views\Home\RiskStatusShow.cshtml"
           Write(Html.DisplayNameFor(model => model.Risk));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\sande\Documents\Odisee\2TI\Marketing & Innovation\Hackaton\Hackaton\Hackaton\Views\Home\RiskStatusShow.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\sande\Documents\Odisee\2TI\Marketing & Innovation\Hackaton\Hackaton\Hackaton\Views\Home\RiskStatusShow.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "C:\Users\sande\Documents\Odisee\2TI\Marketing & Innovation\Hackaton\Hackaton\Hackaton\Views\Home\RiskStatusShow.cshtml"
         if (Model != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\sande\Documents\Odisee\2TI\Marketing & Innovation\Hackaton\Hackaton\Hackaton\Views\Home\RiskStatusShow.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 31 "C:\Users\sande\Documents\Odisee\2TI\Marketing & Innovation\Hackaton\Hackaton\Hackaton\Views\Home\RiskStatusShow.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Risk));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 34 "C:\Users\sande\Documents\Odisee\2TI\Marketing & Innovation\Hackaton\Hackaton\Hackaton\Views\Home\RiskStatusShow.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 37 "C:\Users\sande\Documents\Odisee\2TI\Marketing & Innovation\Hackaton\Hackaton\Hackaton\Views\Home\RiskStatusShow.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 40 "C:\Users\sande\Documents\Odisee\2TI\Marketing & Innovation\Hackaton\Hackaton\Hackaton\Views\Home\RiskStatusShow.cshtml"
                   Write(Html.ActionLink("Delete", "RiskDelete", new {pId=item.pID, rId = item.ID}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 43 "C:\Users\sande\Documents\Odisee\2TI\Marketing & Innovation\Hackaton\Hackaton\Hackaton\Views\Home\RiskStatusShow.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\sande\Documents\Odisee\2TI\Marketing & Innovation\Hackaton\Hackaton\Hackaton\Views\Home\RiskStatusShow.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Hackaton.Models.RiskStatus>> Html { get; private set; }
    }
}
#pragma warning restore 1591
