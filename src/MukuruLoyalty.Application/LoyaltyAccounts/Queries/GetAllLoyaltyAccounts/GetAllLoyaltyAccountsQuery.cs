using MediatR;

using MukuruLoyalty.Application.LoyaltyAccounts.DTOs;

namespace MukuruLoyalty.Application.LoyaltyAccounts.Queries.GetAllLoyaltyAccounts;

/// <summary>
/// Query to retrieve all loyalty accounts.
/// </summary>
public record GetAllLoyaltyAccountsQuery : IRequest<IReadOnlyList<LoyaltyAccountDto>>;