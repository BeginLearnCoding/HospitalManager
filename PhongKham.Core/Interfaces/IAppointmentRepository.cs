using PhongKham.Core.Entities;
using PhongKham.Core.Interfaces.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhongKham.Core.Interfaces
{
    public interface IAppointmentRepository : IGenericRepository<Appointment>
    {
        Task<IEnumerable<Appointment>> GetAppointmentsListAsync();
        Task<Appointment> GetAppointmentById(int id);
        Task<Appointment> AddAppointmentAsync(Appointment appointment);
        Task<Appointment> UpdateAppointment(Appointment appointment);
        Task<Appointment> DeleteAppointment(Appointment appointment);
    }
}
