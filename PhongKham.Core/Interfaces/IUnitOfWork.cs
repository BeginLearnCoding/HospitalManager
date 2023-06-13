using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongKham.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAppointmentRepository Appointments { get; }
        IMedicineRepository Medicines { get; }
        IInvoiceRepository Invoices { get; }
        Task<int> CompleteAsync();
       // Task<int> Commit();
    }
}
