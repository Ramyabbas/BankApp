#pragma checksum "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Customer\CustomerDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5424b0494178753133cb9bd2cbdaac823a93b155"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_CustomerDetails), @"mvc.1.0.view", @"/Views/Customer/CustomerDetails.cshtml")]
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
#line 1 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\_ViewImports.cshtml"
using BankAppMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\_ViewImports.cshtml"
using BankAppMvc.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Customer\CustomerDetails.cshtml"
using System.Collections.Specialized;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Customer\CustomerDetails.cshtml"
using Microsoft.EntityFrameworkCore.Scaffolding;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5424b0494178753133cb9bd2cbdaac823a93b155", @"/Views/Customer/CustomerDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e6f306400523d3e72073ad8b0c57dd76fff90a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_CustomerDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BankAppMvc.ViewModels.CustomerDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-pressed", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Transaction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Customer\CustomerDetails.cshtml"
   ViewData["Title"] = "Customers Details"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"py-5\">\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12 mb-5\">\r\n            <div class=\"card\">\r\n                <div class=\"card-header\">\r\n                    <h4>Kundnummer: ");
#nullable restore
#line 15 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Customer\CustomerDetails.cshtml"
                               Write(Model.CustomerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <p>Förnamn: ");
#nullable restore
#line 18 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Customer\CustomerDetails.cshtml"
                           Write(Model.Givenname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>Efternamn: ");
#nullable restore
#line 19 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Customer\CustomerDetails.cshtml"
                             Write(Model.Surename);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>Gatuadress: ");
#nullable restore
#line 20 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Customer\CustomerDetails.cshtml"
                              Write(Model.StreetAdress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>Stad: ");
#nullable restore
#line 21 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Customer\CustomerDetails.cshtml"
                        Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>Land: ");
#nullable restore
#line 22 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Customer\CustomerDetails.cshtml"
                        Write(Model.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>

                <div class=""card-header"">
                    <h4>Kundens konton</h4>
                </div>
                <div class=""card-body"">
                    <table class=""table table-hover"">
                        <thead>
                            <tr>
                                <th>
                                    Kontonnummer
                                </th>
                                <th>
                                    Summa
                                </th>
                                <th>

                                </th>

                            </tr>
");
#nullable restore
#line 43 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Customer\CustomerDetails.cshtml"
                             foreach (var r in Model.Accounts)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 47 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Customer\CustomerDetails.cshtml"
                                   Write(r.AccountId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 48 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Customer\CustomerDetails.cshtml"
                                   Write(r.Balance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5424b0494178753133cb9bd2cbdaac823a93b1559400", async() => {
                WriteLiteral("Visa transaktioner");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Customer\CustomerDetails.cshtml"
                                                                                                                                                                WriteLiteral(r.AccountId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 51 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Customer\CustomerDetails.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </thead>\r\n\r\n                    </table>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BankAppMvc.ViewModels.CustomerDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591