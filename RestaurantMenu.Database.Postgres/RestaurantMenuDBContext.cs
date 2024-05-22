using Microsoft.EntityFrameworkCore;
using RestaurantMenu.Database.Postgres.Models;

namespace RestaurantMenu.Database.Postgres;

public class RestaurantMenuDBContext : DbContext
{
    public DbSet<RestaurantDAO> Restaurants { get; set; }
    
    public DbSet<MenuPositionDAO> MenuPositions { get; set; }
    
    public RestaurantMenuDBContext(DbContextOptions<RestaurantMenuDBContext> options) : base(options)
    {
    }
}