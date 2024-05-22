namespace RestaurantMenu.Api.Extensions;

public static class EnvironmentExtensions
{
    private const string Postgres = nameof(Postgres);
    private const string AspNetCoreEnvironment = "ASPNETCORE_ENVIRONMENT";
    
    public static bool IsPostgresEnvironment()
    {
        return Environment.GetEnvironmentVariable(AspNetCoreEnvironment) == Postgres.ToLower();
    }
}