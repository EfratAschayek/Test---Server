using _2_Services.Models;
using _3_Repositories;
using _3_Repositories.Entities;
using _3_Repositories.Interfaces;
using _3_Repositories.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services
{
    public static class Extensions
    {
        public static void AddRepoDependencies(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();

            MapperConfiguration config = new MapperConfiguration(
               conf =>
               {
                   conf.CreateMap<User, UserModel>()
                  .ForMember(dest => dest.UserId, opt => opt.MapFrom(dest => dest.UserId))
                  .ReverseMap()
                  .ForMember(dest => dest.UserId, opt => opt
                  .MapFrom(dest => dest.UserId));
               });
            IMapper mapper = config.CreateMapper();

            services.AddSingleton(mapper);

            services.AddDbContext<IDataSource, Context>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }
    }
}
