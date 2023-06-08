using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhongKham.WebApp.ViewModels
{
    public class PaymentViewModel
    {
        [Key]
        public int Id { get; set; }
        public DateTime payDate { get; set; }
        public double payAmount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public PatientViewModel Patient { get; set; }
        public int InvoiceId { get; set; }
        public InvoiceViewModel Invoice { get; set; }
        
    }
    public enum PaymentMethod
    {
        cash =1, banktransfer=2
    }
}
