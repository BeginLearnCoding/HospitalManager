using PhongKham.Core.Interfaces;
using PhongKham.Infrastructure.Data.Context;
using PhongKham.Infrastructure.Repository;
using System.Threading.Tasks;

namespace PhongKham.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PhongKhamDbContext _context;
        public UnitOfWork(PhongKhamDbContext context)
        {
            _context = context;
            Appointments = new AppointmentRepositoryAsync(_context);
            Invoices = new InvoiceRepositoryAsync(_context);
     
        }
        public IAppointmentRepository Appointments { get; private set; }
        public InvoiceRepositoryAsync Invoices { get; }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
