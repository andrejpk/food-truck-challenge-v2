using FoodTruck.API;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

Api.MapRoutes(app);
app.MapControllers();

app.Run();

public partial class Program { }
