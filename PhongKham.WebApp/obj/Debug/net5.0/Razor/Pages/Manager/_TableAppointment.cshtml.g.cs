#pragma checksum "C:\XT-1\CNPM\CNPM_PhongKham\PhongKham.WebApp\Pages\Manager\_TableAppointment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "614e8d2655c11ddcdb7892cfb19694fb42bafd94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PhongKham.WebApp.Pages.Manager.Pages_Manager__TableAppointment), @"mvc.1.0.view", @"/Pages/Manager/_TableAppointment.cshtml")]
namespace PhongKham.WebApp.Pages.Manager
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
#line 1 "C:\XT-1\CNPM\CNPM_PhongKham\PhongKham.WebApp\Pages\Manager\_ViewImports.cshtml"
using PhongKham.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\XT-1\CNPM\CNPM_PhongKham\PhongKham.WebApp\Pages\Manager\_TableAppointment.cshtml"
using PhongKham.Core.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"614e8d2655c11ddcdb7892cfb19694fb42bafd94", @"/Pages/Manager/_TableAppointment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ef933c5a845806e84e6817c7cadfb985cb7f304", @"/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccef467965adfeba844153eb79036f3f4ffb0839", @"/Pages/Manager/_ViewImports.cshtml")]
    public class Pages_Manager__TableAppointment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Appointment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Appointment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return jQueryModalDelete(this)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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


<!-- Basic Bootstrap Table -->
<div class=""card"">
    <h5 class=""card-header"">Appointment List</h5>
    <div class=""table-responsive text-nowrap"">
        <table class=""table"" id=""appointmentTable"">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Date</th>
                    <th>Note</th>
                    <th>Type</th>
                    <th>Doctor</th>
                    <th>Patient</th>
                    <th>Invoice</th>
                    <th>Action</th>
                </tr>
            </thead>
            <tbody class=""table-border-bottom-0"">
");
#nullable restore
#line 24 "C:\XT-1\CNPM\CNPM_PhongKham\PhongKham.WebApp\Pages\Manager\_TableAppointment.cshtml"
                 if (Model.Count() != 0)
                {


                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\XT-1\CNPM\CNPM_PhongKham\PhongKham.WebApp\Pages\Manager\_TableAppointment.cshtml"
                     foreach (var appointment in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td><i class=\"fab fa-angular fa-lg text-danger me-3\"></i> <strong>");
#nullable restore
#line 31 "C:\XT-1\CNPM\CNPM_PhongKham\PhongKham.WebApp\Pages\Manager\_TableAppointment.cshtml"
                                                                                         Write(appointment.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n                            <td>");
#nullable restore
#line 32 "C:\XT-1\CNPM\CNPM_PhongKham\PhongKham.WebApp\Pages\Manager\_TableAppointment.cshtml"
                           Write(appointment.appDate.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td> ");
#nullable restore
#line 33 "C:\XT-1\CNPM\CNPM_PhongKham\PhongKham.WebApp\Pages\Manager\_TableAppointment.cshtml"
                            Write(appointment.appNote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 34 "C:\XT-1\CNPM\CNPM_PhongKham\PhongKham.WebApp\Pages\Manager\_TableAppointment.cshtml"
                           Write(appointment.appType.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>Doctor Name</td>\r\n                            <td>Patient Name</td>\r\n");
#nullable restore
#line 37 "C:\XT-1\CNPM\CNPM_PhongKham\PhongKham.WebApp\Pages\Manager\_TableAppointment.cshtml"
                             if (appointment.Invoice != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>");
#nullable restore
#line 39 "C:\XT-1\CNPM\CNPM_PhongKham\PhongKham.WebApp\Pages\Manager\_TableAppointment.cshtml"
                               Write(appointment.Invoice.InDatetime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 40 "C:\XT-1\CNPM\CNPM_PhongKham\PhongKham.WebApp\Pages\Manager\_TableAppointment.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>No Invoices</td>\r\n");
#nullable restore
#line 44 "C:\XT-1\CNPM\CNPM_PhongKham\PhongKham.WebApp\Pages\Manager\_TableAppointment.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            <td>
                                <div class=""dropdown"">
                                    <button type=""button"" class=""btn p-0 dropdown-toggle hide-arrow"" data-bs-toggle=""dropdown"">
                                        <i class=""bx bx-dots-vertical-rounded""></i>
                                    </button>
                                    <div class=""dropdown-menu"">
                                        <a class=""dropdown-item""");
            BeginWriteAttribute("onclick", " onclick=\"", 2146, "\"", 2233, 4);
            WriteAttributeValue("", 2156, "jQueryModalGet(\'?handler=CreateOrEdit&id=", 2156, 41, true);
#nullable restore
#line 52 "C:\XT-1\CNPM\CNPM_PhongKham\PhongKham.WebApp\Pages\Manager\_TableAppointment.cshtml"
WriteAttributeValue("", 2197, appointment.Id, 2197, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2212, "\',\'Edit", 2212, 7, true);
            WriteAttributeValue(" ", 2219, "Appointment\')", 2220, 14, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                            <i class=""bx bx-edit-alt me-1""></i>
                                            Edit
                                        </a>
                                        <a class=""dropdown-item"" href=""#"" data-toggle=""modal"" data-target=""#createInvoiceModal"" data-appointmentid=""");
#nullable restore
#line 56 "C:\XT-1\CNPM\CNPM_PhongKham\PhongKham.WebApp\Pages\Manager\_TableAppointment.cshtml"
                                                                                                                                               Write(appointment.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Create Invoice</a>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "614e8d2655c11ddcdb7892cfb19694fb42bafd9410886", async() => {
                WriteLiteral("\r\n                                            <button type=\"submit\">\r\n                                                <i class=\"bx bx-trash me-1\"></i> Delete \r\n                                            </button>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\XT-1\CNPM\CNPM_PhongKham\PhongKham.WebApp\Pages\Manager\_TableAppointment.cshtml"
                                                                                                                    WriteLiteral(appointment.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 66 "C:\XT-1\CNPM\CNPM_PhongKham\PhongKham.WebApp\Pages\Manager\_TableAppointment.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\XT-1\CNPM\CNPM_PhongKham\PhongKham.WebApp\Pages\Manager\_TableAppointment.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>

    </div>
</div>
<!--/ Basic Bootstrap Table -->
<script>
    $('#createInvoiceModal').on('show.bs.modal', function (event) {
        var button = $(event.relatedTarget);
        var appointmentId = button.data('appointmentid');
        var modal = $(this);
        modal.find('#AppointmentId').val(appointmentId);
    });
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Appointment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
