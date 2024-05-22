﻿namespace RestaurantMenu;

public record Restaurant
{
    public Guid Id { get; set; }
    
    public required string Name { get; set; }
    
    public required string Address { get; set; }
}