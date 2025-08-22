using Midnight.SOAP.SDK.RequestObjects.OrderVersionPostageInputs;
using Midnight.SOAP.SDK.ResponseObjects.OrderVersionPostageOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

/// <summary>
/// Provides methods for managing postage information related to order versions via SOAP requests.
/// IMPORTANT: Must inject output of Utilities.SoapClient.Configure().
/// </summary>
/// <remarks>This service class includes methods to insert, update, and retrieve postage information for specific
/// order versions. Each method communicates with a SOAP service, sending serialized XML requests and processing the
/// responses. Exceptions are thrown for any failures, including SOAP errors or non-zero return codes in the
/// responses.</remarks>
/// <param name="_soap"></param>
public class OrderVersionPostageService(Service1Soap _soap)
{

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
    /// Sends a SOAP request to update the postage information for a specific order version.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes. Ensure that the 
    /// <paramref name="auth"/> parameter contains valid credentials and that the <paramref name="request"/>  parameter
    /// is properly populated with the required data.</remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the request.</param>
    /// <param name="request">The request body containing the details of the order version postage update, including the  <see
    /// cref="OrderVersionPostageUpdateRequestBody.InputParameter"/> with the postage ID to be updated.</param>
    /// <returns>An <see cref="OrderVersionPostageUpdateResult"/> object containing the result of the update operation, 
    /// including the return code and any error messages if the operation fails.</returns>
    /// <exception cref="Exception">Thrown if the update operation fails, indicated by a non-zero return code, or if an error occurs during  the
    /// SOAP request or response processing.</exception>
    public async Task<OrderVersionPostageUpdateResult> OrderVersionPostageUpdateAsync(ValidationSoapHeader auth, OrderVersionPostageUpdateRequestBody request)
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

        var result = XmlParsing.DeserializeXmlToObject<OrderVersionPostageUpdateResult>(response.OrderVersionPostageUpdateResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("OrderVersionPostageUpdateAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"OrderVersionPostageUpdateAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    
    /// <summary>
    /// Retrieves a list of order version postage records asynchronously via a SOAP request.
    /// </summary>
    /// <remarks>
    /// This method serializes the provided request body to XML and sends it to the SOAP service using the authentication header.
    /// The response is deserialized into an <see cref="OrderVersionPostageListResult"/> object. If the operation fails, an exception is thrown with details from the response.
    /// </remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the SOAP request.</param>
    /// <param name="request">The request body specifying the parameters for the postage list query. Cannot be <c>null</c>.</param>
    /// <returns>
    /// An <see cref="OrderVersionPostageListResult"/> containing postage details and status information for the requested order version.
    /// </returns>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is <c>null</c>.</exception>
    /// <exception cref="Exception">
    /// Thrown if the SOAP service returns a non-zero return code, indicating a failure. The exception message includes the return code and error details.
    /// </exception>
    public async Task<OrderVersionPostageListResult> OrderVersionPostageListAsync(ValidationSoapHeader auth, OrderVersionPostageListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(OrderVersionPostageListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(OrderVersionPostageListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        OrderVersionPostageListResponse response;

        Log.Information("Sending OrderVersionPostageListAsync SOAP request");

        try
        {
            response = await _soap.OrderVersionPostageListAsync(new OrderVersionPostageListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("OrderVersionPostageListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderVersionPostageListAsync Response: {@res}", response.OrderVersionPostageListResult);

        var result = XmlParsing.DeserializeXmlToObject<OrderVersionPostageListResult>(response.OrderVersionPostageListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("OrderVersionPostageListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"OrderVersionPostageListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to insert postage details for a specific order version and returns the result of the
    /// operation.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes. If the operation
    /// fails,  an exception is thrown with details about the failure.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the input parameters for the postage detail insertion operation.</param>
    /// <returns>An <see cref="OrderVersionPostageDetailInsertResult"/> object containing the result of the operation,  including
    /// the return code and any associated errors.</returns>
    /// <exception cref="Exception">Thrown if the operation fails with a non-zero return code or if an unexpected error occurs during the SOAP
    /// request.</exception>
    public async Task<OrderVersionPostageDetailInsertResult> OrderVersionPostageDetailInsertAsync(ValidationSoapHeader auth, OrderVersionPostageDetailInsertRequestBody request)
    {
        Log.Information("Converting {@type} to Xml", typeof(OrderVersionPostageDetailInsertRequestBody));
        Log.Debug("{@type}: {@req}", typeof(OrderVersionPostageDetailInsertRequestBody), FileOutput.CreateXmlFromClass(request));

        string xmlInput = FileOutput.CreateXmlFromClass(request);

        OrderVersionPostageDetailInsertResponse response;

        Log.Information("Sending OrderVersionPostageDetailInsertAsync SOAP request for PostageID: {@v}",
            request.InputParameter.OrderVersionPostageID);

        try
        {
            response = await _soap.OrderVersionPostageDetailInsertAsync(new OrderVersionPostageDetailInsertRequest
            {
                ValidationSoapHeader = auth,
                inputXML = xmlInput
            });
        }
        catch (Exception ex)
        {
            Log.Error("OrderVersionPostageDetailInsertAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderVersionPostageDetailInsertAsync Response: {@response}", response.OrderVersionPostageDetailInsertResult);

        var result = XmlParsing.DeserializeXmlToObject<OrderVersionPostageDetailInsertResult>(response.OrderVersionPostageDetailInsertResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("OrderVersionPostageDetailInsertAsync failed with return code: {@code} and error: {@error}",
                result.ReturnCode, result.ReturnErrors);
            throw new Exception($"OrderVersionPostageDetailInsertAsync failed with return code {result.ReturnCode}: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Retrieves a list of order version postage detail records asynchronously via a SOAP request.
    /// </summary>
    /// <remarks>
    /// This method serializes the provided request body to XML and sends it to the SOAP service using the authentication header.
    /// The response is deserialized into an <see cref="OrderVersionPostageDetailListResult"/> object. If the operation fails, an exception is thrown with details from the response.
    /// </remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the SOAP request.</param>
    /// <param name="request">The request body specifying the parameters for the postage detail list query. Cannot be <c>null</c>.</param>
    /// <returns>
    /// An <see cref="OrderVersionPostageDetailListResult"/> containing postage detail records and status information for the requested order version.
    /// </returns>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is <c>null</c>.</exception>
    /// <exception cref="Exception">
    /// Thrown if the SOAP service returns a non-zero return code, indicating a failure. The exception message includes the return code and error details.
    /// </exception>
    public async Task<OrderVersionPostageDetailListResult> OrderVersionPostageDetailListAsync(ValidationSoapHeader auth, OrderVersionPostageDetailListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        OrderVersionPostageDetailListResponse response;

        Log.Information("Converting {@type} to Xml", typeof(OrderVersionPostageDetailListRequestBody));
        Log.Debug("{@type}: {@req}", typeof(OrderVersionPostageDetailListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending OrderVersionPostageDetailListAsync SOAP request");

        try
        {
            response = await _soap.OrderVersionPostageDetailListAsync(new OrderVersionPostageDetailListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

        }
        catch (Exception ex)
        {
            Log.Error("OrderVersionPostageDetailListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderVersionPostageDetailListAsync Response: {@res}", response.OrderVersionPostageDetailListResult);

        var result = XmlParsing.DeserializeXmlToObject<OrderVersionPostageDetailListResult>(response.OrderVersionPostageDetailListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("OrderVersionPostageDetailListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"OrderVersionPostageDetailListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Updates the postage details for a specific order version asynchronously.
    /// </summary>
    /// <remarks>This method sends a SOAP request to update the postage details for a specific order version. 
    /// The request includes authentication information and the input parameters serialized as XML.  If the operation
    /// fails, an exception is thrown with details about the failure.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the input parameters for the postage detail update operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains an 
    /// <OrderVersionPostageDetailUpdateResult> object, which includes the outcome of the update operation.</returns>
    /// <exception cref="Exception">Thrown if the update operation fails, including cases where the return code from the SOAP response  indicates an
    /// error. The exception message contains the return code and error details.</exception>
    public async Task<OrderVersionPostageDetailUpdateResult> OrderVersionPostageDetailUpdateAsync(ValidationSoapHeader auth, OrderVersionPostageDetailUpdateRequestBody request)
    {
        Log.Information("Converting {@type} to Xml", typeof(OrderVersionPostageDetailUpdateRequestBody));
        Log.Debug("{@type}: {@req}", typeof(OrderVersionPostageDetailUpdateRequestBody), FileOutput.CreateXmlFromClass(request));

        string xmlInput = FileOutput.CreateXmlFromClass(request);

        OrderVersionPostageDetailUpdateResponse response;

        Log.Information("Sending OrderVersionPostageDetailUpdateAsync SOAP request for PostageDetailID: {@v}",
            request.InputParameter.OrederVersionPostageDetailID);

        try
        {
            response = await _soap.OrderVersionPostageDetailUpdateAsync(new OrderVersionPostageDetailUpdateRequest
            {
                ValidationSoapHeader = auth,
                inputXML = xmlInput
            });
        }
        catch (Exception ex)
        {
            Log.Error("OrderVersionPostageDetailUpdateAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderVersionPostageDetailUpdateAsync Response: {@response}", response.OrderVersionPostageDetailUpdateResult);

        var result = XmlParsing.DeserializeXmlToObject<OrderVersionPostageDetailUpdateResult>(response.OrderVersionPostageDetailUpdateResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("OrderVersionPostageDetailUpdateAsync failed with return code: {@code} and error: {@error}",
                result.ReturnCode, result.ReturnErrors);
            throw new Exception($"OrderVersionPostageDetailUpdateAsync failed with return code {result.ReturnCode}: {result.ReturnErrors}");
        }

        return result;
    }
}
