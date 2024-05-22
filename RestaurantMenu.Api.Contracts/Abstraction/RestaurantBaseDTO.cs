namespace RestaurantMenu.Api.Contracts.Abstraction;

public abstract record RestaurantBaseDTO
{
    public required string Name { get; set; }
    
    public required string Address { get; set; }
}