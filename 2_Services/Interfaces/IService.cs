using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services.Interfaces
{
    public interface IService<T>
    {
        Task<ICollection<T>> GetAllAsync();
        Task<T> GetByIdAsync(string id);
        Task<T> AddAsync(T model);
        Task<T> UpdateAsync(T model);
        Task DeleteAsync(string id);
    }
}
