#pragma checksum "C:\Users\abhis\source\repos\SymphonyProject\SymphonyProject\Views\Dashboard\GenerateOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "920b622e80a0968a43f1cae7054289ccc2fc4c5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_GenerateOrder), @"mvc.1.0.view", @"/Views/Dashboard/GenerateOrder.cshtml")]
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
#line 1 "C:\Users\abhis\source\repos\SymphonyProject\SymphonyProject\Views\_ViewImports.cshtml"
using SymphonyProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abhis\source\repos\SymphonyProject\SymphonyProject\Views\_ViewImports.cshtml"
using SymphonyProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"920b622e80a0968a43f1cae7054289ccc2fc4c5e", @"/Views/Dashboard/GenerateOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c11f4cd33e7b5a3c0bfd16e687ec37af7c35c3ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_GenerateOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<main id=\"main\" class=\"main\">\r\n\r\n    <div class=\"pagetitle\">\r\n        <h1>Generate Order</h1>\r\n        <nav>\r\n            <ol class=\"breadcrumb\">\r\n                <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "920b622e80a0968a43f1cae7054289ccc2fc4c5e3971", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                <li class=""breadcrumb-item active"">Generate Order</li>
            </ol>
        </nav>
    </div><!-- End Page Title -->
    
    <div class=""container"">
        <div class=""card mb-4"">
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""mt-2 col-sm-4 mb-4"">
                        <div class=""form-group"">
                            <label>Sold to Party</label>
                            <input type=""text"" name=""name"" class=""form-control"" placeholder=""Enter Sold To Party"">
                        </div>
                    </div>
                    <div class=""mt-2 col-sm-4 mb-4"">
                        <div class=""form-group"">
                            <label>Ship to Party</label>
                            <input type=""text"" name=""name"" class=""form-control"" placeholder=""Enter Ship To Party"">
                        </div>
                    </div>
                    <div class=""mt-2 col-sm-4 mb-4"">
     ");
            WriteLiteral(@"                   <div class=""form-group"">
                            <label>Currency</label>
                            <input type=""text"" name=""name"" class=""form-control"" placeholder=""Enter Currency"">
                        </div>
                    </div>
                </div>

                <div class=""row"">
                    <div class=""mt-1 col-sm-4 mb-4"">
                        <div class=""form-group"">
                            <label>Incoterms</label>
                            <input type=""text"" name=""name"" class=""form-control"" placeholder=""Enter Incoterms"">
                        </div>
                    </div>
                    <div class=""mt-2 col-sm-4 mb-4"">
                        <div class=""form-group"">
                            <label>Incoterms Location 1</label>
                            <input type=""text"" name=""name"" class=""form-control"" placeholder=""Enter Incoterms Location 1"">
                        </div>
                    </div>
            ");
            WriteLiteral(@"        
                </div>
            </div>
        </div>

        <div class=""card mb-4"">
            <div class=""card-body"">
                <div class=""mt-4 row"">
                    <div class=""col-sm-10 md-10""></div>
                    <div class=""col-sm-2 md-2"">
                        <button class=""btn btn-success"" type=""submit"" name=""submit"">Add Item</button>
                    </div>
                </div>

                <div class=""row"">
                    <div class=""mt-2 col-md-12"" id=""divGrid"">
                        <div class=""row"">
                            <div class=""col-sm-12"">
                                <table id=""exampledatatable""
                                       class=""table table-bordered exampledatatable no-footer dtr-inline dataTable"" cellspacing=""0""
                                       role=""grid"" style=""width: 100%; background-color: rgb(235, 243, 249); margin-bottom: 0px;""
                                       aria-describedby=""ex");
            WriteLiteral(@"ampledatatable_info"">
                                    <thead>
                                        <tr role=""row"">
                                            <th width=""5%"" data-nosearchtext=""no"" class=""no-sort notexport sorting_disabled""
                                                rowspan=""1"" colspan=""1"" aria-label=""Action"" style=""width: 122px;"">Action</th>
                                            <th width=""10%"" class=""sorting"" tabindex=""0"" aria-controls=""exampledatatable"" rowspan=""1""
                                                colspan=""1"" aria-label=""Team No: activate to sort column ascending""
                                                style=""width: 220px;"">
                                                Item No
                                            </th>
                                           
                                            <th width=""5%"" class=""sorting"" tabindex=""0"" aria-controls=""exampledatatable"" rowspan=""1""
                                   ");
            WriteLiteral(@"             colspan=""1"" aria-label=""Location: activate to sort column ascending""
                                                style=""width: 117px;"">
                                                Material
                                            </th>
                                            <th width=""10%"" class=""sorting"" tabindex=""0"" aria-controls=""exampledatatable"" rowspan=""1""
                                                colspan=""1"" aria-label=""Area: activate to sort column ascending"" style=""width: 221px;"">
                                                Date
                                            </th>
                                            <th width=""10%"" class=""sorting"" tabindex=""0"" aria-controls=""exampledatatable"" rowspan=""1""
                                                colspan=""1"" aria-label=""Area: activate to sort column ascending"" style=""width: 221px;"">
                                                Quantity
                                            </th>
  ");
            WriteLiteral(@"                                          <th width=""10%"" class=""sorting"" tabindex=""0"" aria-controls=""exampledatatable"" rowspan=""1""
                                                colspan=""1"" aria-label=""Area: activate to sort column ascending"" style=""width: 221px;"">
                                                MRP
                                            </th>
                                            <th width=""10%"" class=""sorting"" tabindex=""0"" aria-controls=""exampledatatable"" rowspan=""1""
                                                colspan=""1"" aria-label=""Area: activate to sort column ascending"" style=""width: 221px;"">
                                                Amount
                                            </th>
                                            <th width=""10%"" class=""sorting"" tabindex=""0"" aria-controls=""exampledatatable"" rowspan=""1""
                                                colspan=""1"" aria-label=""Area: activate to sort column ascending"" style=""width: 221px;"">");
            WriteLiteral(@"
                                                Rate
                                            </th>
                                            <!-- <th width=""10%"" class=""sorting"" tabindex=""0"" aria-controls=""exampledatatable"" rowspan=""1""
                                              colspan=""1"" aria-label=""Area: activate to sort column ascending"" style=""width: 221px;"">
                                             GST Tax
                                            </th>  -->
                                        </tr>

                                    </thead>
                                    <tbody>

                                        <tr role=""row"" class=""odd"">
                                            <td");
            BeginWriteAttribute("nowrap", " nowrap=\"", 7141, "\"", 7150, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""hiddendata"">
                                                <a href=""#""><i class=""bi bi-pencil-fill""></i></a>&nbsp;&nbsp;
                                                <a href=""#"">
                                                    <i class=""fa fa-flag"" title=""Review""></i>
                                                </a>
                                                <a href=""#""><i class=""bi bi-trash-fill""></i></a>

                                            </td>
                                            <td class=""Edit_TeamNo"">
                                                L2 POREBA
                                            </td>
                                            <td class=""Edit_Category"">
                                                Air Cooler
                                            </td>

                                            <td class=""Edit_Zone"">
                                                23/03/2022
                                    ");
            WriteLiteral(@"        </td>
                                            <td class=""Edit_Location"">
                                                50
                                            </td>
                                            <td class=""Edit_Area"">
                                                500000
                                            </td>
                                            <td class=""Edit_Area"">
                                                480000
                                            </td>
                                            <td class=""Edit_Area"">
                                                480000
                                            </td>

                                        </tr>

                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
");
            WriteLiteral(@"
    <section>
        <div class=""wrapper wrapper-content"">
            <div class=""row"">
                <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                    <div class=""ibox"">
                        <div class=""ibox-content"">
                            <div class=""row"">
                                <div class=""col-md-12"" id=""divGrid"">
                                    <div class=""row"">
                                        <div class=""col-sm-12"">
                                            <table id=""exampledatatable""
                                                   class=""table table-bordered exampledatatable no-footer dtr-inline dataTable"" cellspacing=""0""
                                                   role=""grid"" style=""width: 100%; background-color: rgb(235, 243, 249); margin-bottom: 0px;""
                                                   aria-describedby=""exampledatatable_info"">
                                            </table>
                   ");
            WriteLiteral(@"                     </div>
                                    </div>


                                    <div class=""row"">
                                        <div class=""col-sm-12 md-12"">
                                            <div class=""row-card""></div>
                                        </div>
                                    </div>

                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-12"" id=""divManage"" style=""display: none;"">

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        </div>

    </section>

</main><!-- End #main -->");
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
