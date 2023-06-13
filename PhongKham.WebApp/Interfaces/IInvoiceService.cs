using PhongKham.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhongKham.WebApp.Interfaces
{
    public interface IInvoiceService
    {
        Task<IEnumerable<Invoice>> GetInvoicesListAsync();
        Task<Invoice> GetInvoiceById(int id);
        Task<Invoice> AddInvoiceAsync(Invoice invoice);
        Task<Invoice> UpdateInvoice(Invoice invoice);
        Task<Invoice> DeleteInvoice(Invoice invoice);
        Task<List<Medicine>> GetMedicinesListAsync();
    }
}
