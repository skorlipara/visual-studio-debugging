#pragma checksum "F:\Pluralsight\Visual Studio Debugging\LoanCalculator\LoanCalculator.RazorPages\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce3cb6a9d14ac47c2ad09b8467ec195c9617a2f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LoanCalculator.RazorPages.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(LoanCalculator.RazorPages.Pages.Pages_Index), null)]
namespace LoanCalculator.RazorPages.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "F:\Pluralsight\Visual Studio Debugging\LoanCalculator\LoanCalculator.RazorPages\Pages\_ViewImports.cshtml"
using LoanCalculator.RazorPages;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce3cb6a9d14ac47c2ad09b8467ec195c9617a2f2", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1e4b29ee1add5df54497b049e8788b6036f94cf", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/grow.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "F:\Pluralsight\Visual Studio Debugging\LoanCalculator\LoanCalculator.RazorPages\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 1025, true);
            WriteLiteral(@"<h1 class=""display-3"">
    Welcome to the Loan Application!
</h1>
<p class=""lead"">Here you can manage loan applications for our customers.  Currently this site allows you to create new loans, view historical applications, and view current terms and rates.</p>
<hr />
<br />
<h2 class=""title display-4"">Recent Loan Applications</h2>
<div class=""row"">
    <div class=""col-md-8"">
        <div class=""row"">
            <div class=""col-md-12"">
                <table class=""table table-striped table-responsive-lg"">
                    <thead class=""text-light thead-light"">
                        <tr>
                            <th>ID</th>
                            <th>Name</th>
                            <th>Loan Amount</th>
                            <th>Status</th>
                            <th>Reason</th>
                            <th>Interest Rate</th>
                            <th>Payment</th>
                        </tr>
                    </thead>
                    <tbody>");
            WriteLiteral("\n");
            EndContext();
#line 30 "F:\Pluralsight\Visual Studio Debugging\LoanCalculator\LoanCalculator.RazorPages\Pages\Index.cshtml"
                         foreach (var item in Model.LoanApplicationResults)
                        {

#line default
#line hidden
            BeginContext(1200, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(1271, 13, false);
#line 33 "F:\Pluralsight\Visual Studio Debugging\LoanCalculator\LoanCalculator.RazorPages\Pages\Index.cshtml"
                               Write(item.ResultId);

#line default
#line hidden
            EndContext();
            BeginContext(1284, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1328, 14, false);
#line 34 "F:\Pluralsight\Visual Studio Debugging\LoanCalculator\LoanCalculator.RazorPages\Pages\Index.cshtml"
                               Write(item.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1342, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(1345, 13, false);
#line 34 "F:\Pluralsight\Visual Studio Debugging\LoanCalculator\LoanCalculator.RazorPages\Pages\Index.cshtml"
                                                Write(item.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1358, 62, true);
            WriteLiteral("</td>\r\n                                <td class=\"text-right\">");
            EndContext();
            BeginContext(1421, 29, false);
#line 35 "F:\Pluralsight\Visual Studio Debugging\LoanCalculator\LoanCalculator.RazorPages\Pages\Index.cshtml"
                                                  Write(item.LoanAmount.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(1450, 63, true);
            WriteLiteral("</td>\r\n                                <td class=\"text-center\">");
            EndContext();
            BeginContext(1515, 37, false);
#line 36 "F:\Pluralsight\Visual Studio Debugging\LoanCalculator\LoanCalculator.RazorPages\Pages\Index.cshtml"
                                                    Write(item.Approved ? "Approved" : "Denied");

#line default
#line hidden
            EndContext();
            BeginContext(1553, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1597, 17, false);
#line 37 "F:\Pluralsight\Visual Studio Debugging\LoanCalculator\LoanCalculator.RazorPages\Pages\Index.cshtml"
                               Write(item.DenialReason);

#line default
#line hidden
            EndContext();
            BeginContext(1614, 62, true);
            WriteLiteral("</td>\r\n                                <td class=\"text-right\">");
            EndContext();
            BeginContext(1677, 36, false);
#line 38 "F:\Pluralsight\Visual Studio Debugging\LoanCalculator\LoanCalculator.RazorPages\Pages\Index.cshtml"
                                                  Write(item.InterestRate?.ToString("0.00%"));

#line default
#line hidden
            EndContext();
            BeginContext(1713, 62, true);
            WriteLiteral("</td>\r\n                                <td class=\"text-right\">");
            EndContext();
            BeginContext(1776, 34, false);
#line 39 "F:\Pluralsight\Visual Studio Debugging\LoanCalculator\LoanCalculator.RazorPages\Pages\Index.cshtml"
                                                  Write(item.MonthlyPayment?.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(1810, 42, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n");
            EndContext();
#line 41 "F:\Pluralsight\Visual Studio Debugging\LoanCalculator\LoanCalculator.RazorPages\Pages\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1879, 1127, true);
            WriteLiteral(@"                    </tbody>
                </table>
                <a href=""/loanhistory"" class=""btn btn-success float-right"">View Loan History</a>
            </div>
        </div>
        <div class=""row clearfix"">
            <div class=""col-md-12"">
                <hr />
                <h2 class=""title display-4"">Current Loan Rates</h2>
            </div>
            <div class=""col-md-6"">
                <div class=""card"">
                    <div class=""card-header"">
                        The Market Rates
                    </div>
                    <div class=""card-body"">
                        <table class=""table table-striped"">
                            <thead>
                                <tr>
                                    <th>
                                        Loan Type
                                    </th>
                                    <th>
                                        Rate
                                    </th>
           ");
            WriteLiteral("                     </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
            EndContext();
#line 70 "F:\Pluralsight\Visual Studio Debugging\LoanCalculator\LoanCalculator.RazorPages\Pages\Index.cshtml"
                                 foreach (var item in Model.MarketRates)
                                {

#line default
#line hidden
            BeginContext(3115, 132, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(3248, 10, false);
#line 74 "F:\Pluralsight\Visual Studio Debugging\LoanCalculator\LoanCalculator.RazorPages\Pages\Index.cshtml"
                                       Write(item.Label);

#line default
#line hidden
            EndContext();
            BeginContext(3258, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(3398, 35, false);
#line 77 "F:\Pluralsight\Visual Studio Debugging\LoanCalculator\LoanCalculator.RazorPages\Pages\Index.cshtml"
                                       Write(String.Format("{0:P2}.", item.Rate));

#line default
#line hidden
            EndContext();
            BeginContext(3433, 92, true);
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 80 "F:\Pluralsight\Visual Studio Debugging\LoanCalculator\LoanCalculator.RazorPages\Pages\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(3560, 1066, true);
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            <div class=""col-md-6"">
                <div class=""card"">
                    <div class=""card-header"">
                        Our Rates
                    </div>
                    <div class=""card-body"">
                        <table class=""table table-responsive table-striped"">
                            <thead>
                                <tr>
                                    <th>
                                        Low Credit Score
                                    </th>
                                    <th>
                                        Upper Credit Score
                                    </th>
                                    <th>
                                        Interest Rate
                                    </th>
                                </tr>
                            </the");
            WriteLiteral("ad>\r\n                            <tbody>\r\n");
            EndContext();
#line 107 "F:\Pluralsight\Visual Studio Debugging\LoanCalculator\LoanCalculator.RazorPages\Pages\Index.cshtml"
                                 foreach (var item in Model.LoanRates)
                                {

#line default
#line hidden
            BeginContext(4733, 132, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(4866, 51, false);
#line 111 "F:\Pluralsight\Visual Studio Debugging\LoanCalculator\LoanCalculator.RazorPages\Pages\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.LowerCreditScore));

#line default
#line hidden
            EndContext();
            BeginContext(4917, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(5057, 51, false);
#line 114 "F:\Pluralsight\Visual Studio Debugging\LoanCalculator\LoanCalculator.RazorPages\Pages\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.UpperCreditScore));

#line default
#line hidden
            EndContext();
            BeginContext(5108, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(5248, 43, false);
#line 117 "F:\Pluralsight\Visual Studio Debugging\LoanCalculator\LoanCalculator.RazorPages\Pages\Index.cshtml"
                                       Write(String.Format("{0:P2}.", item.InterestRate));

#line default
#line hidden
            EndContext();
            BeginContext(5291, 92, true);
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 120 "F:\Pluralsight\Visual Studio Debugging\LoanCalculator\LoanCalculator.RazorPages\Pages\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(5418, 331, true);
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-md-4"">
        <div class=""card"">
            <div class=""card-header"">
                We're growing!
            </div>
            ");
            EndContext();
            BeginContext(5749, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ce3cb6a9d14ac47c2ad09b8467ec195c9617a2f216152", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5799, 964, true);
            WriteLiteral(@"
            <div class=""card-body"">
                <h5 class=""card-title"">Some quick weekly stats...</h5>
                <h6 class=""card-subtitle mb-2 text-muted"">All thanks to our hard working team. Keep it up!</h6>
                <ul class=""list-group"">
                    <li class=""list-group-item""><span class=""badge badge-secondary"">25</span> approvals</li>
                    <li class=""list-group-item""><span class=""badge badge-secondary"">15</span> denials</li>
                    <li class=""list-group-item""><span class=""badge badge-secondary"">3.2%</span> average interest rate</li>
                    <li class=""list-group-item""><span class=""badge badge-secondary"">10%</span> growth in Q1</li>
                </ul>

            </div>
            <div class=""card-footer"">
                <a href=""#"" class=""card-link float-right"">Create a loan</a>
            </div>
        </div>
        <br />
        
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
