using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PhongKham.Core.Entities
{
    public class Specialize
    {
        [Key]
        public int Id { get; set; }
        public string specName { get; set; }
        //medicine one-many
        //[ForeignKey("SpecializeId")]
        public ICollection<Medicine> Medicines { get; set; }

    }
}
