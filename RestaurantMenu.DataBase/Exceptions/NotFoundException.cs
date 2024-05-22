namespace RestaurantMenu.Database.Exceptions;

public class NotFoundException : Exception
{
    private const string NotFoundErrorTemplate = "{0} with {1} is not found";
    
    public NotFoundException(string nameOfEntity, string id) : base(string.Format(NotFoundErrorTemplate, nameOfEntity, id))
    {
    }
}