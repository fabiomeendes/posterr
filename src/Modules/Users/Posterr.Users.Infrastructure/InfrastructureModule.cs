using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Posterr.Users.Core.Repositories;
using Posterr.Users.Infrastructure.Persistence.Repositories;

namespace Posterr.Users.Infrastructure
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("PosterrCs");

            services
                .AddDb(connectionString)
                .AddRepositories();

            return services;
        }

        private static IServiceCollection AddDb(this IServiceCollection services, string? connectionString)
        {
            services.AddDbContext<UsersDbContext>(options => options.UseSqlServer(connectionString));

            return services;
        }

        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
