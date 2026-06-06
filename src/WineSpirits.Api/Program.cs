using WineSpirits.Application;
using WineSpirits.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapGet("/health", () => Results.Ok(new
{
    service = "WineSpirits.Api",
    status = "Healthy",
    checkedAt = DateTimeOffset.UtcNow
}))
.WithName("HealthCheck")
.WithOpenApi();

app.Run();

public partial class Program
{
}
