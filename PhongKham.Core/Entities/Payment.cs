using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhongKham.Core.Entities
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        public DateTime payDate { get; set; }
        public double payAmount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public Patient Patient { get; set; }
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
        
    }
    public enum PaymentMethod
    {
        cash =1, banktransfer=2
    }
}
