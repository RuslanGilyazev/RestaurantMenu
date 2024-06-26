﻿namespace RestaurantMenu.Database.Postgres.Models;

public class MenuPositionDAO
{
    public Guid Id { get; set; }
    
    public required string Name { get; set; }
    
    public decimal Price { get; set; }
    
    public RestaurantDAO? Restaurant { get; set; }
}