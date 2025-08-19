namespace MukuruLoyalty.Domain.Common;

public interface IDomainEvent
{
    DateTime OccurredOn { get; }
}