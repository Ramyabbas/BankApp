#pragma checksum "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5800db9b9061f48930a7db26689f9bcd93f6ccb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5800db9b9061f48930a7db26689f9bcd93f6ccb7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e6f306400523d3e72073ad8b0c57dd76fff90a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BankAppMvc.ViewModels.StartPageViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""py-5"">
    <div class=""row"">
        <div class=""col-xl-3 col-lg-6 mb-4 mb-xl-0"">
            <div class=""bg-white shadow roundy p-4 h-100 d-flex align-items-center justify-content-between"">
                <div class=""flex-grow-1 d-flex align-items-center"">
                    <div class=""dot mr-3 bg-violet""></div>
                    <div class=""text"">
                        <h6 class=""mb-0"">Antal kunder</h6><span class=""text-gray"">");
#nullable restore
#line 13 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Home\Index.cshtml"
                                                                             Write(Model.Customers);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </div>
                </div>
                <div class=""icon text-white bg-violet""><i class=""fa fa-user""></i></div>
            </div>
        </div>
        <div class=""col-xl-3 col-lg-6 mb-4 mb-xl-0"">
            <div class=""bg-white shadow roundy p-4 h-100 d-flex align-items-center justify-content-between"">
                <div class=""flex-grow-1 d-flex align-items-center"">
                    <div class=""dot mr-3 bg-blue""></div>
                    <div class=""text"">
                        <h6 class=""mb-0"">Antal konton</h6><span class=""text-gray"">");
#nullable restore
#line 24 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Home\Index.cshtml"
                                                                             Write(Model.Accounts);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </div>
                </div>
                <div class=""icon text-white bg-blue""><i class=""o-id-card-1"" aria-hidden=""true""></i></div>
            </div>
        </div>
        <div class=""col-xl-3 col-lg-6 mb-4 mb-xl-0"">
            <div class=""bg-white shadow roundy p-4 h-100 d-flex align-items-center justify-content-between"">
                <div class=""flex-grow-1 d-flex align-items-center"">
                    <div class=""dot mr-3 bg-red""></div>
                    <div class=""text"">
                        <h6 class=""mb-0"">Summan av saldo på konton</h6><span class=""text-gray"">");
#nullable restore
#line 35 "C:\Users\rami9\OneDrive\Skrivbord\Skolan\BankAppMvc\BankAppMvc\Views\Home\Index.cshtml"
                                                                                          Write(Model.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n                <div class=\"icon text-white bg-red\"><i class=\"o-data-storage-1\" aria-hidden=\"true\"></i></div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BankAppMvc.ViewModels.StartPageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591