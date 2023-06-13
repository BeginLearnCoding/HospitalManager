using PhongKham.Core.Entities;
using PhongKham.Core.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongKham.Core.Interfaces
{
    public interface IMedicineRepository : IGenericRepository<Medicine>
    {
        Task<IEnumerable<Medicine>> GetMedicinesListAsync();
        Task<Medicine> GetMedicineById(int id);
        Task<Medicine> AddMedicineAsync(Medicine medicine);
        Task<Medicine> UpdateMedicine(Medicine medicine);
        Task<Medicine> DeleteMedicine(Medicine medicine);
    }
}
