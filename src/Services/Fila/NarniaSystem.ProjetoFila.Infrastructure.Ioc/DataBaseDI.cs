using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NarniaSystem.ProjetoFila.Infrastructure.Data;

namespace NarniaSystem.ProjetoFila.Infrastructure.Ioc
{
    public static class DataBaseDI
    {
        public static IServiceCollection AddConfigDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("ConnectionMysql");

            services.AddDbContext<FilaDbContext>(options =>
            {
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            });


            return services;
        }
    }
}
