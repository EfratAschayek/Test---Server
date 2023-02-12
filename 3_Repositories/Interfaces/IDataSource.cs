using _3_Repositories.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repositories.Interfaces
{
    public interface IDataSource
    {
        DbSet<User> Users { get; set; }
        DbSet<Child> Children { get; set; }
        abstract Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
