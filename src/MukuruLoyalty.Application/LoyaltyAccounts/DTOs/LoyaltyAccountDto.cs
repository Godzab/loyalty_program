namespace MukuruLoyalty.Application.LoyaltyAccounts.DTOs;

/// <summary>
/// Data transfer object for loyalty account information.
/// </summary>
public class LoyaltyAccountDto
{
    public Guid Id { get; set; }
    public string CustomerId { get; set; } = string.Empty;
    public int PointsBalance { get; set; }
    public string Status { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime LastUpdatedAt { get; set; }
}