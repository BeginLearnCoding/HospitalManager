using PhongKham.Core.Entities;
using PhongKham.Core.Interfaces;
using PhongKham.WebApp.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhongKham.WebApp.Services
{
    public class AppointmentService : IAppointmentService
    {

        private readonly IAppointmentRepository _appointmentRepository;
        public AppointmentService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public async Task<Appointment> AddAppointmentAsync(Appointment appointment)
        {
            return await _appointmentRepository.AddAppointmentAsync(appointment);
        }

        public async Task<Appointment> DeleteAppointment(Appointment appointment)
        {
            return await _appointmentRepository.DeleteAppointment(appointment);
        }

        public async Task<Appointment> UpdateAppointment(Appointment appointment)
        {
            return await _appointmentRepository.UpdateAppointment(appointment);
        }

        public async Task<Appointment> GetAppointmentById(int id)
        {
            return await _appointmentRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Appointment>> GetAppointmentsListAsync()
        {
            return await _appointmentRepository.GetAllAsync(a => a.Invoice);
        }
    }
}
