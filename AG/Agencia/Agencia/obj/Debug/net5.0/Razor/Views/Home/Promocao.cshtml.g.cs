#pragma checksum "C:\Users\marci\Desktop\AG\Agencia\Agencia\Views\Home\Promocao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e56d9f547fb272b97ecf08a75bcb8fd003025d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Promocao), @"mvc.1.0.view", @"/Views/Home/Promocao.cshtml")]
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
#line 1 "C:\Users\marci\Desktop\AG\Agencia\Agencia\Views\_ViewImports.cshtml"
using Agencia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\marci\Desktop\AG\Agencia\Agencia\Views\_ViewImports.cshtml"
using Agencia.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e56d9f547fb272b97ecf08a75bcb8fd003025d7", @"/Views/Home/Promocao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8c1edf026f68711ff2f456243198b6a2720ddf2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Promocao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\marci\Desktop\AG\Agencia\Agencia\Views\Home\Promocao.cshtml"
  
    ViewData["Title"] = "Promoção";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e56d9f547fb272b97ecf08a75bcb8fd003025d73376", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Destino</title>\r\n    <link rel=\"stylesheet\" href=\"/style.css\">\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e56d9f547fb272b97ecf08a75bcb8fd003025d74612", async() => {
                WriteLiteral(@"
    <section class=""wrap"">
        
        <main>
            <h2 class=""pagina-titulo"">Promoções</h2>
            <div class=""promocoes"">
                <div class=""promocao"">
                    <img src=""../img/disney.png"" alt=""disney"">
                    <h3>Disney</h3>
                    <p>De <s>R$900,00</s> por <span>R$200,00</span> </p>
                </div>
                <div class=""promocao"">
                    <img src=""../img/egito.jpg"" alt=""egito"">
                    <h3>Egito</h3>
                    <p>De <s>R$1000,00</s> por <span>R$500,00</span> </p>
                </div>
                <div class=""promocao"">
                    <img src=""../img/fernando_noronha.jpg"" alt=""egito"">
                    <h3>Fernando de Noronha</h3>
                    <p>De <s>R$50.000,00</s> por <span>R$25.000,00</span> </p>
                </div>
                <div class=""promocao"">
                    <img src=""../img/japao.jpg"" alt=""japao"">
                    <h3>Japão</h");
                WriteLiteral(@"3>
                    <p>De <s>R$3500,00</s> por <span>R$1200,00</span> </p>
                </div>
                <div class=""promocao"">
                    <img src=""../img/noroega.jpg"" alt=""noruega"">
                    <h3>Noruega</h3>
                    <p>De <s>R$2350,00</s> por <span>R$235,00</span> </p>
                </div>
                <div class=""promocao"">
                    <img src=""../img/paris.jpg"" alt=""paris"">
                    <h3>Paris</h3>
                    <p>De <s>R$3400,00</s> por <span>R$100,00</span> </p>
                </div>
            </div>
            
        </main>
    </section>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
