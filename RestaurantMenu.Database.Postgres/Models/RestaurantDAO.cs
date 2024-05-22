namespace RestaurantMenu.Database.Postgres.Models;

public class RestaurantDAO
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public string Address { get; set; }
    
    public List<MenuPositionDAO> MenuPositions { get; set; }
}