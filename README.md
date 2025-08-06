# Midnight.SOAP.SDK

## Overview

**Midnight.SOAP.SDK** is a .NET 8 library that provides a modern, strongly-typed interface for integrating with PrintReach's Midnight SOAP API. It simplifies authentication, request construction, and XML response parsing for all SOAP operations currently exposed. The SDK is designed for developers who need to interact with the Midnight API in a robust and maintainable way.

---

## Features

- **Authentication**: Securely authenticate with the Midnight SOAP API using developer tokens.
- **Order & Inventory Management**: Retrieve, update, and insert order and inventory data.
- **Strongly-Typed Requests**: Uses strongly-typed request objects to ensure type safety and reduce runtime errors caused by string concatenated XML inputs.
- **Strongly-Typed Responses**: Converts Midnight API XML response strings into strongly-typed C# models.
- **UserDefinedFields**: Full support for UDF fields, all values will be in string format. Convert to appropriate type within your program.
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
var request = new OrderListRequestBody { /* set properties */ };
var orderList = await orderService.OrderListAsync(validationHeader, request);
```

### 3. Update Order Version Inventory
```csharp
using Midnight.SOAP.SDK;
using Midnight.SOAP.SDK.RequestObjects.OrderVersionInventoryInputs;

var updateRequest = new OrderVersionInventoryUpdateRequestBody { /* set properties */ };
var updateResponse = await inventoryService.OrderVersionInventoryUpdateAsync(validationHeader, updateRequest);
```
---

## API Documentation

### AuthenticationService

- **AuthenticateAsync(string devToken)**
  - *IMPORTANT: Never expose your developer token in client-side code or public repositories.*
  - Authenticates the client using the provided developer token and returns a `ValidationSoapHeader` for use in subsequent API calls.

<!-- ### OrderVersionInventoryService

- **OrderVersionInventoryListAsync(ValidationSoapHeader auth, OrderVersionInventoryListRequestBody request)**
  - Retrieves a list of inventory items for a specific order version.

- **OrderVersionInventoryUpdateAsync(ValidationSoapHeader auth, OrderVersionInventoryUpdateRequestBody request)**
  - Updates inventory for a specific order version.

- **OrderVersionInventoryInsertAsync(ValidationSoapHeader auth, OrderVersionInventoryInsertRequestBody request)**
  - Inserts new inventory records for an order version. -->

<!-- ### XmlParser

- **GetCustomerData(string xmlinput)**
  - Parses customer XML and returns a list of `CustomerModel`.

- **GetCustomerContactData(string xmlinput)**
  - Parses customer contact XML and returns a list of `CustomerContact`.

- **GetOrderData(string xmlinput)**
  - Parses order XML and returns a list of `OrderModel`.

- **GetOrderVersionData(string xmlinput)**
  - Parses order version XML and returns a list of `Versions`.

- **GetOrderVersionDropData(string xmlinput)**
  - Parses order version drop XML and returns a list of `Drops`.

- **GetOrderVersionDetailData(string xmlinput)**
  - Parses order version detail XML and returns a list of `Details`.

- **GetOrderVersionInventoryData(string xmlinput)**
  - Parses order version inventory XML and returns a list of `Inventorys`.

- **GetInventoryData(string xmlinput)**
  - Parses inventory XML and returns a list of `Items`.

- **GetInventoryLotData(string xmlinput)**
  - Parses inventory lot XML and returns a list of `Lots`.

- **GetInventoryLocationData(string xmlinput)**
  - Parses inventory location XML and returns a list of `Locations`. -->

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