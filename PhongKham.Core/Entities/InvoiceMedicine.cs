using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongKham.Core.Entities
{
    public class InvoiceMedicine
    {
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }

        public int MedicineId { get; set; }
        public Medicine Medicine { get; set; }
    }
}
