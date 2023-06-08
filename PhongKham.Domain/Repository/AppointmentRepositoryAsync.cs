using Microsoft.EntityFrameworkCore;
using PhongKham.Core.Entities;
using PhongKham.Core.Interfaces;
using PhongKham.Infrastructure.Data.Context;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhongKham.Infrastructure.Repository
{
    public class AppointmentRepositoryAsync : GenericRepository<Appointment>, IAppointmentRepository
    {
        private readonly DbSet<Appointment> _appointment;
        public AppointmentRepositoryAsync(PhongKhamDbContext context) : base(context)
        {
            _appointment = context.Set<Appointment>();
        }

        public async Task<Appointment> AddAppointmentAsync(Appointment appointment)
        {
            return await AddAsync(appointment);
        }

        public  Task<Appointment> UpdateAppointment(Appointment appointment)
        {
            _dbContext.Entry(appointment).State = EntityState.Modified;
            return Task.FromResult(appointment);
        }

        public  Task<Appointment> DeleteAppointment(Appointment appointment)
        {
            _dbContext.Set<Appointment>().Remove(appointment);
            return Task.FromResult(appointment);
        }

        public async Task<Appointment> GetAppointmentById(int id)
        {
            return await GetByIdAsync(id);
        }

        public async Task<IEnumerable<Appointment>> GetAppointmentsListAsync()
        {
            return await GetAllAsync(a => a.Invoice);
        }

    }
}
