
using Midnight.SOAP.SDK.Models;
using Midnight.SOAP.SDK.RequestObjects.InventoryItemLotInputs;
using Midnight.SOAP.SDK.ResponseObjects.InventoryItemLotOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

public class InventoryItemLotService
{
    private readonly Service1SoapClient.EndpointConfiguration _soapConfig;
    private readonly Service1Soap _soap;
    public InventoryItemLotService()
    {
        _soapConfig = new Service1SoapClient.EndpointConfiguration();
        _soap = new Service1SoapClient(_soapConfig);
    }


    /// <summary>
    /// Retrieves a list of inventory item lots based on the provided request parameters.
    /// </summary>
    /// <remarks>This method sends a SOAP request to retrieve inventory item lot data and parses the response
    /// into a list of <see cref="Lots"/>. Ensure that the <paramref name="auth"/> parameter contains valid credentials
    /// and the <paramref name="request"/> parameter is properly populated with the required filtering
    /// criteria.</remarks>
    /// <param name="auth">The authentication header containing validation credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the parameters for filtering and retrieving inventory item lots.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of <see cref="Lots"/> objects
    /// representing the inventory item lots retrieved from the SOAP service.</returns>
    public async Task<List<Lots>> InventoryItemLotListAsync(ValidationSoapHeader auth, InventoryItemLotListRequestBody request)
    {

        InventoryItemLotListResponse response;
        List<Lots> parsedResponse;

        Log.Information("Converting {@type} to Xml", typeof(InventoryItemLotListRequestBody));
        Log.Debug("{@type}: {@req}", typeof(InventoryItemLotListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending InventoryItemLotListAsync SOAP request");

        try
        {
            response = await _soap.InventoryItemLotListAsync(new InventoryItemLotListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

            Log.Information("Parsing InventoryItemLotListAsync response into List of {@type}", typeof(Lots));

            parsedResponse = XmlParser.GetInventoryLotData(response.InventoryItemLotListResult);

        }
        catch (Exception ex)
        {
            Log.Error("InventoryItemLotLiistAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("InventoryItemLotListAsync Response: {@res}", response.InventoryItemLotListResult);

        return parsedResponse;
    }


    public async Task<InventoryItemLotNewResult> InventoryItemLotNewAsync(ValidationSoapHeader auth, InventoryItemLotNewRequestBody request)
    {
        InventoryItemLotNewResponse response;

        Log.Information("Converting {@type} to Xml", typeof(InventoryItemLotNewRequestBody));
        Log.Debug("{@type}: {@req}", typeof(InventoryItemLotNewRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending InventoryItemLotNewAsync SOAP request");

        try
        {
            response = await _soap.InventoryItemLotNewAsync(new InventoryItemLotNewRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("InventoryItemLotNewAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("InventoryItemLotNewAsync Response: {@res}", response.InventoryItemLotNewResult);

        var result = XmlParsing.DeserializeXmlToObject<InventoryItemLotNewResult>(response.InventoryItemLotNewResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("InventoryItemLotNewAsync returned an error: {@error}", result.ReturnErrors);
            throw new Exception($"InventoryItemLotNewAsync failed with error code {result.ReturnCode}: {result.ReturnErrors}");
        }

        return result;
    }

}
