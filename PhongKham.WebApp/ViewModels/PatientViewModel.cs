using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PhongKham.WebApp.ViewModels
{
    public class PatientViewModel
    {
        [Key]
        public int Id { get; set; }
        public string patName { get; set; }
        public DateTime patBirthday { get; set; }
        public string patAddress { get; set; }
        public int patPhone { get; set; }
        //List of appointment
        public ICollection<AppointmentViewModel> Appointments { get; set; }
        //list of payment
        public ICollection<PaymentViewModel> Payments { get; set; }
    }
}
