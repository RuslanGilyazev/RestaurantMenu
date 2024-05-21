using System.Collections.Concurrent;
using RestaurantMenu.Database.Abstractions;

namespace RestaurantMenu.Database.Memory;

public class RestaurantRepository : IRestaurantRepository
{
    private readonly ConcurrentDictionary<Guid, Restaurant> _restaurantDictionary = new();
    
    public async Task<Guid> Create(Restaurant restaurant)
    {
        restaurant.Id = Guid.NewGuid();
        _restaurantDictionary.TryAdd(restaurant.Id, restaurant);
        return await Task.FromResult(restaurant.Id);
    }

    public async Task<Restaurant?> Get(Guid id) => _restaurantDictionary.TryGetValue(id, out var restaurant) ? await Task.FromResult(restaurant) : null;

    public async Task<List<Restaurant>> Get() => await Task.FromResult(_restaurantDictionary.Values.ToList());
}