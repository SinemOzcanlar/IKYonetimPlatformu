#pragma checksum "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Views\Calisan\CalisanEgitimGoruntuleme.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d29251e4084e0a3a11465b811143eae0bac02fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calisan_CalisanEgitimGoruntuleme), @"mvc.1.0.view", @"/Views/Calisan/CalisanEgitimGoruntuleme.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d29251e4084e0a3a11465b811143eae0bac02fc", @"/Views/Calisan/CalisanEgitimGoruntuleme.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a79a8ff6601846e773eb80c86c5a0f2937b299d", @"/Views/_ViewImports.cshtml")]
    public class Views_Calisan_CalisanEgitimGoruntuleme : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataAccess.ViewModels.CalisanEgitimViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Views\Calisan\CalisanEgitimGoruntuleme.cshtml"
  
    ViewData["Title"] = "CalisanEgitimGoruntuleme";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link href=""Bootstrap4/css/bootstrap.min.css"" rel=""stylesheet"" />
<style>
    .marginleft {
        margin-left: 335px;
    }
</style>
<div class=""row"">
    <div class=""col"">
        <div class=""card"">
            <div class=""card-body"">
                <h5 class=""card-title"">");
#nullable restore
#line 17 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Views\Calisan\CalisanEgitimGoruntuleme.cshtml"
                                  Write(Model.Calisan.Adi);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 17 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Views\Calisan\CalisanEgitimGoruntuleme.cshtml"
                                                     Write(Model.Calisan.Soyadi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Eğitim Bilgileri</h5>
                <table class=""table"">
                    <thead>
                        <tr>
                            <th scope=""col"">#</th>
                            <th scope=""col"">Okul Adı</th>
                            <th scope=""col"">Eğitim Seviyesi</th>
                            <th scope=""col"">Mezuniyet Tarihi</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 28 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Views\Calisan\CalisanEgitimGoruntuleme.cshtml"
                         for (int i = 0; i < Model.EgitimBilgileri.Count; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th scope=\"row\">");
#nullable restore
#line 31 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Views\Calisan\CalisanEgitimGoruntuleme.cshtml"
                                            Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td>");
#nullable restore
#line 32 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Views\Calisan\CalisanEgitimGoruntuleme.cshtml"
                               Write(Model.EgitimBilgileri.ElementAtOrDefault(i).OkulAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 33 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Views\Calisan\CalisanEgitimGoruntuleme.cshtml"
                               Write(Model.EgitimBilgileri.ElementAtOrDefault(i).EgitimSeviyesi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 34 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Views\Calisan\CalisanEgitimGoruntuleme.cshtml"
                               Write(Model.EgitimBilgileri.ElementAtOrDefault(i).MezuniyetTarihi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 36 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Views\Calisan\CalisanEgitimGoruntuleme.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>
<script src=""Bootstrap4/js/bootstrap.min.js""></script>
<script>
    $(document).ready(function () {
        $('.leftmenutrigger').on('click', function (e) {
            $('.side-nav').toggleClass(""open"");
            e.preventDefault();
        });
    });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataAccess.ViewModels.CalisanEgitimViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
