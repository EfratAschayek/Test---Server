using _2_Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services.Interfaces
{
    public interface IUserService : IService<UserModel>
    {
        Task<ICollection<UserModel>> GetAllAsync();
        Task<UserModel> GetByIdAsync(string id);
        Task<UserModel> AddAsync(UserModel model);
        Task<UserModel> UpdateAsync(UserModel model);
        Task DeleteAsync(string id);
    }
}
