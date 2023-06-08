using CNPM_PhongKham.Data.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhongKham.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhongKham.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AppointmentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult GetAllAppointments()
        {
            var popularAppointments = _unitOfWork.Appointments.GetAppointmentsListAsync();
            return Ok(popularAppointments);
        }
        [HttpPost]
        public IActionResult GetAppointmentById()
        {
            var appointment = new Appointment
            {
                appDate = DateTime.Now,
                appNote = " Tiem phong Covid",
                appType = AppType.TiemPhong

            };

            _unitOfWork.Appointments.AddAsync(appointment);
            _unitOfWork.CompleteAsync();
            return Ok();

        }
    }
}
