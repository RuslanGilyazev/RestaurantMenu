using Microsoft.AspNetCore.Mvc;
using RestaurantMenu.Api.Contracts;
using RestaurantMenu.Api.Contracts.Requests;

namespace RestaurantMenu.Api.Controllers;

[ApiController]
[Route("[controller]/{RestaurantId}")]
public class MenuPositionController : ControllerBase
{
    [HttpPost]
    public async Task<Guid> Create(CreateMenuPosition restaurant)
    {
        return Guid.NewGuid();
    }
    
    [HttpGet]
    public async Task<MenuPosition> Get(Guid id)
    {
        return new MenuPosition()
        {
            Id = Guid.NewGuid()
        };
    }
    
    [HttpGet("all")]
    public async Task<List<MenuPosition>> GetAll()
    {
        return new List<MenuPosition>()
        {
            new MenuPosition()
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