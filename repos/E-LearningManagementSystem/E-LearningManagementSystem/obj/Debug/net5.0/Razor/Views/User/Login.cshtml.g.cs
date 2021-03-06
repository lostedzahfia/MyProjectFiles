#pragma checksum "C:\Users\OWNER\source\repos\E-LearningManagementSystem\E-LearningManagementSystem\Views\User\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "539f08d8dbea260de3e23d5dd5821875a0321e9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Login), @"mvc.1.0.view", @"/Views/User/Login.cshtml")]
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
#line 1 "C:\Users\OWNER\source\repos\E-LearningManagementSystem\E-LearningManagementSystem\Views\_ViewImports.cshtml"
using E_LearningManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\OWNER\source\repos\E-LearningManagementSystem\E-LearningManagementSystem\Views\_ViewImports.cshtml"
using E_LearningManagementSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"539f08d8dbea260de3e23d5dd5821875a0321e9c", @"/Views/User/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f79a21f7e8a3567f9f7e81779983211d7468da7", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<caption><h3 style=""font-size: 10%; color:cadetblue; font-weight:bold;"">Login</h3></caption>
<hr />

<div class=""container"">

    <!-- Outer Row -->
    <div class=""row justify-content-center"">

        <div class=""col-xl-10 col-lg-12 col-md-9"">

            <div class=""card o-hidden border-0 shadow-lg my-5"">
                <div class=""card-body p-0"">
                    <!-- Nested Row within Card Body -->
                    <div class=""row"">
                        <div class=""col-lg-6 d-none d-lg-block bg-login-image""></div>
                        <div class=""col-lg-6"">
                            <div class=""p-5"">
                                <div class=""text-center"">
                                    <h1 class=""h4 text-gray-900 mb-4"">Welcome Back!</h1>
                                </div>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "539f08d8dbea260de3e23d5dd5821875a0321e9c4856", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\Users\OWNER\source\repos\E-LearningManagementSystem\E-LearningManagementSystem\Views\User\Login.cshtml"
                                     if (!string.IsNullOrEmpty(ViewBag.Message))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <p class=\"alert alert-warning alert-dismissible\" role=\"alert\">");
#nullable restore
#line 25 "C:\Users\OWNER\source\repos\E-LearningManagementSystem\E-LearningManagementSystem\Views\User\Login.cshtml"
                                                                                                 Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 26 "C:\Users\OWNER\source\repos\E-LearningManagementSystem\E-LearningManagementSystem\Views\User\Login.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    <div class=""form-group"">
                                        <input type=""email"" class=""form-control form-control-user""
                                               aria-describedby=""emailHelp"" name=""email""
                                               placeholder=""Enter Email Address..."">
                                    </div>
                                    <div class=""form-group"">
                                        <input type=""password"" name=""Password"" class=""form-control form-control-user""
                                               placeholder=""Password"">
                                    </div>
                                    <div class=""form-group"">
                                        <div class=""custom-control custom-checkbox small"">
                                            <input type=""checkbox"" class=""custom-control-input"" id=""customCheck"">
                                            <label class=""custom-control-lab");
                WriteLiteral(@"el"" for=""customCheck"">
                                                Remember
                                                Me
                                            </label>
                                        </div>
                                    </div>
                                    <input type=""submit"" value=""Login"" class=""btn btn-primary btn-user btn-block"" />

                                    <hr>

                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                <hr>
                                <div class=""text-center"">
                                    <a class=""small"" href=""forgot-password.html"">Forgot Password?</a>
                                </div>
                                <div class=""text-center"">
                                    <a class=""small"" href=""register.html"">Create an Account!</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>

    </div>

</div>
");
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
