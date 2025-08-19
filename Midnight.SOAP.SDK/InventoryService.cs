using Midnight.SOAP.SDK.RequestObjects.InventoryInputs;
using Midnight.SOAP.SDK.RequestObjects.InventoryItemInputs;
using Midnight.SOAP.SDK.ResponseObjects.InventoryOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

/// <summary>
/// Provides methods for interacting with inventory data through SOAP-based web services.
/// </summary>
/// <remarks>The <see cref="InventoryService"/> class facilitates operations such as retrieving inventory lists, 
/// updating inventory details, and querying inventory item locations, lots, and transactions.  Each method sends a SOAP
/// request to the underlying service and processes the response accordingly. Ensure that valid authentication
/// credentials are provided for all operations.</remarks>
public class InventoryService
{
    private readonly Service1SoapClient.EndpointConfiguration _soapConfig;
    private readonly Service1Soap _soap;
    public InventoryService()
    {
        _soapConfig = new Service1SoapClient.EndpointConfiguration();
        _soap = new Service1SoapClient(_soapConfig);
    }

    
    public async Task<InventoryListResult> InventoryListAsync(ValidationSoapHeader auth, InventoryListRequestBody request)
    {

        InventoryListResponse response;

        Log.Information("Converting {@type} to Xml", typeof(InventoryListRequestBody));
        Log.Debug("{@type}: {@req}", typeof(InventoryListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending InventoryListAsync SOAP request");

        try
        {
            response = await _soap.InventoryListAsync(new InventoryListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("InventoryListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("InventoryListAsync Response: {@res}", response.InventoryListResult);

        var result = XmlParsing.DeserializeXmlToObject<InventoryListResult>(response.InventoryListResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("InventoryListAsync returned an error: {@error}", result.ReturnErrors);
            throw new Exception($"InventoryListAsync failed with error code {result.ReturnCode}: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends an asynchronous SOAP request to update inventory information and returns the result of the operation.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes. If the operation
    /// fails,  an exception is thrown with the relevant error information. Ensure that the <paramref name="auth"/> 
    /// parameter contains valid credentials and that the <paramref name="request"/> parameter is properly
    /// populated.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing inventory update details, including the item ID and other parameters.</param>
    /// <returns>An <see cref="InventoryUpdateResult"/> object containing the result of the inventory update operation, 
    /// including a return code and any error messages if applicable.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the response indicates an error, with details about the error code and
    /// message.</exception>
    public async Task<InventoryUpdateResult> InventoryUpdateAsync(ValidationSoapHeader auth, InventoryUpdateRequestBody request)
    {

        InventoryUpdateResponse response;

        Log.Information("Converting {@type} to Xml", typeof(InventoryUpdateRequestBody));
        Log.Debug("{@type}: {@req}", typeof(InventoryUpdateRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending InventoryUpdateAsync SOAP request for ItemID: {@i}", request.InputParameter.ItemID);

        try
        {
            response = await _soap.InventoryUpdateAsync(new InventoryUpdateRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("InventoryUpdateAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("InventoryUpdateAsync Response: {@res}", response.InventoryUpdateResult);

        var result = XmlParsing.DeserializeXmlToObject<InventoryUpdateResult>(response.InventoryUpdateResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("InventoryUpdateAsync returned an error: {@error}", result.ReturnErrors);
            throw new Exception($"InventoryUpdateAsync failed with error code {result.ReturnCode}: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Updates inventory transaction details asynchronously using the provided SOAP request.
    /// </summary>
    /// <remarks>This method sends a SOAP request to update inventory transaction details and processes the
    /// response.  If the operation fails, an exception is thrown with details about the error.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing inventory transaction details, including item, lot, order, and quantity information.</param>
    /// <returns>An <see cref="InventoryTransactionUpdateResult"/> object containing the result of the inventory transaction
    /// update,  including a return code and any associated errors.</returns>
    /// <exception cref="Exception">Thrown if the SOAP service returns a non-zero return code, indicating an error in the transaction update.</exception>
    public async Task<InventoryTransactionUpdateResult> InventoryTransactionUpdateAsync(ValidationSoapHeader auth, InventoryTransactionUpdateRequestBody request)
    {

        InventoryTransactionUpdateResponse response;

        Log.Information("Converting {@type} to Xml", typeof(InventoryTransactionUpdateRequestBody));
        Log.Debug("{@type}: {@req}", typeof(InventoryTransactionUpdateRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending InventoryTransactionUpdateAsync SOAP request for ItemID: {@i} in LotID: {@l} on OrderID: {@o} with Quantity: {@q}",
            request.InputParameter.Item.ItemID,
            request.InputParameter.Item.LotID,
            request.InputParameter.Item.OrderID,
            request.InputParameter.Item.Quantity);

        try
        {
            response = await _soap.InventoryTransactionUpdateAsync(new InventoryTransactionUpdateRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("InventoryTransactionUpdateAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("InventoryTransactionUpdateAsync Response: {@res}", response.InventoryTransactionUpdateResult);

        var result = XmlParsing.DeserializeXmlToObject<InventoryTransactionUpdateResult>(response.InventoryTransactionUpdateResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("InventoryTransactionUpdateAsync returned an error: {@error}", result.ReturnErrors);
            throw new Exception($"InventoryTransactionUpdateAsync failed with error code {result.ReturnCode}: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to create a new inventory entry and retrieves the result.
    /// </summary>
    /// <remarks>This method communicates with an external SOAP service to create a new inventory entry.  If
    /// the operation fails, an exception is thrown with details about the error.</remarks>
    /// <param name="auth">The authentication header containing credentials for the SOAP request. Cannot be null.</param>
    /// <param name="request">The request body containing the inventory details to be processed. Cannot be null.</param>
    /// <returns>An <see cref="InventoryNewResult"/> object containing the result of the inventory creation operation.</returns>
    /// <exception cref="Exception">Thrown if the SOAP service returns an error, including a non-zero return code or other processing issues.</exception>
    public async Task<InventoryNewResult> InventoryNewAsync(ValidationSoapHeader auth, InventoryNewRequestBody request)
    {
        InventoryNewResponse response;

        Log.Information("Converting {@type} to Xml", typeof(InventoryNewRequestBody));
        Log.Debug("{@type}: {@req}", typeof(InventoryNewRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending InventoryNewAsync SOAP request");


        try
        {
            response = await _soap.InventoryNewAsync(new InventoryNewRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("InventoryNewAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("InventoryNewAsync Response: {@res}", response.InventoryNewResult);

        var result = XmlParsing.DeserializeXmlToObject<InventoryNewResult>(response.InventoryNewResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("InventoryNewAsync returned an error: {@error}", result.ReturnErrors);
            throw new Exception($"InventoryNewAsync failed with error code {result.ReturnCode}: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to create a new item request and retrieves the result.
    /// </summary>
    /// <remarks>This method sends a SOAP request to the external service to create a new item request.  It
    /// logs the request and response details for debugging purposes. If the operation fails,  an exception is thrown
    /// with details about the error.</remarks>
    /// <param name="auth">The authentication header containing credentials for the SOAP request. Cannot be null.</param>
    /// <param name="request">The request body containing the details of the item request. Cannot be null.</param>
    /// <returns>An <see cref="ItemRequestNewResult"/> object containing the result of the item request operation.</returns>
    /// <exception cref="Exception">Thrown if the SOAP service returns a non-zero return code, indicating an error. The exception message includes
    /// the error code and error details.</exception>
    public async Task<ItemRequestNewResult> ItemRequestNewAsync(ValidationSoapHeader auth, ItemRequestNewRequestBody request)
    {
        ItemRequestNewResponse response;

        Log.Information("Converting {@type} to Xml", typeof(ItemRequestNewRequestBody));
        Log.Debug("{@type}: {@req}", typeof(ItemRequestNewRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending ItemRequestNewAsync SOAP request");

        try
        {
            response = await _soap.ItemRequestNewAsync(new ItemRequestNewRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("ItemRequestNewAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("ItemRequestNewAsync Response: {@res}", response.ItemRequestNewResult);

        var result = XmlParsing.DeserializeXmlToObject<ItemRequestNewResult>(response.ItemRequestNewResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("ItemRequestNewAsync returned an error: {@error}", result.ReturnErrors);
            throw new Exception($"ItemRequestNewAsync failed with error code {result.ReturnCode}: {result.ReturnErrors}");
        }

        return result;
    }
}
