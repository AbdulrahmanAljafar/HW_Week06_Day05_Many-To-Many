#pragma checksum "C:\Users\abdul\OneDrive\سطح المكتب\.net\HW_Week06_Day05_Many-To-Many\CodeFirstApp\Views\Customers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebbdc87ce95301898df5a98f7bdaf3246ca2aeca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Index), @"mvc.1.0.view", @"/Views/Customers/Index.cshtml")]
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
#line 1 "C:\Users\abdul\OneDrive\سطح المكتب\.net\HW_Week06_Day05_Many-To-Many\CodeFirstApp\Views\_ViewImports.cshtml"
using CodeFirstApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abdul\OneDrive\سطح المكتب\.net\HW_Week06_Day05_Many-To-Many\CodeFirstApp\Views\_ViewImports.cshtml"
using CodeFirstApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebbdc87ce95301898df5a98f7bdaf3246ca2aeca", @"/Views/Customers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a67b1c23b3f15af6920d3c70b52285a28e3f28e", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\abdul\OneDrive\سطح المكتب\.net\HW_Week06_Day05_Many-To-Many\CodeFirstApp\Views\Customers\Index.cshtml"
  
    var Customers = (List<CustomerModel>)ViewData["Customers"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>ID</th>\r\n            <th>First Name</th>\r\n            <th>Last Name</th>\r\n            <th>Email</th>\r\n        </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n");
#nullable restore
#line 16 "C:\Users\abdul\OneDrive\سطح المكتب\.net\HW_Week06_Day05_Many-To-Many\CodeFirstApp\Views\Customers\Index.cshtml"
         foreach (var Customer in Customers)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\abdul\OneDrive\سطح المكتب\.net\HW_Week06_Day05_Many-To-Many\CodeFirstApp\Views\Customers\Index.cshtml"
               Write(Customer.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\abdul\OneDrive\سطح المكتب\.net\HW_Week06_Day05_Many-To-Many\CodeFirstApp\Views\Customers\Index.cshtml"
               Write(Customer.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\abdul\OneDrive\سطح المكتب\.net\HW_Week06_Day05_Many-To-Many\CodeFirstApp\Views\Customers\Index.cshtml"
               Write(Customer.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\abdul\OneDrive\سطح المكتب\.net\HW_Week06_Day05_Many-To-Many\CodeFirstApp\Views\Customers\Index.cshtml"
               Write(Customer.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 24 "C:\Users\abdul\OneDrive\سطح المكتب\.net\HW_Week06_Day05_Many-To-Many\CodeFirstApp\Views\Customers\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n</table>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
