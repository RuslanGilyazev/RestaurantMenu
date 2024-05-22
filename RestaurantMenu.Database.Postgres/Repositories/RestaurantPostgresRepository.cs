using Mapster;
using Microsoft.EntityFrameworkCore;
using RestaurantMenu.Database.Abstractions;
using RestaurantMenu.Database.Exceptions;
using RestaurantMenu.Database.Postgres.Models;

namespace RestaurantMenu.Database.Postgres.Repositories;

public class RestaurantPostgresRepository(RestaurantMenuDBContext dbContext) : IRestaurantRepository
{
    public async Task<Guid> Create(Restaurant restaurant)
    {
        var create = restaurant.Adapt<RestaurantDAO>();
        await dbContext.Restaurants.AddAsync(create);
        await dbContext.SaveChangesAsync();
        return create.Id;
    }

    public async Task<Restaurant> Get(Guid id) => (await GetDAO(id)).Adapt<Restaurant>();

    public async Task<List<Restaurant>> Get() => (await dbContext.Restaurants.ToListAsync()).Adapt<List<Restaurant>>();

    public async Task Update(Guid id, Restaurant restaurant)
    {
        var dao = await GetDAO(id);
        var restaurantDAOUpdate = restaurant.Adapt<RestaurantDAO>();
        dbContext.Entry(dao).CurrentValues.SetValues(restaurantDAOUpdate);
        await dbContext.SaveChangesAsync();
    }

    public async Task Delete(Guid id)
    {
        dbContext.Restaurants.Remove(await GetDAO(id));
        await dbContext.SaveChangesAsync();
    }

    private async Task<RestaurantDAO> GetDAO(Guid id) => 
        await dbContext.Restaurants.FindAsync(id) ?? throw new NotFoundException(nameof(Restaurant), id.ToString());
}