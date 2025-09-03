using DevBnbStart.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DevBnbStart.Infrastructure
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddData(configuration)
                .AddRepositories();
        
            return services;
        }

        static IServiceCollection AddData(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("AppDb");

            services.AddDbContext<AppDbContext>(o => o.UseSqlServer(connectionString));
            return services;
        }
        static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services;
        }
    }
}
