#pragma checksum "D:\Documents\GitHub\YeniWebProje\YasayanKutuphane\Areas\Identity\Pages\Account\Logout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f7d194b822bd00b2ad290f32c3ceb07acd2be3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Logout), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Logout.cshtml")]
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
#line 1 "D:\Documents\GitHub\YeniWebProje\YasayanKutuphane\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documents\GitHub\YeniWebProje\YasayanKutuphane\Areas\Identity\Pages\_ViewImports.cshtml"
using YasayanKutuphane.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Documents\GitHub\YeniWebProje\YasayanKutuphane\Areas\Identity\Pages\_ViewImports.cshtml"
using YasayanKutuphane.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Documents\GitHub\YeniWebProje\YasayanKutuphane\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using YasayanKutuphane.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Documents\GitHub\YeniWebProje\YasayanKutuphane\Areas\Identity\Pages\Account\Logout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f7d194b822bd00b2ad290f32c3ceb07acd2be3e", @"/Areas/Identity/Pages/Account/Logout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8100f9fb4f8f012f6b934d456c1ece62411a8951", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ce83a081ec9c191c36ab65765b8fc5433934cd1", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Logout : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Documents\GitHub\YeniWebProje\YasayanKutuphane\Areas\Identity\Pages\Account\Logout.cshtml"
  
    ViewData["Title"] = "Çıkış Yapıldı";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Documents\GitHub\YeniWebProje\YasayanKutuphane\Areas\Identity\Pages\Account\Logout.cshtml"
 if (HttpContext.Session.GetString("GirisYapanEmail") == "b161210115@sakarya.edu.tr")
{
    Layout = "~/Pages/Shared/_Layout.cshtml";
}
else
{
    Layout = "~/Pages/Shared/_Layout1.cshtml";
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<header>\r\n    <h1>");
#nullable restore
#line 16 "D:\Documents\GitHub\YeniWebProje\YasayanKutuphane\Areas\Identity\Pages\Account\Logout.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p>Siteden Başarılı Bir Şekilde Çıkıp Yaptınız. Yeniden Görüşmek Dileğiyle</p>\r\n</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LogoutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LogoutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LogoutModel>)PageContext?.ViewData;
        public LogoutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
