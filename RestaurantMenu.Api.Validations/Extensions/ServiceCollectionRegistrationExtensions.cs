using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using RestaurantMenu.Api.Contracts.Requests;
using RestaurantMenu.Api.Validations.Validators;
using SharpGrip.FluentValidation.AutoValidation.Mvc.Extensions;

namespace RestaurantMenu.Api.Validations.Extensions;

public static class ServiceCollectionRegistrationExtensions
{
    public static IServiceCollection AddRestaurantApiValidators(this IServiceCollection services) => 
        services
            .AddValidatorsFromAssemblyContaining<CreateRestaurantDTOValidator>()
            .AddScoped<IValidator<CreateRestaurantDTO> , CreateRestaurantDTOValidator>()
            .AddFluentValidationAutoValidation();
}