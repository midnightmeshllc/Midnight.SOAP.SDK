using Midnight.SOAP.SDK.RequestObjects.PurchaseOrderInputs;
using Midnight.SOAP.SDK.ResponseObjects.PurchaseOrderOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

/// <summary>
/// Provides methods for creating, retrieving, and updating purchase orders via SOAP requests.
/// </summary>
/// <remarks>This service acts as a client for interacting with a SOAP-based API to manage purchase orders.  It
/// includes methods for creating new purchase orders, retrieving a list of purchase orders,  and updating existing
/// purchase orders. Each method handles serialization of request objects  to XML, sends the SOAP request, and
/// deserializes the response into strongly-typed result objects.</remarks>
public class PurchaseOrderService
{
    private readonly Service1SoapClient.EndpointConfiguration _soapConfig;
    private readonly Service1Soap _soap;
    public PurchaseOrderService()
    {
        _soapConfig = new Service1SoapClient.EndpointConfiguration();
        _soap = new Service1SoapClient(_soapConfig);
    }

    /// <summary>
    /// Sends a SOAP request to create a new purchase order and returns the result of the operation.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes.  Ensure that
    /// sensitive information is handled appropriately in the logs.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the details of the purchase order to be created.  This parameter cannot be <see
    /// langword="null"/>.</param>
    /// <returns>A <see cref="PurchaseOrderNewResult"/> object containing the result of the operation,  including the return code
    /// and any associated errors or messages.</returns>
    /// <exception cref="Exception">Thrown if the operation fails, including cases where the return code from the SOAP response  indicates an error.
    /// The exception message will include the return code and error details.</exception>
    public async Task<PurchaseOrderNewResult> PurchaseOrderNewAsync(ValidationSoapHeader auth, PurchaseOrderNewRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(PurchaseOrderNewRequestBody)} to Xml");
        Log.Debug($"{typeof(PurchaseOrderNewRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        PurchaseOrderNewResponse response;

        Log.Information($"Sending PurchaseOrderNewAsync SOAP request");

        try
        {
            response = await _soap.PurchaseOrderNewAsync(new PurchaseOrderNewRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error occurred while sending PurchaseOrderNewAsync SOAP request");
            throw;
        }

        Log.Debug($"{typeof(PurchaseOrderNewResult)}: {FileOutput.CreateXmlFromClass(response)}");

        var result = XmlParsing.DeserializeXmlToObject<PurchaseOrderNewResult>(response.PurchaseOrderNewResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("PurchaseOrderNewAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"PurchaseOrderNewAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Retrieves a list of purchase orders asynchronously via a SOAP request.
    /// </summary>
    /// <remarks>
    /// This method serializes the provided request body to XML and sends it to the SOAP service using the authentication header.
    /// The response is deserialized into an <see cref="PurchaseOrderListResult"/> object. If the operation fails, an exception is thrown with details from the response.
    /// </remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the SOAP request.</param>
    /// <param name="request">The request body specifying the parameters for the purchase order list query. Cannot be <c>null</c>.</param>
    /// <returns>
    /// An <see cref="PurchaseOrderListResult"/> containing purchase order details and status information for the requested query.
    /// </returns>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is <c>null</c>.</exception>
    /// <exception cref="Exception">
    /// Thrown if the SOAP service returns a non-zero return code, indicating a failure. The exception message includes the return code and error details.
    /// </exception>
    public async Task<PurchaseOrderListResult> PurchaseOrderListAsync(ValidationSoapHeader auth, PurchaseOrderListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(PurchaseOrderListRequestBody)} to Xml");
        Log.Debug($"{typeof(PurchaseOrderListRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        PurchaseOrderListResponse response;

        Log.Information($"Sending PurchaseOrderListAsync SOAP request");

        try
        {
            response = await _soap.PurchaseOrderListAsync(new PurchaseOrderListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error occurred while sending PurchaseOrderListAsync SOAP request");
            throw;
        }

        Log.Debug($"{typeof(PurchaseOrderListResult)}: {FileOutput.CreateXmlFromClass(response)}");

        var result = XmlParsing.DeserializeXmlToObject<PurchaseOrderListResult>(response.PurchaseOrderListResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("PurchaseOrderListAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"PurchaseOrderListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Updates a purchase order asynchronously using the provided request data and authentication header.
    /// </summary>
    /// <remarks>This method sends a SOAP request to update a purchase order and processes the response.  If
    /// the operation fails, an exception is thrown with details about the failure.</remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the request.</param>
    /// <param name="request">The request body containing the details of the purchase order to be updated.  This parameter cannot be <see
    /// langword="null"/>.</param>
    /// <returns>A <see cref="PurchaseOrderUpdateResult"/> object containing the result of the update operation,  including the
    /// return code and any associated errors.</returns>
    /// <exception cref="Exception">Thrown if the update operation fails, including cases where the return code indicates an error.</exception>
    public async Task<PurchaseOrderUpdateResult> PurchaseOrderUpdateAsync(ValidationSoapHeader auth, PurchaseOrderUpdateRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(PurchaseOrderUpdateRequestBody)} to Xml");
        Log.Debug($"{typeof(PurchaseOrderUpdateRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        PurchaseOrderUpdateResponse response;

        Log.Information($"Sending PurchaseOrderUpdateAsync SOAP request");

        try
        {
            response = await _soap.PurchaseOrderUpdateAsync(new PurchaseOrderUpdateRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error occurred while sending PurchaseOrderUpdateAsync SOAP request");
            throw;
        }

        Log.Debug($"{typeof(PurchaseOrderUpdateResult)}: {FileOutput.CreateXmlFromClass(response)}");

        var result = XmlParsing.DeserializeXmlToObject<PurchaseOrderUpdateResult>(response.PurchaseOrderUpdateResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("PurchaseOrderUpdateAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"PurchaseOrderUpdateAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }
}
