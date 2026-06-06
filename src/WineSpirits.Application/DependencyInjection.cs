using Microsoft.Extensions.DependencyInjection;

namespace WineSpirits.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        return services;
    }
}
