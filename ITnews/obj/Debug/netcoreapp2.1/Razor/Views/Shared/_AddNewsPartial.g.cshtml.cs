#pragma checksum "C:\Users\buian\source\repos\ITnews\ITnews\Views\Shared\_AddNewsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff6c399d99c720043350fda7c8e145b08850c3b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AddNewsPartial), @"mvc.1.0.view", @"/Views/Shared/_AddNewsPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_AddNewsPartial.cshtml", typeof(AspNetCore.Views_Shared__AddNewsPartial))]
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
#line 1 "C:\Users\buian\source\repos\ITnews\ITnews\Views\_ViewImports.cshtml"
using ITnews;

#line default
#line hidden
#line 2 "C:\Users\buian\source\repos\ITnews\ITnews\Views\_ViewImports.cshtml"
using ITnews.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff6c399d99c720043350fda7c8e145b08850c3b7", @"/Views/Shared/_AddNewsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67d82542340a11c6915723b27e8a44a65b843770", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AddNewsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 297, true);
            WriteLiteral(@"<style>
    #addNews {
        position: fixed;
        top: 250px;
        background-color: #2bacfd;
        width: 250px;
        height: 200px;
        right: 100px;
        font-size:20px;
    }
</style>
<button class=""btn btn-default"" id=""addNews"">
    + Добавить пост
</button>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591