using PhongKham.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhongKham.WebApp.Interfaces
{
    public interface ISpecializationService
    {
        Task<IEnumerable<Specialize>> GetSpecializesListAsync();
        Task<Specialize> GetSpecializeById(int id);
        Task<Specialize> AddSpecializeAsync(Specialize specialize);
        Task<Specialize> UpdateSpecialize(Specialize specialize);
        Task<Specialize> DeleteSpecialize(Specialize specialize);
    }
}
