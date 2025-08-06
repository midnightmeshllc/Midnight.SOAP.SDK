
using Midnight.SOAP.SDK.RequestObjects.SettingInputs;
using Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

public class SettingService
{
    private readonly Service1SoapClient.EndpointConfiguration _soapConfig;
    private readonly Service1Soap _soap;
    public SettingService()
    {
        _soapConfig = new Service1SoapClient.EndpointConfiguration();
        _soap = new Service1SoapClient(_soapConfig);
    }


    /// <summary>
    /// Sends a SOAP request to retrieve a list of customer types and returns the result.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes. If the operation
    /// fails, the method logs the error and throws an exception.</remarks>
    /// <param name="auth">The authentication header containing credentials for the SOAP request.</param>
    /// <param name="request">The request body containing the parameters required for the customer type list operation. Cannot be <see
    /// langword="null"/>.</param>
    /// <returns>A <see cref="CustomerTypeListResult"/> object containing the list of customer types and associated metadata.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the response indicates an error, as determined by a non-zero return code.</exception>
    public async Task<CustomerTypeListResult> CustomerTypeListAsync(ValidationSoapHeader auth, CustomerTypeListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(CustomerTypeListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(CustomerTypeListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        CustomerTypeListResponse response;

        Log.Information("Sending CustomerTypeListAsync SOAP request");

        try
        {
            response = await _soap.CustomerTypeListAsync(new CustomerTypeListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("CustomerTypeListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("CustomerTypeListAsync Response: {@res}", response.CustomerTypeListResult);

        var result = XmlParsing.DeserializeXmlToObject<CustomerTypeListResult>(response.CustomerTypeListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("CustomerTypeListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"CustomerTypeListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Retrieves a list of delivery methods based on the provided request parameters.
    /// </summary>
    /// <remarks>This method sends a SOAP request to retrieve delivery methods and processes the response.  If
    /// the operation fails, detailed error information is logged, and an exception is thrown.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing parameters for retrieving the delivery methods. Cannot be <see langword="null"/>.</param>
    /// <returns>A <see cref="DeliveryMethodListResult"/> object containing the list of delivery methods and associated metadata.</returns>
    /// <exception cref="Exception">Thrown if the SOAP service returns a non-zero return code or if an error occurs during the request. The
    /// exception message will include the return code and error details.</exception>
    public async Task<DeliveryMethodListResult> DeliveryMethodListAsync(ValidationSoapHeader auth, DeliveryMethodListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(DeliveryMethodListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(DeliveryMethodListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        DeliveryMethodListResponse response;

        Log.Information("Sending CustomerTypeListAsync SOAP request");

        try
        {
            response = await _soap.DeliveryMethodListAsync(new DeliveryMethodListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("DeliveryMethodListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("DeliveryMethodListAsync Response: {@res}", response.DeliveryMethodListResult);

        var result = XmlParsing.DeserializeXmlToObject<DeliveryMethodListResult>(response.DeliveryMethodListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("DeliveryMethodListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"DeliveryMethodListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to retrieve a list of document types and returns the result.
    /// </summary>
    /// <remarks>This method converts the provided <paramref name="request"/> object to XML format and sends
    /// it as part of a SOAP request. If the operation fails, an exception is thrown with details about the
    /// failure.</remarks>
    /// <param name="auth">The authentication header containing credentials for the SOAP request. Cannot be null.</param>
    /// <param name="request">The request body containing the parameters for the document type list operation. Cannot be null.</param>
    /// <returns>A <see cref="DocumentTypeListResult"/> object containing the list of document types and associated metadata.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the response indicates an error, such as a non-zero return code.</exception>
    public async Task<DocumentTypeListResult> DocumentTypeListAsync(ValidationSoapHeader auth, DocumentTypeListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(DocumentTypeListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(DocumentTypeListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        DocumentTypeListResponse response;

        Log.Information("Sending CustomerTypeListAsync SOAP request");

        try
        {
            response = await _soap.DocumentTypeListAsync(new DocumentTypeListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("DocumentTypeListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("DocumentTypeListAsync Response: {@res}", response.DocumentTypeListResult);

        var result = XmlParsing.DeserializeXmlToObject<DocumentTypeListResult>(response.DocumentTypeListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("DocumentTypeListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"DocumentTypeListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to retrieve a list of employees and returns the result.
    /// </summary>
    /// <remarks>This method communicates with a SOAP service to fetch employee data. The request is
    /// serialized to XML before being sent,  and the response is deserialized into an <see cref="EmployeeListResult"/>
    /// object. If the operation fails, an exception is thrown.</remarks>
    /// <param name="auth">The authentication header containing credentials for the SOAP request. Cannot be null.</param>
    /// <param name="request">The request body containing the parameters for the employee list query. Cannot be null.</param>
    /// <returns>An <see cref="EmployeeListResult"/> object containing the list of employees and associated metadata.</returns>
    /// <exception cref="Exception">Thrown if the SOAP service returns a non-zero return code or if an error occurs during the request or response
    /// processing.</exception>
    public async Task<EmployeeListResult> EmployeeListAsync(ValidationSoapHeader auth, EmployeeListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(EmployeeListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(EmployeeListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        EmployeeListResponse response;

        Log.Information("Sending CustomerTypeListAsync SOAP request");

        try
        {
            response = await _soap.EmployeeListAsync(new EmployeeListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("EmployeeListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("EmployeeListAsync Response: {@res}", response.EmployeeListResult);

        var result = XmlParsing.DeserializeXmlToObject<EmployeeListResult>(response.EmployeeListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("EmployeeListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"EmployeeListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }
}
