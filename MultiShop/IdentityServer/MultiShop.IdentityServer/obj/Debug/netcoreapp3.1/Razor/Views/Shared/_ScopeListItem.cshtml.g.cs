#pragma checksum "C:\Users\teteg\Masaüstü\dosyalarım\proje\Asp.Net-Core-MultiShop-Microservice-ECommerce\MultiShop\IdentityServer\MultiShop.IdentityServer\Views\Shared\_ScopeListItem.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9a3a2e08f415ed6f9f86658eb8f2380291fe031534537d8f53d0d42118bd137a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ScopeListItem), @"mvc.1.0.view", @"/Views/Shared/_ScopeListItem.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\teteg\Masaüstü\dosyalarım\proje\Asp.Net-Core-MultiShop-Microservice-ECommerce\MultiShop\IdentityServer\MultiShop.IdentityServer\Views\_ViewImports.cshtml"
using IdentityServerHost.Quickstart.UI

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"9a3a2e08f415ed6f9f86658eb8f2380291fe031534537d8f53d0d42118bd137a", @"/Views/Shared/_ScopeListItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a37bb02fe3277db53ef664b0b2223d70455027585a6423f2ad507316524fd6fa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__ScopeListItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ScopeViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<li class=\"list-group-item\">\r\n    <label>\r\n        <input class=\"consent-scopecheck\"\r\n               type=\"checkbox\"\r\n               name=\"ScopesConsented\"");
            BeginWriteAttribute("id", "\r\n               id=\"", 180, "\"", 220, 2);
            WriteAttributeValue("", 201, "scopes_", 201, 7, true);
            WriteAttributeValue("", 208, 
#nullable restore
#line 8 "C:\Users\teteg\Masaüstü\dosyalarım\proje\Asp.Net-Core-MultiShop-Microservice-ECommerce\MultiShop\IdentityServer\MultiShop.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
                           Model.Value

#line default
#line hidden
#nullable disable
            , 208, 12, false);
            EndWriteAttribute();
            BeginWriteAttribute("value", "\r\n               value=\"", 221, "\"", 257, 1);
            WriteAttributeValue("", 245, 
#nullable restore
#line 9 "C:\Users\teteg\Masaüstü\dosyalarım\proje\Asp.Net-Core-MultiShop-Microservice-ECommerce\MultiShop\IdentityServer\MultiShop.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
                       Model.Value

#line default
#line hidden
#nullable disable
            , 245, 12, false);
            EndWriteAttribute();
            BeginWriteAttribute("checked", "\r\n               checked=\"", 258, "\"", 298, 1);
            WriteAttributeValue("", 284, 
#nullable restore
#line 10 "C:\Users\teteg\Masaüstü\dosyalarım\proje\Asp.Net-Core-MultiShop-Microservice-ECommerce\MultiShop\IdentityServer\MultiShop.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
                         Model.Checked

#line default
#line hidden
#nullable disable
            , 284, 14, false);
            EndWriteAttribute();
            BeginWriteAttribute("disabled", "\r\n               disabled=\"", 299, "\"", 341, 1);
            WriteAttributeValue("", 326, 
#nullable restore
#line 11 "C:\Users\teteg\Masaüstü\dosyalarım\proje\Asp.Net-Core-MultiShop-Microservice-ECommerce\MultiShop\IdentityServer\MultiShop.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
                          Model.Required

#line default
#line hidden
#nullable disable
            , 326, 15, false);
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 12 "C:\Users\teteg\Masaüstü\dosyalarım\proje\Asp.Net-Core-MultiShop-Microservice-ECommerce\MultiShop\IdentityServer\MultiShop.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
         if (Model.Required)
        {

#line default
#line hidden
#nullable disable

            WriteLiteral("            <input type=\"hidden\"\r\n                   name=\"ScopesConsented\"");
            BeginWriteAttribute("value", "\r\n                   value=\"", 463, "\"", 503, 1);
            WriteAttributeValue("", 491, 
#nullable restore
#line 16 "C:\Users\teteg\Masaüstü\dosyalarım\proje\Asp.Net-Core-MultiShop-Microservice-ECommerce\MultiShop\IdentityServer\MultiShop.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
                           Model.Value

#line default
#line hidden
#nullable disable
            , 491, 12, false);
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 17 "C:\Users\teteg\Masaüstü\dosyalarım\proje\Asp.Net-Core-MultiShop-Microservice-ECommerce\MultiShop\IdentityServer\MultiShop.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
        }

#line default
#line hidden
#nullable disable

            WriteLiteral("        <strong>");
            Write(
#nullable restore
#line 18 "C:\Users\teteg\Masaüstü\dosyalarım\proje\Asp.Net-Core-MultiShop-Microservice-ECommerce\MultiShop\IdentityServer\MultiShop.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
                 Model.DisplayName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</strong>\r\n");
#nullable restore
#line 19 "C:\Users\teteg\Masaüstü\dosyalarım\proje\Asp.Net-Core-MultiShop-Microservice-ECommerce\MultiShop\IdentityServer\MultiShop.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
         if (Model.Emphasize)
        {

#line default
#line hidden
#nullable disable

            WriteLiteral("            <span class=\"glyphicon glyphicon-exclamation-sign\"></span>\r\n");
#nullable restore
#line 22 "C:\Users\teteg\Masaüstü\dosyalarım\proje\Asp.Net-Core-MultiShop-Microservice-ECommerce\MultiShop\IdentityServer\MultiShop.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
        }

#line default
#line hidden
#nullable disable

            WriteLiteral("    </label>\r\n");
#nullable restore
#line 24 "C:\Users\teteg\Masaüstü\dosyalarım\proje\Asp.Net-Core-MultiShop-Microservice-ECommerce\MultiShop\IdentityServer\MultiShop.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
     if (Model.Required)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <span><em>(required)</em></span>\r\n");
#nullable restore
#line 27 "C:\Users\teteg\Masaüstü\dosyalarım\proje\Asp.Net-Core-MultiShop-Microservice-ECommerce\MultiShop\IdentityServer\MultiShop.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
    }

#line default
#line hidden
#nullable disable

#nullable restore
#line 28 "C:\Users\teteg\Masaüstü\dosyalarım\proje\Asp.Net-Core-MultiShop-Microservice-ECommerce\MultiShop\IdentityServer\MultiShop.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
     if (Model.Description != null)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <div class=\"consent-description\">\r\n            <label");
            BeginWriteAttribute("for", " for=\"", 891, "\"", 916, 2);
            WriteAttributeValue("", 897, "scopes_", 897, 7, true);
            WriteAttributeValue("", 904, 
#nullable restore
#line 31 "C:\Users\teteg\Masaüstü\dosyalarım\proje\Asp.Net-Core-MultiShop-Microservice-ECommerce\MultiShop\IdentityServer\MultiShop.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
                                Model.Value

#line default
#line hidden
#nullable disable
            , 904, 12, false);
            EndWriteAttribute();
            WriteLiteral(">");
            Write(
#nullable restore
#line 31 "C:\Users\teteg\Masaüstü\dosyalarım\proje\Asp.Net-Core-MultiShop-Microservice-ECommerce\MultiShop\IdentityServer\MultiShop.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
                                              Model.Description

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</label>\r\n        </div>\r\n");
#nullable restore
#line 33 "C:\Users\teteg\Masaüstü\dosyalarım\proje\Asp.Net-Core-MultiShop-Microservice-ECommerce\MultiShop\IdentityServer\MultiShop.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("</li>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ScopeViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
