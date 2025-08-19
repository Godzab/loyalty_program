# Application Layer

This layer contains your application's use cases and orchestration logic.

## Design Considerations

- How will you handle the TransactionCompleted events from external systems?
- What pattern will you use for organizing use cases? (CQRS, Services, etc.)
- How will you ensure proper validation and error handling?
- What DTOs/contracts are needed for external communication?

## Provided Dependencies

- MediatR is available for CQRS if you choose to use it
- FluentValidation is available for input validation

## Requirements to Implement

1. Handle loyalty account creation
2. Process point accrual when transactions complete
3. Provide balance and history queries
4. Ensure idempotent operations