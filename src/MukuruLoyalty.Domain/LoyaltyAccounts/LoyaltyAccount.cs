using MukuruLoyalty.Domain.Common;

namespace MukuruLoyalty.Domain.LoyaltyAccounts;

/// <summary>
/// Represents a customer's loyalty account aggregate root.
/// Design considerations:
/// - How should the account track points history?
/// - What invariants must be protected?
/// - How to ensure idempotency for point accrual?
/// </summary>
public class LoyaltyAccount : AggregateRoot<Guid>
{
    public LoyaltyAccount(Guid id) : base(id)
    {
        throw new NotImplementedException("TODO: Design and implement the aggregate");
    }

    // TODO: Design the aggregate's public interface
    // Consider: What operations are needed? What data should be exposed?
}