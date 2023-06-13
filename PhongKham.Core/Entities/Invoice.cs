using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PhongKham.Core.Entities
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        public string InNote { get; set; }
        public DateTime InDatetime { get; set; }
        public double InvoiceTotal { get; set; }
        public int? AppointmentId { get; set; }
        public Appointment Appointment { get; set; }
        public ICollection<InvoiceMedicine> InvoiceMedicines { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public Patient Patient { get; set; }
   
    }

    public enum PaymentStatus
    {
        payed =1, unpay =2
    }

    public enum PaymentMethod
    {
        cash = 1, banktransfer = 2
    }
}
