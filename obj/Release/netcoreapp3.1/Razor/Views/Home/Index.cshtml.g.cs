#pragma checksum "C:\Users\tripl\OneDrive\Desktop\az1\dotnet_ai_azure_one\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e5087870b22a1d0a7489cf9b560399e297c298c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\tripl\OneDrive\Desktop\az1\dotnet_ai_azure_one\Views\_ViewImports.cshtml"
using dotnet_ai_test_one;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tripl\OneDrive\Desktop\az1\dotnet_ai_azure_one\Views\_ViewImports.cshtml"
using dotnet_ai_test_one.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e5087870b22a1d0a7489cf9b560399e297c298c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9ee6f28f4245f69e7dfa3aaec4f8da0e4a267f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""alert alert-warning"" role=""alert"">
    Remember to disable ADBLOCK!
</div>
<div style=""margin-bottom: 20px;"">
    <button id=""button"" class=""btn btn-primary"">Call Functions</button>
</div>
<div class=""alert alert-primary"" role=""alert"" id=""message""style=""display: none;""></div>
<div class=""alert alert-danger"" role=""alert"" id=""error""style=""display: none;""></div>
<script src=""https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.4.1.min.js""></script>
<script>
    var url = ""/api/Demo"";
    $( ""#button"" ).click(function() {
        $( ""#message"" ).text(""Loading..."");
        $.get(url)
            .done(function(data) {
                $( ""#message"" ).text(data).show();
            })
            .fail(function(error) {
                $( ""#error"" ).text(JSON.stringify(error)).show();
            })
    });
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.ApplicationInsights.AspNetCore.JavaScriptSnippet JavaScriptSnippet { get; private set; }
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