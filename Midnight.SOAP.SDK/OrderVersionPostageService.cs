using Midnight.SOAP.SDK.RequestObjects.OrderVersionPostageInputs;
using Midnight.SOAP.SDK.ResponseObjects.OrderVersionPostageOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

/// <summary>
/// Provides methods for interacting with the Order Version Postage service via SOAP.
/// </summary>
/// <remarks>This service allows clients to insert and update postage information for order versions. It
/// communicates with the SOAP endpoint using the <see cref="Service1SoapClient"/>.</remarks>
public class OrderVersionPostageService
{
    private readonly Service1SoapClient.EndpointConfiguration _soapConfig;
    private readonly Service1Soap _soap;
    public OrderVersionPostageService()
    {
        _soapConfig = new Service1SoapClient.EndpointConfiguration();
        _soap = new Service1SoapClient(_soapConfig);
    }

    /// <summary>
    /// Sends a SOAP request to insert postage information for a specific order version and returns the result.
    /// </summary>
    /// <remarks>This method converts the provided request object into an XML format and sends it as part of a
    /// SOAP request. If the operation fails, an exception is thrown with details about the failure.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the order version details and postage information to be inserted.</param>
    /// <returns>An <see cref="OrderVersionPostageInsertResult"/> object containing the result of the operation,  including the
    /// return code and any associated errors.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the operation returns a non-zero return code, indicating an error.</exception>
    public async Task<OrderVersionPostageInsertResult> OrderVersionPostageInsertAsync(ValidationSoapHeader auth, OrderVersionPostageInsertRequestBody request)
    {

        Log.Information("Converting {@type} to Xml", typeof(OrderVersionPostageInsertRequestBody));
        Log.Debug("{@type}: {@req}", typeof(OrderVersionPostageInsertRequestBody), FileOutput.CreateXmlFromClass(request));

        string xmlInput = FileOutput.CreateXmlFromClass(request);

        OrderVersionPostageInsertResponse response;

        Log.Information("Sending OrderVersionPostageInsertAsync SOAP request for VersionID: {@v} with PostageTotal: {@t}",
            request.InputParameter.VersionID,
            request.InputParameter.PostageTotal);

        try
        {
            response = await _soap.OrderVersionPostageInsertAsync(new OrderVersionPostageInsertRequest
            {
                ValidationSoapHeader = auth,
                inputXML = xmlInput
            });
        }
        catch (Exception ex)
        {
            Log.Error("OrderVersionPostageInsertAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderVersionPostageInsertAsync Response: {@res}", response.OrderVersionPostageInsertResult);

        var result = XmlParsing.DeserializeXmlToObject<OrderVersionPostageInsertResult>(response.OrderVersionPostageInsertResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("OrderVersionPostageInsertAsync failed with ReturnCode: {@code} and Errors: {@errors}",
                result.ReturnCode, result.ReturnErrors);
            throw new Exception($"OrderVersionPostageInsertAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }


    /// <summary>
    /// Sends a SOAP request to update postage information for a specific order version.
    /// </summary>
    /// <remarks>This method converts the provided request body into XML format and sends it as part of the
    /// SOAP request. Ensure that the <paramref name="auth"/> parameter contains valid credentials and that the
    /// <paramref name="request"/> parameter includes all required fields.</remarks>
    /// <param name="auth">The authentication header containing validation credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the parameters needed to update the postage information, including the
    /// OrderVersionPostageID.</param>
    /// <returns>A <see cref="OrderVersionPostageUpdateResponse"/> object containing the result of the postage update operation.</returns>
    public async Task<OrderVersionPostageUpdateResponse> OrderVersionPostageUpdateAsync(ValidationSoapHeader auth, OrderVersionPostageUpdateRequestBody request)
    {

        OrderVersionPostageUpdateResponse response;

        Log.Information("Converting {@type} to Xml", typeof(OrderVersionPostageUpdateRequestBody));
        Log.Debug("{@type}: {@req}", typeof(OrderVersionPostageUpdateRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending OrderVersionPostageUpdateAsync SOAP request for PostageID: {@v}", request.InputParameter.OrderVersionPostageID);

        try
        {
            response = await _soap.OrderVersionPostageUpdateAsync(new OrderVersionPostageUpdateRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("OrderVersionPostageUpdateAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderVersionPostageUpdateAsync Response: {@res}", response.OrderVersionPostageUpdateResult);

        return response;
    }
}
