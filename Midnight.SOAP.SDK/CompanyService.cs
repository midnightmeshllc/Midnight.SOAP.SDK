
using Midnight.SOAP.SDK.RequestObjects.CompanyInputs;
using Midnight.SOAP.SDK.RequestObjects.CustomerInputs;
using Midnight.SOAP.SDK.ResponseObjects.CompanyOutputs;
using Midnight.SOAP.SDK.ResponseObjects.CustomerOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

public class CompanyService
{
    private readonly Service1SoapClient.EndpointConfiguration _soapConfig;
    private readonly Service1Soap _soap;
    public CompanyService()
    {
        _soapConfig = new Service1SoapClient.EndpointConfiguration();
        _soap = new Service1SoapClient(_soapConfig);
    }


    public async Task<CompanyListResult> CompanyListAsync(ValidationSoapHeader auth, CompanyListRequestBody request)
    {
        CompanyListResponse response;

        Log.Information($"Converting {typeof(CompanyListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(CompanyListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending CompanyListAsync SOAP request");
        try
        {
            response = await _soap.CompanyListAsync(new CompanyListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("CompanyListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("CompanyListAsync Response: {@res}", response.CompanyListResult);

        var result = XmlParsing.DeserializeXmlToObject<CompanyListResult>(response.CompanyListResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("CompanyListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"CompanyListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }
}
