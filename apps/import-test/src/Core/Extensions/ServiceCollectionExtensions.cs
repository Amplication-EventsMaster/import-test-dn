using ImportTest.APIs;

namespace ImportTest;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Add services to the container.
    /// </summary>
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<IClientsService, ClientsService>();
        services.AddScoped<IContractsService, ContractsService>();
        services.AddScoped<ISubscriptionTypesService, SubscriptionTypesService>();
        services.AddScoped<ISystemTypesService, SystemTypesService>();
        services.AddScoped<IUsersService, UsersService>();
    }
}
