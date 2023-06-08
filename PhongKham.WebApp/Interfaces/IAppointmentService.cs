using PhongKham.WebApp.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using PhongKham.Core.Entities;

namespace PhongKham.WebApp.Interfaces
{
    public interface IAppointmentService
    {
        Task<IEnumerable<Appointment>> GetAppointmentsListAsync();
        Task<Appointment> GetAppointmentById(int id);
        Task<Appointment> AddAppointmentAsync(Appointment appointment);
        Task<Appointment> UpdateAppointment(Appointment appointment);
        Task<Appointment> DeleteAppointment(Appointment appointment);
    }
}
