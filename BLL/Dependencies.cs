using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BLL.MapperConfig;
using System.Reflection;
using BLL.Interfaces;
using BLL.Services;

namespace BLL
{
    public static class Dependencies
    {
        public static IServiceCollection AddDependenciesBll(this IServiceCollection collection)
        {
            collection.AddAutoMapper(Assembly.GetExecutingAssembly());
            collection.AddScoped<IGoodsService, GoodsService>();

            return collection;
        }
    }
}
