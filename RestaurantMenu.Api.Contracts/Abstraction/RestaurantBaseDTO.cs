namespace RestaurantMenu.Api.Contracts.Abstraction;

public abstract record RestaurantBaseDTO
{
    public string Name { get; set; }
    
    public string Address { get; set; }
}