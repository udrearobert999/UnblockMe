#pragma checksum "C:\Users\Robert\Desktop\UnblockMe\UnblockMe\UnblockMe\Views\Admin\PartialUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b0b11ceec1316691c1f0881b022c87034316e28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_PartialUsers), @"mvc.1.0.view", @"/Views/Admin/PartialUsers.cshtml")]
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
#line 1 "C:\Users\Robert\Desktop\UnblockMe\UnblockMe\UnblockMe\Views\_ViewImports.cshtml"
using UnblockMe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Robert\Desktop\UnblockMe\UnblockMe\UnblockMe\Views\_ViewImports.cshtml"
using UnblockMe.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b0b11ceec1316691c1f0881b022c87034316e28", @"/Views/Admin/PartialUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9da95a8eb7ebad05f369e90021df8c2247ebe8a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_PartialUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Users>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/colapsible.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/partialUsers.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editUserForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/partialusers.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5b0b11ceec1316691c1f0881b022c87034316e285186", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5b0b11ceec1316691c1f0881b022c87034316e286300", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<link rel=\"stylesheet\" type=\"text/css\" href=\"https://cdn.jsdelivr.net/npm/toastify-js/src/toastify.min.css\">\r\n<script type=\"text/javascript\"\r\n        src=\"https://cdnjs.cloudflare.com/ajax/libs/mdb-ui-kit/3.6.0/mdb.min.js\"></script>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Robert\Desktop\UnblockMe\UnblockMe\UnblockMe\Views\Admin\PartialUsers.cshtml"
 foreach (var user in Model)
{

    var userName = user.UserName.Substring(0, user.UserName.IndexOf("@"));
    string btnCollor = user.Banned == null ? "btn-primary" : "btn-danger";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button type=\"button\"");
            BeginWriteAttribute("class", " class=\"", 582, "\"", 606, 2);
            WriteAttributeValue("", 590, "btn", 590, 3, true);
#nullable restore
#line 14 "C:\Users\Robert\Desktop\UnblockMe\UnblockMe\UnblockMe\Views\Admin\PartialUsers.cshtml"
WriteAttributeValue(" ", 593, btnCollor, 594, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 607, "\"", 628, 2);
            WriteAttributeValue("", 612, "user-", 612, 5, true);
#nullable restore
#line 14 "C:\Users\Robert\Desktop\UnblockMe\UnblockMe\UnblockMe\Views\Admin\PartialUsers.cshtml"
WriteAttributeValue("", 617, userName, 617, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"modal\" data-target=\"#editUser\">\r\n        <span class=\"buttonUserName\">");
#nullable restore
#line 15 "C:\Users\Robert\Desktop\UnblockMe\UnblockMe\UnblockMe\Views\Admin\PartialUsers.cshtml"
                                Write(userName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <span class=\"userId\" hidden>");
#nullable restore
#line 16 "C:\Users\Robert\Desktop\UnblockMe\UnblockMe\UnblockMe\Views\Admin\PartialUsers.cshtml"
                               Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </button>\r\n");
#nullable restore
#line 18 "C:\Users\Robert\Desktop\UnblockMe\UnblockMe\UnblockMe\Views\Admin\PartialUsers.cshtml"
    
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<div class=""modal fade"" id=""editUser"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b0b11ceec1316691c1f0881b022c87034316e2810352", async() => {
                WriteLiteral(@"

                    <p hidden>
                        <input type=""text"" id=""Id"" required />
                    </p>
                    <p>
                        <div class=""form-outline"">
                            <input type=""text"" id=""fName"" class=""form-control active"" required />
                            <label class=""form-label"" for=""fName"">First Name</label>
                        </div>
                    </p>
                    <p>
                        <div class=""form-outline"">
                            <input type=""text"" id=""lName"" class=""form-control active"" required />
                            <label class=""form-label"" for=""lName"">Last Name</label>
                        </div>
                    
                    </p>
                    <p>
                        <div class=""form-outline"">
                            <input type=""text"" id=""email"" class=""form-control active"" required />
                            <label class=""form-label"" for=""em");
                WriteLiteral(@"ail"">Email</label>
                        </div>
                    </p>
                    <p>
                        <div class=""form-outline"">
                            <input type=""text"" id=""phone"" class=""form-control active"" required />
                            <label class=""form-label"" for=""phone"">Email</label>
                        </div>
                    </p>

                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <button class=""btn btn-danger banAction"" id=""banAction"">Ban</button>
                <button class=""btn btn-success"" id=""unbanAction"">UnBan</button>
                <button class=""btn btn-primary"" id=""infoAction"">User Info</button>
                <button class=""btn btn-primary"" id=""ManageRoles"">Manage Roles</button>

                <div class=""colapsible colapsibleManageRoles"">
                    <div class=""ManageRolesContainer"">

                    </div>
                </div>

                <div class=""colapsible colapsibleDownloadInfo"">
                    <div class=""infoContainer"">
                        <p>
                            <label for=""carInfo"">Cars info: </label>
                            <a");
            BeginWriteAttribute("href", " href=\"", 3585, "\"", 3632, 2);
#nullable restore
#line 81 "C:\Users\Robert\Desktop\UnblockMe\UnblockMe\UnblockMe\Views\Admin\PartialUsers.cshtml"
WriteAttributeValue("", 3592, Url.Action("DownloadCarInfo","AddCar"), 3592, 39, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3631, "/", 3631, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" id=""carInfo"">
                                <img id=""downloadCarInfo"" src=""https://img.icons8.com/ios-glyphs/60/000000/car--v1.png"" />
                            </a>
                            <label for=""downloadBanInfo"">Ban History: </label>
                            <img id=""downloadBanInfo"" src=""https://img.icons8.com/ios-glyphs/60/000000/user--v1.png"" />
                        </p>
                        
                    </div>
                    
                </div>
                   
                <div class=""colapsible colapsibleBan"">
                    <div class=""banForm"">

                        <div class=""banInput"">

                            <input required type=""range"" class=""form-control-range"" id=""duration"" value=""1"" min=""1"" max=""3"">
                            <p id=""durationLabel"">Duration: One day</p>
                            <input required type=""text"" placeholder=""Reason.."" id=""reason"" />
                        </div>

                   ");
            WriteLiteral(@"     <div class=""banActionButtons"">
                            <a>
                                <img class=""banButton"" src=""https://img.icons8.com/color/48/000000/cancel-2--v1.png"" />

                            </a>
                        </div>
                    </div>
                </div>
               

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary gray"" data-dismiss=""modal"">Close</button>
                <button type=""submit"" form=""editUserForm"" class=""btn btn-primary"">Save changes</button>
            </div>
        </div>
    </div>
</div>
<script type=""text/javascript"" src=""https://cdn.jsdelivr.net/npm/toastify-js""></script>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b0b11ceec1316691c1f0881b022c87034316e2816297", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Users>> Html { get; private set; }
    }
}
#pragma warning restore 1591
