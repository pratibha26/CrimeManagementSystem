#pragma checksum "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\Officers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91cded50aac76ffb7d35b170ee884806882cd6ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CrimeManagementSystem.Pages.Officers.Pages_Officers_Details), @"mvc.1.0.razor-page", @"/Pages/Officers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Officers/Details.cshtml", typeof(CrimeManagementSystem.Pages.Officers.Pages_Officers_Details), null)]
namespace CrimeManagementSystem.Pages.Officers
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\_ViewImports.cshtml"
using CrimeManagementSystem;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91cded50aac76ffb7d35b170ee884806882cd6ce", @"/Pages/Officers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09970178ad3c24ef14fefc1ad07f9783a7a2c1e5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Officers_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\Officers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(110, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Officer</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(232, 48, false);
#line 15 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\Officers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Officer.Name));

#line default
#line hidden
            EndContext();
            BeginContext(280, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(324, 44, false);
#line 18 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\Officers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Officer.Name));

#line default
#line hidden
            EndContext();
            BeginContext(368, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(412, 55, false);
#line 21 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\Officers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Officer.Designation));

#line default
#line hidden
            EndContext();
            BeginContext(467, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(511, 51, false);
#line 24 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\Officers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Officer.Designation));

#line default
#line hidden
            EndContext();
            BeginContext(562, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(606, 55, false);
#line 27 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\Officers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Officer.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(661, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(705, 51, false);
#line 30 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\Officers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Officer.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(756, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(800, 49, false);
#line 33 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\Officers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Officer.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(849, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(893, 45, false);
#line 36 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\Officers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Officer.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(938, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(982, 49, false);
#line 39 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\Officers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Officer.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1031, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1075, 45, false);
#line 42 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\Officers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Officer.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1120, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1164, 59, false);
#line 45 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\Officers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Officer.PostingLocation));

#line default
#line hidden
            EndContext();
            BeginContext(1223, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1267, 55, false);
#line 48 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\Officers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Officer.PostingLocation));

#line default
#line hidden
            EndContext();
            BeginContext(1322, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1366, 60, false);
#line 51 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\Officers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Officer.RegistrationDate));

#line default
#line hidden
            EndContext();
            BeginContext(1426, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1470, 56, false);
#line 54 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\Officers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Officer.RegistrationDate));

#line default
#line hidden
            EndContext();
            BeginContext(1526, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1570, 58, false);
#line 57 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\Officers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Officer.RetirementDate));

#line default
#line hidden
            EndContext();
            BeginContext(1628, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1672, 54, false);
#line 60 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\Officers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Officer.RetirementDate));

#line default
#line hidden
            EndContext();
            BeginContext(1726, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1770, 54, false);
#line 63 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\Officers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Officer.CaseSolved));

#line default
#line hidden
            EndContext();
            BeginContext(1824, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1868, 50, false);
#line 66 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\Officers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Officer.CaseSolved));

#line default
#line hidden
            EndContext();
            BeginContext(1918, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1962, 55, false);
#line 69 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\Officers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Officer.CasePending));

#line default
#line hidden
            EndContext();
            BeginContext(2017, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2061, 51, false);
#line 72 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\Officers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Officer.CasePending));

#line default
#line hidden
            EndContext();
            BeginContext(2112, 45, true);
            WriteLiteral("\r\n        </dd>\r\n          <dt>\r\n            ");
            EndContext();
            BeginContext(2158, 55, false);
#line 75 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\Officers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Officer.CasesWorked));

#line default
#line hidden
            EndContext();
            BeginContext(2213, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2257, 51, false);
#line 78 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\Officers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Officer.CasesWorked));

#line default
#line hidden
            EndContext();
            BeginContext(2308, 45, true);
            WriteLiteral("\r\n        </dd>\r\n          <dt>\r\n            ");
            EndContext();
            BeginContext(2354, 47, false);
#line 81 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\Officers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Officer.Age));

#line default
#line hidden
            EndContext();
            BeginContext(2401, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2445, 43, false);
#line 84 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\Officers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Officer.Age));

#line default
#line hidden
            EndContext();
            BeginContext(2488, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2535, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ee5500adc014141916c824eef0b39f7", async() => {
                BeginContext(2589, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 89 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\Officers\Details.cshtml"
                           WriteLiteral(Model.Officer.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2597, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2605, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f27c3d14999488285da1976b444f6a2", async() => {
                BeginContext(2627, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2643, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CrimeManagementSystem.Pages.Officers.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CrimeManagementSystem.Pages.Officers.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CrimeManagementSystem.Pages.Officers.DetailsModel>)PageContext?.ViewData;
        public CrimeManagementSystem.Pages.Officers.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
