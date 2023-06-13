using PhongKham.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhongKham.WebApp.Interfaces
{
    public interface IMedicineService
    {
        Task<IEnumerable<Medicine>> GetMedicinesListAsync();
        Task<Medicine> GetMedicineById(int id);
        Task<Medicine> AddMedicineAsync(Medicine medicine);
        Task<Medicine> UpdateMedicine(Medicine medicine);
        Task<Medicine> DeleteMedicine(Medicine medicine);
    }
}
