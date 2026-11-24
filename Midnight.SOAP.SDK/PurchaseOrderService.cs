using Midnight.SOAP.SDK.RequestObjects.PurchaseOrderInputs;
using Midnight.SOAP.SDK.ResponseObjects.PurchaseOrderOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

/// <summary>
/// Provides methods for creating, retrieving, and updating purchase orders via SOAP requests.
/// IMPORTANT: Must inject output of Utilities.SoapClient.Configure().
/// </summary>
/// <remarks>This service acts as a client for interacting with a SOAP-based API to manage purchase orders.  It
/// includes methods for creating new purchase orders, retrieving lists of existing purchase orders,  and updating
/// purchase orders. Each method handles serialization of request objects to XML,  communication with the SOAP service,
/// and deserialization of the response into strongly-typed objects.  Exceptions are thrown for invalid input or when
/// the SOAP service returns an error.  Ensure that the provided authentication headers and request objects are valid
/// and complete.</remarks>
/// <param name="_soap"></param>
public class PurchaseOrderService(Service1Soap _soap)
{

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
    public async Task<PurchaseOrderNewResult> PurchaseOrderNewAsync(ValidationSoapHeader auth, PurchaseOrderNewRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(PurchaseOrderNewRequestBody)} to Xml");
        Log.Debug($"{typeof(PurchaseOrderNewRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        PurchaseOrderNewResponse response;

        Log.Information($"Sending PurchaseOrderNewAsync SOAP request");

        response = await _soap.PurchaseOrderNewAsync(new PurchaseOrderNewRequest
        {
            ValidationSoapHeader = auth,
            inputXML = inputXml
        });

        Log.Debug($"{typeof(PurchaseOrderNewResult)}: {FileOutput.CreateXmlFromClass(response)}");

        var result = XmlParsing.DeserializeXmlToObject<PurchaseOrderNewResult>(response.PurchaseOrderNewResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("PurchaseOrderNewAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}",
                result.ReturnCode, result.ReturnErrors.First().Error);
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
    public async Task<PurchaseOrderListResult> PurchaseOrderListAsync(ValidationSoapHeader auth, PurchaseOrderListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(PurchaseOrderListRequestBody)} to Xml");
        Log.Debug($"{typeof(PurchaseOrderListRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        PurchaseOrderListResponse response;

        Log.Information($"Sending PurchaseOrderListAsync SOAP request");

        response = await _soap.PurchaseOrderListAsync(new PurchaseOrderListRequest
        {
            ValidationSoapHeader = auth,
            inputXML = inputXml
        });

        Log.Debug($"{typeof(PurchaseOrderListResult)}: {FileOutput.CreateXmlFromClass(response)}");

        var result = XmlParsing.DeserializeXmlToObject<PurchaseOrderListResult>(response.PurchaseOrderListResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("PurchaseOrderListAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}", 
                result.ReturnCode, result.ReturnErrors.First().Error);
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
    public async Task<PurchaseOrderUpdateResult> PurchaseOrderUpdateAsync(ValidationSoapHeader auth, PurchaseOrderUpdateRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(PurchaseOrderUpdateRequestBody)} to Xml");
        Log.Information($"{typeof(PurchaseOrderUpdateRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        PurchaseOrderUpdateResponse response;

        Log.Information($"Sending PurchaseOrderUpdateAsync SOAP request");

        response = await _soap.PurchaseOrderUpdateAsync(new PurchaseOrderUpdateRequest
        {
            ValidationSoapHeader = auth,
            inputXML = inputXml
        });

        Log.Information($"{typeof(PurchaseOrderUpdateResult)}: {FileOutput.CreateXmlFromClass(response)}");

        var result = XmlParsing.DeserializeXmlToObject<PurchaseOrderUpdateResult>(response.PurchaseOrderUpdateResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("PurchaseOrderUpdateAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}", 
                result.ReturnCode, result.ReturnErrors.First().Error);
        }

        return result;
    }
}
