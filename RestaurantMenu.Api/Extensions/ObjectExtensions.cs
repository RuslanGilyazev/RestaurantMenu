namespace RestaurantMenu.Api.Extensions;

public static class ObjectExtensions
{
    public static void WriteToConsole(this object obj, string description)
    {
        Console.WriteLine(description);
        Console.WriteLine(obj);
    }

    public static void WriteToConsole(this object obj) => Console.WriteLine(obj);
}