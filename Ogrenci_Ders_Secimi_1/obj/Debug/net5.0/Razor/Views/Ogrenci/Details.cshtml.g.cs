#pragma checksum "C:\Users\PATRON\Desktop\Visual Studio\Projeler\VİSUAL Projeler\Ogrenci_Ders_Secimi_1\ogrenci_ders_secimi_1\Views\Ogrenci\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cdc3b3eea30adefaf06ac70528a6060d0170197"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ogrenci_Details), @"mvc.1.0.view", @"/Views/Ogrenci/Details.cshtml")]
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
#line 1 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\VİSUAL Projeler\Ogrenci_Ders_Secimi_1\ogrenci_ders_secimi_1\Views\_ViewImports.cshtml"
using Ogrenci_Ders_Secimi_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\VİSUAL Projeler\Ogrenci_Ders_Secimi_1\ogrenci_ders_secimi_1\Views\_ViewImports.cshtml"
using Ogrenci_Ders_Secimi_1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cdc3b3eea30adefaf06ac70528a6060d0170197", @"/Views/Ogrenci/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef87d44dd3f9840ca84c913bdefb0bfcceb9eb38", @"/Views/_ViewImports.cshtml")]
    public class Views_Ogrenci_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ogrenci>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\VİSUAL Projeler\Ogrenci_Ders_Secimi_1\ogrenci_ders_secimi_1\Views\Ogrenci\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"bg-dark text-light\">Öğrenci Detayları</h1>\r\n\r\n<div class=\"bg-dark text-light\">\r\n    <h4>Öğrenci</h4>\r\n    <h5>Öğrenci ID: </h5>\r\n    <p class=\"text-light\">");
#nullable restore
#line 11 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\VİSUAL Projeler\Ogrenci_Ders_Secimi_1\ogrenci_ders_secimi_1\Views\Ogrenci\Details.cshtml"
                     Write(Model.OgrenciId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h5>Öğrenci Ad</h5>\r\n    <p class=\"text-light\">");
#nullable restore
#line 13 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\VİSUAL Projeler\Ogrenci_Ders_Secimi_1\ogrenci_ders_secimi_1\Views\Ogrenci\Details.cshtml"
                     Write(Model.OgrenciAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h5>Öğrenci Soyad</h5>\r\n    <p class=\"text-light\">");
#nullable restore
#line 15 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\VİSUAL Projeler\Ogrenci_Ders_Secimi_1\ogrenci_ders_secimi_1\Views\Ogrenci\Details.cshtml"
                     Write(Model.OgrenciSoyAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h5>Öğrenci Doğum Tarihi</h5>\r\n    <p class=\"text-light\">");
#nullable restore
#line 17 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\VİSUAL Projeler\Ogrenci_Ders_Secimi_1\ogrenci_ders_secimi_1\Views\Ogrenci\Details.cshtml"
                     Write(Model.OgrenciDogumTarihi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h5>Öğrenci Kayıt Tarihi</h5>\r\n    <p class=\"text-light\">");
#nullable restore
#line 19 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\VİSUAL Projeler\Ogrenci_Ders_Secimi_1\ogrenci_ders_secimi_1\Views\Ogrenci\Details.cshtml"
                     Write(Model.OgrenciKayitTarihi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h5>Öğrenci Dönemi</h5>\r\n    <p class=\"text-light\">");
#nullable restore
#line 21 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\VİSUAL Projeler\Ogrenci_Ders_Secimi_1\ogrenci_ders_secimi_1\Views\Ogrenci\Details.cshtml"
                     Write(Model.OgrenciDonemi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cdc3b3eea30adefaf06ac70528a6060d01701976158", async() => {
                WriteLiteral("Öğrenci Sayfasına Dön");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ogrenci> Html { get; private set; }
    }
}
#pragma warning restore 1591
