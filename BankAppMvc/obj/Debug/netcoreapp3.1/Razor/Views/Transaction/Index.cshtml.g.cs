#pragma checksum "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Transaction\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b01ede08a4f56b2b43655837efae910ff13e24a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaction_Index), @"mvc.1.0.view", @"/Views/Transaction/Index.cshtml")]
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
#line 1 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Transaction\Index.cshtml"
using System.Collections.Specialized;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Transaction\Index.cshtml"
using Microsoft.EntityFrameworkCore.Scaffolding;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b01ede08a4f56b2b43655837efae910ff13e24a5", @"/Views/Transaction/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e6f306400523d3e72073ad8b0c57dd76fff90a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Transaction_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BankAppMvc.ViewModels.CustomerTransactionsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TransactionRow", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Transaction\Index.cshtml"
   ViewData["Title"] = "Customers Transactions"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""py-5"">

    <div class=""row"">
        <div class=""col-lg-12 mb-5"">
            <div class=""card"">
                <div class=""card-header"">

                </div>
                <div class=""card-body"">
                    <table class=""table table-hover"" id=""transaction"">
                        <thead>
                            <tr>
                                <th scope=""col"">Id</th>
                                <th scope=""col"">Konotonummer</th>
                                <th scope=""col"">Datum</th>
                                <th scope=""col"">Typ</th>
                                <th scope=""col"">Drift</th>
                                <th scope=""col"">Belopp</th>
                                <th scope=""col"">Summa</th>
                                <th scope=""col"">Bank</th>
                                <th scope=""col"">Konto</th>

                            </tr>
                        </thead>
                        <thead>
");
#nullable restore
#line 34 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Transaction\Index.cshtml"
                             foreach (var transaction in Model.Transactions)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b01ede08a4f56b2b43655837efae910ff13e24a55603", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 36 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Transaction\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = transaction;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Transaction\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </table>\r\n                </div>\r\n                <a class=\"btn btn-primary\" href=\"#\" onclick=\"fetch20more(); return false;\">se 20 transaktioner till ....</a>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
                    <script>
                        var skip = 0;
                        console.log(""here"")
                        function fetch20more() {
                            skip = skip + 20;
                            $.ajax({
                                url: ""/Transaction/GetTransactionsFrom?skip="" + skip, success: function (result) {
                                    $(""#transaction"").append(result);
                                }
                            });
                        }
                    </script>
                ");
            }
            );
            WriteLiteral("            </div>\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BankAppMvc.ViewModels.CustomerTransactionsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591