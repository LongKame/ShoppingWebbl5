#pragma checksum "C:\Users\Computer\source\repos\ShoppingWebbl5\ShoppingWebbl5\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14dbdb1aaf28283a7113846d7e5492212b1bc798"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_List), @"mvc.1.0.view", @"/Views/Home/List.cshtml")]
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
#line 1 "C:\Users\Computer\source\repos\ShoppingWebbl5\ShoppingWebbl5\Views\_ViewImports.cshtml"
using ShoppingWebbl5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Computer\source\repos\ShoppingWebbl5\ShoppingWebbl5\Views\_ViewImports.cshtml"
using ShoppingWebbl5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14dbdb1aaf28283a7113846d7e5492212b1bc798", @"/Views/Home/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1aca0e42e59e1bb923487262707815f0b39bf279", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShoppingWebbl5.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icon/heart.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icon/compare.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icon/search.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Computer\source\repos\ShoppingWebbl5\ShoppingWebbl5\Views\Home\List.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""breadcrumb-option"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""breadcrumb__text"">
                    <h4>Cửa hàng</h4>
                    <div class=""breadcrumb__links"">
                        <a href=""./index.html"">Trang chủ</a>
                        <span>Cửa hàng</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Breadcrumb Section End -->
<!-- Shop Section Begin -->
<section class=""shop spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3"">
                <div class=""shop__sidebar"">
                    <div class=""shop__sidebar__search"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14dbdb1aaf28283a7113846d7e5492212b1bc7986638", async() => {
                WriteLiteral("\r\n                            <input type=\"text\" placeholder=\"Search...\">\r\n                            <button type=\"submit\"><span class=\"icon_search\"></span></button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""shop__sidebar__accordion"">
                        <div class=""accordion"" id=""accordionExample"">
                            <div class=""card"">
                                <div class=""card-heading"">
                                    <a data-toggle=""collapse"" data-target=""#collapseOne"">Thể loại</a>
                                </div>
                                <div id=""collapseOne"" class=""collapse show"" data-parent=""#accordionExample"">
                                    <div class=""card-body"">
                                        <div class=""shop__sidebar__categories"">
                                            <ul class=""nice-scroll"">
                                                <li><a href=""#"">Áo (20)</a></li>
                                                <li><a href=""#"">Quần (20)</a></li>
                                                <li><a href=""#"">Giày (20)</a></li>
                                        ");
            WriteLiteral(@"        <li><a href=""#"">Kính mắt (20)</a></li>
                                                <li><a href=""#"">Thắt lưng (20)</a></li>
                                                <li><a href=""#"">Phụ kiện (20)</a></li>
                                                <li><a href=""#"">Đồng hồ (20)</a></li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""card"">
                                <div class=""card-heading"">
                                    <a data-toggle=""collapse"" data-target=""#collapseTwo"">Thương hiệu</a>
                                </div>
                                <div id=""collapseTwo"" class=""collapse show"" data-parent=""#accordionExample"">
                                    <div class=""card-body"">
                                        <div class=""shop__sidebar__b");
            WriteLiteral(@"rand"">
                                            <ul>
                                                <li><a href=""#"">Louis Vuitton</a></li>
                                                <li><a href=""#"">Chanel</a></li>
                                                <li><a href=""#"">Hermes</a></li>
                                                <li><a href=""#"">Gucci</a></li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""card"">
                                <div class=""card-heading"">
                                    <a data-toggle=""collapse"" data-target=""#collapseThree"">Lọc giá</a>
                                </div>
                                <div id=""collapseThree"" class=""collapse show"" data-parent=""#accordionExample"">
                                    <div class=""card-");
            WriteLiteral(@"body"">
                                        <div class=""shop__sidebar__price"">
                                            <ul>
                                                <li><a href=""#"">0 - 200đ</a></li>
                                                <li><a href=""#"">200 - 300đ</a></li>
                                                <li><a href=""#"">300 - 400đ</a></li>
                                                <li><a href=""#"">400đ - 500đ</a></li>
                                                <li><a href=""#"">Trên 500đ</a></li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-9"">
                <div class=""shop__product__option"">
                    <div class=""row"">
                ");
            WriteLiteral(@"        <div class=""col-lg-6 col-md-6 col-sm-6"">
                            <div class=""shop__product__option__left"">
                                <p>Hiển thị 1-12 trong số 126 kết quả</p>
                            </div>
                        </div>
                        <div class=""col-lg-6 col-md-6 col-sm-6"">
                            <div class=""shop__product__option__right"">
                                <p>Sắp xếp theo giá:</p>
                                <select>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14dbdb1aaf28283a7113846d7e5492212b1bc79813022", async() => {
                WriteLiteral("Thấp đến cao");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14dbdb1aaf28283a7113846d7e5492212b1bc79814224", async() => {
                WriteLiteral("Cao đến thấp");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14dbdb1aaf28283a7113846d7e5492212b1bc79815426", async() => {
                WriteLiteral("0 - 200đ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14dbdb1aaf28283a7113846d7e5492212b1bc79816624", async() => {
                WriteLiteral("200 - 300đ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14dbdb1aaf28283a7113846d7e5492212b1bc79817824", async() => {
                WriteLiteral("300 - 400đ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </select>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 119 "C:\Users\Computer\source\repos\ShoppingWebbl5\ShoppingWebbl5\Views\Home\List.cshtml"
                     foreach (Product product in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4 col-md-6 col-sm-6\">\r\n                            <div class=\"product__item\">\r\n                                <div class=\"product__item__pic set-bg\" data-setbg=\"");
#nullable restore
#line 123 "C:\Users\Computer\source\repos\ShoppingWebbl5\ShoppingWebbl5\Views\Home\List.cshtml"
                                                                              Write(product.Image);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                    <ul class=\"product__hover\">\r\n                                        <li><a href=\"#\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "14dbdb1aaf28283a7113846d7e5492212b1bc79820126", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a></li>\r\n                                        <li>\r\n                                            <a href=\"#\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "14dbdb1aaf28283a7113846d7e5492212b1bc79821356", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                                        </li>\r\n                                        <li><a href=\"./shop-details.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "14dbdb1aaf28283a7113846d7e5492212b1bc79822600", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a></li>\r\n                                    </ul>\r\n                                </div>\r\n                                <div class=\"product__item__text\">\r\n                                    <h6>");
#nullable restore
#line 133 "C:\Users\Computer\source\repos\ShoppingWebbl5\ShoppingWebbl5\Views\Home\List.cshtml"
                                   Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 7382, "\"", 7413, 2);
            WriteAttributeValue("", 7389, "/Home/Detail/", 7389, 13, true);
#nullable restore
#line 134 "C:\Users\Computer\source\repos\ShoppingWebbl5\ShoppingWebbl5\Views\Home\List.cshtml"
WriteAttributeValue("", 7402, product.Id, 7402, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""add-cart"">+ Thêm vào giỏ hàng</a>
                                    <div class=""rating"">
                                        <i class=""fa fa-star-o""></i>
                                        <i class=""fa fa-star-o""></i>
                                        <i class=""fa fa-star-o""></i>
                                        <i class=""fa fa-star-o""></i>
                                        <i class=""fa fa-star-o""></i>
                                    </div>
                                    <h5>$");
#nullable restore
#line 142 "C:\Users\Computer\source\repos\ShoppingWebbl5\ShoppingWebbl5\Views\Home\List.cshtml"
                                    Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                    <div class=""product__color__select"">
                                        <label for=""pc-4"">
                                            <input type=""radio"" id=""pc-4"">
                                        </label>
                                        <label class=""active black"" for=""pc-5"">
                                            <input type=""radio"" id=""pc-5"">
                                        </label>
                                        <label class=""grey"" for=""pc-6"">
                                            <input type=""radio"" id=""pc-6"">
                                        </label>
                                    </div>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 157 "C:\Users\Computer\source\repos\ShoppingWebbl5\ShoppingWebbl5\Views\Home\List.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-lg-12\">\r\n                        <div class=\"product__pagination\">\r\n");
#nullable restore
#line 163 "C:\Users\Computer\source\repos\ShoppingWebbl5\ShoppingWebbl5\Views\Home\List.cshtml"
                              
                                int numberPage = (int)ViewBag.numberPage;
                                int pageCurrent = ViewBag.pageCurrent;

                                if (pageCurrent > 1)
                                {
                                    int prePage = pageCurrent - 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a class=\"fa fa-angle-double-left\"");
            BeginWriteAttribute("href", " href=\"", 9385, "\"", 9406, 2);
            WriteAttributeValue("", 9392, "?page=", 9392, 6, true);
#nullable restore
#line 170 "C:\Users\Computer\source\repos\ShoppingWebbl5\ShoppingWebbl5\Views\Home\List.cshtml"
WriteAttributeValue("", 9398, prePage, 9398, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n");
#nullable restore
#line 171 "C:\Users\Computer\source\repos\ShoppingWebbl5\ShoppingWebbl5\Views\Home\List.cshtml"
                                }

                                int i;
                                for (i = 1; i < numberPage; i++)
                                {
                                    if (i == pageCurrent)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"active\"");
            BeginWriteAttribute("href", " href=\"", 9747, "\"", 9762, 2);
            WriteAttributeValue("", 9754, "?page=", 9754, 6, true);
#nullable restore
#line 178 "C:\Users\Computer\source\repos\ShoppingWebbl5\ShoppingWebbl5\Views\Home\List.cshtml"
WriteAttributeValue("", 9760, i, 9760, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 178 "C:\Users\Computer\source\repos\ShoppingWebbl5\ShoppingWebbl5\Views\Home\List.cshtml"
                                                                     Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 179 "C:\Users\Computer\source\repos\ShoppingWebbl5\ShoppingWebbl5\Views\Home\List.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a");
            BeginWriteAttribute("href", " href=\"", 9934, "\"", 9949, 2);
            WriteAttributeValue("", 9941, "?page=", 9941, 6, true);
#nullable restore
#line 182 "C:\Users\Computer\source\repos\ShoppingWebbl5\ShoppingWebbl5\Views\Home\List.cshtml"
WriteAttributeValue("", 9947, i, 9947, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 182 "C:\Users\Computer\source\repos\ShoppingWebbl5\ShoppingWebbl5\Views\Home\List.cshtml"
                                                      Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 183 "C:\Users\Computer\source\repos\ShoppingWebbl5\ShoppingWebbl5\Views\Home\List.cshtml"
                                    }
                                }

                                if (pageCurrent >= 1 && pageCurrent < numberPage)
                                {
                                    int nextPage = pageCurrent + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a class=\"fa fa-angle-double-right\"");
            BeginWriteAttribute("href", " href=\"", 10293, "\"", 10315, 2);
            WriteAttributeValue("", 10300, "?page=", 10300, 6, true);
#nullable restore
#line 189 "C:\Users\Computer\source\repos\ShoppingWebbl5\ShoppingWebbl5\Views\Home\List.cshtml"
WriteAttributeValue("", 10306, nextPage, 10306, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n");
#nullable restore
#line 190 "C:\Users\Computer\source\repos\ShoppingWebbl5\ShoppingWebbl5\Views\Home\List.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShoppingWebbl5.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
