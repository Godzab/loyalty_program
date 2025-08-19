using MukuruLoyalty.Domain.LoyaltyAccounts;
using System.Collections.Concurrent;

namespace MukuruLoyalty.Infrastructure.Persistence.InMemory;

/// <summary>
/// In-memory implementation of the loyalty account repository.
/// Note: This is provided for testing purposes. Focus on the domain and application logic.
/// </summary>
public class InMemoryLoyaltyAccountRepository : ILoyaltyAccountRepository
{
    private readonly ConcurrentDictionary<Guid, LoyaltyAccount> _storage = new();

    // TODO: Implement based on your repository interface design
    // Consider: Thread safety, idempotency, query requirements
}