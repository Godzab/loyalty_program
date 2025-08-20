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

    public InMemoryLoyaltyAccountRepository()
    {
        InitializeStorage();
    }

    private void InitializeStorage()
    {
        // Pre-populate with 10 sample loyalty accounts
        for (int i = 1; i <= 10; i++)
        {
            var id = Guid.NewGuid();
            var account = new LoyaltyAccount(id);
            _storage[id] = account;
        }
    }

    public Task<IReadOnlyList<LoyaltyAccount>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        // Step 1: Get all account IDs (this is the "1" query)
        var accountIds = _storage.Keys.ToList();

        // Step 2: For each ID, perform a separate lookup (these are the "N" queries)
        var accounts = new List<LoyaltyAccount>();
        foreach (var id in accountIds)
        {
            // This simulates a separate database call for each account
            if (_storage.TryGetValue(id, out var account))
            {
                accounts.Add(account);
            }
        }

        return Task.FromResult<IReadOnlyList<LoyaltyAccount>>(accounts);
    }
}