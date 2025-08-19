# Mukuru Loyalty Program - Technical Assessment

## Scenario
Mukuru is launching a customer loyalty program to improve engagement. Customers will earn points for financial transactions, and the marketing team will use this information for targeted campaigns.

## Your Task
Build the core backend logic for a loyalty points system that:

1. **Establishes Loyalty Accounts** - Create and manage customer loyalty accounts
2. **Accrues Points** - Award points when qualifying transactions occur (1 point per R100 spent)
3. **Provides Balance Information** - Retrieve current points balance
4. **Tracks History** - Maintain a ledger of all point-accruing events

## Technical Context

### Provided Structure
```
MukuruLoyalty/
├── src/
│   ├── MukuruLoyalty.Domain/       # Core business logic
│   ├── MukuruLoyalty.Application/  # Use cases and orchestration
│   └── MukuruLoyalty.Infrastructure/ # Technical implementations
└── tests/                           # Test projects
```

### Available Dependencies
- **.NET 8.0**
- **MediatR** - You may use this for CQRS if you choose
- **FluentValidation** - Available for validation
- **Testing**: xUnit, FluentAssertions, Moq

### External Events
Your system will receive `TransactionCompleted` events from other parts of the system containing:
- Transaction ID
- Customer ID  
- Amount
- Currency
- Date
- Description

## Requirements & Constraints

### Business Rules
- Each customer can have only one loyalty account
- Points calculation: 1 point for every R100 spent
- Points cannot be negative
- Same transaction should not award points twice

### Technical Requirements
- Implement as a .NET class library (no UI needed)
- Use in-memory persistence (provided)
- Follow Clean Architecture principles
- Apply Domain-Driven Design where appropriate
- Write testable code with appropriate tests

## Getting Started

1. **Analyze the requirements** and ask clarifying questions
2. **Design your solution** - consider the architecture and patterns you'll use
3. **Implement the core functionality** 
4. **Write tests** to demonstrate your solution works
5. **Be prepared to discuss** your design decisions and trade-offs

### Build & Test
```bash
dotnet build
dotnet test
```

## Assessment Focus

We're evaluating:
- **Problem-solving approach** - How you break down and tackle the problem
- **Design skills** - Your architectural decisions and pattern usage
- **Code quality** - Cleanliness, maintainability, and adherence to principles
- **Domain modeling** - How you model the business domain
- **Testing approach** - Test coverage and strategy
- **Communication** - How you explain your solution

## Important Notes

- You have **60 minutes** for implementation
- Focus on demonstrating your best practices
- It's better to have a well-designed partial solution than a complete but poorly designed one
- You may use online resources and AI tools - be ready to explain your choices
- The infrastructure layer is partially provided - focus on domain and application logic