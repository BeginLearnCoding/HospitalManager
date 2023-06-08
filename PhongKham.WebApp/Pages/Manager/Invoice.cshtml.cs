using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using PhongKham.Core.Entities;
using PhongKham.Core.Interfaces;
using PhongKham.WebApp.Services;

namespace PhongKham.WebApp.Pages.Manager
{
    public class InvoiceModel : PageModel
    {
        private readonly InvoiceService _invoiceService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRazorRenderService _renderService;

        public InvoiceModel(InvoiceService invoiceService,IUnitOfWork unitOfWork, IRazorRenderService renderService)
        {
            _invoiceService = invoiceService;
            _unitOfWork = unitOfWork;
            _renderService = renderService;

        }

        public  IEnumerable<Invoice> Invoices { get; set; }
        public async Task OnGetAsync()
        {
            Invoices = await _invoiceService.GetInvoiceListAsync();
        }
        /*
        public void OnGet()
        {
          
        }
        */
        public async Task<PartialViewResult> OnGetViewAllPartial()
        {
            Invoices = await _invoiceService.GetInvoiceListAsync();
            return new PartialViewResult
            {
                ViewName = "_TableInvoice",
                ViewData = new ViewDataDictionary<IEnumerable<Invoice>>(ViewData, Invoices)
            };
        }
        public async Task<JsonResult> OnGetCreateOrEditAsync(int id = 0)
        {
            if (id == 0)
                return new JsonResult(new { isValid = true, html = await _renderService.ToStringAsync("_CreateOrEditInvoice", new Invoice()) });
            else
            {
                var thisInvoice = await _invoiceService.GetInvoiceById(id);
                return new JsonResult(new { isValid = true, html = await _renderService.ToStringAsync("_CreateOrEditInvoice", thisInvoice) });
            }
        }
        public async Task<JsonResult> OnPostCreateOrEditAsync(int id, Invoice invoice)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    await _invoiceService.AddInvoiceAsync(invoice);
                    await _unitOfWork.CompleteAsync();
                }
                else
                {
                    await _invoiceService.UpdateInvoice(invoice);
                    await _unitOfWork.CompleteAsync();
                }
                Invoices = await _invoiceService.GetInvoiceListAsync();
                var html = await _renderService.ToStringAsync("_TableInvoice", invoice);
                return new JsonResult(new { isValid = true, html = html });
            }
            else
            {
                var html = await _renderService.ToStringAsync("_TableInvoice", invoice);
                return new JsonResult(new { isValid = false, html = html });
            }
        }
        public async Task<JsonResult> OnPostDeleteAsync(int id)
        {
            var invoice = await _invoiceService.GetInvoiceById(id);
            await _invoiceService.DeleteInvoice(invoice);
            await _unitOfWork.CompleteAsync();
            Invoices = await _invoiceService.GetInvoiceListAsync();
            var html = await _renderService.ToStringAsync("_TableInvoice", invoice);
            return new JsonResult(new { isValid = true, html = html });
        }
    }
}
