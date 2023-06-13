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
            //invoice.CalculateInvoiceTotal();
            return await AddAsync(invoice);
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

        public async Task<IEnumerable<Invoice>> GetInvoicesListAsync()
        {
            //invoice.CalculateInvoiceTotal();
            throw new NotImplementedException();
            //return await GetAllAsync(a => a.Patient, k => k.Medicines , p => p.Appointment);
        }

        public Task<Invoice> UpdateInvoice(Invoice invoice)
        {
            _dbContext.Entry(invoice).State = EntityState.Modified;
            return Task.FromResult(invoice);
        }

        public async Task<List<Medicine>> GetMedicinesListAsync()
        {
            return await _dbContext.Medicines.ToListAsync();
        }
    }
}
