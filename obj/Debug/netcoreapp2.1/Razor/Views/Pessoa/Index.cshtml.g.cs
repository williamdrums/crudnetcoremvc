#pragma checksum "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6ee8cfd1afcf34729736c6416a7f24f9463077b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pessoa_Index), @"mvc.1.0.view", @"/Views/Pessoa/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pessoa/Index.cshtml", typeof(AspNetCore.Views_Pessoa_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6ee8cfd1afcf34729736c6416a7f24f9463077b", @"/Views/Pessoa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db2933efadf110051704914082d78a139fcb37e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Pessoa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CadastroPessoa.Models.Pessoa>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CriarPessoa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AtualizarPessoa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(93, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(122, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d9812e841cf42e588e85a34dcedd2de", async() => {
                BeginContext(150, 17, true);
                WriteLiteral("Criar Nova Pessoa");
                EndContext();
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
            EndContext();
            BeginContext(171, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(264, 44, false);
#line 16 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdPessoa));

#line default
#line hidden
            EndContext();
            BeginContext(308, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(364, 40, false);
#line 19 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.nome));

#line default
#line hidden
            EndContext();
            BeginContext(404, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(460, 45, false);
#line 22 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.sobrenome));

#line default
#line hidden
            EndContext();
            BeginContext(505, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(561, 41, false);
#line 25 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(602, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(658, 39, false);
#line 28 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.cpf));

#line default
#line hidden
            EndContext();
            BeginContext(697, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(753, 41, false);
#line 31 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.idade));

#line default
#line hidden
            EndContext();
            BeginContext(794, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(850, 44, false);
#line 34 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.telefone));

#line default
#line hidden
            EndContext();
            BeginContext(894, 57, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(952, 47, false);
#line 38 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.localizacao));

#line default
#line hidden
            EndContext();
            BeginContext(999, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1055, 41, false);
#line 41 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.hobby));

#line default
#line hidden
            EndContext();
            BeginContext(1096, 90, true);
            WriteLiteral("\r\n            </th>\r\n            <th>Acao</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 47 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1218, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1267, 43, false);
#line 50 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdPessoa));

#line default
#line hidden
            EndContext();
            BeginContext(1310, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1366, 39, false);
#line 53 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.nome));

#line default
#line hidden
            EndContext();
            BeginContext(1405, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1461, 44, false);
#line 56 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.sobrenome));

#line default
#line hidden
            EndContext();
            BeginContext(1505, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1561, 40, false);
#line 59 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.email));

#line default
#line hidden
            EndContext();
            BeginContext(1601, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1657, 38, false);
#line 62 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.cpf));

#line default
#line hidden
            EndContext();
            BeginContext(1695, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1751, 40, false);
#line 65 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.idade));

#line default
#line hidden
            EndContext();
            BeginContext(1791, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1847, 43, false);
#line 68 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.telefone));

#line default
#line hidden
            EndContext();
            BeginContext(1890, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1946, 46, false);
#line 71 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.localizacao));

#line default
#line hidden
            EndContext();
            BeginContext(1992, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2048, 40, false);
#line 74 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.hobby));

#line default
#line hidden
            EndContext();
            BeginContext(2088, 73, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                \r\n                ");
            EndContext();
            BeginContext(2161, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df3370c9391f4077b5c3fcdc8a26272e", async() => {
                BeginContext(2223, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\Index.cshtml"
                                                  WriteLiteral(item.IdPessoa);

#line default
#line hidden
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
            EndContext();
            BeginContext(2231, 4, true);
            WriteLiteral(" |\r\n");
            EndContext();
            BeginContext(2322, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(2338, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bae0de483114f408b05a28eb5957eb6", async() => {
                BeginContext(2398, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 80 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\Index.cshtml"
                                                WriteLiteral(item.IdPessoa);

#line default
#line hidden
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
            EndContext();
            BeginContext(2408, 38, true);
            WriteLiteral("\r\n\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 84 "C:\Users\developer\Desktop\CadastroPessoa\CadastroPessoa\Views\Pessoa\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2449, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CadastroPessoa.Models.Pessoa>> Html { get; private set; }
    }
}
#pragma warning restore 1591