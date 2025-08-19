using Microsoft.Extensions.DependencyInjection;
using MukuruLoyalty.Domain.LoyaltyAccounts;
using MukuruLoyalty.Infrastructure.Persistence.InMemory;

namespace MukuruLoyalty.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        // Repository registration
        services.AddSingleton<ILoyaltyAccountRepository, InMemoryLoyaltyAccountRepository>();

        // TODO: Add other infrastructure services as needed

        return services;
    }
}