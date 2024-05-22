using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using RestaurantMenu.Database.Exceptions;

namespace RestaurantMenu.Api.Filters;

public class NotFoundExceptionFilter :  ExceptionFilterAttribute 
{
    public override void OnException(ExceptionContext context)
    {
        if (context.Exception is NotFoundException)
        {
            context.Result = new NotFoundResult();
        }
    }
}