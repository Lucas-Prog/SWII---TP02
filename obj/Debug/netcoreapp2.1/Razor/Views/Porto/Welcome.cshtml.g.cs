#pragma checksum "C:\TP02-SW\SWII-TP02\Views\Porto\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af15d527d14c3bff7ca33e201317cfd08d1ba9b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Porto_Welcome), @"mvc.1.0.view", @"/Views/Porto/Welcome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Porto/Welcome.cshtml", typeof(AspNetCore.Views_Porto_Welcome))]
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
#line 1 "C:\TP02-SW\SWII-TP02\Views\_ViewImports.cshtml"
using TP02SWII;

#line default
#line hidden
#line 2 "C:\TP02-SW\SWII-TP02\Views\_ViewImports.cshtml"
using TP02SWII.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af15d527d14c3bff7ca33e201317cfd08d1ba9b7", @"/Views/Porto/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"145af1ebecd56787c9566600e507d4382cdd3106", @"/Views/_ViewImports.cshtml")]
    public class Views_Porto_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "C:\TP02-SW\SWII-TP02\Views\Porto\Welcome.cshtml"
  
    ViewData["Title"] = "Welcome";

#line default
#line hidden
            BeginContext(41, 24, true);
            WriteLiteral("\n<h2>Welcome</h2>\n\n<ul>\n");
            EndContext();
#line 9 "C:\TP02-SW\SWII-TP02\Views\Porto\Welcome.cshtml"
     for (int i = 0; i < (int)ViewData["NumTimes"]; i++)
    {

#line default
#line hidden
            BeginContext(128, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(141, 19, false);
#line 11 "C:\TP02-SW\SWII-TP02\Views\Porto\Welcome.cshtml"
       Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(160, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 12 "C:\TP02-SW\SWII-TP02\Views\Porto\Welcome.cshtml"
    }

#line default
#line hidden
            BeginContext(172, 6, true);
            WriteLiteral("</ul>\n");
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