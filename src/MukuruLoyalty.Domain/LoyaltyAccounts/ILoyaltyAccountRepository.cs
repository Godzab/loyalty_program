namespace MukuruLoyalty.Domain.LoyaltyAccounts;

/// <summary>
/// Repository interface for loyalty accounts.
/// Consider: What operations are truly needed at the domain level?
/// </summary>
public interface ILoyaltyAccountRepository
{
    // TODO: Define repository methods
    // Think about: aggregate boundaries, consistency requirements, query needs

    Task<IReadOnlyList<LoyaltyAccount>> GetAllAsync(CancellationToken cancellationToken = default);
}