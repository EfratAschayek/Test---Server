using _3_Repositories.Entities;
using _3_Repositories.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repositories.Repositories
{
    public class UserRepository : IUserRepository
    {
        IDataSource dataSource;
        public UserRepository(IDataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public async Task<User> AddAsync(User model)
        {
            EntityEntry<User> newUser = dataSource.Users.Add(model);
            await dataSource.SaveChangesAsync();
            return newUser.Entity;
        }

        public Task DeleteAsync(User model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<User>> GetAllAsync()
        {
            return await dataSource.Users.ToListAsync();
        }

        public async Task<User?> GetByIdAsync(string id)
        {
            return await dataSource.Users.FirstOrDefaultAsync(u => u.IdNumber == id);
        }

        public Task<User> UpdateAsync(User model)
        {
            throw new NotImplementedException();
        }
    }
}
