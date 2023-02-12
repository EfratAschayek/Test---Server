using _3_Repositories.Entities;
using _3_Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _3_Repositories
{
    public class Context : DbContext, IDataSource
    {
        public DbSet<Child> Children { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=PeopleDB;Integrated Security=True;TrustServerCertificate=True");
            optionsBuilder.UseLazyLoadingProxies(true).UseSqlServer(@"Data Source=.;Initial Catalog=PeopleDB;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}

