using Midnight.SOAP.SDK.Models;
using Midnight.SOAP.SDK.RequestObjects.InventoryInputs;
using Midnight.SOAP.SDK.RequestObjects.InventoryItemLocationInputs;
using Midnight.SOAP.SDK.RequestObjects.InventoryItemLotInputs;
using Midnight.SOAP.SDK.RequestObjects.InventoryTransactionInputs;
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

    /// <summary>
    /// Retrieves a list of inventory items asynchronously based on the provided request parameters.
    /// </summary>
    /// <remarks>This method sends a SOAP request to retrieve inventory data and parses the response into a
    /// list of <see cref="Items"/>. Ensure that the <paramref name="auth"/> parameter contains valid credentials and
    /// the <paramref name="request"/> parameter is properly populated with the required query details.</remarks>
    /// <param name="auth">The authentication header containing validation credentials required for the SOAP request. This parameter cannot
    /// be null.</param>
    /// <param name="request">The request body containing the parameters for the inventory list query. This parameter cannot be null.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of <see cref="Items"/> 
    /// representing the inventory data retrieved from the SOAP service.</returns>
    public async Task<List<Items>> InventoryListAsync(ValidationSoapHeader auth, InventoryListRequestBody request)
    {

        InventoryListResponse response;
        List<Items> parsedResponse;

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

            Log.Information("Parsing InventoryListAsync response into List of {@type}", typeof(Items));

            parsedResponse = XmlParser.GetInventoryData(response.InventoryListResult);

        }
        catch (Exception ex)
        {
            Log.Error("InventoryListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("InventoryListAsync Response: {@res}", response.InventoryListResult);

        return parsedResponse;
    }

    /// <summary>
    /// Sends an asynchronous SOAP request to update inventory information based on the provided input parameters.
    /// </summary>
    /// <remarks>This method converts the provided <paramref name="request"/> object into XML format and sends
    /// it as part of the SOAP request. Ensure that the <paramref name="auth"/> parameter contains valid credentials and
    /// that the <paramref name="request"/> object is properly populated.</remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the SOAP request.</param>
    /// <param name="request">The request body containing inventory update parameters, including the item ID and other relevant details.</param>
    /// <returns>An <see cref="InventoryUpdateResponse"/> object containing the result of the inventory update operation.</returns>
    public async Task<InventoryUpdateResponse> InventoryUpdateAsync(ValidationSoapHeader auth, InventoryUpdateRequestBody request)
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

        return response;
    }

    /// <summary>
    /// Retrieves a list of inventory item locations based on the provided request parameters.
    /// </summary>
    /// <remarks>This method sends a SOAP request to retrieve inventory item location data and parses the
    /// response. Ensure that the <paramref name="auth"/> parameter contains valid credentials and the <paramref
    /// name="request"/> parameter is properly populated with the required query details.</remarks>
    /// <param name="auth">The authentication header containing validation credentials required for the SOAP request. This parameter cannot
    /// be null.</param>
    /// <param name="request">The request body containing the parameters for the inventory item location query. This parameter cannot be null.</param>
    /// <returns>A <see cref="List{T}"/> of <see cref="Locations"/> objects representing the inventory item locations. The list
    /// will be empty if no locations are found.</returns>
    public async Task<List<Locations>> InventoryItemLocationListAsync(ValidationSoapHeader auth, InventoryItemLocationListRequestBody request)
    {

        InventoryItemLocationListResponse response;
        List<Locations> parsedResponse;

        Log.Information("Converting {@type} to Xml", typeof(InventoryItemLocationListRequestBody));
        Log.Debug("{@type}: {@req}", typeof(InventoryItemLocationListRequestBody), FileOutput.CreateXmlFromClass(request));


        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending InventoryItemLocationListAsync SOAP request");

        try
        {
            response = await _soap.InventoryItemLocationListAsync(new InventoryItemLocationListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

            Log.Information("Parsing InventoryItemLocationListAsync response into List of {@type}", typeof(Locations));

            parsedResponse = XmlParser.GetInventoryLocationData(response.InventoryItemLocationListResult);

        }
        catch (Exception ex)
        {
            Log.Error("InventoryItemLocationListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("InventoryItemLocationListAsync Response: {@res}", response.InventoryItemLocationListResult);

        return parsedResponse;
    }

    /// <summary>
    /// Sends a SOAP request to update inventory transaction details based on the provided input parameters.
    /// </summary>
    /// <remarks>This method converts the provided <paramref name="request"/> object into XML format and sends
    /// it as part of the SOAP request. Ensure that the <paramref name="auth"/> parameter contains valid credentials and
    /// that the <paramref name="request"/> object is properly populated with all required fields.</remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the request.</param>
    /// <param name="request">The request body containing inventory transaction details, including item information, lot ID, order ID, and
    /// quantity.</param>
    /// <returns>An <see cref="InventoryTransactionUpdateResponse"/> object containing the result of the inventory transaction
    /// update. The response includes details about the success or failure of the operation.</returns>
    public async Task<InventoryTransactionUpdateResponse> InventoryTransactionUpdateAsync(ValidationSoapHeader auth, InventoryTransactionUpdateRequestBody request)
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

        return response;
    }

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
