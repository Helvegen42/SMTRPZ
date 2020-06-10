using DAL.Repositories;
using DAL.UoF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public static class Dependencies
    {
        public static IServiceCollection AddConfigDal(this IServiceCollection collection, IConfiguration configuration)
        {
            collection.AddScoped<IUoF, UoF.UoF>();
            collection.AddDbContext<ApplicationDbContext>(options =>
            options.UseLazyLoadingProxies().
            UseSqlServer(configuration.
            GetConnectionString("BookDataBase")));

            return collection;
        }
    }
}
