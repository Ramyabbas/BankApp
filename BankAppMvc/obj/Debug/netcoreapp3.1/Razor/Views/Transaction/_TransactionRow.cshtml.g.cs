#pragma checksum "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Transaction\_TransactionRow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f1bd0df8284e6490891c7b58ac9d8552375bda3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaction__TransactionRow), @"mvc.1.0.view", @"/Views/Transaction/_TransactionRow.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f1bd0df8284e6490891c7b58ac9d8552375bda3", @"/Views/Transaction/_TransactionRow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e6f306400523d3e72073ad8b0c57dd76fff90a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Transaction__TransactionRow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BankAppMvc.ViewModels.TransactionsRowViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Transaction\_TransactionRow.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            <tr>\r\n                                <td>");
#nullable restore
#line 10 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Transaction\_TransactionRow.cshtml"
                               Write(Model.TransactionId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 11 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Transaction\_TransactionRow.cshtml"
                               Write(Model.AccountId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 12 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Transaction\_TransactionRow.cshtml"
                               Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 13 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Transaction\_TransactionRow.cshtml"
                               Write(Model.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 14 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Transaction\_TransactionRow.cshtml"
                               Write(Model.Operation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 15 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Transaction\_TransactionRow.cshtml"
                               Write(Model.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 16 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Transaction\_TransactionRow.cshtml"
                               Write(Model.Balance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 17 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Transaction\_TransactionRow.cshtml"
                               Write(Model.Bank);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 18 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Transaction\_TransactionRow.cshtml"
                               Write(Model.Account);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            </tr>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BankAppMvc.ViewModels.TransactionsRowViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591