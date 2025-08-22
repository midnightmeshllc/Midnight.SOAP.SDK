using Midnight.SOAP.SDK.RequestObjects.OrderVersionDetailInputs;
using Midnight.SOAP.SDK.ResponseObjects.OrderVersionDetailOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

/// <summary>
/// Provides methods for managing order version details through SOAP-based asynchronous operations.
/// IMPORTANT: Must inject output of Utilities.SoapClient.Configure().
/// </summary>
/// <remarks>This service includes functionality to retrieve, insert, update, delete, and query estimated time
/// details for order versions. Each method communicates with a SOAP service, sending serialized XML requests and
/// processing the corresponding responses. Exceptions are thrown for non-zero return codes or unexpected errors, with
/// detailed logging for debugging purposes.</remarks>
/// <param name="_soap"></param>
public class OrderVersionDetailService(Service1Soap _soap)
{
    
    /// <summary>
    /// Retrieves a list of order version details asynchronously via a SOAP request.
    /// </summary>
    /// <param name="auth">The authentication header containing validation credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing parameters for the order version detail list query. Cannot be <c>null</c>.</param>
    /// <returns>
    /// A task representing the asynchronous operation. The task result contains an <see cref="OrderVersionDetailListResult"/> object
    /// with the list of order version details and status information.
    /// </returns>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is <c>null</c>.</exception>
    /// <exception cref="Exception">
    /// Thrown if the SOAP service returns a non-zero return code, indicating a failure. The exception message includes the return code and error details.
    /// </exception>
    public async Task<OrderVersionDetailListResult> OrderVersionDetailListAsync(ValidationSoapHeader auth, OrderVersionDetailListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        OrderVersionDetailListResponse response;

        Log.Information("Converting {@type} to Xml", typeof(OrderVersionDetailListRequestBody));
        Log.Debug("{@type}: {@req}", typeof(OrderVersionDetailListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending OrderVersionDetailListAsync SOAP request");

        try
        {
            response = await _soap.OrderVersionDetailListAsync(new OrderVersionDetailListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

        }
        catch (Exception ex)
        {
            Log.Error("OrderVersionDetailListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderVersionDetailListAsync Response: {@res}", response.OrderVersionDetailListResult);

        var result = XmlParsing.DeserializeXmlToObject<OrderVersionDetailListResult>(response.OrderVersionDetailListResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("OrderVersionDetailListAsync failed with ReturnCode: {@code}, Errors: {@errors}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"OrderVersionDetailListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }


    /// <summary>
    /// Sends a SOAP request to insert order version details asynchronously.
    /// </summary>
    /// <remarks>This method converts the provided <see cref="OrderVersionDetailInsertRequestBody"/> into XML
    /// format and sends it as part of the SOAP request. If an exception occurs during the operation, it is logged and
    /// rethrown.</remarks>
    /// <param name="auth">The authentication header containing validation credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the order version details to be inserted.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the response from the SOAP service,
    /// including the result of the order version detail insertion.</returns>
    public async Task<OrderVersionDetailInsertResult> OrderVersionDetailInsertAsync(ValidationSoapHeader auth, OrderVersionDetailInsertRequestBody request)
    {

        OrderVersionDetailInsertResponse response;

        Log.Information("Converting {@type} to Xml", typeof(OrderVersionDetailInsertRequestBody));
        Log.Debug("{@type}: {@req}", typeof(OrderVersionDetailInsertRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending OrderVersionDetailInsertAsync SOAP request");

        try
        {
            response = await _soap.OrderVersionDetailInsertAsync(new OrderVersionDetailInsertRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("OrderVersionDetailInsertAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderVersionDetailInsertAsync Response: {@res}", response.OrderVersionDetailInsertResult);

        var result = XmlParsing.DeserializeXmlToObject<OrderVersionDetailInsertResult>(response.OrderVersionDetailInsertResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("OrderVersionDetailInsertAsync failed with ReturnCode: {@code} and Errors: {@errors}", 
                result.ReturnCode, result.ReturnErrors);
            throw new Exception($"OrderVersionDetailInsertAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }


    /// <summary>
    /// Sends a SOAP request to update the details of an order version and returns the result of the operation.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes. If the operation
    /// fails,  an exception is thrown with details about the failure, including the return code and error
    /// messages.</remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the request.</param>
    /// <param name="request">The request body containing the input parameters for the order version detail update operation.</param>
    /// <returns>An <see cref="OrderVersionDetailUpdateResult"/> object containing the result of the update operation,  including
    /// the return code and any associated errors.</returns>
    /// <exception cref="Exception">Thrown if the operation fails with a non-zero return code or if an unexpected error occurs during the request.</exception>
    public async Task<OrderVersionDetailUpdateResult> OrderVersionDetailUpdateAsync(ValidationSoapHeader auth, OrderVersionDetailUpdateRequestBody request)
    {

        OrderVersionDetailUpdateResponse response;

        Log.Information("Converting {@type} to Xml", typeof(OrderVersionDetailUpdateRequestBody));
        Log.Debug("{@type}: {@req}", typeof(OrderVersionDetailUpdateRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending OrderVersionDetailUpdateAsync SOAP request for OrderVersionDetailID: {@detailid}", 
            request.InputParameter.OrderVersionDetailID);

        try
        {
            response = await _soap.OrderVersionDetailUpdateAsync(new OrderVersionDetailUpdateRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("OrderVersionDetailupdateAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderVersionDetailUpdateAsync Response: {@res}", response.OrderVersionDetailUpdateResult);

        var result = XmlParsing.DeserializeXmlToObject<OrderVersionDetailUpdateResult>(response.OrderVersionDetailUpdateResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("OrderVersionDetailUpdateAsync failed with ReturnCode: {@code} and Errors: {@errors}",
                result.ReturnCode, result.ReturnErrors);
            throw new Exception($"OrderVersionDetailUpdateAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    
    /// <summary>
    /// Sends a SOAP request to retrieve the estimated time details for an order version.
    /// </summary>
    /// <remarks>
    /// This method serializes the provided request body to XML and sends it to the SOAP service using the authentication header.
    /// The response is deserialized into an <see cref="OrderVersionDetailEstimatedTimeResult"/> object. If the operation fails, an exception is thrown with details from the response.
    /// </remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the SOAP request.</param>
    /// <param name="request">The request body specifying the parameters for the estimated time query. Cannot be <c>null</c>.</param>
    /// <returns>An <see cref="OrderVersionDetailEstimatedTimeResult"/> containing estimated time details and status information for the requested order version.</returns>
    /// <exception cref="Exception">Thrown if the SOAP service returns a non-zero return code, indicating a failure. The exception message includes the return code and error details.</exception>
    public async Task<OrderVersionDetailEstimatedTimeResult> OrderVersionDetailEstimatedTimeAsync(ValidationSoapHeader auth, OrderVersionDetailEstimatedTimeRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);
        OrderVersionDetailEstimatedTimeResponse response;

        Log.Information("Converting {@type} to Xml", typeof(OrderVersionDetailEstimatedTimeRequestBody));
        Log.Debug("{@type}: {@req}", typeof(OrderVersionDetailEstimatedTimeRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending OrderVersionDetailEstimatedTimeAsync SOAP request");

        try
        {
            response = await _soap.OrderVersionDetailEstimatedTimeAsync(new OrderVersionDetailEstimatedTimeRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("OrderVersionDetailEstimatedTimeAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderVersionDetailEstimatedTimeAsync Response: {@res}", response.OrderVersionDetailEstimatedTimeResult);

        var result = XmlParsing.DeserializeXmlToObject<OrderVersionDetailEstimatedTimeResult>(response.OrderVersionDetailEstimatedTimeResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("OrderVersionDetailEstimatedTimeAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"OrderVersionDetailEstimatedTimeAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;

    }

    /// <summary>
    /// Deletes the details of a specific order version asynchronously using a SOAP request.
    /// </summary>
    /// <remarks>This method sends a SOAP request to delete the specified order version details.  If the
    /// operation fails, an exception is thrown with details about the failure, including the return code and
    /// errors.</remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the request.</param>
    /// <param name="request">The request body containing the details of the order version to be deleted.</param>
    /// <returns>An <see cref="OrderVersionDetailDeleteResult"/> object containing the result of the delete operation,  including
    /// the return code and any associated errors.</returns>
    /// <exception cref="Exception">Thrown if the operation fails with a non-zero return code or if an error occurs during the SOAP request.</exception>
    public async Task<OrderVersionDetailDeleteResult> OrderVersionDetailDeleteAsync(ValidationSoapHeader auth, OrderVersionDetailDeleteRequestBody request)
    {

        OrderVersionDetailDeleteResponse response;

        Log.Information("Converting {@type} to Xml", typeof(OrderVersionDetailDeleteRequestBody));
        Log.Debug("{@type}: {@req}", typeof(OrderVersionDetailDeleteRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending OrderVersionDetailDeleteAsync SOAP request");

        try
        {
            response = await _soap.OrderVersionDetailDeleteAsync(new OrderVersionDetailDeleteRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("OrderVersionDetailDeleteAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderVersionDetailDeleteAsync Response: {@res}", response.OrderVersionDetailDeleteResult);

        var result = XmlParsing.DeserializeXmlToObject<OrderVersionDetailDeleteResult>(response.OrderVersionDetailDeleteResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("OrderVersionDetailDeleteAsync failed with ReturnCode: {@code} and Errors: {@errors}",
                result.ReturnCode, result.ReturnErrors);
            throw new Exception($"OrderVersionDetailDeleteAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }
}
