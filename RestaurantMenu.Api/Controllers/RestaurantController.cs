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
    public async Task<IActionResult> Create(CreateRestaurantDTO restaurantDto) => 
         Created("/", await restaurantService.Create(restaurantDto.Adapt<Restaurant>()));

    [HttpPatch]
    public async Task Update(UpdateRestaurantDTO restaurantDto)
    {
    }

    [HttpGet]
    public async Task<IActionResult> Get(Guid id) => 
        await restaurantService.Get(id) is { } restaurant ? Ok(restaurant.Adapt<RestaurantDTO>()) : NotFound();


    [HttpGet("all")]
    public async Task<List<RestaurantDTO>> GetAll() => (await restaurantService.Get()).Adapt<List<RestaurantDTO>>();

    [HttpDelete]
    public async Task Delete(Guid id)
    {
    }
}