using Midnight.SOAP.SDK.RequestObjects.OrderVersionInventoryInputs;
using Midnight.SOAP.SDK.ResponseObjects.OrderVersionInventoryOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

/// <summary>
/// Provides methods for interacting with order version inventory records via SOAP requests.
/// IMPORTANT: Must inject output of Utilities.SoapClient.Configure().
/// </summary>
/// <remarks>This service facilitates operations such as retrieving, updating, and inserting order version
/// inventory records. Each method communicates with a SOAP service, handling serialization of request objects to XML
/// and deserialization of responses into strongly-typed result objects. Exceptions are thrown for failed operations,
/// with detailed error information included.</remarks>
/// <param name="_soap"></param>
public class OrderVersionInventoryService(Service1Soap _soap)
{
    
    /// <summary>
    /// Retrieves a list of order version inventory records asynchronously via a SOAP request.
    /// </summary>
    /// <remarks>
    /// This method serializes the provided request body to XML and sends it to the SOAP service using the authentication header.
    /// The response is deserialized into an <see cref="OrderVersionInventoryListResult"/> object. If the operation fails, an exception is thrown with details from the response.
    /// </remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the SOAP request.</param>
    /// <param name="request">The request body specifying the parameters for the inventory list query. Cannot be <c>null</c>.</param>
    /// <returns>
    /// An <see cref="OrderVersionInventoryListResult"/> containing inventory details and status information for the requested order version.
    /// </returns>
    /// <exception cref="Exception">
    /// Thrown if the SOAP service returns a non-zero return code, indicating a failure. The exception message includes the return code and error details.
    /// </exception>
    public async Task<OrderVersionInventoryListResult> OrderVersionInventoryListAsync(ValidationSoapHeader auth, OrderVersionInventoryListRequestBody request)
    {

        OrderVersionInventoryListResponse response;

        Log.Information("Converting {@type} to Xml", typeof(OrderVersionInventoryListRequestBody));
        Log.Debug("{@type}: {@req}", typeof(OrderVersionInventoryListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending OrderVersionInventoryListAsync SOAP request");

        try
        {
            response = await _soap.OrderVersionInventoryListAsync(new OrderVersionInventoryListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

        }
        catch (Exception ex)
        {
            Log.Error("OrderVersionInventoryListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderVersionInvetoryListAsync Response: {@res}", response.OrderVersionInventoryListResult);

        var result = XmlParsing.DeserializeXmlToObject<OrderVersionInventoryListResult>(response.OrderVersionInventoryListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("OrderVersionInventoryListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"OrderVersionInventoryListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to update the inventory for a specific order version and returns the result of the
    /// operation.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes. If the operation
    /// fails, an exception is thrown with details about the failure, including the return code and error
    /// messages.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the input parameters for the inventory update operation.</param>
    /// <returns>An <see cref="OrderVersionInventoryUpdateResult"/> object containing the result of the inventory update
    /// operation, including the return code and any error messages if the operation fails.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the operation returns a non-zero return code, indicating an error.</exception>
    public async Task<OrderVersionInventoryUpdateResult> OrderVersionInventoryUpdateAsync(ValidationSoapHeader auth, OrderVersionInventoryUpdateRequestBody request)
    {

        OrderVersionInventoryUpdateResponse response;

        Log.Information("Converting {@type} to Xml", typeof(OrderVersionInventoryUpdateRequestBody));
        Log.Debug("{@type}: {@req}", typeof(OrderVersionInventoryUpdateRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending OrderVersionInventoryUpdateAsync SOAP request for InventoryID: {@item}", request.InputParameter.OrderInventoryID);

        try
        {
            response = await _soap.OrderVersionInventoryUpdateAsync(new OrderVersionInventoryUpdateRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("OrderVersionInventoryUpdateAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderVersionInventoryUpdateAsync Response: {@res}", response.OrderVersionInventoryUpdateResult);

        var result = XmlParsing.DeserializeXmlToObject<OrderVersionInventoryUpdateResult>(response.OrderVersionInventoryUpdateResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("OrderVersionInventoryUpdateAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"OrderVersionInventoryUpdateAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to insert inventory data for a specific order version and returns the result of the
    /// operation.
    /// </summary>
    /// <remarks>This method converts the provided request object to XML format and sends it as part of a SOAP
    /// request.  If the operation fails, an exception is thrown with details about the failure.</remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the request.</param>
    /// <param name="request">The request body containing the inventory data to be inserted, including order version details.</param>
    /// <returns>An <see cref="OrderVersionInventoryInsertResult"/> object containing the result of the operation, including the
    /// return code and any errors.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the operation returns a non-zero return code, indicating an error.</exception>
    public async Task<OrderVersionInventoryInsertResult> OrderVersionInventoryInsertAsync(ValidationSoapHeader auth, OrderVersionInventoryInsertRequestBody request)
    {
        OrderVersionInventoryInsertResponse response;

        Log.Information("Converting {@type} to Xml", typeof(OrderVersionInventoryInsertRequestBody));
        Log.Debug("{@type}: {@req}", typeof(OrderVersionInventoryInsertRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending OrderVersionInventoryInsertAsync SOAP request");

        try
        {
            response = await _soap.OrderVersionInventoryInsertAsync(new OrderVersionInventoryInsertRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("OrderVersionInventoryInsertAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderVersionInventoryInsertAsync Response: {@res}", response.OrderVersionInventoryInsertResult);

        var result = XmlParsing.DeserializeXmlToObject<OrderVersionInventoryInsertResult>(response.OrderVersionInventoryInsertResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("OrderVersionInventoryInsertAsync failed with ReturnCode: {@code}, Errors: {@errors}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"OrderVersionInventoryInsertAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }
}
