#pragma checksum "D:\Code\MessageBoardApp\Views\Home\ViewUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7877c745604ee2b3c9fc7e28807f61c2341664e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewUser), @"mvc.1.0.view", @"/Views/Home/ViewUser.cshtml")]
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
#line 1 "D:\Code\MessageBoardApp\Views\_ViewImports.cshtml"
using MessageBoardApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Code\MessageBoardApp\Views\_ViewImports.cshtml"
using MessageBoardApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7877c745604ee2b3c9fc7e28807f61c2341664e6", @"/Views/Home/ViewUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"554ad851f98a7d2b0880b17d20471a5bb9a6e9b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MessageBoardApp.Models.UserLogin>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Code\MessageBoardApp\Views\Home\ViewUser.cshtml"
  
    ViewData["Title"] = "ViewUser";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ViewUser</h1>\r\n<h4>User Id</h4>\r\n");
#nullable restore
#line 8 "D:\Code\MessageBoardApp\Views\Home\ViewUser.cshtml"
Write(Model.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>Name</h4>\r\n");
#nullable restore
#line 10 "D:\Code\MessageBoardApp\Views\Home\ViewUser.cshtml"
Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>Message</h4>\r\n");
#nullable restore
#line 12 "D:\Code\MessageBoardApp\Views\Home\ViewUser.cshtml"
Write(Model.MessageContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MessageBoardApp.Models.UserLogin> Html { get; private set; }
    }
}
#pragma warning restore 1591
