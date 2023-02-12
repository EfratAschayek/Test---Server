using _2_Services.Interfaces;
using _2_Services.Models;
using _3_Repositories.Entities;
using _3_Repositories.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services.ServiceClasses
{
    public class UserService:IUserService
    {
        IUserRepository rep;
        IMapper mapper;
        public UserService(IUserRepository _rep, IMapper _mapper)
        {
            rep = _rep;
            mapper = _mapper;
        }

        public async Task<UserModel> AddAsync(UserModel model)
        {
            User newUser = mapper.Map<User>(model);
            return mapper.Map<UserModel>(await rep.AddAsync(newUser));
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<UserModel>> GetAllAsync()
        {
            return mapper.Map<List<UserModel>>(await rep.GetAllAsync());
        }

        public async Task<UserModel> GetByIdAsync(string id)
        {
            return mapper.Map<UserModel>(await rep.GetByIdAsync(id));
        }

        public Task<UserModel> UpdateAsync(UserModel model)
        {
            throw new NotImplementedException();
        }
    }
}
