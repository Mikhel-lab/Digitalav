#pragma checksum "C:\Users\SDSD DEV7\source\repos\DigitalAvss\DigitalAv.MachingTest.Solution\Views\Customer\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a05f22c9c1f1a02687fa6552602efbb25777acbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Detail), @"mvc.1.0.view", @"/Views/Customer/Detail.cshtml")]
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
#line 1 "C:\Users\SDSD DEV7\source\repos\DigitalAvss\DigitalAv.MachingTest.Solution\Views\_ViewImports.cshtml"
using DigitalAv.MachingTest.Solution;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SDSD DEV7\source\repos\DigitalAvss\DigitalAv.MachingTest.Solution\Views\_ViewImports.cshtml"
using DigitalAv.MachingTest.Solution.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a05f22c9c1f1a02687fa6552602efbb25777acbf", @"/Views/Customer/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1d53deaa4d1c2a411cd12b4456f69a7a08c4456", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DigitalAv.Domain.DTO.CustomerDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-md-12 grid-margin grid-margin-md-0\">\r\n\t<div class=\"card\">\r\n\t\t<div class=\"card-body\">\r\n\t\t\t<nav aria-label=\"breadcrumb\">\r\n\t\t\t\t<ol class=\"breadcrumb\">\r\n\t\t\t\t\t<li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a05f22c9c1f1a02687fa6552602efbb25777acbf4064", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n\t\t\t\t\t<li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a05f22c9c1f1a02687fa6552602efbb25777acbf5468", async() => {
                WriteLiteral("User List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
					<li class=""breadcrumb-item active"" aria-current=""page"">User Details</li>
				</ol>
			</nav><br /><br />
			<div class=""wrap d-flex justify-content-lg-start justify-content-sm-center flex-wrap"">
				<div class=""wrap align-items-center ml-5"">
					<p class=""font-weight-bold text-success"" style=""font-size: 20px"">");
#nullable restore
#line 15 "C:\Users\SDSD DEV7\source\repos\DigitalAvss\DigitalAv.MachingTest.Solution\Views\Customer\Detail.cshtml"
                                                                                Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t<p class=\"font-weight-normal\">SaleDate: ");
#nullable restore
#line 16 "C:\Users\SDSD DEV7\source\repos\DigitalAvss\DigitalAv.MachingTest.Solution\Views\Customer\Detail.cshtml"
                                                       Write(Model.SaleDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t<p class=\"font-weight-normal\">Quantity: ");
#nullable restore
#line 17 "C:\Users\SDSD DEV7\source\repos\DigitalAvss\DigitalAv.MachingTest.Solution\Views\Customer\Detail.cshtml"
                                                       Write(Model.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t<p class=\"font-weight-normal\">Country: ");
#nullable restore
#line 18 "C:\Users\SDSD DEV7\source\repos\DigitalAvss\DigitalAv.MachingTest.Solution\Views\Customer\Detail.cshtml"
                                                      Write(Model.CountryCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t<p class=\"font-weight-normal\">Region: ");
#nullable restore
#line 19 "C:\Users\SDSD DEV7\source\repos\DigitalAvss\DigitalAv.MachingTest.Solution\Views\Customer\Detail.cshtml"
                                                     Write(Model.RegionCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t<p class=\"font-weight-normal\">City: ");
#nullable restore
#line 20 "C:\Users\SDSD DEV7\source\repos\DigitalAvss\DigitalAv.MachingTest.Solution\Views\Customer\Detail.cshtml"
                                                   Write(Model.CityCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t<p class=\"font-weight-normal\">Product: ");
#nullable restore
#line 21 "C:\Users\SDSD DEV7\source\repos\DigitalAvss\DigitalAv.MachingTest.Solution\Views\Customer\Detail.cshtml"
                                                      Write(Model.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DigitalAv.Domain.DTO.CustomerDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
