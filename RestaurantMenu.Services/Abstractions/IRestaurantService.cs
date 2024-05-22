namespace RestaurantMenu.Services.Abstractions;

public interface IRestaurantService
{
    Task<Guid> Create(Restaurant restaurant);
    
    Task<Restaurant?> Get(Guid id);
    
    Task<List<Restaurant>> Get();
    
    Task Update(Guid id, Restaurant restaurant);
    
    Task Delete(Guid id);
}