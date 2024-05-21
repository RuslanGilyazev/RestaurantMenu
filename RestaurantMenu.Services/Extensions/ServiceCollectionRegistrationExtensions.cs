using Microsoft.Extensions.DependencyInjection;
using RestaurantMenu.Services.Abstractions;

namespace RestaurantMenu.Services.Extensions;

public static class ServiceCollectionRegistrationExtensions
{
    public static IServiceCollection AddRestaurantServices(this IServiceCollection services) => 
        services.AddTransient<IRestaurantService, RestaurantService>();
}