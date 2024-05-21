using Mapster;
using RestaurantMenu.Api.Contracts.Requests;

namespace RestaurantMenu.Api.Mapping;

public class RestaurantMapping : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.ForType<CreateRestaurantDTO, Restaurant>();
    }
}