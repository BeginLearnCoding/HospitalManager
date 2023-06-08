using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhongKham.WebApp.ViewModels
{
    public class AppointmentViewModel
    {
        [Key]
        public int Id { get; set; }
        public DateTime appDate { get; set; }
        public string appNote { get; set; }
        public AppType appType { get; set; }
        //n - 1 relationship
        //public int DoctorId { get; set; }
        public DoctorViewModel Doctor { get; set; }
        //public int PatientId { get; set; }
        public PaymentViewModel Patient { get; set; }
        // public int InvoiceId { get; set; }
        public InvoiceViewModel Invoice { get; set; }
    }
    public enum AppType
    {
        TiemPhong, XetNghiem, ChuanDoan, TuVan
    }
}

