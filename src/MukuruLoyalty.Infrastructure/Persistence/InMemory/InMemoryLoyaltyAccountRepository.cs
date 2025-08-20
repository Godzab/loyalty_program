using System.Collections.Concurrent;

using MukuruLoyalty.Domain.LoyaltyAccounts;

namespace MukuruLoyalty.Infrastructure.Persistence.InMemory;

/// <summary>
/// In-memory implementation of the loyalty account repository.
/// Note: This is provided for testing purposes. Focus on the domain and application logic.
/// </summary>
public class InMemoryLoyaltyAccountRepository : ILoyaltyAccountRepository
{
    private readonly ConcurrentDictionary<Guid, LoyaltyAccount> _storage = new();

    public Task<IReadOnlyList<LoyaltyAccount>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var accounts = _storage.Values.ToList();
        return Task.FromResult<IReadOnlyList<LoyaltyAccount>>(accounts);
    }
}