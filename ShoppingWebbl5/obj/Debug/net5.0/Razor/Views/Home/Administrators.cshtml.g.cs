#pragma checksum "C:\Users\Computer\Desktop\ShoppingWebbl5\ShoppingWebbl5\Views\Home\Administrators.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17e5b6fbed4998b09c3ae341ef62fa9324f39d2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Administrators), @"mvc.1.0.view", @"/Views/Home/Administrators.cshtml")]
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
#line 1 "C:\Users\Computer\Desktop\ShoppingWebbl5\ShoppingWebbl5\Views\_ViewImports.cshtml"
using ShoppingWebbl5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Computer\Desktop\ShoppingWebbl5\ShoppingWebbl5\Views\_ViewImports.cshtml"
using ShoppingWebbl5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17e5b6fbed4998b09c3ae341ef62fa9324f39d2b", @"/Views/Home/Administrators.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1aca0e42e59e1bb923487262707815f0b39bf279", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Administrators : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ShoppingWebbl5.Models.Product>>
    {
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
#line 3 "C:\Users\Computer\Desktop\ShoppingWebbl5\ShoppingWebbl5\Views\Home\Administrators.cshtml"
  
    Layout = "~/Views/Shared/AdminLayout.cshtml";
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<script src=""https://code.jquery.com/jquery-1.10.2.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous""></script>


<div class=""col-md-3"">
    <div class=""card card-stats card-warning"">
        <div class=""card-body "">
            <div class=""row"">
                <div class=""col-5"">
                    <div class=""icon-big text-center"">
                        <i class=""la la-users""></i>
                    </div>
                </div>
                <div class=""col-7 d-flex align-items-center"">
                    <div class=""numbers"">
                        <p class=""card-category"">Visitors</p>
                        <h4 class=""card-title"">1,294</h4>
                    </div>
                </div>
            </div>
        <");
            WriteLiteral(@"/div>
    </div>
</div>
<div class=""col-md-3"">
    <div class=""card card-stats card-success"">
        <div class=""card-body "">
            <div class=""row"">
                <div class=""col-5"">
                    <div class=""icon-big text-center"">
                        <i class=""la la-bar-chart""></i>
                    </div>
                </div>
                <div class=""col-7 d-flex align-items-center"">
                    <div class=""numbers"">
                        <p class=""card-category"">Sales</p>
                        <h4 class=""card-title"">$ 1,345</h4>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""col-md-3"">
    <div class=""card card-stats card-danger"">
        <div class=""card-body"">
            <div class=""row"">
                <div class=""col-5"">
                    <div class=""icon-big text-center"">
                        <i class=""la la-newspaper-o""></i>
                    </div>
        ");
            WriteLiteral(@"        </div>
                <div class=""col-7 d-flex align-items-center"">
                    <div class=""numbers"">
                        <p class=""card-category"">Subscribers</p>
                        <h4 class=""card-title"">1303</h4>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""col-md-3"">
    <div class=""card card-stats card-primary"">
        <div class=""card-body "">
            <div class=""row"">
                <div class=""col-5"">
                    <div class=""icon-big text-center"">
                        <i class=""la la-check-circle""></i>
                    </div>
                </div>
                <div class=""col-7 d-flex align-items-center"">
                    <div class=""numbers"">
                        <p class=""card-category"">Order</p>
                        <h4 class=""card-title"">576</h4>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div");
            WriteLiteral(@">

<div class=""row"">
    <div class=""col-md-3"">
        <div class=""card"">
            <div class=""card-header"">
                <h4 class=""card-title"">Task</h4>
                <p class=""card-category"">Complete</p>
            </div>
            <div class=""card-body"">
                <div id=""task-complete"" class=""chart-circle mt-4 mb-3""></div>
            </div>
            <div class=""card-footer"">
                <div class=""legend""><i class=""la la-circle text-primary""></i> Completed</div>
            </div>
        </div>
    </div>
    <div class=""col-md-9"">
        <div class=""card"">
            <div class=""card-header"">
                <h4 class=""card-title"">World Map</h4>
                <p class=""card-category"">
                    Map of the distribution of users around the world
                </p>
            </div>
            <div class=""card-body"">
                <div class=""mapcontainer"">
                    <div class=""map"">
                        <span>Altern");
            WriteLiteral(@"ative content for the map</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""row row-card-no-pd"">
    <div class=""col-md-4"">
        <div class=""card"">
            <div class=""card-body"">
                <p class=""fw-bold mt-1"">My Balance</p>
                <h4><b>$ 3,018</b></h4>
                <a href=""#"" class=""btn btn-primary btn-full text-left mt-3 mb-3""><i class=""la la-plus""></i> Add Balance</a>
            </div>
            <div class=""card-footer"">
                <ul class=""nav"">
                    <li class=""nav-item""><a class=""btn btn-default btn-link"" href=""#""><i class=""la la-history""></i> History</a></li>
                    <li class=""nav-item ml-auto""><a class=""btn btn-default btn-link"" href=""#""><i class=""la la-refresh""></i> Refresh</a></li>
                </ul>
            </div>
        </div>
    </div>
    <div class=""col-md-5"">
        <div class=""card"">
            <div class=""card-body"">
");
            WriteLiteral(@"                <div class=""progress-card"">
                    <div class=""d-flex justify-content-between mb-1"">
                        <span class=""text-muted"">Profit</span>
                        <span class=""text-muted fw-bold""> $3K</span>
                    </div>
                    <div class=""progress mb-2"" style=""height: 7px;"">
                        <div class=""progress-bar bg-success"" role=""progressbar"" style=""width: 78%"" aria-valuenow=""78"" aria-valuemin=""0"" aria-valuemax=""100"" data-toggle=""tooltip"" data-placement=""top"" title=""78%""></div>
                    </div>
                </div>
                <div class=""progress-card"">
                    <div class=""d-flex justify-content-between mb-1"">
                        <span class=""text-muted"">Orders</span>
                        <span class=""text-muted fw-bold""> 576</span>
                    </div>
                    <div class=""progress mb-2"" style=""height: 7px;"">
                        <div class=""progress-bar bg-info""");
            WriteLiteral(@" role=""progressbar"" style=""width: 65%"" aria-valuenow=""60"" aria-valuemin=""0"" aria-valuemax=""100"" data-toggle=""tooltip"" data-placement=""top"" title=""65%""></div>
                    </div>
                </div>
                <div class=""progress-card"">
                    <div class=""d-flex justify-content-between mb-1"">
                        <span class=""text-muted"">Tasks Complete</span>
                        <span class=""text-muted fw-bold""> 70%</span>
                    </div>
                    <div class=""progress mb-2"" style=""height: 7px;"">
                        <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 70%"" aria-valuenow=""70"" aria-valuemin=""0"" aria-valuemax=""100"" data-toggle=""tooltip"" data-placement=""top"" title=""70%""></div>
                    </div>
                </div>
                <div class=""progress-card"">
                    <div class=""d-flex justify-content-between mb-1"">
                        <span class=""text-muted"">Open Rate</span>
   ");
            WriteLiteral(@"                     <span class=""text-muted fw-bold""> 60%</span>
                    </div>
                    <div class=""progress mb-2"" style=""height: 7px;"">
                        <div class=""progress-bar bg-warning"" role=""progressbar"" style=""width: 60%"" aria-valuenow=""60"" aria-valuemin=""0"" aria-valuemax=""100"" data-toggle=""tooltip"" data-placement=""top"" title=""60%""></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-md-3"">
        <div class=""card card-stats"">
            <div class=""card-body"">
                <p class=""fw-bold mt-1"">Statistic</p>
                <div class=""row"">
                    <div class=""col-5"">
                        <div class=""icon-big text-center icon-warning"">
                            <i class=""la la-pie-chart text-warning""></i>
                        </div>
                    </div>
                    <div class=""col-7 d-flex align-items-center"">
                        <div cl");
            WriteLiteral(@"ass=""numbers"">
                            <p class=""card-category"">Number</p>
                            <h4 class=""card-title"">150GB</h4>
                        </div>
                    </div>
                </div>
                <hr />
                <div class=""row"">
                    <div class=""col-5"">
                        <div class=""icon-big text-center"">
                            <i class=""la la-heart-o text-primary""></i>
                        </div>
                    </div>
                    <div class=""col-7 d-flex align-items-center"">
                        <div class=""numbers"">
                            <p class=""card-category"">Followers</p>
                            <h4 class=""card-title"">+45K</h4>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-md-4"">
        <div class=""card"">
            <div class=""card-header"">
      ");
            WriteLiteral(@"          <h4 class=""card-title"">Users Statistics</h4>
                <p class=""card-category"">
                    Users statistics this month
                </p>
            </div>
            <div class=""card-body"">
                <div id=""monthlyChart"" class=""chart chart-pie""></div>
            </div>
        </div>
    </div>
    <div class=""col-md-8"">
        <div class=""card"">
            <div class=""card-header"">
                <h4 class=""card-title"">2018 Sales</h4>
                <p class=""card-category"">
                    Number of products sold
                </p>
            </div>
            <div class=""card-body"">
                <div id=""salesChart"" class=""chart""></div>
            </div>
        </div>
    </div>


    <div class=""col-md-12"">
        <div class=""card card-tasks"">
            <div class=""card-header "">
                <h4 class=""card-title"">Tasks</h4>
                <p class=""card-category"">To Do List</p>
            </div>
            <");
            WriteLiteral(@"div class=""card-body "">
                <div class=""table-full-width"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th class=""td-actions text-center"">Order of list</th>
                                <th class=""td-actions text-center"">ProductName</th>
                                <th class=""td-actions text-center"">Image</th>
                                <th class=""td-actions text-center"">Quantity</th>
                                <th class=""td-actions text-center"">Price</th>
                                <th class=""td-actions text-center"">Original</th>
                                <th class=""td-actions text-center"">View</th>
                                <th class=""td-actions text-center"">Action</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 270 "C:\Users\Computer\Desktop\ShoppingWebbl5\ShoppingWebbl5\Views\Home\Administrators.cshtml"
                             foreach (Product product in ViewBag.ListProduct)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=\"nr td-actions text-center\"></td>\r\n                                    <td class=\"td-actions text-center\">");
#nullable restore
#line 274 "C:\Users\Computer\Desktop\ShoppingWebbl5\ShoppingWebbl5\Views\Home\Administrators.cshtml"
                                                                  Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"td-actions text-center\"><img");
            BeginWriteAttribute("src", " src=\"", 11721, "\"", 11741, 1);
#nullable restore
#line 275 "C:\Users\Computer\Desktop\ShoppingWebbl5\ShoppingWebbl5\Views\Home\Administrators.cshtml"
WriteAttributeValue("", 11727, product.Image, 11727, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"60\" height=\"80\"></td>\r\n                                    <td class=\"td-actions text-center\">");
#nullable restore
#line 276 "C:\Users\Computer\Desktop\ShoppingWebbl5\ShoppingWebbl5\Views\Home\Administrators.cshtml"
                                                                  Write(product.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"td-actions text-center\">");
#nullable restore
#line 277 "C:\Users\Computer\Desktop\ShoppingWebbl5\ShoppingWebbl5\Views\Home\Administrators.cshtml"
                                                                  Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"td-actions text-center\">");
#nullable restore
#line 278 "C:\Users\Computer\Desktop\ShoppingWebbl5\ShoppingWebbl5\Views\Home\Administrators.cshtml"
                                                                  Write(product.Original);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"td-actions text-center\">");
#nullable restore
#line 279 "C:\Users\Computer\Desktop\ShoppingWebbl5\ShoppingWebbl5\Views\Home\Administrators.cshtml"
                                                                  Write(product.View);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"td-actions text-center\">\r\n");
            WriteLiteral("                                        <div class=\"form-button-action\">\r\n                                            <button type=\"button\" data-toggle=\"tooltip\" class=\"btn btn-link <btn-simple-primary\" title=\"Edit\" id=\"#exampleModalCenter\"");
            BeginWriteAttribute("onclick", " onclick=\"", 13522, "\"", 13554, 3);
            WriteAttributeValue("", 13532, "openEdit(", 13532, 9, true);
#nullable restore
#line 293 "C:\Users\Computer\Desktop\ShoppingWebbl5\ShoppingWebbl5\Views\Home\Administrators.cshtml"
WriteAttributeValue("", 13541, product.Id, 13541, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 13552, ");", 13552, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                                <i class=""la la-edit""></i>
                                            </button>
                                            <button type=""button"" data-toggle=""tooltip"" class=""btn btn-link btn-simple-danger"" title=""Remove"" id=""#deleteModalCenter""");
            BeginWriteAttribute("onclick", " onclick=\"", 13854, "\"", 13888, 3);
            WriteAttributeValue("", 13864, "openDelete(", 13864, 11, true);
#nullable restore
#line 296 "C:\Users\Computer\Desktop\ShoppingWebbl5\ShoppingWebbl5\Views\Home\Administrators.cshtml"
WriteAttributeValue("", 13875, product.Id, 13875, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 13886, ");", 13886, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                                <i class=""la la-times""></i>
                                            </button>

                                        </div>
                                    </td>
                                </tr>
");
#nullable restore
#line 303 "C:\Users\Computer\Desktop\ShoppingWebbl5\ShoppingWebbl5\Views\Home\Administrators.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
            <div class=""card-footer "">
                <div class=""stats"">
                    <i class=""now-ui-icons loader_refresh spin""></i> Updated 3 minutes ago
                </div>
            </div>
        </div>
    </div>

    <script>
        function openEdit(selectedItem) {
            const data = JSON.stringify({
                ""selectedItems"": $('#sel').val()
            });
            $.ajax({
                url: ""PopupEdit/"" + selectedItem,
                type: ""GET"",
                dataType: 'json',
                processData: false,
                contentType: false,
                data: { id: selectedItem },
                success: function (res) {
                    if (res.data != null) {
                        var obj;
                        if (typeof res === 'object')
                            obj = res.data;
                        else");
            WriteLiteral(@" if (typeof res === 'string')
                            obj = JSON.parse(res).data;

                        $('#id').val(obj.id);
                        $('#name').val(obj.productName);
                        $('#quantity').val(obj.quantity);
                        $('#price').val(obj.price);
                        $('#original').val(obj.original);
                        $('#image').val(obj.image);
                        $('#brand').val(obj.idBrand);
                        $('#category').val(obj.idCategory);
                        $('#exampleModalCenter').modal('show')
                        document.getElementById('#exampleModalCenter')
                    }
                },
                error: function (errormessage) {
                    alert(errormessage.responseText);
                }
            });
        }

        function Update() {
            var product = {
                Id: $('#id').val(),
                ProductName: $('#name').val(),
             ");
            WriteLiteral(@"   Quantity: $('#quantity').val(),
                Price: $('#price').val(),
                Original: $('#original').val(),
                Image: $('#image').val(),
                IdBrand: $('#brand').val(),
                IdCategory: $('#category').val(),
            };
            console.log(product.Id);
            console.log(product);
            val1 = ""5"";
            $.ajax({
                type: ""POST"",
                dataType: 'JSON',
                url: ""/Home/UpdateProductById"",
                data: { product: product },

                success: function (result) {
                    $('#exampleModalCenter').modal('hide');
                    $('#id').val("""");
                    $('#name').val("""");
                    $('#quantity').val("""");
                    $('#price').val("""");
                    $('#original').val("""");
                    $('#image').val("""");
                    $('#brand').val("""");
                    $('#category').val("""");
           ");
            WriteLiteral(@"         console.log(result);
                    if (result.message === true) {
                        alert(""Successfully"");
                        location.reload();
                    } else {
                        alert(""Fail"");
                    }
                },
                error: function (errormessage) {
                    alert(errormessage.responseText);
                }
            });
        }

        function openDelete(selectedItem) {
            var ans = confirm(""Are you sure you want to delete this Record?"");
            if (ans) {
                $.ajax({
                    url: ""/Home/DeleteProductById/"" + selectedItem,
                    type: ""POST"",
                    dataType: ""json"",
                    success: function (result) {
                        alert(""Successfully"");
                        location.reload();
                    },
                    error: function (errormessage) {
                        alert(""Fail"");
    ");
            WriteLiteral("                }\r\n                });\r\n            }\r\n        }\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n    </script>\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral(@"
    <div class=""modal fade"" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Edit product</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17e5b6fbed4998b09c3ae341ef62fa9324f39d2b25654", async() => {
                WriteLiteral(@"

                        <div class=""row"">
                            <div class=""col-sm-12"">
                                <div class=""row"">
                                    <div class=""col-6"">
                                        <label for=""recipient-name"" class=""col-form-label"">Id:</label>
                                        <input type=""text"" class=""form-control"" id=""id"">
                                        <label for=""message-text"" class=""col-form-label"">ProductName:</label>
                                        <input type=""text"" class=""form-control"" id=""name"">
                                        <label for=""message-text"" class=""col-form-label"">Quantity:</label>
                                        <input type=""text"" class=""form-control"" id=""quantity"">
                                        <label for=""message-text"" class=""col-form-label"">Price:</label>
                                        <input type=""text"" class=""form-control"" id=""price"">
                 ");
                WriteLiteral(@"                   </div>
                                    <div class=""col-6"">
                                        <label for=""message-text"" class=""col-form-label"">Original:</label>
                                        <input type=""text"" class=""form-control"" id=""original"">
                                        <label for=""message-text"" class=""col-form-label"">Image:</label>
                                        <input type=""text"" class=""form-control"" id=""image"">
                                        <label for=""message-text"" class=""col-form-label"">Brand:</label>
                                        <input type=""text"" class=""form-control"" id=""brand"">
                                        <label for=""message-text"" class=""col-form-label"">Category:</label>
                                        <input type=""text"" class=""form-control"" id=""category"">
                                    </div>
                                </div>
                            </div>
                ");
                WriteLiteral("        </div>\r\n\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""btn btn-primary"" onclick=""Update();"">Update</button>
                </div>
            </div>
        </div>
    </div>



");
            WriteLiteral(@"    <div class=""modal fade"" id=""deleteModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Delete product</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <input type=""hidden"" class=""form-control"" id=""id"">
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""btn btn-danger"" onclick=""Delete();"">Delete</button>
                </div>
            </div>
        </div>
    </div>

    <script type=""text/javascript"">
        var a =");
            WriteLiteral(" document.getElementsByClassName(\"nr\");\r\n        for (var i = 0; i < a.length; i++) {\r\n            a[i].innerHTML = (i + 1);\r\n        }\r\n    </script>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ShoppingWebbl5.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
