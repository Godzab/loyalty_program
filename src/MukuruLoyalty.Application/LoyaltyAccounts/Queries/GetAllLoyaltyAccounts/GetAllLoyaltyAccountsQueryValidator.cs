using FluentValidation;

namespace MukuruLoyalty.Application.LoyaltyAccounts.Queries.GetAllLoyaltyAccounts;

/// <summary>
/// Validator for the GetAllLoyaltyAccountsQuery.
/// </summary>
public class GetAllLoyaltyAccountsQueryValidator : AbstractValidator<GetAllLoyaltyAccountsQuery>
{
    public GetAllLoyaltyAccountsQueryValidator()
    {
        // No validation rules needed for this simple query
        // This validator exists for consistency and future extensibility
    }
}