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
    public class SpecializationRepositoryAsync : GenericRepository<Specialize>, ISpecializationRepository
    {
        private readonly DbSet<Specialize> _specialize;
        public SpecializationRepositoryAsync(PhongKhamDbContext context) : base(context)
        {
            _specialize = context.Set<Specialize>();
        }
        public async Task<Specialize> AddSpecializeAsync(Specialize specialize)
        {
            return await AddAsync(specialize);
        }

        public Task<Specialize> DeleteSpecialize(Specialize specialize)
        {
            _dbContext.Set<Specialize>().Remove(specialize);
            return Task.FromResult(specialize);
        }

        public async Task<Specialize> GetSpecializeById(int id)
        {
            return await GetByIdAsync(id);
        }

        public async Task<IEnumerable<Specialize>> GetSpecializesListAsync()
        {
            return await GetAllAsync();
        }

        public Task<Specialize> UpdateSpecialize(Specialize specialize)
        {
            _dbContext.Entry(specialize).State = EntityState.Modified;
            return Task.FromResult(specialize);
        }
    }
}
