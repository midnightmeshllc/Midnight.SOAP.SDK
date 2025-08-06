
using Midnight.SOAP.SDK.RequestObjects.EstimateInputs;
using Midnight.SOAP.SDK.ResponseObjects.EstimateOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

public class EstimateService
{
    private readonly Service1SoapClient.EndpointConfiguration _soapConfig;
    private readonly Service1Soap _soap;
    public EstimateService()
    {
        _soapConfig = new Service1SoapClient.EndpointConfiguration();
        _soap = new Service1SoapClient(_soapConfig);
    }


    public async Task<EstimateListResult> EstimateListAsync(ValidationSoapHeader auth, EstimateListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(EstimateListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(EstimateListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        EstimateListResponse response;

        Log.Information("Sending EstimateListAsync SOAP request");

        try
        {
            response = await _soap.EstimateListAsync(new EstimateListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("EstimateListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("EstimateListAsync Response: {@res}", response.EstimateListResult);

        var result = XmlParsing.DeserializeXmlToObject<EstimateListResult>(response.EstimateListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("EstimateListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"EstimateListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }
}
