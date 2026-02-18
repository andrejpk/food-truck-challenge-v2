using System.Net;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace FoodTruck.API.Tests;

public class CustomWebApplicationFactory : WebApplicationFactory<Program>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder) =>
        builder.UseContentRoot(AppContext.BaseDirectory);
}

public class HelloTests(CustomWebApplicationFactory factory) : IClassFixture<CustomWebApplicationFactory>
{
    private readonly HttpClient _client = factory.CreateClient();

    [Fact]
    public async Task GetRoot_ReturnsHelloMessage()
    {
        var response = await _client.GetAsync("/");
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        var result = await response.Content.ReadFromJsonAsync<HelloResponse>();
        Assert.Equal("Hello, Food Truck Challenge!", result?.Message);
    }

    [Fact]
    public async Task GetHelloController_ReturnsHelloMessage()
    {
        var response = await _client.GetAsync("/Hello");
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        var result = await response.Content.ReadFromJsonAsync<HelloResponse>();
        Assert.Equal("Hello, Food Truck Challenge!", result?.Message);
    }
}
