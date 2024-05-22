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
    public async Task Create(CreateRestaurantDTO restaurantDto) =>
        await restaurantService.Create(restaurantDto.Adapt<Restaurant>());

    [HttpPatch]
    public async Task Update(UpdateRestaurantDTO restaurantDto) =>
        await restaurantService.Update(restaurantDto.Adapt<Restaurant>());

    [HttpGet]
    public async Task<RestaurantDTO> Get(Guid id) =>
        (await restaurantService.Get(id)).Adapt<RestaurantDTO>();

    [HttpGet("all")]
    public async Task<List<RestaurantDTO>> GetAll() => (await restaurantService.Get()).Adapt<List<RestaurantDTO>>();

    [HttpDelete]
    public async Task Delete(Guid id) => await restaurantService.Delete(id);
}