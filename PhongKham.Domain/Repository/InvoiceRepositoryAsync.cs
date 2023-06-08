using Microsoft.EntityFrameworkCore;
using PhongKham.Core.Entities;
using PhongKham.Core.Interfaces;
using PhongKham.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongKham.Infrastructure.Repository
{
    public class InvoiceRepositoryAsync : GenericRepository<Invoice>, IInvoiceRepository
    {
        private readonly DbSet<Invoice> _invoice;
        public InvoiceRepositoryAsync(PhongKhamDbContext context) : base(context)
        {
            _invoice = context.Set<Invoice>();
        }
        public async Task<Invoice> AddInvoiceAsync(Invoice invoice)
        {
            return await AddAsync(invoice);
        }

        public async Task<Invoice> UpdateInvoice(Invoice invoice, )
        {
            await Update(invoice, a => a.Medicines, p => p.Payment, k=>k.Appointment);
            return invoice;
        }

        public Task<Invoice> DeleteInvoice(Invoice invoice)
        {
            _dbContext.Set<Invoice>().Remove(invoice);
            return Task.FromResult(invoice);
        }

        public async Task<Invoice> GetInvoiceById(int id)
        {
            return await GetByIdAsync(id);
        }

        public async Task<IEnumerable<Invoice>> GetInvoiceListAsync()
        {
            return await GetAllAsync(a => a.Medicines, p => p.Payment );
        }
    }
}
