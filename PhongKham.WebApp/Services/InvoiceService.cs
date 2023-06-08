using PhongKham.Core.Entities;
using PhongKham.Core.Interfaces;
using PhongKham.WebApp.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhongKham.WebApp.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository _invoiceRepository;
        public InvoiceService(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }
        public async Task<Invoice> AddInvoiceAsync(Invoice invoice)
        {
            return await _invoiceRepository.AddInvoiceAsync(invoice);
        }

        public async Task<Invoice> DeleteInvoice(Invoice invoice)
        {
            return await _invoiceRepository.DeleteInvoice(invoice);
        }

        public async Task<Invoice> GetInvoiceById(int id)
        {
            return await _invoiceRepository.GetInvoiceById(id);
        }

        public async Task<IEnumerable<Invoice>> GetInvoiceListAsync()
        {
            return await _invoiceRepository.GetAllAsync(a => a.Medicines, p => p.Payment);
        }

        public async Task<Invoice> UpdateInvoice(Invoice invoice)
        {
            return await _invoiceRepository.Update(invoice, a => a.Medicines, p => p.Payment);
        }
    }
}
