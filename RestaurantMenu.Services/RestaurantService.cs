using RestaurantMenu.Database.Abstractions;
using RestaurantMenu.Services.Abstractions;

namespace RestaurantMenu.Services;

public class RestaurantService(IRestaurantRepository restaurantRepository) : IRestaurantService
{
    public async Task<Guid> Create(Restaurant restaurant) => await restaurantRepository.Create(restaurant);
    
    public async Task<Restaurant?> Get(Guid id) => await restaurantRepository.Get(id);

    public async Task<List<Restaurant>> Get() => await restaurantRepository.Get();
    
    public async Task Update(Guid id, Restaurant restaurant) => await restaurantRepository.Update(id, restaurant);

    public async Task Delete(Guid id) => await restaurantRepository.Delete(id);
}