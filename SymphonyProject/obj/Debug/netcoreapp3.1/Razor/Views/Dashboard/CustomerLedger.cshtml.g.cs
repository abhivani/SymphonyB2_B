#pragma checksum "C:\Users\abhis\source\repos\SymphonyProject\SymphonyProject\Views\Dashboard\CustomerLedger.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c486a68129332915f78fae55ceac89a3b0b1587"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_CustomerLedger), @"mvc.1.0.view", @"/Views/Dashboard/CustomerLedger.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c486a68129332915f78fae55ceac89a3b0b1587", @"/Views/Dashboard/CustomerLedger.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c11f4cd33e7b5a3c0bfd16e687ec37af7c35c3ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_CustomerLedger : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<main id=\"main\" class=\"main\">\r\n\r\n    <div class=\"pagetitle\">\r\n        <h1>Customer Ledger</h1>\r\n        <nav>\r\n            <ol class=\"breadcrumb\">\r\n                <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c486a68129332915f78fae55ceac89a3b0b15873977", async() => {
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
                <li class=""breadcrumb-item active"">Customer Ledger</li>
            </ol>
        </nav>
    </div><!-- End Page Title -->
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
                   ");
            WriteLiteral(@"                                aria-describedby=""exampledatatable_info"">
                                                <thead>
                                                    <tr role=""row"">
                                                        <th width=""5%"" data-nosearchtext=""no"" class=""no-sort notexport sorting_disabled""
                                                            rowspan=""1"" colspan=""1"" aria-label=""Action"" style=""width: 122px;"">Action</th>
                                                        <th width=""10%"" class=""sorting"" tabindex=""0"" aria-controls=""exampledatatable"" rowspan=""1""
                                                            colspan=""1"" aria-label=""Team No: activate to sort column ascending""
                                                            style=""width: 220px;"">
                                                            SAP SO No
                                                        </th>
                                                    ");
            WriteLiteral(@"    <th width=""10%"" class=""sorting"" tabindex=""0"" aria-controls=""exampledatatable"" rowspan=""1""
                                                            colspan=""1"" aria-label=""Category: activate to sort column ascending""
                                                            style=""width: 220px;"">
                                                            Item No
                                                        </th>
                                                        <th width=""10%"" class=""sorting"" tabindex=""0"" aria-controls=""exampledatatable"" rowspan=""1""
                                                            colspan=""1"" aria-label=""Zone Number: activate to sort column ascending""
                                                            style=""width: 220px;"">
                                                            Material
                                                        </th>
                                                        <th width=""5%"" class=""sorting""");
            WriteLiteral(@" tabindex=""0"" aria-controls=""exampledatatable"" rowspan=""1""
                                                            colspan=""1"" aria-label=""Location: activate to sort column ascending""
                                                            style=""width: 117px;"">
                                                            Order
                                                        </th>
                                                        <th width=""10%"" class=""sorting"" tabindex=""0"" aria-controls=""exampledatatable"" rowspan=""1""
                                                            colspan=""1"" aria-label=""Area: activate to sort column ascending"" style=""width: 221px;"">
                                                            Delivery
                                                        </th>
                                                        <th width=""10%"" class=""sorting"" tabindex=""0"" aria-controls=""exampledatatable"" rowspan=""1""
                                            ");
            WriteLiteral(@"                colspan=""1"" aria-label=""Area: activate to sort column ascending"" style=""width: 221px;"">
                                                            Delivered
                                                        </th>
                                                        <th width=""10%"" class=""sorting"" tabindex=""0"" aria-controls=""exampledatatable"" rowspan=""1""
                                                            colspan=""1"" aria-label=""Area: activate to sort column ascending"" style=""width: 221px;"">
                                                            Delivered Date
                                                        </th>
                                                        <th width=""10%"" class=""sorting"" tabindex=""0"" aria-controls=""exampledatatable"" rowspan=""1""
                                                            colspan=""1"" aria-label=""Area: activate to sort column ascending"" style=""width: 221px;"">
                                                      ");
            WriteLiteral(@"      Invoice
                                                        </th>
                                                        <th width=""10%"" class=""sorting"" tabindex=""0"" aria-controls=""exampledatatable"" rowspan=""1""
                                                            colspan=""1"" aria-label=""Area: activate to sort column ascending"" style=""width: 221px;"">
                                                            Invoice Date
                                                        </th>
                                                        <th width=""10%"" class=""sorting"" tabindex=""0"" aria-controls=""exampledatatable"" rowspan=""1""
                                                            colspan=""1"" aria-label=""Area: activate to sort column ascending"" style=""width: 221px;"">
                                                            Approved Date
                                                        </th>
                                                    </tr>
                    ");
            WriteLiteral(@"                               
                                                </thead>
                                                <tbody>

                                                    <tr role=""row"" class=""odd"">
                                                        <td");
            BeginWriteAttribute("nowrap", " nowrap=\"", 6683, "\"", 6692, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""hiddendata"">
                                                            <a href=""/WorkPlaceManagementSystem/TeamRegistration/Index/17"">
                                                                <i class=""fa fa-lg fa-pencil"" title=""Edit""></i>
                                                            </a>
                                                            <a href=""/WorkPlaceManagementSystem/Review/ViewReview?paramRegId=17"">
                                                                <i class=""fa fa-flag"" title=""Review""></i>
                                                            </a>
                                                            <a href=""/WorkPlaceManagementSystem/Audit/ViewAudit?paramRegId=17"">
                                                                <i class=""fa fa-check""></i>
                                                            </a>

                                                        </td>
                                         ");
            WriteLiteral(@"               <td class=""Edit_TeamNo"">
                                                            L2 POREBA 26-205 - 2021 - 17
                                                        </td>
                                                        <td class=""Edit_Category"">
                                                            Category1
                                                        </td>

                                                        <td class=""Edit_Zone"">
                                                            Zone1
                                                        </td>
                                                        <td class=""Edit_Location"">
                                                            HZW
                                                        </td>
                                                        <td class=""Edit_Area"">
                                                            L2 POREBA 26-205
                              ");
            WriteLiteral("                          </td>\r\n\r\n                                                    </tr>\r\n                                                    <tr role=\"row\" class=\"even\">\r\n                                                        <td");
            BeginWriteAttribute("nowrap", " nowrap=\"", 8976, "\"", 8985, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""hiddendata"">
                                                            <a href=""/WorkPlaceManagementSystem/TeamRegistration/Index/16"">
                                                                <i class=""fa fa-lg fa-pencil"" title=""Edit""></i>
                                                            </a>
                                                            <a href=""/WorkPlaceManagementSystem/Review/ViewReview?paramRegId=16"">
                                                                <i class=""fa fa-flag"" title=""Review""></i>
                                                            </a>
                                                            <a href=""/WorkPlaceManagementSystem/Audit/ViewAudit?paramRegId=16"">
                                                                <i class=""fa fa-check""></i>
                                                            </a>

                                                        </td>
                                         ");
            WriteLiteral(@"               <td class=""Edit_TeamNo"">
                                                            L2 POREBA 26-205 - 2022 - 16
                                                        </td>
                                                        <td class=""Edit_Category"">
                                                            Category1
                                                        </td>

                                                        <td class=""Edit_Zone"">
                                                            Zone1
                                                        </td>
                                                        <td class=""Edit_Location"">
                                                            HZW
                                                        </td>
                                                        <td class=""Edit_Area"">
                                                            L2 POREBA 26-205
                              ");
            WriteLiteral("                          </td>\r\n\r\n                                                    </tr>\r\n                                                    <tr role=\"row\" class=\"odd\">\r\n                                                        <td");
            BeginWriteAttribute("nowrap", " nowrap=\"", 11268, "\"", 11277, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""hiddendata"">
                                                            <a href=""/WorkPlaceManagementSystem/TeamRegistration/Index/15"">
                                                                <i class=""fa fa-lg fa-pencil"" title=""Edit""></i>
                                                            </a>
                                                            <a href=""/WorkPlaceManagementSystem/Review/ViewReview?paramRegId=15"">
                                                                <i class=""fa fa-flag"" title=""Review""></i>
                                                            </a>
                                                            <a href=""/WorkPlaceManagementSystem/Audit/ViewAudit?paramRegId=15"">
                                                                <i class=""fa fa-check""></i>
                                                            </a>

                                                        </td>
                                         ");
            WriteLiteral(@"               <td class=""Edit_TeamNo"">
                                                            L2 POREBA 26-212 - 2022 - 15
                                                        </td>
                                                        <td class=""Edit_Category"">
                                                            Category2
                                                        </td>

                                                        <td class=""Edit_Zone"">
                                                            Zone1
                                                        </td>
                                                        <td class=""Edit_Location"">
                                                            HZW
                                                        </td>
                                                        <td class=""Edit_Area"">
                                                            L2 POREBA 26-212
                              ");
            WriteLiteral("                          </td>\r\n\r\n                                                    </tr>\r\n                                                    <tr role=\"row\" class=\"even\">\r\n                                                        <td");
            BeginWriteAttribute("nowrap", " nowrap=\"", 13561, "\"", 13570, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""hiddendata"">
                                                            <a href=""/WorkPlaceManagementSystem/TeamRegistration/Index/14"">
                                                                <i class=""fa fa-lg fa-pencil"" title=""Edit""></i>
                                                            </a>
                                                            <a href=""/WorkPlaceManagementSystem/Review/ViewReview?paramRegId=14"">
                                                                <i class=""fa fa-flag"" title=""Review""></i>
                                                            </a>
                                                            <a href=""/WorkPlaceManagementSystem/Audit/ViewAudit?paramRegId=14"">
                                                                <i class=""fa fa-check""></i>
                                                            </a>

                                                        </td>
                                         ");
            WriteLiteral(@"               <td class=""Edit_TeamNo"">
                                                            L2 POREBA 26-205 - 2022 - 14
                                                        </td>
                                                        <td class=""Edit_Category"">
                                                            Category1
                                                        </td>

                                                        <td class=""Edit_Zone"">
                                                            Zone1
                                                        </td>
                                                        <td class=""Edit_Location"">
                                                            HZW
                                                        </td>
                                                        <td class=""Edit_Area"">
                                                            L2 POREBA 26-205
                              ");
            WriteLiteral("                          </td>\r\n\r\n                                                    </tr>\r\n                                                    <tr role=\"row\" class=\"odd\">\r\n                                                        <td");
            BeginWriteAttribute("nowrap", " nowrap=\"", 15853, "\"", 15862, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""hiddendata"">
                                                            <a href=""/WorkPlaceManagementSystem/TeamRegistration/Index/13"">
                                                                <i class=""fa fa-lg fa-pencil"" title=""Edit""></i>
                                                            </a>
                                                            <a href=""/WorkPlaceManagementSystem/Review/ViewReview?paramRegId=13"">
                                                                <i class=""fa fa-flag"" title=""Review""></i>
                                                            </a>
                                                            <a href=""/WorkPlaceManagementSystem/Audit/ViewAudit?paramRegId=13"">
                                                                <i class=""fa fa-check""></i>
                                                            </a>

                                                        </td>
                                         ");
            WriteLiteral(@"               <td class=""Edit_TeamNo"">
                                                            L2 POREBA 26-205 - 2022 - 13
                                                        </td>
                                                        <td class=""Edit_Category"">
                                                            Category1
                                                        </td>

                                                        <td class=""Edit_Zone"">
                                                            Zone1
                                                        </td>
                                                        <td class=""Edit_Location"">
                                                            HZW
                                                        </td>
                                                        <td class=""Edit_Area"">
                                                            L2 POREBA 26-205
                              ");
            WriteLiteral("                          </td>\r\n\r\n                                                    </tr>\r\n                                                    <tr role=\"row\" class=\"even\">\r\n                                                        <td");
            BeginWriteAttribute("nowrap", " nowrap=\"", 18146, "\"", 18155, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""hiddendata"">
                                                            <a href=""/WorkPlaceManagementSystem/TeamRegistration/Index/12"">
                                                                <i class=""fa fa-lg fa-pencil"" title=""Edit""></i>
                                                            </a>
                                                            <a href=""/WorkPlaceManagementSystem/Review/ViewReview?paramRegId=12"">
                                                                <i class=""fa fa-flag"" title=""Review""></i>
                                                            </a>
                                                            <a href=""/WorkPlaceManagementSystem/Audit/ViewAudit?paramRegId=12"">
                                                                <i class=""fa fa-check""></i>
                                                            </a>

                                                        </td>
                                         ");
            WriteLiteral(@"               <td class=""Edit_TeamNo"">
                                                            L2 POREBA 26-205 - 2021 - 12
                                                        </td>
                                                        <td class=""Edit_Category"">
                                                            Category1
                                                        </td>

                                                        <td class=""Edit_Zone"">
                                                            Zone1
                                                        </td>
                                                        <td class=""Edit_Location"">
                                                            HZW
                                                        </td>
                                                        <td class=""Edit_Area"">
                                                            L2 POREBA 26-205
                              ");
            WriteLiteral(@"                          </td>

                                                    </tr>
                                                </tbody>
                                            </table>
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
