using Microsoft.AspNetCore.Mvc;

namespace FoodTruck.API.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public HelloResponse Get()
    {
        return new HelloResponse("Hello, Food Truck Challenge!");
    }
}
