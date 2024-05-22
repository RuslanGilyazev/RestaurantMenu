namespace RestaurantMenu.Database.Postgres.Models;

public class RestaurantDAO
{
    public Guid Id { get; set; }
    
    public required string Name { get; set; }
    
    public required string Address { get; set; }
    
    public List<MenuPositionDAO>? MenuPositions { get; set; }
}