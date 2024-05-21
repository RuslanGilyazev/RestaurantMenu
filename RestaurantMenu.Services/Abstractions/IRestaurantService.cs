namespace RestaurantMenu.Services.Abstractions;

public interface IRestaurantService
{
    Task<Guid> Create(Restaurant restaurant);
    
    Task<Restaurant?> Get(Guid id);
    
    Task<List<Restaurant>> Get();
}