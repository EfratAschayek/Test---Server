using _3_Repositories.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repositories.Interfaces
{
    public interface IUserRepository:IRepository<User>
    {
        Task<ICollection<User>> GetAllAsync();
        Task<User> GetByIdAsync(string id);
        Task<User> AddAsync(User model);
        Task<User> UpdateAsync(User model);
        Task DeleteAsync(string id);
    }
}
