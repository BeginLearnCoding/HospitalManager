using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PhongKham.Core.Entities
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }
        public DateTime appDate { get; set; }
        public string appNote { get; set; }
        public AppType appType { get; set; }
        //n - 1 relationship
        //public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        //public int PatientId { get; set; }
        public Patient Patient { get; set; }
       // public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
    }
    public enum AppType { 
        TiemPhong, XetNghiem, ChuanDoan, TuVan
    }
}
