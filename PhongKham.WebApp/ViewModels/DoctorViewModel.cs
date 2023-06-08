using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PhongKham.WebApp.ViewModels
{
    public class DoctorViewModel
    {
        [Key]
        public int Id { get; set; }
        public string docName { get; set; }
        //specialize one-one
        public int SpecializeId{ get; set; }
        public SpecializeViewModel Specialize { get; set; }
        public ICollection<AppointmentViewModel> Appointments { get; set; }
    }
}
