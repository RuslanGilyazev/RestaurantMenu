using RestaurantMenu.Api.Contracts.Abstraction;

namespace RestaurantMenu.Api.Contracts.Requests;

public record UpdateRestaurantDTO : RestaurantBaseDTO
{
    public Guid Id { get; set; }
}