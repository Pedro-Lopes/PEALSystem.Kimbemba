#pragma checksum "C:\#PEAL\Dev\PEAL\PEALSystem.Kimbemba\PEALSystem.Kimbemba\Views\CodigoBarra\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34afb9e9e18dca50d853e956bc88bf77c698ad0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CodigoBarra_Detalhes), @"mvc.1.0.view", @"/Views/CodigoBarra/Detalhes.cshtml")]
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
#line 1 "C:\#PEAL\Dev\PEAL\PEALSystem.Kimbemba\PEALSystem.Kimbemba\Views\_ViewImports.cshtml"
using PEALSystem.Kimbemba;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\#PEAL\Dev\PEAL\PEALSystem.Kimbemba\PEALSystem.Kimbemba\Views\_ViewImports.cshtml"
using PEALSystem.Kimbemba.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34afb9e9e18dca50d853e956bc88bf77c698ad0e", @"/Views/CodigoBarra/Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03bb505039ace4b1c379df94c3b8faaa48f93962", @"/Views/_ViewImports.cshtml")]
    public class Views_CodigoBarra_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PEALSystem.Kimbemba.Models.CodigoBarra>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::PEALSystem.Kimbemba.Tags.BarCodeTagHelper __PEALSystem_Kimbemba_Tags_BarCodeTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\#PEAL\Dev\PEAL\PEALSystem.Kimbemba\PEALSystem.Kimbemba\Views\CodigoBarra\Detalhes.cshtml"
  
    ViewData["Title"] = "Detalhes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalhes</h1>\r\n\r\n<div>\r\n    <h4>CodigoBarra</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\#PEAL\Dev\PEAL\PEALSystem.Kimbemba\PEALSystem.Kimbemba\Views\CodigoBarra\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("barcode", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "34afb9e9e18dca50d853e956bc88bf77c698ad0e5003", async() => {
            }
            );
            __PEALSystem_Kimbemba_Tags_BarCodeTagHelper = CreateTagHelper<global::PEALSystem.Kimbemba.Tags.BarCodeTagHelper>();
            __tagHelperExecutionContext.Add(__PEALSystem_Kimbemba_Tags_BarCodeTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "content", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 17 "C:\#PEAL\Dev\PEAL\PEALSystem.Kimbemba\PEALSystem.Kimbemba\Views\CodigoBarra\Detalhes.cshtml"
AddHtmlAttributeValue("", 352, Model.Codigo, 352, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\#PEAL\Dev\PEAL\PEALSystem.Kimbemba\PEALSystem.Kimbemba\Views\CodigoBarra\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.CodigoAEN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\#PEAL\Dev\PEAL\PEALSystem.Kimbemba\PEALSystem.Kimbemba\Views\CodigoBarra\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.CodigoAEN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\#PEAL\Dev\PEAL\PEALSystem.Kimbemba\PEALSystem.Kimbemba\Views\CodigoBarra\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Numero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\#PEAL\Dev\PEAL\PEALSystem.Kimbemba\PEALSystem.Kimbemba\Views\CodigoBarra\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Numero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\#PEAL\Dev\PEAL\PEALSystem.Kimbemba\PEALSystem.Kimbemba\Views\CodigoBarra\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Data));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\#PEAL\Dev\PEAL\PEALSystem.Kimbemba\PEALSystem.Kimbemba\Views\CodigoBarra\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Data));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\#PEAL\Dev\PEAL\PEALSystem.Kimbemba\PEALSystem.Kimbemba\Views\CodigoBarra\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.IsValid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\#PEAL\Dev\PEAL\PEALSystem.Kimbemba\PEALSystem.Kimbemba\Views\CodigoBarra\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.IsValid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34afb9e9e18dca50d853e956bc88bf77c698ad0e9234", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PEALSystem.Kimbemba.Models.CodigoBarra> Html { get; private set; }
    }
}
#pragma warning restore 1591
