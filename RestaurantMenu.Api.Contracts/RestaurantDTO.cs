using RestaurantMenu.Api.Contracts.Abstraction;

namespace RestaurantMenu.Api.Contracts;

public record RestaurantDTO : RestaurantBaseDTO
{
    public Guid Id { get; set; }
}