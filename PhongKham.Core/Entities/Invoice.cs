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
        public Payment Payment { get; set; }
        public int? AppointmentId { get; set; }
        public Appointment Appointment { get; set; }
        public ICollection<Medicine> Medicines { get; set; }

    }
}
