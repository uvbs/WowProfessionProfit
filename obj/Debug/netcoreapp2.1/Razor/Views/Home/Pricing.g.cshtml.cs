#pragma checksum "D:\VisualStudioProjects\WowProfitCalcProfessions\WowProfitCalcProfessions\Views\Home\Pricing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70287d589508462483aca2676ad64806a3982df4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Pricing), @"mvc.1.0.view", @"/Views/Home/Pricing.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Pricing.cshtml", typeof(AspNetCore.Views_Home_Pricing))]
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
#line 1 "D:\VisualStudioProjects\WowProfitCalcProfessions\WowProfitCalcProfessions\Views\_ViewImports.cshtml"
using WowProfitCalcProfessions;

#line default
#line hidden
#line 2 "D:\VisualStudioProjects\WowProfitCalcProfessions\WowProfitCalcProfessions\Views\_ViewImports.cshtml"
using WowProfitCalcProfessions.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70287d589508462483aca2676ad64806a3982df4", @"/Views/Home/Pricing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"168fa2028726462d03ceee8f424641ad4fa98c86", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Pricing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WowProfitCalcProfessions.Models.ItemModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("panel-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\VisualStudioProjects\WowProfitCalcProfessions\WowProfitCalcProfessions\Views\Home\Pricing.cshtml"
  
	Layout = null;

#line default
#line hidden
            BeginContext(88, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(117, 170, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4d124b603d74f709d584f1de59d7a4b", async() => {
                BeginContext(123, 59, true);
                WriteLiteral("\r\n\t<meta name=\"viewport\" content=\"width=device-width\" />\r\n\t");
                EndContext();
                BeginContext(182, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c8ef7e24e1ea446ab614f9138276132d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(253, 27, true);
                WriteLiteral("\r\n\t<title>Pricing</title>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(287, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(289, 489, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b92e2eef7bb044ae9e8f77d5a5aeca13", async() => {
                BeginContext(314, 172, true);
                WriteLiteral("\r\n\t<h2>Costs</h2>\r\n\t<table class=\"table table-sm table-striped table-bordered\">\r\n\t\t<thead>\r\n\t\t\t<tr>\r\n\t\t\t\t<th>Name</th>\r\n\t\t\t\t<th>Cost</th>\r\n\t\t\t</tr>\r\n\t\t</thead>\r\n\t\t<tbody>\r\n");
                EndContext();
#line 24 "D:\VisualStudioProjects\WowProfitCalcProfessions\WowProfitCalcProfessions\Views\Home\Pricing.cshtml"
              
				int count = 0;
				foreach (WowProfitCalcProfessions.Models.ItemModel item in Model)
				{
					count = count + 1;
					float cost = item.Cost / 100f;

#line default
#line hidden
                BeginContext(653, 21, true);
                WriteLiteral("\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td>");
                EndContext();
                BeginContext(675, 5, false);
#line 31 "D:\VisualStudioProjects\WowProfitCalcProfessions\WowProfitCalcProfessions\Views\Home\Pricing.cshtml"
                       Write(count);

#line default
#line hidden
                EndContext();
                BeginContext(680, 2, true);
                WriteLiteral(". ");
                EndContext();
                BeginContext(683, 9, false);
#line 31 "D:\VisualStudioProjects\WowProfitCalcProfessions\WowProfitCalcProfessions\Views\Home\Pricing.cshtml"
                               Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(692, 17, true);
                WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
                EndContext();
                BeginContext(710, 4, false);
#line 32 "D:\VisualStudioProjects\WowProfitCalcProfessions\WowProfitCalcProfessions\Views\Home\Pricing.cshtml"
                       Write(cost);

#line default
#line hidden
                EndContext();
                BeginContext(714, 21, true);
                WriteLiteral(" s</td>\r\n\t\t\t\t\t</tr>\r\n");
                EndContext();
#line 34 "D:\VisualStudioProjects\WowProfitCalcProfessions\WowProfitCalcProfessions\Views\Home\Pricing.cshtml"
				}
			

#line default
#line hidden
                BeginContext(748, 23, true);
                WriteLiteral("\t\t</tbody>\r\n\t</table>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(778, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WowProfitCalcProfessions.Models.ItemModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
