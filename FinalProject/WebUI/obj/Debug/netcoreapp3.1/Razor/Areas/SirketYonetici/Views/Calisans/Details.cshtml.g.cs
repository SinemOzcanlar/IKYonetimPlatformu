#pragma checksum "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fc1c4d23677dc9f70776d1ae6b4cfcfa5ab3993"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SirketYonetici_Views_Calisans_Details), @"mvc.1.0.view", @"/Areas/SirketYonetici/Views/Calisans/Details.cshtml")]
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
#line 1 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\_ViewImports.cshtml"
using WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\_ViewImports.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\_ViewImports.cshtml"
using Entities.Concrete.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\_ViewImports.cshtml"
using Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fc1c4d23677dc9f70776d1ae6b4cfcfa5ab3993", @"/Areas/SirketYonetici/Views/Calisans/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a79a8ff6601846e773eb80c86c5a0f2937b299d", @"/Areas/SirketYonetici/Views/_ViewImports.cshtml")]
    public class Areas_SirketYonetici_Views_Calisans_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.Concrete.Calisan>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Calisan</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 14 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Adi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 17 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.Adi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 20 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Soyadi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 23 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.Soyadi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 26 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DogumTarihi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 29 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.DogumTarihi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 32 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TcNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 35 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.TcNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 38 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ErisimTuru));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 41 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.ErisimTuru));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 44 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SozlesmeTuru));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 47 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.SozlesmeTuru));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 50 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EngelDerecesi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 53 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.EngelDerecesi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 56 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Uyruk));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 59 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.Uyruk));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 62 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cinsiyet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 65 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cinsiyet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 68 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.KanGrubu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 71 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.KanGrubu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 74 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EgitimDurumu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 77 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.EgitimDurumu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 80 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EgitimSeviyesi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 83 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.EgitimSeviyesi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 86 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SonTamamlananEgitimKurumu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 89 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.SonTamamlananEgitimKurumu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 92 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CocukSayisi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 95 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.CocukSayisi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 98 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.KullandigiYıllıkIzinSayisi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 101 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.KullandigiYıllıkIzinSayisi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 104 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.KalanYıllıkIzinSayisi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 107 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.KalanYıllıkIzinSayisi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 110 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ToplamKullanilanIzinSayisi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 113 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.ToplamKullanilanIzinSayisi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 116 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MailIs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 119 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.MailIs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 122 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MailKisisel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 125 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.MailKisisel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 128 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TelIs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 131 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.TelIs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 134 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TelKisisel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 137 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.TelKisisel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 140 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Fotograf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 143 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.Fotograf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 146 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AktifMi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 149 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.AktifMi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 152 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IseGirisTarihi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 155 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.IseGirisTarihi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 158 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SozlesmeBitisTarihi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 161 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.SozlesmeBitisTarihi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 164 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MedeniDurum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 167 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.MedeniDurum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 170 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Sirket));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 173 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.Sirket.SirketId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 176 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AcilDurumBilgiID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 179 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.AcilDurumBilgiID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 182 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AdresId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 185 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.AdresId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 188 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BaglantiSosyalMedyaId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 191 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.BaglantiSosyalMedyaId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 194 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BankaId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 197 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.BankaId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 200 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CalisanAvansID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 203 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.CalisanAvansID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 206 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.KullaniciYorumuId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 209 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.KullaniciYorumuId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 212 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 215 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 218 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ModifiedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 221 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
       Write(Html.DisplayFor(model => model.ModifiedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fc1c4d23677dc9f70776d1ae6b4cfcfa5ab399328970", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 226 "C:\Users\pc\Documents\GitHub\hr-management-project\FinalProject\WebUI\Areas\SirketYonetici\Views\Calisans\Details.cshtml"
                           WriteLiteral(Model.CalisanId);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fc1c4d23677dc9f70776d1ae6b4cfcfa5ab399331162", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.Concrete.Calisan> Html { get; private set; }
    }
}
#pragma warning restore 1591