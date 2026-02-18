namespace FoodTruck.API;

public static class Api
{
    public static void MapRoutes(WebApplication app)
    {
        app.MapGet("/", () => new HelloResponse("Hello, Food Truck Challenge!"));
    }
}
