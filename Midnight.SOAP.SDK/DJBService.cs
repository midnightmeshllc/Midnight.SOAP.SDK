
using Midnight.SOAP.SDK.RequestObjects.DJBInputs;
using Midnight.SOAP.SDK.ResponseObjects.DJBOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

public class DJBService
{
    private readonly Service1SoapClient.EndpointConfiguration _soapConfig;
    private readonly Service1Soap _soap;
    public DJBService()
    {
        _soapConfig = new Service1SoapClient.EndpointConfiguration();
        _soap = new Service1SoapClient(_soapConfig);
    }

    public async Task<DJBJobStatusListResult> DJBJobStatusListAsync(ValidationSoapHeader auth, DJBJobStatusListRequestBody request)
    {
        DJBJobStatusListResponse response;

        Log.Information($"Converting {typeof(DJBJobStatusListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(DJBJobStatusListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending DJBJobStatusListAsync SOAP request");
        try
        {
            response = await _soap.DJBJobStatusListAsync(new DJBJobStatusListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("DJBJobStatusListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("DJBJobStatusListAsync Response: {@res}", response.DJBJobStatusListResult);

        var result = XmlParsing.DeserializeXmlToObject<DJBJobStatusListResult>(response.DJBJobStatusListResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("DJBJobStatusListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"DJBJobStatusListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to retrieve a DJB list and processes the response.
    /// </summary>
    /// <remarks>This method sends a SOAP request to the DJBList endpoint, processes the XML response, and
    /// deserializes it into a <see cref="DJBListResult"/> object. If the operation fails, an exception is thrown with
    /// details about the failure.</remarks>
    /// <param name="auth">The authentication header containing credentials for the SOAP request. Cannot be null.</param>
    /// <param name="request">The request body containing the parameters for the DJB list operation. Cannot be null.</param>
    /// <returns>A <see cref="DJBListResult"/> object containing the result of the DJB list operation.</returns>
    /// <exception cref="Exception">Thrown if the SOAP response indicates a failure, as determined by a non-zero <c>ReturnCode</c> in the <see
    /// cref="DJBListResult"/>. The exception message includes the return code and error details.</exception>
    public async Task<DJBListResult> DJBListAsync(ValidationSoapHeader auth, DJBListRequestBody request)
    {
        DJBListResponse response;

        Log.Information($"Converting {typeof(DJBListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(DJBListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending DJBListAsync SOAP request");
        try
        {
            response = await _soap.DJBListAsync(new DJBListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("DJBListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("DJBListAsync Response: {@res}", response.DJBListResult);

        var result = XmlParsing.DeserializeXmlToObject<DJBListResult>(response.DJBListResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("DJBListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"DJBListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }
}
