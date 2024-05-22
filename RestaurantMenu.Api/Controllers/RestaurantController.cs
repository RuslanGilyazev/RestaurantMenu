using Asp.Versioning;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using RestaurantMenu.Api.Contracts;
using RestaurantMenu.Api.Contracts.Requests;
using RestaurantMenu.Services.Abstractions;

namespace RestaurantMenu.Api.Controllers;

[ApiVersion("1.0")]
[ApiController]
[Route("[controller]")]
public class RestaurantController(IRestaurantService restaurantService) : ControllerBase
{
    [HttpPost]
    public async Task<Guid> Create(CreateRestaurantDTO restaurantDto) =>
        await restaurantService.Create(restaurantDto.Adapt<Restaurant>());

    [HttpPatch("{id:guid}")]
    public async Task Update(Guid id, UpdateRestaurantDTO restaurantDto)
    {
        var restaurant = restaurantDto.Adapt<Restaurant>();
        restaurant.Id = id;
        await restaurantService.Update(id, restaurant);
    }

    [HttpGet("{id:guid}")]
    public async Task<RestaurantDTO> Get(Guid id) =>
        (await restaurantService.Get(id)).Adapt<RestaurantDTO>();

    [HttpGet("all")]
    public async Task<List<RestaurantDTO>> GetAll() => (await restaurantService.Get()).Adapt<List<RestaurantDTO>>();

    [HttpDelete("{id:guid}")]
    public async Task Delete(Guid id) => await restaurantService.Delete(id);
}