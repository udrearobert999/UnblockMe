#pragma checksum "C:\Users\Robert\Desktop\UnblockMe_SummerCamp\UnblockMe\UnblockMe\Views\AddCar\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13adb05a0d0d8609829ccfaef025fb42c999835e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AddCar_Index), @"mvc.1.0.view", @"/Views/AddCar/Index.cshtml")]
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
#line 1 "C:\Users\Robert\Desktop\UnblockMe_SummerCamp\UnblockMe\UnblockMe\Views\_ViewImports.cshtml"
using UnblockMe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Robert\Desktop\UnblockMe_SummerCamp\UnblockMe\UnblockMe\Views\_ViewImports.cshtml"
using UnblockMe.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13adb05a0d0d8609829ccfaef025fb42c999835e", @"/Views/AddCar/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9da95a8eb7ebad05f369e90021df8c2247ebe8a2", @"/Views/_ViewImports.cshtml")]
    public class Views_AddCar_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Cars>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/additional-methods.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/modal.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/addcar.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AddCar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DownloadCarInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addCarForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editCarForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/addcar.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "13adb05a0d0d8609829ccfaef025fb42c999835e8618", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13adb05a0d0d8609829ccfaef025fb42c999835e9732", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13adb05a0d0d8609829ccfaef025fb42c999835e10771", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13adb05a0d0d8609829ccfaef025fb42c999835e11811", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13adb05a0d0d8609829ccfaef025fb42c999835e12851", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "13adb05a0d0d8609829ccfaef025fb42c999835e13891", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "13adb05a0d0d8609829ccfaef025fb42c999835e15010", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div class=""buttons"">
    
        <div class=""addCar d-inline-block"" data-toggle=""modal"" data-target=""#AddCar"">
            <svg xmlns=""http://www.w3.org/2000/svg"" x=""0px"" y=""0px""
                 width=""80"" height=""80""
                 viewBox=""0 0 172 172""
                 style="" fill:#000000;"">
                <g fill=""none"" fill-rule=""nonzero"" stroke=""none"" stroke-width=""1"" stroke-linecap=""butt"" stroke-linejoin=""miter"" stroke-miterlimit=""10""");
            BeginWriteAttribute("stroke-dasharray", " stroke-dasharray=\"", 955, "\"", 974, 0);
            EndWriteAttribute();
            WriteLiteral(@" stroke-dashoffset=""0"" font-family=""none"" font-size=""none"" style=""mix-blend-mode: normal""><path d=""M0,172v-172h172v172z"" fill=""none"" stroke=""none""></path><g id=""original-icon"" fill=""#000000"" stroke=""none"" opacity=""0"" visibility=""hidden""><path d=""M46.37337,28.66667c-4.58667,0 -8.67861,2.92165 -10.16211,7.26465l-14.71126,42.90202v50.16667v7.16667c0,3.956 3.21067,7.16667 7.16667,7.16667h7.16667c3.956,0 7.16667,-3.21067 7.16667,-7.16667v-7.16667h86v7.16667c0,3.956 3.21067,7.16667 7.16667,7.16667h7.16667c3.956,0 7.16667,-3.21067 7.16667,-7.16667v-14.33333v-43l-14.71126,-42.90202c-1.4835,-4.343 -5.57544,-7.26465 -10.16211,-7.26465zM48.9349,43h74.13021l7.37663,21.5h-88.88346zM36.64518,78.83333h98.70964l0.81185,2.37956v33.45378h-100.33333v-33.45378zM53.75,86c-5.93706,0 -10.75,4.81294 -10.75,10.75c0,5.93706 4.81294,10.75 10.75,10.75c5.93706,0 10.75,-4.81294 10.75,-10.75c0,-5.93706 -4.81294,-10.75 -10.75,-10.75zM118.25,86c-5.93706,0 -10.75,4.81294 -10.75,10.75c0,5.93706 4.81294,10.75 10.75,10.75c5.93706,0 10.75,-4.8129");
            WriteLiteral(@"4 10.75,-10.75c0,-5.93706 -4.81294,-10.75 -10.75,-10.75z""></path></g><g id=""subtracted-icon"" fill=""#000000"" stroke=""none""><path d=""M125.62663,28.66667c4.58667,0 8.67861,2.92165 10.16211,7.26465l14.71126,42.90202v9.2522c-4.54325,-1.35665 -9.35473,-2.08553 -14.33333,-2.08553v-4.78711l-0.81185,-2.37956h-98.70964l-0.81185,2.37956v33.45378l55.01042,0c-2.12268,4.45703 -3.60683,9.27448 -4.33346,14.33333h-43.51029v7.16667c0,3.956 -3.21067,7.16667 -7.16667,7.16667h-7.16667c-3.956,0 -7.16667,-3.21067 -7.16667,-7.16667v-57.33333l14.71126,-42.90202c1.4835,-4.343 5.57544,-7.26465 10.16211,-7.26465zM41.55827,64.5h88.88346l-7.37663,-21.5h-74.13021zM64.5,96.75c0,5.93706 -4.81294,10.75 -10.75,10.75c-5.93706,0 -10.75,-4.81294 -10.75,-10.75c0,-5.93706 4.81294,-10.75 10.75,-10.75c5.93706,0 10.75,4.81294 10.75,10.75zM118.25,86c2.03089,0 3.93024,0.56317 5.55041,1.54186c-5.85819,1.4904 -11.30801,4.01434 -16.14309,7.36544c0.87391,-5.0591 5.2839,-8.9073 10.59268,-8.9073z""></path></g><g fill=""#000000"" stroke=""none""><g id=""Filled_3_""><");
            WriteLiteral(@"path d=""M136.16667,100.33333c-19.78717,0 -35.83333,16.04617 -35.83333,35.83333c0,19.78717 16.04617,35.83333 35.83333,35.83333c19.78717,0 35.83333,-16.04617 35.83333,-35.83333c0,-19.78717 -16.04617,-35.83333 -35.83333,-35.83333zM157.66667,143.33333h-14.33333v14.33333h-14.33333v-14.33333h-14.33333v-14.33333h14.33333v-14.33333h14.33333v14.33333h14.33333z""></path></g><g id=""Filled_3_"" opacity=""0""><path d=""M186.33333,136.16667c0,27.66333 -22.50333,50.16667 -50.16667,50.16667c-27.66333,0 -50.16667,-22.50333 -50.16667,-50.16667c0,-27.66333 22.50333,-50.16667 50.16667,-50.16667c27.66333,0 50.16667,22.50333 50.16667,50.16667z""></path></g></g><path d=""M100.33333,172v-71.66667h71.66667v71.66667z"" id=""overlay-drag"" fill=""#ff0000"" stroke=""none"" opacity=""0""></path></g>
            </svg>
        </div>

        <div class=""editCar d-inline-block"" data-toggle=""modal"" data-target=""#EditCar"" id=""editButton"">
            <svg xmlns=""http://www.w3.org/2000/svg"" x=""0px"" y=""0px""
                 width=""80"" height=""80""
    ");
            WriteLiteral("             viewBox=\"0 0 172 172\"\r\n                 style=\" fill:#000000;\">\r\n                <g fill=\"none\" fill-rule=\"nonzero\" stroke=\"none\" stroke-width=\"1\" stroke-linecap=\"butt\" stroke-linejoin=\"miter\" stroke-miterlimit=\"10\"");
            BeginWriteAttribute("stroke-dasharray", " stroke-dasharray=\"", 4275, "\"", 4294, 0);
            EndWriteAttribute();
            WriteLiteral(@" stroke-dashoffset=""0"" font-family=""none"" font-size=""none"" style=""mix-blend-mode: normal""><path d=""M0,172v-172h172v172z"" fill=""none"" stroke=""none""></path><g id=""original-icon"" fill=""#000000"" stroke=""none"" opacity=""0"" visibility=""hidden""><path d=""M46.37337,28.66667c-4.58667,0 -8.67861,2.92165 -10.16211,7.26465l-14.71126,42.90202v50.16667v7.16667c0,3.956 3.21067,7.16667 7.16667,7.16667h7.16667c3.956,0 7.16667,-3.21067 7.16667,-7.16667v-7.16667h86v7.16667c0,3.956 3.21067,7.16667 7.16667,7.16667h7.16667c3.956,0 7.16667,-3.21067 7.16667,-7.16667v-14.33333v-43l-14.71126,-42.90202c-1.4835,-4.343 -5.57544,-7.26465 -10.16211,-7.26465zM48.9349,43h74.13021l7.37663,21.5h-88.88346zM36.64518,78.83333h98.70964l0.81185,2.37956v33.45378h-100.33333v-33.45378zM53.75,86c-5.93706,0 -10.75,4.81294 -10.75,10.75c0,5.93706 4.81294,10.75 10.75,10.75c5.93706,0 10.75,-4.81294 10.75,-10.75c0,-5.93706 -4.81294,-10.75 -10.75,-10.75zM118.25,86c-5.93706,0 -10.75,4.81294 -10.75,10.75c0,5.93706 4.81294,10.75 10.75,10.75c5.93706,0 10.75,-4.8129");
            WriteLiteral(@"4 10.75,-10.75c0,-5.93706 -4.81294,-10.75 -10.75,-10.75z""></path></g><g id=""subtracted-icon"" fill=""#000000"" stroke=""none""><path d=""M125.62663,28.66667c4.58667,0 8.67861,2.92165 10.16211,7.26465l14.71126,42.90202v16.5524c-1.43902,0.79371 -2.7913,1.80008 -4.01033,3.0191l-10.32301,10.32301v-27.51496l-0.81185,-2.37956h-98.70964l-0.81185,2.37956v33.45378l94.39451,0l-14.33333,14.33333h-72.89451v7.16667c0,3.956 -3.21067,7.16667 -7.16667,7.16667h-7.16667c-3.956,0 -7.16667,-3.21067 -7.16667,-7.16667v-57.33333l14.71126,-42.90202c1.4835,-4.343 5.57544,-7.26465 10.16211,-7.26465zM41.55827,64.5h88.88346l-7.37663,-21.5h-74.13021zM64.5,96.75c0,5.93706 -4.81294,10.75 -10.75,10.75c-5.93706,0 -10.75,-4.81294 -10.75,-10.75c0,-5.93706 4.81294,-10.75 10.75,-10.75c5.93706,0 10.75,4.81294 10.75,10.75zM129,96.75c0,5.93706 -4.81294,10.75 -10.75,10.75c-5.93706,0 -10.75,-4.81294 -10.75,-10.75c0,-5.93706 4.81294,-10.75 10.75,-10.75c5.93706,0 10.75,4.81294 10.75,10.75z""></path></g><g fill=""#000000"" stroke=""none""><g id=""Filled_3_""><path d");
            WriteLiteral(@"=""M144.37628,120.78405l14.33416,14.33416l-36.88179,36.88179h-14.33416v-14.33416zM156.61765,108.54267l-7.16708,7.16708l14.33416,14.33416l7.16708,-7.16708c1.39758,-1.39758 1.39758,-3.66955 0,-5.06713l-9.26703,-9.26703c-1.40475,-1.39758 -3.66955,-1.39758 -5.06713,0z""></path></g><g id=""Filled_3_"" opacity=""0""><path d=""M181.09234,133.01467l-49.12317,49.12317c-2.68766,2.68049 -6.3357,4.19274 -10.13425,4.19274h-14.33416c-7.91246,0 -14.33416,-6.4217 -14.33416,-14.33416v-14.33416c0,-3.79855 1.51225,-7.4466 4.19991,-10.13425l49.12317,-49.12317c6.9879,-6.9879 18.35489,-6.9879 25.33563,0l9.26703,9.26703c6.98074,6.9879 6.98074,18.35489 0,25.3428z""></path></g></g><path d=""M107.49449,172v-64.50551h64.50551v64.50551z"" id=""overlay-drag"" fill=""#ff0000"" stroke=""none"" opacity=""0""></path></g>
            </svg>

        </div>
   
        
        <div class=""parkCar d-inline-block"" data-toggle=""modal"" data-target=""#ParkCar"">
            <img src=""https://img.icons8.com/material-outlined/80/000000/parking.png"" />
        <");
            WriteLiteral("/div>\r\n\r\n        <div class=\"downloadCsv d-inline-block\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13adb05a0d0d8609829ccfaef025fb42c999835e23753", async() => {
                WriteLiteral("\r\n\r\n                <img src=\"https://img.icons8.com/material-outlined/80 /000000/export-excel.png\" />\r\n\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        
   
   

</div>


<div class=""modal custom fade"" id=""AddCar"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Add a car</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13adb05a0d0d8609829ccfaef025fb42c999835e25876", async() => {
                WriteLiteral(@"
                    <p>
                        <label for=""addlicensePlate"">License Plate: </label>
                        <input type=""text"" id=""addlicensePlate"" required />
                    </p>
                    <p>

                        <label for=""addBrand"">Brand: </label>
                        <input type=""text"" id=""addBrand"" required />
                    </p>
                    <p>

                        <label for=""addColor"">Color: </label>
                        <input type=""text"" id=""addColor"" required />
                    </p>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                        <button type=""submit"" class=""btn btn-primary"">Add Car</button>
                    </div>

                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

            </div>

        </div>
    </div>
</div>



<div class=""modal custom fade"" id=""EditCar"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Edit a car!</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
");
#nullable restore
#line 102 "C:\Users\Robert\Desktop\UnblockMe_SummerCamp\UnblockMe\UnblockMe\Views\AddCar\Index.cshtml"
                 if (Model.Count() > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13adb05a0d0d8609829ccfaef025fb42c999835e29016", async() => {
                WriteLiteral("\r\n                        <select id=\"selectEditCar\">\r\n\r\n");
#nullable restore
#line 107 "C:\Users\Robert\Desktop\UnblockMe_SummerCamp\UnblockMe\UnblockMe\Views\AddCar\Index.cshtml"
                               int i = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\Users\Robert\Desktop\UnblockMe_SummerCamp\UnblockMe\UnblockMe\Views\AddCar\Index.cshtml"
                             foreach (var element in Model)
                            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13adb05a0d0d8609829ccfaef025fb42c999835e29886", async() => {
#nullable restore
#line 111 "C:\Users\Robert\Desktop\UnblockMe_SummerCamp\UnblockMe\UnblockMe\Views\AddCar\Index.cshtml"
                                                                                 Write(element.LicensePlate);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 111 "C:\Users\Robert\Desktop\UnblockMe_SummerCamp\UnblockMe\UnblockMe\Views\AddCar\Index.cshtml"
                                   WriteLiteral(element.LicensePlate);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 10125, "select", 10125, 6, true);
#nullable restore
#line 111 "C:\Users\Robert\Desktop\UnblockMe_SummerCamp\UnblockMe\UnblockMe\Views\AddCar\Index.cshtml"
AddHtmlAttributeValue("", 10131, i, 10131, 4, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 112 "C:\Users\Robert\Desktop\UnblockMe_SummerCamp\UnblockMe\UnblockMe\Views\AddCar\Index.cshtml"
                                i++;
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </select>
                        <br /><br />
                        <label for=""brand"">Brand</label>
                        <input type=""text"" id=""brand"" name=""brand"" />
                        <br />
                        <label for=""color"">Color</label>
                        <input type=""text"" id=""color"" name=""color"" />
                        <br />
                        <button type=""button"" class=""btn btn-secondary"" id=""deletButton"">Remove</button>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                            <button type=""submit"" class=""btn btn-primary"">Save changes</button>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 128 "C:\Users\Robert\Desktop\UnblockMe_SummerCamp\UnblockMe\UnblockMe\Views\AddCar\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>You must add a car first!</p>\r\n");
#nullable restore
#line 132 "C:\Users\Robert\Desktop\UnblockMe_SummerCamp\UnblockMe\UnblockMe\Views\AddCar\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>

        </div>
    </div>
</div>


<div class=""modal custom fade"" id=""ParkCar"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Park a car</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""modal-body"">
                Park a car!
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-primary"">Save changes</button>
            </div>
        </div>
    </div>
</div>


");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13adb05a0d0d8609829ccfaef025fb42c999835e36324", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Cars>> Html { get; private set; }
    }
}
#pragma warning restore 1591
