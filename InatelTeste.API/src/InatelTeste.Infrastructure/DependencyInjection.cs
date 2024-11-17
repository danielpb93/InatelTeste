using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InatelTeste.Application.interfaces.services;
using InatelTeste.Domain.interfaces.repositories;
using InatelTeste.Infrastructure.Context;
using InatelTeste.Infrastructure.repositories;
using InatelTeste.Infrastructure.seed;
using InatelTeste.Infrastructure.services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InatelTeste.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseMySQL(configuration.GetConnectionString("Default")));

            services.AddHttpClient<UniversityAPIService>("UniversityApi",
            client =>
            {
                client.BaseAddress = new Uri("http://universities.hipolabs.com");
            });

            services.AddScoped<IUniversityRepository, UniversityRepository>();
            services.AddScoped<IUniversityAPIService, UniversityAPIService>();
            services.AddScoped<DataSeeder>();
            return services;
        }
    }
}