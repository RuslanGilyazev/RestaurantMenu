using Microsoft.Extensions.DependencyInjection;
using RestaurantMenu.Database.Abstractions;

namespace RestaurantMenu.Database.Memory.Extensions;

public static class ServiceCollectionRegistrationExtensions
{
    public static IServiceCollection AddRestaurantMemoryDatabaseServices(this IServiceCollection services) => 
        services
            .AddSingleton<IRestaurantRepository, RestaurantRepository>();
}