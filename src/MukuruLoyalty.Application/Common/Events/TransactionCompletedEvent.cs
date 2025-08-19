namespace MukuruLoyalty.Application.Common.Events;

/// <summary>
/// Event received from the transaction processing system when a transaction completes.
/// This is an external event that your system needs to handle.
/// </summary>
public class TransactionCompletedEvent
{
    public string TransactionId { get; set; } = string.Empty;
    public string CustomerId { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public string Currency { get; set; } = "ZAR";
    public DateTime TransactionDate { get; set; }
    public string Description { get; set; } = string.Empty;
}