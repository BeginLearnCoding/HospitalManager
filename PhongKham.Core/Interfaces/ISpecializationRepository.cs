using PhongKham.Core.Entities;
using PhongKham.Core.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongKham.Core.Interfaces
{
    public interface ISpecializationRepository : IGenericRepository<Specialize>
    {
        Task<IEnumerable<Specialize>> GetSpecializesListAsync();
        Task<Specialize> GetSpecializeById(int id);
        Task<Specialize> AddSpecializeAsync(Specialize specialize);
        Task<Specialize> UpdateSpecialize(Specialize specialize);
        Task<Specialize> DeleteSpecialize(Specialize specialize);
    }
}
