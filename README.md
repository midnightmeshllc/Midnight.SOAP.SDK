# Midnight.SOAP.SDK

## Overview

**Midnight.SOAP.SDK** is a .NET 8 library that provides a modern, strongly-typed interface for integrating with PrintReach's Midnight SOAP API. It simplifies authentication, request construction, and XML response parsing for all SOAP operations currently exposed. The SDK is designed for developers who need to interact with the Midnight API in a robust and maintainable way. The documentation from PrintReach can be found [here](https://drive.google.com/file/d/1YEIF8Jxqo1EHYi1ZAvqC1lAYNnkFGDT0/view) in PDF format.

---

## Features

- **Full Midnight SOAP API Wrapper**: Retrieve, update, and insert any data supported by the Midnight SOAP API, including orders, inventory, customers, and more.
- **Strongly-Typed Requests**: Uses strongly-typed request objects to ensure type safety and reduce runtime errors caused by string concatenated XML inputs.
- **Strongly-Typed Responses**: Converts Midnight API XML response strings into strongly-typed C# models.
- **User-Defined Fields Support**: The SDK provides a flexible UserDefinedFields class, where each UDF property (UDF1 to UDF30) is implemented using the UDFValue class. This allows each field to accept and serialize values as string, decimal, integer, date, or time, ensuring correct XML formatting for both requests and responses. The UDFValue class handles type conversion and serializes the value as the text content of the corresponding <UDFx> XML tag.
- **Logging**: Integrated Serilog logging for diagnostics and debugging.

---

## Setup Instructions

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- Visual Studio 2022 or later (recommended)
- Serilog v4.3.0 or later for logging
- PrintReach Midnight MIS API access (developer token)

### Installation
```
Install-Package Midnight.SOAP.SDK
```
---

## Usage

### 1. Authentication
**IMPORTANT: Never expose your developer token in client-side code or public repositories. Use a secrets manager or json configuration files that are in the .gitignore file**
- So long as your team has purchased API access from PrintReach for Midnight MIS, you can find your dev token in Admin Settings > Global Settings > Site Token.
```csharp
using Midnight.SOAP.SDK;

var authService = new AuthenticationService();
var validationHeader = await authService.AuthenticateAsync("your-dev-token");
```


### 2. Retrieve Order List
```csharp
using Midnight.SOAP.SDK;
using Midnight.SOAP.SDK.RequestObjects.OrderInputs;

var orderService = new OrderService();
var orderListInput = new OrderListRequestBody { /* set properties */ };
var orderListResult = await orderService.OrderListAsync(validationHeader, orderListInput);
```

### 3. Update Order Version Inventory
```csharp
using Midnight.SOAP.SDK;
using Midnight.SOAP.SDK.RequestObjects.OrderVersionInventoryInputs;

var versionInventoryUpdateInput = new OrderVersionInventoryUpdateRequestBody { /* set properties */ };
var versionInventoryUpdateResult = await inventoryService.OrderVersionInventoryUpdateAsync(validationHeader, versionInventoryUpdateInput);
```
---

## Commit Message and Branch Naming Conventions

### Conventional Commit Messages
All commit messages must follow the [Conventional Commits](https://www.conventionalcommits.org/en/v1.0.0/) specification, which is compatible with automated versioning tools like Versionize and GitVersion. Example formats:

- `feat: add support for NuGet deploy and release`
- `fix: correct null reference in authentication service`
- `docs: update API usage section in README`
- `refactor(service): simplify request logic`
- `chore: update dependencies`
- `test: add unit tests for AuthenticationService`

### Branch Naming Conventions
Branches must follow the enforced naming contract:

- `feature-new-api-integration`
- `bugfix-fix-authentication-error`
- `hotfix-critical-production-issue`
- `docs-update-readme`
- `refactor-service-layer`
- `chore-update-dependencies`
- `test-add-auth-tests`
- `build-update-ci-workflow`
- `release-v1.2.3`
- `merge-main-into-feature`

> Branch names must match the pattern: `^(feature|bugfix|hotfix|docs|refactor|chore|test|experimental|build|release|merge)-[a-z0-9._-]+$`

These conventions are enforced by git hooks and the CI/CD workflow to ensure consistency and compatibility with automated versioning and changelog generation.

---

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request.

---

## License

This project is licensed under the MIT License.

---

## Support

For questions or support, please open an issue on the repository.

---

## Roadmap
The roadmap for **Midnight.SOAP.SDK** includes:
- Add unit tests for all services and request/response objects.
- Implement Aggregate services for common combinations of other services.
- Implement additional features as requested by the community.
- Enhance documentation with more examples and use cases.

**Midnight.SOAP.SDK** makes integrating with the Midnight SOAP API fast, reliable, and developer-friendly.