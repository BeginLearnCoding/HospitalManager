#pragma checksum "C:\XT-1\CNPM\CNPM_PhongKham\PhongKham.WebApp\Pages\Manager\Appointment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dccfc4cc1969a6cfdded1a8244be8b47cb3835c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PhongKham.WebApp.Pages.Manager.Pages_Manager_Appointment), @"mvc.1.0.razor-page", @"/Pages/Manager/Appointment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/Manager/Appointment")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dccfc4cc1969a6cfdded1a8244be8b47cb3835c5", @"/Pages/Manager/Appointment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ef933c5a845806e84e6817c7cadfb985cb7f304", @"/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccef467965adfeba844153eb79036f3f4ffb0839", @"/Pages/Manager/_ViewImports.cshtml")]
    public class Pages_Manager_Appointment : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <div class=""col-sm-12"" style=""padding:20px"">
        <a onclick=""jQueryModalGet('?handler=CreateOrEdit','Create Appointment')"" class=""btn bg-success"">
            Create
        </a>
        <a id=""reload"" class=""btn bg-warning"">
            Reload
        </a>
    </div>
    <div id=""viewAll"" class=""container-xxl flex-grow-1 container-p-y""> </div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('#viewAll').load('?handler=ViewAllPartial');
        });
        $(function () {
            $('#reload').on('click', function () {
                $('#viewAll').load('?handler=ViewAllPartial');
            });
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PhongKham.WebApp.Pages.Manager.AppointmentModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PhongKham.WebApp.Pages.Manager.AppointmentModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PhongKham.WebApp.Pages.Manager.AppointmentModel>)PageContext?.ViewData;
        public PhongKham.WebApp.Pages.Manager.AppointmentModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
