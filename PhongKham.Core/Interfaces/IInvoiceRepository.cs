using PhongKham.Core.Entities;
using PhongKham.Core.Interfaces.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhongKham.Core.Interfaces
{
    public interface IInvoiceRepository : IGenericRepository<Invoice>
    {
        Task<IEnumerable<Invoice>> GetInvoiceListAsync();
        Task<Invoice> GetInvoiceById(int id);
        Task<Invoice> AddInvoiceAsync(Invoice invoice);
        Task<Invoice> UpdateInvoice(Invoice invoice);
        Task<Invoice> DeleteInvoice(Invoice invoice);
    }
}
