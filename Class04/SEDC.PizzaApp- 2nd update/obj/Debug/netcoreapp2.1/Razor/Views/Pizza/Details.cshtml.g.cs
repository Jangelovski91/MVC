#pragma checksum "C:\Users\Ace\Desktop\SEDC.PizzaApp\Views\Pizza\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a4b617d9d3407ce124a146801686bf0cfd63d26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizza_Details), @"mvc.1.0.view", @"/Views/Pizza/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pizza/Details.cshtml", typeof(AspNetCore.Views_Pizza_Details))]
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
#line 1 "C:\Users\Ace\Desktop\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp;

#line default
#line hidden
#line 2 "C:\Users\Ace\Desktop\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a4b617d9d3407ce124a146801686bf0cfd63d26", @"/Views/Pizza/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9da3483405b0ddc092d1e77dd5d8a02d663a044", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizza_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SEDC.PizzaApp.Models.ViewModels.PizzaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/PartialViews/_HelloFromPizzaWorld.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(176, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(185, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4e57a276bd1b4e32bb5f844c61cd40d9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(259, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(266, 17, false);
#line 8 "C:\Users\Ace\Desktop\SEDC.PizzaApp\Views\Pizza\Details.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(283, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\Ace\Desktop\SEDC.PizzaApp\Views\Pizza\Details.cshtml"
 if (ViewBag.Pizza.IsOnPromotion = true)
{

#line default
#line hidden
            BeginContext(337, 21, true);
            WriteLiteral("    <h2>\"Pizza Name:\"");
            EndContext();
            BeginContext(359, 18, false);
#line 12 "C:\Users\Ace\Desktop\SEDC.PizzaApp\Views\Pizza\Details.cshtml"
                Write(ViewBag.Pizza.Name);

#line default
#line hidden
            EndContext();
            BeginContext(377, 23, true);
            WriteLiteral("</h2>\r\n    <p>\"Price:\" ");
            EndContext();
            BeginContext(401, 19, false);
#line 13 "C:\Users\Ace\Desktop\SEDC.PizzaApp\Views\Pizza\Details.cshtml"
           Write(ViewBag.Pizza.Price);

#line default
#line hidden
            EndContext();
            BeginContext(420, 26, true);
            WriteLiteral("</p>\r\n    <p>Pizza Size:\" ");
            EndContext();
            BeginContext(447, 23, false);
#line 14 "C:\Users\Ace\Desktop\SEDC.PizzaApp\Views\Pizza\Details.cshtml"
               Write(ViewBag.Pizza.PizzaSize);

#line default
#line hidden
            EndContext();
            BeginContext(470, 18, true);
            WriteLiteral("</p>\r\n    <br />\r\n");
            EndContext();
            BeginContext(490, 41, true);
            WriteLiteral("    <h4>This Pizza is on promotion</h4>\r\n");
            EndContext();
#line 18 "C:\Users\Ace\Desktop\SEDC.PizzaApp\Views\Pizza\Details.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(543, 21, true);
            WriteLiteral("    <h2>\"Pizza Name:\"");
            EndContext();
            BeginContext(565, 18, false);
#line 21 "C:\Users\Ace\Desktop\SEDC.PizzaApp\Views\Pizza\Details.cshtml"
                Write(ViewBag.Pizza.Name);

#line default
#line hidden
            EndContext();
            BeginContext(583, 23, true);
            WriteLiteral("</h2>\r\n    <p>\"Price:\" ");
            EndContext();
            BeginContext(607, 19, false);
#line 22 "C:\Users\Ace\Desktop\SEDC.PizzaApp\Views\Pizza\Details.cshtml"
           Write(ViewBag.Pizza.Price);

#line default
#line hidden
            EndContext();
            BeginContext(626, 26, true);
            WriteLiteral("</p>\r\n    <p>Pizza Size:\" ");
            EndContext();
            BeginContext(653, 23, false);
#line 23 "C:\Users\Ace\Desktop\SEDC.PizzaApp\Views\Pizza\Details.cshtml"
               Write(ViewBag.Pizza.PizzaSize);

#line default
#line hidden
            EndContext();
            BeginContext(676, 18, true);
            WriteLiteral("</p>\r\n    <br />\r\n");
            EndContext();
#line 25 "C:\Users\Ace\Desktop\SEDC.PizzaApp\Views\Pizza\Details.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SEDC.PizzaApp.Models.ViewModels.PizzaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591