using MediatR;

using MukuruLoyalty.Application.LoyaltyAccounts.DTOs;
using MukuruLoyalty.Domain.LoyaltyAccounts;

namespace MukuruLoyalty.Application.LoyaltyAccounts.Queries.GetAllLoyaltyAccounts;

/// <summary>
/// Handler for retrieving all loyalty accounts.
/// </summary>
public class GetAllLoyaltyAccountsQueryHandler : IRequestHandler<GetAllLoyaltyAccountsQuery, IReadOnlyList<LoyaltyAccountDto>>
{
    private readonly ILoyaltyAccountRepository _loyaltyAccountRepository;

    public GetAllLoyaltyAccountsQueryHandler(ILoyaltyAccountRepository loyaltyAccountRepository)
    {
        _loyaltyAccountRepository = loyaltyAccountRepository ?? throw new ArgumentNullException(nameof(loyaltyAccountRepository));
    }

    public async Task<IReadOnlyList<LoyaltyAccountDto>> Handle(GetAllLoyaltyAccountsQuery request, CancellationToken cancellationToken)
    {
        var loyaltyAccounts = await _loyaltyAccountRepository.GetAllAsync(cancellationToken);

        throw new NotImplementedException("This method is not implemented yet. Please implement the logic to convert LoyaltyAccount to LoyaltyAccountDto.");
    }
}