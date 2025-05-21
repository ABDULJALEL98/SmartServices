using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SmartServices.Data;
using SmartServices.Repositories;
using SmartServices.Repositories.Contracts;
using SmartServices.Services;
using SmartServices.Services.Contracts;

namespace SmartServices.Infrastructure.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)

        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
                 

                options.EnableSensitiveDataLogging(true);
            });
        }

        public static void ConfigureRepositoryRegistration(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
        }
        public static void ConfigureServiceRegistration(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
        }


    }







    }
