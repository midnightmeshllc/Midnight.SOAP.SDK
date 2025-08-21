# Midnight.SOAP.SDK

## Overview

**Midnight.SOAP.SDK** is a .NET 8 library that provides a modern, strongly-typed interface for integrating with PrintReach's Midnight SOAP API. It simplifies authentication, request construction, and XML response parsing for all SOAP operations currently exposed. The SDK is designed for developers who need to interact with the Midnight API in a robust and maintainable way. 

*The SOAP API documentation from PrintReach can be found [here](https://drive.google.com/file/d/1YEIF8Jxqo1EHYi1ZAvqC1lAYNnkFGDT0/view) in PDF format.*

---

## Features

- **Full Midnight SOAP API Wrapper**: Retrieve, update, and insert any data supported by the Midnight SOAP API, including orders, inventory, customers, and more.
- **Strongly-Typed Requests**: Uses strongly-typed request objects to ensure type safety and reduce runtime errors caused by string concatenated XML inputs.
- **Strongly-Typed Responses**: Converts Midnight API XML response strings into strongly-typed C# models.
- **User-Defined Fields Support**: The SDK provides a flexible UserDefinedFields class, where each UDF property (UDF1 to UDF30) is implemented using the `UDFValue` class. This allows each field to accept and serialize values as string, decimal, integer, date, or time, ensuring correct XML formatting for both requests and responses. The UDFValue class handles type conversion and serializes the value as the text content of the corresponding <UDF*> XML tag.
- **Logging**: Integrated logging for diagnostics and debugging using Serilog.

---

## Setup Instructions

### Prerequisites

- PrintReach Midnight MIS API access (developer token)
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- Visual Studio 2022 or later (recommended)
- Serilog v4.3.0 or later for logging

### Installation
```
Install-Package Midnight.SOAP.SDK
```
---

## Usage

### 1. Service Initializations
```csharp
using Midnight.SOAP.SDK;

var authService = new AuthenticationService();
var customerService = new CustomerService();
var customerContactService = new CustomerContactService();
var djbService = new DJBService();
var estimateService = new EstimateService();
var inventoryItemService = new InventoryItemService();
var inventoryService = new InventoryService();
var jobCostingService = new JobCostingService();
var orderService = new OrderService();
var orderVersionService = new OrderVersionService();
var orderVersionDetailService = new OrderVersionDetailService();
var orderVersionDropService = new OrderVersionDropService();
var orderVersionInventoryService = new OrderVersionInventoryService();
var orderVersionPostageService = new OrderVersionPostageService();

// ProofingService is the wrapper for "Request" api calls, making it clearer what the service is used for.
var proofingService = new ProofingService();

var purchaseOrderService = new PurchaseOrderService();
var settingsService = new SettingService();
var venderService = new VendorService();
var vendorContactService = new VendorContactService();

```

### 2. Authentication
**IMPORTANT: Never expose your developer token in client-side code or public repositories. Use a secrets manager or json configuration files that are in the .gitignore file**
- So long as your team has purchased API access from PrintReach for Midnight MIS, you can find your dev token in Admin Settings > Global Settings > Site Token.
```csharp
var validationHeader = await authService.AuthenticateAsync("your-dev-token");
```

### 3. User Defined Fields Example
User Defined Fields (UDFs) are supported in all services that accept or return UDFs. The `UserDefinedFields` class contains properties for UDF1 to UDF30, each of which is of type `UDFValue`. The `UDFValue` class can hold values of different types (string, decimal, integer, date, time) and ensures proper serialization/deserialization to XML. 

***NOTE: In scenarios where only a portion of available UDFs are available to send in a request or receive in a response, those classes inherit either `UserDefinedFields_Top10` or `UserDefinedFields_Top5` classes.***

```csharp
using Midnight.SOAP.SDK.CommonObjects;

var customerInsertUDFs = new UserDefinedFields
{
    UDF7 = new UDFValue { Value = (decimal)0.999 }, // decimal type in Midnight UDF setup
    UDF11 = new UDFValue { Value = 12345 }, // csharp auto-recognizes this as an integer
    UDF1 = new UDFValue { Value = "testStringUDFInput" }, // csharp auto-recognizes this as a string 
    UDF5 = new UDFValue { Value = (decimal)999.00 } // currency-type field within Midnight UDF setup
};

var customerInsertResult = await customerService.CustomerInsertAsync(auth, new CustomerInsertRequestBody
{
    InputParameter = new CustomerInsertInputParameter
    {
        CustomerCode = "TESTCUSTOMER1234",
        CustomerName = "TEST CUSTOMER 123",
        UDF7 = customerInsertUDFs.UDF7,
        UDF11 = customerInsertUDFs.UDF11,
        UDF1 = customerInsertUDFs.UDF1,
        UDF5 = customerInsertUDFs.UDF5
    }
});
```

### 4. Retrieve Order List
```csharp
using Midnight.SOAP.SDK.RequestObjects.OrderInputs;

var orderListInput = new OrderListRequestBody { /* set properties */ };
var orderListResult = await orderService.OrderListAsync(validationHeader, orderListInput);
```

### 5. Update Order Version Inventory
```csharp
using Midnight.SOAP.SDK.RequestObjects.OrderVersionInventoryInputs;

var versionInventoryUpdateInput = new OrderVersionInventoryUpdateRequestBody { /* set properties */ };
var versionInventoryUpdateResult = await inventoryService.OrderVersionInventoryUpdateAsync(validationHeader, versionInventoryUpdateInput);
```
---

## Errors and Exceptions
The SDK uses a combination of exceptions and error messages within the result objects to indicate errors. The inheritance of `CommonResult` for all output objects ensures the ReturnCode and ReturnErrors object are consistently available across all service responses.

### Error Example
```csharp
...
    ReturnCode = -1, // Non-zero indicates an error
    ReturnErrors = 
    {
        Error = "Invalid authentication token." ,
        Error = "CustomerCode is required." 
    }
...
```

### Exceptions
The SDK will throw exceptions immediately after a non-zero ReturnCode is detected in the response. The ReturnCode and ReturnErrors properties are logged when this occurs. 

#### Exceptions Possible
- `ArgumentNullException`: Thrown when a required parameter is null.
- `InvalidOperationException`: Thrown when an operation is attempted that is not valid for the current state of the object.
- `AuthenticationException`: Thrown when authentication fails.
- `Exception`: Thrown for general errors that do not fit other categories.

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
- Add unit tests for all services.
- Implement custom services for common combinations of other services.
- Implement Aggregation services for reporting, analytics, and invoicing integrations.
- Implement additional features as requested by the community.
- Enhance documentation with more examples and use cases.

**Midnight.SOAP.SDK** makes integrating with the Midnight SOAP API fast, reliable, and developer-friendly.