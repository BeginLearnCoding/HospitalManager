using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PhongKham.WebApp.ViewModels
{
    public class SpecializeViewModel
    {
        [Key]
        public int Id { get; set; }
        public string specName { get; set; }
        //medicine one-many
        //[ForeignKey("SpecializeId")]
        public ICollection<MedicineViewModel> Medicines { get; set; }

    }
}
