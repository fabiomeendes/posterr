namespace Posterr.API
{
    public static class ModularModule
    {
        public static IServiceCollection LoadModules(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddUserModule(configuration)
                .AddPostModule(configuration);

            return services;
        }

        private static IServiceCollection AddUserModule(this IServiceCollection services, IConfiguration configuration)
        {
            Users.Application.ApplicationModule.AddApplication(services);
            Users.Infrastructure.InfrastructureModule.AddInfrastructure(services, configuration);

            return services;
        }

        private static IServiceCollection AddPostModule(this IServiceCollection services, IConfiguration configuration)
        {
            Posts.Application.ApplicationModule.AddApplication(services);
            Posts.Infrastructure.InfrastructureModule.AddInfrastructure(services, configuration);

            return services;
        }
    }
}
