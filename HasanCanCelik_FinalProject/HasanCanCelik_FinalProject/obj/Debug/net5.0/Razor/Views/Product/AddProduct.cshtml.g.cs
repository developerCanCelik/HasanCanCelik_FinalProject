#pragma checksum "C:\Users\90539\source\repos\HasanCanCelik_FinalProject\HasanCanCelik_FinalProject\Views\Product\AddProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e361175564846dfc9567e32c55ff5dc7d1e3ba8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_AddProduct), @"mvc.1.0.view", @"/Views/Product/AddProduct.cshtml")]
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
#line 1 "C:\Users\90539\source\repos\HasanCanCelik_FinalProject\HasanCanCelik_FinalProject\Views\_ViewImports.cshtml"
using HasanCanCelik_FinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\90539\source\repos\HasanCanCelik_FinalProject\HasanCanCelik_FinalProject\Views\_ViewImports.cshtml"
using HasanCanCelik_FinalProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e361175564846dfc9567e32c55ff5dc7d1e3ba8", @"/Views/Product/AddProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6e8dc69f24f6b5c180af497c2ecf02b193a6f08", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_AddProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Entities.Product>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\90539\source\repos\HasanCanCelik_FinalProject\HasanCanCelik_FinalProject\Views\Product\AddProduct.cshtml"
  
    ViewData["Title"] = "AddProduct";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e361175564846dfc9567e32c55ff5dc7d1e3ba85044", async() => {
                WriteLiteral(@"
    <input type=""hidden"" name=""IsPublish"" value=""False"" class=""form-control"" id=""title"" /> 
    <div class=""form-group"">
        
        <input type=""text"" name=""ProductName"" class=""form-control"" id=""title"" placeholder=""Ürün İsmi"" />
    </div>
    <div class=""form-group"">
        <input type=""number"" name=""Price"" class=""form-control"" id=""subtitle"" placeholder=""Ürün Fiyat"" />
    </div>
    <div class=""form-group"">
        <input type=""number"" name=""Stock"" class=""form-control"" id=""subtitle"" placeholder=""Stok Miktar"" />
    </div>
    <div>
        <label>Kategori Seçiniz</label>
        ");
#nullable restore
#line 22 "C:\Users\90539\source\repos\HasanCanCelik_FinalProject\HasanCanCelik_FinalProject\Views\Product\AddProduct.cshtml"
   Write(Html.DropDownListFor(m => m.CategoryID, (List<SelectListItem>)ViewBag.categoryVal, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <label>Tag Seçiniz</label>\r\n        ");
#nullable restore
#line 26 "C:\Users\90539\source\repos\HasanCanCelik_FinalProject\HasanCanCelik_FinalProject\Views\Product\AddProduct.cshtml"
   Write(Html.DropDownListFor(m => m.TagID, (List<SelectListItem>)ViewBag.tagVal, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <br />\r\n    <button type=\"submit\" value=\"Create\" class=\"btn btn-primary\">Ekle</button>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 32 "C:\Users\90539\source\repos\HasanCanCelik_FinalProject\HasanCanCelik_FinalProject\Views\Product\AddProduct.cshtml"
 if (TempData["mesaj"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"   <div class=""modal"" id=""validation"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Dikkat</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Kapat"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>

                <div class=""modal-body"">
                    <p>");
#nullable restore
#line 45 "C:\Users\90539\source\repos\HasanCanCelik_FinalProject\HasanCanCelik_FinalProject\Views\Product\AddProduct.cshtml"
                  Write(TempData["mesaj"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Kapat</button>
                </div>
    
        </div>
    </div>
</div>
  <script>
    $('#validation').modal('show');
    </script>
");
#nullable restore
#line 57 "C:\Users\90539\source\repos\HasanCanCelik_FinalProject\HasanCanCelik_FinalProject\Views\Product\AddProduct.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Entities.Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591