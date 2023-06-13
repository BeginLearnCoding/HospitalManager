using Microsoft.EntityFrameworkCore;
using PhongKham.Core.Entities;
using PhongKham.Core.Interfaces;
using PhongKham.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongKham.Infrastructure.Repository
{
    public class MedicineRepositoryAsync : GenericRepository<Medicine>, IMedicineRepository
    {
        private readonly DbSet<Medicine> _medicine;
        public MedicineRepositoryAsync(PhongKhamDbContext context):base(context)
        {
            _medicine = context.Set<Medicine>();
        }


        public async Task<Medicine> AddMedicineAsync(Medicine medicine)
        {
            return await AddAsync(medicine);
        }

        public Task<Medicine> DeleteMedicine(Medicine medicine)
        {
            _dbContext.Set<Medicine>().Remove(medicine);
            return Task.FromResult(medicine);
        }

        public async Task<Medicine> GetMedicineById(int id)
        {
            return await GetByIdAsync(id);
        }

        public async Task<IEnumerable<Medicine>> GetMedicinesListAsync()
        {
            return await GetAllAsync(a => a.Specialize);
        }

        public Task<Medicine> UpdateMedicine(Medicine medicine)
        {
            _dbContext.Entry(medicine).State = EntityState.Modified;
            return Task.FromResult(medicine);
        }
    }
}
