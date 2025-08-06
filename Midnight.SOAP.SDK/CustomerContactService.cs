using Midnight.SOAP.SDK.Models;
using Midnight.SOAP.SDK.RequestObjects.CustomerContactInputs;
using Midnight.SOAP.SDK.ResponseObjects.CustomerContactOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

/// <summary>
/// Provides methods for interacting with customer contact information via SOAP requests.
/// </summary>
/// <remarks>The <see cref="CustomerContactService"/> class enables asynchronous operations for inserting,
/// retrieving,  and updating customer contact information. Each method requires valid authentication credentials and 
/// properly formatted request objects. This class is designed to handle SOAP-based communication with  external
/// services, converting request objects to XML and parsing responses.</remarks>
public class CustomerContactService
{
    private readonly Service1SoapClient.EndpointConfiguration _soapConfig;
    private readonly Service1Soap _soap;
    public CustomerContactService()
    {
        _soapConfig = new Service1SoapClient.EndpointConfiguration();
        _soap = new Service1SoapClient(_soapConfig);
    }

    /// <summary>
    /// Sends a SOAP request to insert customer contact information and returns the result of the operation.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes. If the operation
    /// fails, an exception is thrown with details about the failure.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing customer contact information to be inserted. Cannot be <see langword="null"/>.</param>
    /// <returns>A <see cref="CustomerContactInsertResult"/> object containing the result of the operation, including the return
    /// code and any error messages.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the operation returns a non-zero return code, indicating an error.</exception>
    public async Task<CustomerContactInsertResult> CustomerContactInsertAsync(ValidationSoapHeader auth, CustomerContactListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(CustomerContactListRequestBody)} to Xml");
        Log.Debug($"{typeof(CustomerContactListRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        CustomerContactInsertResponse response;

        Log.Information($"Sending CustomerContactInsertAsync SOAP request");

        try
        {
            response = await _soap.CustomerContactInsertAsync(new CustomerContactInsertRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("CustomerContactInsertAsync Exception: {@ex}", ex.Message );
            throw;
        }

        Log.Debug("CustomerContactInsertAsync Response: {@res}", response.CustomerContactInsertResult);

        var result = XmlParsing.DeserializeXmlToObject<CustomerContactInsertResult>(response.CustomerContactInsertResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("CustomerContactInsertAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"CustomerContactInsertAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to retrieve a list of customer contacts and returns the result.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes. If the operation
    /// fails,  the method logs the error and throws an exception with relevant details.</remarks>
    /// <param name="auth">The authentication header containing credentials for the SOAP request.</param>
    /// <param name="request">The request body containing the parameters required for the customer contact list operation. Cannot be <see
    /// langword="null"/>.</param>
    /// <returns>A <see cref="CustomerContactListResult"/> object containing the list of customer contacts and associated
    /// metadata.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the operation returns a non-zero return code, indicating an error.  The
    /// exception message will include the return code and error details.</exception>
    public async Task<CustomerContactListResult> CustomerContactListAsync(ValidationSoapHeader auth, CustomerContactListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(CustomerContactListRequestBody)} to Xml");
        Log.Debug("{@type}: {@req}", typeof(CustomerContactListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        CustomerContactListResponse response;

        Log.Information($"Sending CustomerContactListAsync SOAP request");

        try
        {
            response = await _soap.CustomerContactListAsync(new CustomerContactListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

        }
        catch (Exception ex)
        {
            Log.Error("CustomerContactListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("CustomerContactListAsync Response: {@res}", response.CustomerContactListResult);

        var result = XmlParsing.DeserializeXmlToObject<CustomerContactListResult>(response.CustomerContactListResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("CustomerContactListAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"CustomerContactListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to update customer contact information asynchronously.
    /// </summary>
    /// <remarks>This method converts the provided <paramref name="request"/> object into XML format and sends
    /// it as part of a SOAP request. Ensure that the <paramref name="auth"/> parameter contains valid credentials, as
    /// the operation requires authentication.</remarks>
    /// <param name="auth">The authentication header containing validation credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the customer contact update details. Cannot be <see langword="null"/>.</param>
    /// <returns>A <see cref="CustomerContactUpdateResponse"/> object containing the result of the customer contact update
    /// operation.</returns>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is <see langword="null"/>.</exception>
    public async Task<CustomerContactUpdateResponse> CustomerContactUpdateAsync(ValidationSoapHeader auth, CustomerContactUpdateRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information("Converting {@type} to Xml", typeof(CustomerContactUpdateRequestBody));
        Log.Debug($"{typeof(CustomerContactUpdateRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        CustomerContactUpdateResponse response;

        Log.Information($"Sending CustomerContactUpdateAsync SOAP request");

        try
        {
            response = await _soap.CustomerContactUpdateAsync(new CustomerContactUpdateRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("CustomerContactUpdateAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("CustomerContactUpdateAsync Response: {@res}", response.CustomerContactUpdateResult);

        return response;
    }

}
