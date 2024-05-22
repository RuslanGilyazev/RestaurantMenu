using FluentValidation;
using RestaurantMenu.Api.Contracts.Requests;

namespace RestaurantMenu.Api.Validations.Validators;

public class CreateRestaurantDTOValidator : AbstractValidator<CreateRestaurantDTO> 
{
    public CreateRestaurantDTOValidator()
    {
        RuleFor(dto => dto.Name).NotNull().NotEmpty();
        RuleFor(dto => dto.Address).NotNull().NotEmpty();
    }
}