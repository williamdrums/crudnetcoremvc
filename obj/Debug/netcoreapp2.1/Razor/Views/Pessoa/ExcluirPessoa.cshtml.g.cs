#pragma checksum "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\ExcluirPessoa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2011e038702bd570bffe48aa08819d6e0e88738"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pessoa_ExcluirPessoa), @"mvc.1.0.view", @"/Views/Pessoa/ExcluirPessoa.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pessoa/ExcluirPessoa.cshtml", typeof(AspNetCore.Views_Pessoa_ExcluirPessoa))]
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
#line 1 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\_ViewImports.cshtml"
using CadastroPessoa;

#line default
#line hidden
#line 2 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\_ViewImports.cshtml"
using CadastroPessoa.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2011e038702bd570bffe48aa08819d6e0e88738", @"/Views/Pessoa/ExcluirPessoa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db2933efadf110051704914082d78a139fcb37e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Pessoa_ExcluirPessoa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CadastroPessoa.Models.Pessoa>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExcluirPessoa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\ExcluirPessoa.cshtml"
  
    ViewData["Title"] = "ExcluirPessoa";

#line default
#line hidden
            BeginContext(88, 173, true);
            WriteLiteral("\r\n<h2>ExcluirPessoa</h2>\r\n\r\n<h3>Voce tem certeza que deseja excluir?</h3>\r\n<div>\r\n    <h4>Pessoa</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(262, 40, false);
#line 15 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\ExcluirPessoa.cshtml"
       Write(Html.DisplayNameFor(model => model.nome));

#line default
#line hidden
            EndContext();
            BeginContext(302, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(346, 36, false);
#line 18 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\ExcluirPessoa.cshtml"
       Write(Html.DisplayFor(model => model.nome));

#line default
#line hidden
            EndContext();
            BeginContext(382, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(426, 45, false);
#line 21 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\ExcluirPessoa.cshtml"
       Write(Html.DisplayNameFor(model => model.sobrenome));

#line default
#line hidden
            EndContext();
            BeginContext(471, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(515, 41, false);
#line 24 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\ExcluirPessoa.cshtml"
       Write(Html.DisplayFor(model => model.sobrenome));

#line default
#line hidden
            EndContext();
            BeginContext(556, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(600, 39, false);
#line 27 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\ExcluirPessoa.cshtml"
       Write(Html.DisplayNameFor(model => model.cpf));

#line default
#line hidden
            EndContext();
            BeginContext(639, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(683, 35, false);
#line 30 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\ExcluirPessoa.cshtml"
       Write(Html.DisplayFor(model => model.cpf));

#line default
#line hidden
            EndContext();
            BeginContext(718, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(762, 41, false);
#line 33 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\ExcluirPessoa.cshtml"
       Write(Html.DisplayNameFor(model => model.idade));

#line default
#line hidden
            EndContext();
            BeginContext(803, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(847, 37, false);
#line 36 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\ExcluirPessoa.cshtml"
       Write(Html.DisplayFor(model => model.idade));

#line default
#line hidden
            EndContext();
            BeginContext(884, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(928, 44, false);
#line 39 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\ExcluirPessoa.cshtml"
       Write(Html.DisplayNameFor(model => model.telefone));

#line default
#line hidden
            EndContext();
            BeginContext(972, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1016, 40, false);
#line 42 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\ExcluirPessoa.cshtml"
       Write(Html.DisplayFor(model => model.telefone));

#line default
#line hidden
            EndContext();
            BeginContext(1056, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1102, 47, false);
#line 46 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\ExcluirPessoa.cshtml"
       Write(Html.DisplayNameFor(model => model.localizacao));

#line default
#line hidden
            EndContext();
            BeginContext(1149, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1193, 43, false);
#line 49 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\ExcluirPessoa.cshtml"
       Write(Html.DisplayFor(model => model.localizacao));

#line default
#line hidden
            EndContext();
            BeginContext(1236, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1280, 41, false);
#line 52 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\ExcluirPessoa.cshtml"
       Write(Html.DisplayNameFor(model => model.hobby));

#line default
#line hidden
            EndContext();
            BeginContext(1321, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1365, 37, false);
#line 55 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\ExcluirPessoa.cshtml"
       Write(Html.DisplayFor(model => model.hobby));

#line default
#line hidden
            EndContext();
            BeginContext(1402, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1440, 222, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80f1e923b64546caa2124349d49c4b73", async() => {
                BeginContext(1473, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1483, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c56b517da94b4d71b1a80b0b15b0c3f8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 60 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\ExcluirPessoa.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdPessoa);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1525, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1609, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "137bdc1ebd6e49d1939726fa5d3db6ea", async() => {
                    BeginContext(1631, 14, true);
                    WriteLiteral("Voltar a Lista");
                    EndContext();
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
                EndContext();
                BeginContext(1649, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1662, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CadastroPessoa.Models.Pessoa> Html { get; private set; }
    }
}
#pragma warning restore 1591
