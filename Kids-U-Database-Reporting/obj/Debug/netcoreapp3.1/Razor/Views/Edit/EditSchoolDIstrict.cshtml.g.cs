#pragma checksum "C:\Users\julie\Source\Repos\Kids-U-Database-Reporting\Kids-U-Database-Reporting\Views\Edit\EditSchoolDIstrict.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86ee8314eb947471430757a7ebc663d5c5555474"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Edit_EditSchoolDIstrict), @"mvc.1.0.view", @"/Views/Edit/EditSchoolDIstrict.cshtml")]
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
#line 1 "C:\Users\julie\Source\Repos\Kids-U-Database-Reporting\Kids-U-Database-Reporting\Views\_ViewImports.cshtml"
using Kids_U_Database_Reporting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\julie\Source\Repos\Kids-U-Database-Reporting\Kids-U-Database-Reporting\Views\_ViewImports.cshtml"
using Kids_U_Database_Reporting.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86ee8314eb947471430757a7ebc663d5c5555474", @"/Views/Edit/EditSchoolDIstrict.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2729ac36731c414e9ee10976a21255d520e94cf9", @"/Views/_ViewImports.cshtml")]
    public class Views_Edit_EditSchoolDIstrict : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/SchoolDistricts/Edit/1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86ee8314eb947471430757a7ebc663d5c55554744183", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"container body-content\">\r\n        \r\n\r\n\r\n<h2>Edit</h2>\r\n\r\n\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86ee8314eb947471430757a7ebc663d5c55554744536", async() => {
                    WriteLiteral(@"<input name=""__RequestVerificationToken"" type=""hidden"" value=""vaAEDEgc-HggP6tZ04EgVGRgor40IdtPsIOUCmtafvKK001W9o7Gvu4jfmi7JFmgiRTxV7315GPTXuRWGp28e5WE6Fn1amZs36DObPHxa9xLlHO5rJi9vVh7kAqyvTpc0"" />    <div class=""form-horizontal"">
        <h4>SchoolDistrict</h4>
        <hr />
        
        <input data-val=""true"" data-val-number=""The field Id must be a number."" data-val-required=""The Id field is required."" id=""Id"" name=""Id"" type=""hidden"" value=""1"" />

        <div class=""form-group"">
            <label class=""control-label col-md-2"" for=""Name"">Name</label>
            <div class=""col-md-10"">
                <input class=""form-control text-box single-line"" data-val=""true"" data-val-maxlength=""The field Name must be a string or array type with a maximum length of &#39;255&#39;."" data-val-maxlength-max=""255"" data-val-minlength=""The field Name must be a string or array type with a minimum length of &#39;3&#39;."" data-val-minlength-min=""3"" data-val-required=""The Name field is required."" id=""Name"" name=""Na");
                    WriteLiteral(@"me"" type=""text"" value=""Dallas ISD"" />
                <span class=""field-validation-valid text-danger"" data-valmsg-for=""Name"" data-valmsg-replace=""true""></span>
            </div>
        </div>

        <div class=""form-group"">
            <label class=""control-label col-md-2"" for=""IsActive"">Active</label>
            <div class=""col-md-10"">
                <div class=""checkbox"">
                    <input checked=""checked"" class=""check-box"" data-val=""true"" data-val-required=""The Active field is required."" id=""IsActive"" name=""IsActive"" type=""checkbox"" value=""true"" /><input name=""IsActive"" type=""hidden"" value=""false"" />
                    <span class=""field-validation-valid text-danger"" data-valmsg-for=""IsActive"" data-valmsg-replace=""true""></span>
                </div>
            </div>
        </div>

        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Save"" class=""btn btn-default"" />
            </div>
       ");
                    WriteLiteral(" </div>\r\n    </div>\r\n");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
<div>
    <a href=""/SchoolDistricts"">Back to List</a>
</div>


       
    </div>

    <script src=""/bundles/jquery?v=FVs3ACwOLIVInrAl5sdzR2jrCDmVOWFbZMY6g6Q0ulE1""></script>

	<script src=""/bundles/bootstrap?v=XFQ6ekRmUKkC5q116_4vvIKt0mhNOzNmfxA0NYVcPDY1""></script>

    <script src=""/Scripts/jquery.bootstrap.wizard.min.js""></script>
    
    <script src=""/bundles/jqueryval?v=NOVQDySGO89wzMzO5x7mWS4C_uAdynpZe_Lk2y-xEM41""></script>


	<script> $(function() {
	$('input[type=number]').on('keydown', function(e) {
		if ($.inArray(e.keyCode, [46, 8, 9, 27, 13, 110, 190]) !== -1 ||
			// Allow: Ctrl+A
		   (e.keyCode == 65 && e.ctrlKey === true) ||
			// Allow: home, end, left, right
		   (e.keyCode >= 35 && e.keyCode <= 40)) {
			// let it happen, don't do anything
			return;
		}
		// Ensure that it is a number and stop the keypress
		if ((e.shiftKey || (e.keyCode < 48 || e.keyCode > 57)) && (e.keyCode < 96 || e.keyCode > 105)) {
			e.preventDefault();
		}
	});
});</script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
