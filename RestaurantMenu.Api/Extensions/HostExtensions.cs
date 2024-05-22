using Microsoft.EntityFrameworkCore;
using RestaurantMenu.Database.Postgres;

namespace RestaurantMenu.Api.Extensions
{
    internal static class HostExtensions
    {
        public static IHost Migrate(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            
            var services = scope.ServiceProvider;

            try
            {
                using var context = services.GetRequiredService<RestaurantMenuDBContext>();
                
                context.Database.Migrate();
            }
            catch (Exception ex)
            {
                var logger = services.GetRequiredService<ILogger<Program>>();
                logger.LogError(ex, "An error migrating the DB");
            }
            
            return host;
        }
    }
}