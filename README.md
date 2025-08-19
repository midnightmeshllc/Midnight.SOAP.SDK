# Midnight.SOAP.SDK

## Overview

**Midnight.SOAP.SDK** is a .NET 8 library that provides a modern, strongly-typed interface for integrating with PrintReach's Midnight SOAP API. It simplifies authentication, request construction, and XML response parsing for all SOAP operations currently exposed. The SDK is designed for developers who need to interact with the Midnight API in a robust and maintainable way.

---

## Features

- **Authentication**: Securely authenticate with the Midnight SOAP API using developer tokens.
- **Order & Inventory Management**: Retrieve, update, and insert order and inventory data.
- **Strongly-Typed Requests**: Uses strongly-typed request objects to ensure type safety and reduce runtime errors caused by string concatenated XML inputs.
- **Strongly-Typed Responses**: Converts Midnight API XML response strings into strongly-typed C# models.
- **User-Defined Fields Support**: The SDK provides a flexible UserDefinedFields class, where each UDF property (UDF1–UDF30) is implemented using the UDFValue class. This allows each field to accept and serialize values as string, decimal, integer, date, or time, ensuring correct XML formatting for both requests and responses. The UDFValue class handles type conversion and serializes the value as the text content of the corresponding <UDFx> XML tag.
- **Logging**: Integrated Serilog logging for diagnostics and debugging.

---

## Setup Instructions

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- Visual Studio 2022 or later (recommended)

### Installation

1. **Clone the repository**
```
git clone <your-repo-url>
cd Midnight.SOAP.SDK
```
2. **Restore NuGet packages**
```
dotnet restore
```
3. **Build the solution**
```
dotnet build
```
---

## Usage

### 1. Authentication
**IMPORTANT: Never expose your developer token in client-side code or public repositories. Use a secrets manager or json configuration files that are in the .gitignore file**
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

**Midnight.SOAP.SDK** makes integrating with the Midnight SOAP API fast, reliable, and developer-friendly.