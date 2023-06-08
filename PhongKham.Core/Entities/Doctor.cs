using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PhongKham.Core.Entities
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        public string docName { get; set; }
        //specialize one-one
        public int SpecializeId{ get; set; }
        public Specialize Specialize { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}
