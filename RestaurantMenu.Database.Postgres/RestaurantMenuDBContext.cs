using Microsoft.EntityFrameworkCore;
using RestaurantMenu.Database.Postgres.Models;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace RestaurantMenu.Database.Postgres;

public class RestaurantMenuDBContext : DbContext
{
    public DbSet<RestaurantDAO> Restaurants { get; set; }
    
    public DbSet<MenuPositionDAO> MenuPositions { get; set; }
    
    public RestaurantMenuDBContext(DbContextOptions<RestaurantMenuDBContext> options) : base(options)
    {
    }
}