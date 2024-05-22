namespace RestaurantMenu;

public record Restaurant
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public string Address { get; set; }
}