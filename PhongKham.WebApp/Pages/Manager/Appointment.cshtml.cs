using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using PhongKham.Core.Entities;
using PhongKham.Core.Interfaces;
using PhongKham.WebApp.Services;

namespace PhongKham.WebApp.Pages.Manager
{
    public class AppointmentModel : PageModel
    {
        private readonly AppointmentService _appointmentService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRazorRenderService _renderService;

        public AppointmentModel(AppointmentService appointmentService,IUnitOfWork unitOfWork, IRazorRenderService renderService)
        {
            _appointmentService = appointmentService;
            _unitOfWork = unitOfWork;
            _renderService = renderService;

        }

        public  IEnumerable<Appointment> Appointments { get; set; }
        public async Task OnGetAsync()
        {
            Appointments = await _appointmentService.GetAppointmentsListAsync();
        }
        /*
        public void OnGet()
        {
          
        }
        */
        public async Task<PartialViewResult> OnGetViewAllPartial()
        {
            Appointments = await _appointmentService.GetAppointmentsListAsync();
            return new PartialViewResult
            {
                ViewName = "_TableAppointment",
                ViewData = new ViewDataDictionary<IEnumerable<Appointment>>(ViewData, Appointments)
            };
        }
        public async Task<JsonResult> OnGetCreateOrEditAsync(int id = 0)
        {
            if (id == 0)
                return new JsonResult(new { isValid = true, html = await _renderService.ToStringAsync("_CreateOrEditAppointment", new Appointment()) });
            else
            {
                var thisAppointment = await _appointmentService.GetAppointmentById(id);
                return new JsonResult(new { isValid = true, html = await _renderService.ToStringAsync("_CreateOrEditAppointment", thisAppointment) });
            }
        }
        public async Task<JsonResult> OnPostCreateOrEditAsync(int id, Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    await _appointmentService.AddAppointmentAsync(appointment);
                    await _unitOfWork.CompleteAsync();
                }
                else
                {
                    await _appointmentService.UpdateAppointment(appointment);
                    await _unitOfWork.CompleteAsync();
                }
                Appointments = await _appointmentService.GetAppointmentsListAsync();
                var html = await _renderService.ToStringAsync("_TableAppointment", appointment);
                return new JsonResult(new { isValid = true, html = html });
            }
            else
            {
                var html = await _renderService.ToStringAsync("_CreateOrEditAppointment", appointment);
                return new JsonResult(new { isValid = false, html = html });
            }
        }
        public async Task<JsonResult> OnPostDeleteAsync(int id)
        {
            var appointment = await _appointmentService.GetAppointmentById(id);
            await _appointmentService.DeleteAppointment(appointment);
            await _unitOfWork.CompleteAsync();
            Appointments = await _appointmentService.GetAppointmentsListAsync();
            var html = await _renderService.ToStringAsync("_TableAppointment", appointment);
            return new JsonResult(new { isValid = true, html = html });
        }
    }
}
