using System.Net;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;

namespace WineSpirits.Api.Tests;

public sealed class HealthEndpointTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public HealthEndpointTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task Health_Returns_Healthy_Service_Response()
    {
        using var client = _factory.CreateClient();

        var response = await client.GetAsync("/health");
        var payload = await response.Content.ReadFromJsonAsync<HealthResponse>();

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.NotNull(payload);
        Assert.Equal("WineSpirits.Api", payload.Service);
        Assert.Equal("Healthy", payload.Status);
        Assert.NotEqual(default, payload.CheckedAt);
    }

    private sealed record HealthResponse(
        string Service,
        string Status,
        DateTimeOffset CheckedAt);
}
