using PhongKham.Core.Entities;
using PhongKham.Core.Interfaces;
using PhongKham.WebApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhongKham.WebApp.Services
{
    public class MedicineService : IMedicineService
    {
        private readonly IMedicineRepository _medicineRepository;
        public MedicineService(IMedicineRepository medicineRepository)
        {
            _medicineRepository = medicineRepository;
        }
        public async Task<Medicine> AddMedicineAsync(Medicine medicine)
        {
            return await _medicineRepository.AddMedicineAsync(medicine);
        }

        public async Task<Medicine> DeleteMedicine(Medicine medicine)
        {
            return await _medicineRepository.DeleteMedicine(medicine);
        }

        public async Task<Medicine> GetMedicineById(int id)
        {
            return await _medicineRepository.GetMedicineById(id);
        }

        public async Task<IEnumerable<Medicine>> GetMedicinesListAsync()
        {
            return await _medicineRepository.GetMedicinesListAsync();
        }

        public async Task<Medicine> UpdateMedicine(Medicine medicine)
        {
            return await _medicineRepository.UpdateMedicine(medicine);
        }
    }
}
