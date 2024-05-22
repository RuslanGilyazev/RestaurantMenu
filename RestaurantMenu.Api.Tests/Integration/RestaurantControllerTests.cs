using System.Net;
using System.Net.Http.Json;
using AutoFixture;
using Microsoft.AspNetCore.Mvc.Testing;
using RestaurantMenu.Api.Contracts.Requests;
using RestaurantMenu.Api.Extensions;
using Shouldly;

namespace RestaurantMenu.Api.Tests.Integration;

[TestClass]
public class RestaurantControllerTests
{
    private Fixture _fixture = null!;
    private WebApplicationFactory<Program> _application = null!;

    private const string ControllerName = "restaurant";

    [TestInitialize]
    public Task Setup()
    {
        _fixture = new Fixture();
        _application = new WebApplicationFactory<Program>();
        return Task.CompletedTask;
    }
    
    [TestMethod]
    public async Task CreateRestaurant_SuccessfulCreation()
    {
        var client = _application.CreateClient();

        var createRestaurantDTO = _fixture.Create<CreateRestaurantDTO>();
        createRestaurantDTO.WriteToConsole("Source:");
        
        var creationResult = await client.PostAsJsonAsync($"{ControllerName}", createRestaurantDTO);
        creationResult.ShouldNotBeNull();
        creationResult.StatusCode.ShouldBe(HttpStatusCode.OK);
        
        var newRestaurantId = await creationResult.Content.ReadFromJsonAsync<Guid>();
        newRestaurantId.ShouldBeOfType<Guid>();
        newRestaurantId.WriteToConsole("New Id:");
        
        var getResponse = await client.GetStringAsync($"{ControllerName}/{newRestaurantId}");
        getResponse.ShouldNotBeNullOrEmpty();
        getResponse.WriteToConsole("Response:");
    }
}