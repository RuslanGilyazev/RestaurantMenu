using Microsoft.AspNetCore.Mvc;
using RestaurantMenu.Api.Contracts;
using RestaurantMenu.Api.Contracts.Requests;

namespace RestaurantMenu.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class RestaurantController : ControllerBase
{
    [HttpPost]
    public async Task<Guid> Create(CreateRestaurant restaurant)
    {
        return Guid.NewGuid();
    }
    
    [HttpPatch]
    public async Task Update(UpdateRestaurant restaurant)
    {
    }
    
    [HttpGet]
    public async Task<Restaurant> Get(Guid id)
    {
        return new Restaurant();
    }
    
    [HttpDelete]
    public async Task Delete(Guid id)
    {
    }
}