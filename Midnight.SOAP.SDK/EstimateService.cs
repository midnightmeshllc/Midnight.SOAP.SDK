using Midnight.SOAP.SDK.RequestObjects.EstimateInputs;
using Midnight.SOAP.SDK.ResponseObjects.EstimateOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

/// <summary>
/// Provides methods for interacting with a SOAP service to manage estimates and related operations.
/// </summary>
/// <remarks>The <see cref="EstimateService"/> class offers a set of asynchronous methods to perform various
/// operations such as retrieving estimates, inserting new estimates, updating existing estimates, and calculating
/// preview prices. Each method communicates with the SOAP service by serializing request objects to XML and
/// deserializing the responses into strongly-typed result objects. Exceptions are thrown for invalid inputs or if the
/// SOAP service returns an error.</remarks>
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


    /// <summary>
    /// Sends a SOAP request to calculate the preview price for a print template and returns the result.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes. If the SOAP
    /// response contains a non-zero return code, an exception is thrown with the associated error details.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the details of the print template for which the preview price is to be calculated.
    /// This parameter cannot be <see langword="null"/>.</param>
    /// <returns>A <see cref="PrintTemplatePreviewPriceResult"/> object containing the calculated preview price and related
    /// details.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the response indicates an error, such as a non-zero return code.</exception>
    public async Task<PrintTemplatePreviewPriceResult> PrintTemplatePreviewPriceAsync(ValidationSoapHeader auth, PrintTemplatePreviewPriceRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(PrintTemplatePreviewPriceRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(PrintTemplatePreviewPriceRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        PrintTemplatePreviewPriceResponse response;

        Log.Information("Sending PrintTemplatePreviewPriceAsync SOAP request");

        try
        {
            response = await _soap.PrintTemplatePreviewPriceAsync(new PrintTemplatePreviewPriceRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("PrintTemplatePreviewPriceAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("PrintTemplatePreviewPriceAsync Response: {@res}", response.PrintTemplatePreviewPriceResult);

        var result = XmlParsing.DeserializeXmlToObject<PrintTemplatePreviewPriceResult>(response.PrintTemplatePreviewPriceResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("PrintTemplatePreviewPriceAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"PrintTemplatePreviewPriceAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }


    /// <summary>
    /// Sends a SOAP request to calculate the preview price for wide-format printing based on the provided request data.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes. If the response
    /// contains a non-zero return code, an exception is thrown with the associated error details.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the parameters needed to calculate the wide-format preview price. This parameter
    /// cannot be <see langword="null"/>.</param>
    /// <returns>A <see cref="WideFormatPreviewPriceResult"/> object containing the calculated preview price and related details.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the response indicates an error, such as a non-zero return code.</exception>
    public async Task<WideFormatPreviewPriceResult> WideFormatPreviewPriceAsync(ValidationSoapHeader auth, WideFormatPreviewPriceRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(WideFormatPreviewPriceRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(WideFormatPreviewPriceRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        WideFormatPreviewPriceResponse response;

        Log.Information("Sending WideFormatPreviewPriceAsync SOAP request");

        try
        {
            response = await _soap.WideFormatPreviewPriceAsync(new WideFormatPreviewPriceRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("WideFormatPreviewPriceAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("WideFormatPreviewPriceAsync Response: {@res}", response.WideFormatPreviewPriceResult);

        var result = XmlParsing.DeserializeXmlToObject<WideFormatPreviewPriceResult>(response.WideFormatPreviewPriceResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("WideFormatPreviewPriceAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"WideFormatPreviewPriceAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }


    /// <summary>
    /// Sends an asynchronous SOAP request to update an estimate and returns the result.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes. If the operation
    /// fails, it logs the error and throws an exception with relevant details.</remarks>
    /// <param name="auth">The authentication header required for the SOAP request.</param>
    /// <param name="request">The request body containing the data needed to perform the estimate update.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains an <see cref="EstimateUpdateResult">
    /// object with the outcome of the estimate update operation.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the operation completes with a non-zero return code. The exception
    /// message includes the return code and any associated error messages.</exception>
    public async Task<EstimateUpdateResult> EstimateUpdateAsync(ValidationSoapHeader auth, EstimateUpdateRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(EstimateUpdateRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(EstimateUpdateRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        EstimateUpdateResponse response;

        Log.Information("Sending EstimateUpdateAsync SOAP request");

        try
        {
            response = await _soap.EstimateUpdateAsync(new EstimateUpdateRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("EstimateUpdateAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("EstimateUpdateAsync Response: {@res}", response.EstimateUpdateResult);

        var result = XmlParsing.DeserializeXmlToObject<EstimateUpdateResult>(response.EstimateUpdateResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("EstimateUpdateAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"EstimateUpdateAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }
}
