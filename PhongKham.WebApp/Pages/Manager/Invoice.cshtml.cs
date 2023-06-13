using System;
using System.Collections.Generic;
using System.Linq;
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

        public InvoiceModel(InvoiceService invoiceService, IUnitOfWork unitOfWork, IRazorRenderService renderService)
        {
            _invoiceService = invoiceService;
            _unitOfWork = unitOfWork;
            _renderService = renderService;

        }

        public IEnumerable<Invoice> Invoices { get; set; }
        public async Task OnGetAsync()
        {
            Invoices = await _invoiceService.GetInvoicesListAsync();
        }
        /*
        public void OnGet()
        {
          
        }
        */
        public async Task<PartialViewResult> OnGetViewAllPartial()
        {
            Invoices = await _invoiceService.GetInvoicesListAsync();
            return new PartialViewResult
            {
                ViewName = "_TableInvoice",
                ViewData = new ViewDataDictionary<IEnumerable<Invoice>>(ViewData, Invoices)
            };
        }
        public async Task<JsonResult> OnGetCreateOrEditAsync(int id = 0)
        {
            try
            {
                if (id == 0)
                {
                    var newInvoice = new Invoice();
                    //newInvoice.Medicines = await _invoiceService.GetMedicinesListAsync();
                    return new JsonResult(new { isValid = true, html = await _renderService.ToStringAsync("_CreateOrEditInvoice", newInvoice) });
                }
                else
                {
                    var thisInvoice = await _invoiceService.GetInvoiceById(id);
                    //thisInvoice.Medicines = await _invoiceService.GetMedicinesListAsync();
                    return new JsonResult(new { isValid = true, html = await _renderService.ToStringAsync("_CreateOrEditInvoice", thisInvoice) });
                }
            }
            catch (Exception ex)
            {
                // Log the exception and return an error message to the user
                // ...
                return new JsonResult(new { isValid = false, errorMessage = "An error occurred while processing your request." });
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
                Invoices = await _invoiceService.GetInvoicesListAsync();
                var html = await _renderService.ToStringAsync("_TableInvoice", invoice);
                return new JsonResult(new { isValid = true, html = html });
            }
            else
            {
                var html = await _renderService.ToStringAsync("_CreateOrEditInvoice", invoice);
                return new JsonResult(new { isValid = false, html = html });
            }
        }
        public async Task<JsonResult> OnPostDeleteAsync(int id)
        {
            var invoice = await _invoiceService.GetInvoiceById(id);
            await _invoiceService.DeleteInvoice(invoice);
            await _unitOfWork.CompleteAsync();
            Invoices = await _invoiceService.GetInvoicesListAsync();
            var html = await _renderService.ToStringAsync("_TableInvoice", invoice);
            return new JsonResult(new { isValid = true, html = html });
        }
    }
}
