using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhongKham.Core.Entities
{
    public class Medicine
    {
        [Key]
        public int Id { get; set; }
        public string medName { get; set; }
        public DateTime medOutdate { get; set; }
        public double medPrice { get; set; }
        public int SpecializeId { get; set; }
        public Specialize Specialize { get; set; }
    }
}
