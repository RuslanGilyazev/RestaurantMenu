using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using RestaurantMenu.Api.Contracts;
using RestaurantMenu.Api.Contracts.Requests;

namespace RestaurantMenu.Api.Controllers;

[ApiVersion("1.0")]
[ApiController]
[Route("[controller]/{RestaurantId}")]
public class MenuPositionController : ControllerBase
{
    [HttpPost]
    public async Task<Guid> Create(CreateMenuPositionDTO restaurant)
    {
        return Guid.NewGuid();
    }
    
    [HttpGet]
    public async Task<MenuPositionDTO> Get(Guid id)
    {
        return new MenuPositionDTO()
        {
            Id = Guid.NewGuid()
        };
    }
    
    [HttpGet("all")]
    public async Task<List<MenuPositionDTO>> GetAll()
    {
        return new List<MenuPositionDTO>()
        {
            new MenuPositionDTO()
            {
                Id = Guid.NewGuid()
            }
        };
    }
    
    [HttpDelete]
    public async Task Delete(Guid id)
    {
    }
}