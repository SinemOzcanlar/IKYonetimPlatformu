#pragma checksum "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36fad2017ffee2499b4ec0b5fc7fda9116e05930"
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
#line 1 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Views\_ViewImports.cshtml"
using WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Views\_ViewImports.cshtml"
using Entities.Concrete.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Views\_ViewImports.cshtml"
using Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36fad2017ffee2499b4ec0b5fc7fda9116e05930", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a79a8ff6601846e773eb80c86c5a0f2937b299d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Views\Home\Index.cshtml"
 if (Context.Request.Cookies["Username"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span>\r\n        ");
#nullable restore
#line 8 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Views\Home\Index.cshtml"
   Write(Context.Request.Cookies["Username"].ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral(" Hoş geldiniz...\r\n    </span>\r\n");
#nullable restore
#line 10 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\" style=\"margin-top:50px\">\r\n\r\n    <div class=\"container col-6\">\r\n        ");
#nullable restore
#line 15 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Views\Home\Index.cshtml"
   Write(await Component.InvokeAsync("CalisanAvanslar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"container col-6\">\r\n        ");
#nullable restore
#line 19 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Views\Home\Index.cshtml"
   Write(await Component.InvokeAsync("ResmiTatil"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
