using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RestaurantMenu.Database.Abstractions;
using RestaurantMenu.Database.Postgres.Repositories;

namespace RestaurantMenu.Database.Postgres.Extensions;

public static class ServiceCollectionRegistrationExtensions
{
    public static IServiceCollection AddRestaurantPostgresDatabase(this IServiceCollection services, IConfiguration configuration) =>
        services.AddDbContext<RestaurantMenuDBContext>(builder => 
            builder.UseNpgsql(configuration.GetConnectionString("postgres")))
            .AddScoped<IRestaurantRepository, RestaurantPostgresRepository>();
}