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


    /// <summary>
    /// Sends a SOAP request to retrieve a list of estimates and returns the result.
    /// </summary>
    /// <remarks>
    /// This method serializes the provided <paramref name="request"/> to XML and sends it to the SOAP service using the authentication header.
    /// The response is deserialized into a <see cref="EstimateListResult"/> object. If the operation fails, an exception is thrown with details from the response.
    /// </remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the SOAP request.</param>
    /// <param name="request">The request body specifying the parameters for the estimate list query. Cannot be <c>null</c>.</param>
    /// <returns>
    /// A <see cref="EstimateListResult"/> containing estimate details and status information for the requested query.
    /// </returns>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is <c>null</c>.</exception>
    /// <exception cref="Exception">
    /// Thrown if the SOAP service returns a non-zero return code, indicating a failure. The exception message includes the return code and error details.
    /// </exception>
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


    /// <summary>
    /// Sends a SOAP request to retrieve a list of estimate details and returns the result.
    /// </summary>
    /// <remarks>
    /// This method serializes the provided <paramref name="request"/> to XML and sends it to the SOAP service using the authentication header.
    /// The response is deserialized into a <see cref="EstimateDetailListResult"/> object. If the operation fails, an exception is thrown with details from the response.
    /// </remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the SOAP request.</param>
    /// <param name="request">The request body specifying the parameters for the estimate detail list query. Cannot be <c>null</c>.</param>
    /// <returns>
    /// A <see cref="EstimateDetailListResult"/> containing estimate detail information and status for the requested query.
    /// </returns>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is <c>null</c>.</exception>
    /// <exception cref="Exception">
    /// Thrown if the SOAP service returns a non-zero return code, indicating a failure. The exception message includes the return code and error details.
    /// </exception>
    public async Task<EstimateDetailListResult> EstimateDetailListAsync(ValidationSoapHeader auth, EstimateDetailListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(EstimateDetailListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(EstimateDetailListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        EstimateDetailListResponse response;

        Log.Information("Sending EstimateDetailListAsync SOAP request");

        try
        {
            response = await _soap.EstimateDetailListAsync(new EstimateDetailListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("EstimateDetailListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("EstimateDetailListAsync Response: {@res}", response.EstimateDetailListResult);

        var result = XmlParsing.DeserializeXmlToObject<EstimateDetailListResult>(response.EstimateDetailListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("EstimateDetailListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"EstimateDetailListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }


    /// <summary>
    /// Sends a SOAP request to insert a new estimate and returns the result.
    /// </summary>
    /// <remarks>
    /// This method serializes the provided <paramref name="request"/> to XML and sends it to the SOAP service using the authentication header.
    /// The response is deserialized into an <see cref="EstimateInsertResult"/> object. If the operation fails, an exception is thrown with details from the response.
    /// </remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the SOAP request.</param>
    /// <param name="request">The request body specifying the parameters for the estimate insert operation. Cannot be <c>null</c>.</param>
    /// <returns>
    /// An <see cref="EstimateInsertResult"/> containing the inserted estimate details and status information for the operation.
    /// </returns>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is <c>null</c>.</exception>
    /// <exception cref="Exception">
    /// Thrown if the SOAP service returns a non-zero return code, indicating a failure. The exception message includes the return code and error details.
    /// </exception>
    public async Task<EstimateInsertResult> EstimateInsertAsync(ValidationSoapHeader auth, EstimateInsertRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(EstimateInsertRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(EstimateInsertRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        EstimateInsertResponse response;

        Log.Information("Sending EstimateInsertAsync SOAP request");

        try
        {
            response = await _soap.EstimateInsertAsync(new EstimateInsertRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("EstimateInsertAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("EstimateInsertAsync Response: {@res}", response.EstimateInsertResult);

        var result = XmlParsing.DeserializeXmlToObject<EstimateInsertResult>(response.EstimateInsertResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("EstimateInsertAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"EstimateInsertAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }
}
