using Microsoft.Extensions.DependencyInjection;
using RestaurantMenu.Database.Abstractions;
using RestaurantMenu.Database.Memory.Repositories;

namespace RestaurantMenu.Database.Memory.Extensions;

public static class ServiceCollectionRegistrationExtensions
{
    public static IServiceCollection AddRestaurantMemoryDatabase(this IServiceCollection services) => 
        services
            .AddSingleton<IRestaurantRepository, RestaurantMemoryRepository>();
}