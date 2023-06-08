using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PhongKham.WebApp.ViewModels
{
    public class InvoiceViewModel
    {
        [Key]
        public int Id { get; set; }
        public string InNote { get; set; }
        public DateTime InDatetime { get; set; }
        public PaymentViewModel Payment { get; set; }
        public int? AppointmentId { get; set; }
        public AppointmentViewModel Appointment { get; set; }
        public ICollection<MedicineViewModel> Medicines { get; set; }

    }
}
