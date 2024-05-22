using System.Collections.Concurrent;
using RestaurantMenu.Database.Abstractions;
using RestaurantMenu.Database.Exceptions;

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

    public async Task<Restaurant> Get(Guid id) => 
        _restaurantDictionary.TryGetValue(id, out var restaurant) 
            ? await Task.FromResult(restaurant) 
            : throw new NotFoundException(nameof(Restaurant), id.ToString());

    public async Task<List<Restaurant>> Get() => await Task.FromResult(_restaurantDictionary.Values.ToList());
    
    public async Task Update(Restaurant restaurant) => 
        _restaurantDictionary.TryUpdate(restaurant.Id, restaurant, await Get(restaurant.Id));

    public async Task Delete(Guid id) => _restaurantDictionary.TryRemove((await Get(id)).Id, out _);
}