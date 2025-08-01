using DocumentFormat.OpenXml.Wordprocessing;
using Midnight.SOAP.SDK.Models;
using Midnight.SOAP.SDK.RequestObjects.OrderVersionInventoryInputs;
using Midnight.SOAP.SDK.ResponseObjects.OrderVersionInventoryOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK;

/// <summary>
/// Provides methods for interacting with the Order Version Inventory SOAP service,  including retrieving and updating
/// inventory data.
/// </summary>
/// <remarks>This service acts as a client for the SOAP-based Order Version Inventory API,  enabling operations
/// such as fetching inventory lists and updating inventory records.  It requires authentication via a <see
/// cref="ValidationSoapHeader"/> and uses XML-based  request and response payloads.</remarks>
public class OrderVersionInventoryService
{
    private readonly Service1SoapClient.EndpointConfiguration _soapConfig;
    private readonly Service1Soap _soap;
    public OrderVersionInventoryService()
    {
        _soapConfig = new Service1SoapClient.EndpointConfiguration();
        _soap = new Service1SoapClient(_soapConfig);
    }

    /// <summary>
    /// Sends a SOAP request to retrieve and parse a list of inventory items based on the specified order version.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes. Ensure that the
    /// <paramref name="auth"/>  parameter contains valid credentials and the <paramref name="request"/> parameter is
    /// properly populated with the  required data.</remarks>
    /// <param name="auth">The authentication header containing validation credentials for the SOAP request. Cannot be null.</param>
    /// <param name="request">The request body containing the parameters required to query the inventory list. Cannot be null.</param>
    /// <returns>A list of <see cref="Inventorys"/> objects representing the inventory data for the specified order version.
    /// Returns an empty list if no inventory data is found.</returns>
    public async Task<List<Inventorys>> OrderVersionInventoryListAsync(ValidationSoapHeader auth, OrderVersionInventoryListRequestBody request)
    {

        OrderVersionInventoryListResponse response;
        List<Inventorys> parsedResponse;

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

            Log.Information("Parsing OrderVersionInvetoryListAsync response into List of {@type}", typeof(Inventorys));

            parsedResponse = XmlParser.GetOrderVersionInventoryData(response.OrderVersionInventoryListResult);

        }
        catch (Exception ex)
        {
            Log.Error("OrderVersionInventoryListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderVersionInvetoryListAsync Response: {@res}", response.OrderVersionInventoryListResult);

        return parsedResponse;
    }

    /// <summary>
    /// Sends a SOAP request to update the inventory for a specific order version.
    /// </summary>
    /// <remarks>This method converts the provided request body into XML format and sends it as part of a SOAP
    /// request. Ensure that the <paramref name="auth"/> parameter contains valid credentials and that the  <paramref
    /// name="request"/> parameter includes all required input parameters.</remarks>
    /// <param name="auth">The authentication header containing validation credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the input parameters for the inventory update operation.</param>
    /// <returns>A <see cref="OrderVersionInventoryUpdateResponse"/> object containing the result of the inventory update
    /// operation.</returns>
    public async Task<OrderVersionInventoryUpdateResponse> OrderVersionInventoryUpdateAsync(ValidationSoapHeader auth, OrderVersionInventoryUpdateRequestBody request)
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

        return response;
    }

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
