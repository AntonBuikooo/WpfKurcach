#pragma checksum "C:\Users\buian\source\repos\ITnews\ITnews\Areas\Identity\Pages\Account\ConfirmEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54be8ca307e87fd0122a93625abc01e7ef9b791b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ITnews.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_ConfirmEmail), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/ConfirmEmail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/ConfirmEmail.cshtml", typeof(ITnews.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_ConfirmEmail), null)]
namespace ITnews.Areas.Identity.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 3 "C:\Users\buian\source\repos\ITnews\ITnews\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\buian\source\repos\ITnews\ITnews\Areas\Identity\Pages\_ViewImports.cshtml"
using ITnews.Areas.Identity;

#line default
#line hidden
#line 1 "C:\Users\buian\source\repos\ITnews\ITnews\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using ITnews.Areas.Identity.Pages.Account;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54be8ca307e87fd0122a93625abc01e7ef9b791b", @"/Areas/Identity/Pages/Account/ConfirmEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d3b5d94efc8fda9a3c5c1bdd3c9ec418304c6a8", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cad8eaaee5c8911e1b892a6ec1e8ea65fe259a83", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_ConfirmEmail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Localization.AspNetCore.TagHelpers.GenericLocalizeTagHelper __Localization_AspNetCore_TagHelpers_GenericLocalizeTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\buian\source\repos\ITnews\ITnews\Areas\Identity\Pages\Account\ConfirmEmail.cshtml"
  
    ViewData["Title"] = "Confirm email";

#line default
#line hidden
            BeginContext(82, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(84, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("h2", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c24aaa2b4a044ac82337129a3b905fb", async() => {
                BeginContext(97, 31, true);
                WriteLiteral("Подтверждение электронной почты");
                EndContext();
            }
            );
            __Localization_AspNetCore_TagHelpers_GenericLocalizeTagHelper = CreateTagHelper<global::Localization.AspNetCore.TagHelpers.GenericLocalizeTagHelper>();
            __tagHelperExecutionContext.Add(__Localization_AspNetCore_TagHelpers_GenericLocalizeTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("localize", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(133, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(146, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("p", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6071a974dfbd4fbeb03777d25fa853b5", async() => {
                BeginContext(158, 72, true);
                WriteLiteral("\r\n        Благодарим вас за подтверждение вашей электронной почты.\r\n    ");
                EndContext();
            }
            );
            __Localization_AspNetCore_TagHelpers_GenericLocalizeTagHelper = CreateTagHelper<global::Localization.AspNetCore.TagHelpers.GenericLocalizeTagHelper>();
            __tagHelperExecutionContext.Add(__Localization_AspNetCore_TagHelpers_GenericLocalizeTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("localize", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(234, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConfirmEmailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConfirmEmailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConfirmEmailModel>)PageContext?.ViewData;
        public ConfirmEmailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
