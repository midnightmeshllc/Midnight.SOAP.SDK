using Midnight.SOAP.SDK.RequestObjects.OrderVersionInputs;
using Midnight.SOAP.SDK.ResponseObjects.OrderOutputs;
using Midnight.SOAP.SDK.ResponseObjects.OrderVersionOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

/// <summary>
/// Provides methods for managing order versions through SOAP requests.
/// IMPORTANT: Must inject output of Utilities.SoapClient.Configure().
/// </summary>
/// <remarks>This service facilitates operations such as retrieving, adding, updating, deleting, and completing
/// order versions by interacting with an external SOAP-based API. Each method in this service handles the conversion of
/// request objects to XML, sends the SOAP request, and processes the response into strongly-typed result objects.
/// Exceptions are logged and rethrown for error handling.</remarks>
/// <param name="_soap"></param>
public class OrderVersionService(Service1Soap _soap)
{

    /// <summary>
    /// Sends a SOAP request to retrieve and order a list of versions based on the provided input parameters.
    /// </summary>
    /// <remarks>This method converts the provided request object into XML, sends it as part of a SOAP
    /// request,  and parses the response into a list of <see cref="Versions"/> objects.  If the request fails or an
    /// exception occurs, the method logs the error and rethrows the exception.</remarks>
    /// <param name="auth">The authentication header required for the SOAP request. Must not be null.</param>
    /// <param name="request">The request body containing the input parameters for ordering the version list.  Must not be null and must
    /// include valid data for processing.</param>
    /// <returns>A list of <see cref="Versions"/> objects representing the ordered version data retrieved from the SOAP response.
    /// Returns an empty list if no versions are found.</returns>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is null.</exception>
    public async Task<OrderVersionListResult> OrderVersionListAsync(ValidationSoapHeader auth, OrderVersionListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        OrderVersionListResponse response;

        Log.Information("Converting {@type} to Xml", typeof(OrderVersionListRequestBody));
        Log.Debug("{@type}: {@req}", typeof(OrderVersionListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending OrderVersionListAsync SOAP request for OrderID: {@id}", request.InputParameter.OrderID);

        try
        {
            response = await _soap.OrderVersionListAsync(new OrderVersionListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

        }
        catch (Exception ex)
        {
            Log.Error("OrderVersionListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderVersionListAsync Response: {@res}", response.OrderVersionListResult);

        var result = XmlParsing.DeserializeXmlToObject<OrderVersionListResult>(response.OrderVersionListResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("OrderVersionListAsync failed with ReturnCode: {@code}, Errors: {@errors}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"OrderVersionListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;

    }


    /// <summary>
    /// Sends a SOAP request to quickly add a new version of an order and returns the result of the operation.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes.  If the operation
    /// fails, an exception is thrown with details about the failure.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the details of the order version to be added.  This parameter cannot be <see
    /// langword="null"/>.</param>
    /// <returns>An <see cref="OrderVersionQuickAddResult"/> object containing the result of the operation,  including the return
    /// code and any error messages if the operation fails.</returns>
    /// <exception cref="InvalidOperationException">Thrown if the operation fails, as indicated by a non-zero return code in the response. The exception message
    /// includes the return code and error details.</exception>
    public async Task<OrderVersionQuickAddResult> OrderVersionQuickAddAsync(ValidationSoapHeader auth, OrderVersionQuickAddRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        OrderVersionQuickAddResponse response;

        Log.Information("Converting {@type} to Xml", typeof(OrderVersionQuickAddRequestBody));
        Log.Debug("{@type}: {@req}", typeof(OrderVersionQuickAddRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending OrderVersionQuickAddAsync SOAP request for Order: {@order} with VersionName: {@vname}",
            request.OrderVersion.OrderNumber, request.OrderVersion.VersionName);

        try
        {
            response = await _soap.OrderVersionQuickAddAsync(new OrderVersionQuickAddRequest
            {
                ValidationSoapHeader = auth,
                sXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("OrderVersionQuickAddAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderVersionQuickAddAsync Response: {@res}", response.OrderVersionQuickAddResult);

        var result = XmlParsing.DeserializeXmlToObject<OrderVersionQuickAddResult>(response.OrderVersionQuickAddResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("OrderVersionQuickAddAsync failed with ReturnCode: {@code} and Errors: {@msg}", result.ReturnCode, result.ReturnErrors);
            throw new InvalidOperationException($"OrderVersionQuickAddAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }


    /// <summary>
    /// Sends a SOAP request to update the version of an order and returns the result of the operation.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes. If the operation
    /// fails, an exception is thrown with details about the failure.</remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the request.</param>
    /// <param name="request">The request body containing the input parameters for the order version update operation.</param>
    /// <returns>An <see cref="OrderVersionUpdateResult"/> object containing the result of the operation, including the return
    /// code and any errors encountered.</returns>
    /// <exception cref="InvalidOperationException">Thrown if the operation fails, indicated by a non-zero return code in the response. The exception message
    /// includes the return code and error details.</exception>
    public async Task<OrderVersionUpdateResult> OrderVersionUpdateAsync(ValidationSoapHeader auth, OrderVersionUpdateRequestBody request)
    {

        OrderVersionUpdateResponse response;

        Log.Information("Converting {@type} to Xml", typeof(OrderVersionUpdateRequestBody));
        Log.Debug("{@type}: {@req}", typeof(OrderVersionUpdateRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending OrderVersionUpdateAsync SOAP request for VersionID: {@vid}", request.InputParameter.VersionID);

        try
        {
            response = await _soap.OrderVersionUpdateAsync(new OrderVersionUpdateRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("OrderVersionUpdateAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderVersionUpdateAsync Response: {@res}", response.OrderVersionUpdateResult);

        var result = XmlParsing.DeserializeXmlToObject<OrderVersionUpdateResult>(response.OrderVersionUpdateResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("OrderVersionUpdateAsync failed with ReturnCode: {@code} and Errors: {@msg}", result.ReturnCode, result.ReturnErrors);
            throw new InvalidOperationException($"OrderVersionUpdateAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }


    /// <summary>
    /// Deletes a specific version of an order permanently using the provided SOAP request.
    /// </summary>
    /// <remarks>This method sends a SOAP request to delete a specific order version identified by the version
    /// ID. The operation is permanent and cannot be undone. Ensure that the version ID is correct before calling this
    /// method.</remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the request.</param>
    /// <param name="request">The request body containing the input parameters, including the version ID of the order to be deleted.</param>
    /// <returns>An <see cref="OrderVersionDeleteResult"/> object containing the result of the delete operation,  including the
    /// return code and any associated error messages.</returns>
    /// <exception cref="InvalidOperationException">Thrown if the operation fails, indicated by a non-zero return code in the response.</exception>
    public async Task<OrderVersionDeleteResult> OrderVersionDeleteAsync(ValidationSoapHeader auth, OrderVersionDeleteRequestBody request)
    {
        Log.Warning("PERMANENT ACTION: VersionID {@vid} will not be recoverable", request.InputParameter.VersionID);

        OrderVersionDeleteResponse response;

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending OrderVersionDeleteAsync SOAP request for VersionID: {@vid}", request.InputParameter.VersionID);

        try
        {
            response = await _soap.OrderVersionDeleteAsync(new OrderVersionDeleteRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("OrderVersionDeleteAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderVersionDeleteAsync Response: {@res}", response.OrderVersionDeleteResult);

        var result = XmlParsing.DeserializeXmlToObject<OrderVersionDeleteResult>(response.OrderVersionDeleteResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("OrderVersionDeleteAsync failed with ReturnCode: {@code} and Errors: {@msg}", result.ReturnCode, result.ReturnErrors);
            throw new InvalidOperationException($"OrderVersionDeleteAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to create a new version of an order and retrieves the result.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes. If the operation
    /// fails, the method logs the error details before throwing an exception.</remarks>
    /// <param name="auth">The authentication header containing credentials for the SOAP request.</param>
    /// <param name="request">The request body containing the input parameters required to create a new order version. This parameter cannot
    /// be <see langword="null"/>.</param>
    /// <returns>An <see cref="OrderVersionNewResult"/> object containing the result of the operation, including the return code
    /// and any associated errors.</returns>
    /// <exception cref="InvalidOperationException">Thrown if the operation fails, indicated by a non-zero return code in the response. The exception message
    /// includes the return code and any associated error messages.</exception>
    public async Task<OrderVersionNewResult> OrderVersionNewAsync(ValidationSoapHeader auth, OrderVersionNewRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);
        OrderVersionNewResponse response;

        Log.Information("Converting {@type} to Xml", typeof(OrderVersionNewRequestBody));
        Log.Debug("{@type}: {@req}", typeof(OrderVersionNewRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending OrderVersionNewAsync SOAP request for OrderID: {@id}", request.InputParameter.OrderID);

        try
        {
            response = await _soap.OrderVersionNewAsync(new OrderVersionNewRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("OrderVersionNewAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderVersionNewAsync Response: {@res}", response.OrderVersionNewResult);

        var result = XmlParsing.DeserializeXmlToObject<OrderVersionNewResult>(response.OrderVersionNewResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("OrderVersionNewAsync failed with ReturnCode: {@code} and Errors: {@msg}", result.ReturnCode, result.ReturnErrors);
            throw new InvalidOperationException($"OrderVersionNewAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Completes the specified order version by sending a SOAP request to the external service.
    /// </summary>
    /// <remarks>This method sends a SOAP request to complete an order version identified by the
    /// <c>VersionID</c> in the request. If the operation fails, an <see cref="InvalidOperationException"/> is thrown
    /// with details about the failure.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the input parameters for completing the order version.</param>
    /// <returns>A <see cref="OrderVersionCompleteResult"/> object containing the result of the operation, including the return
    /// code and any errors.</returns>
    /// <exception cref="InvalidOperationException">Thrown if the operation fails, indicated by a non-zero return code in the response.</exception>
    public async Task<OrderVersionCompleteResult> OrderVersionCompleteAsync(ValidationSoapHeader auth, OrderVersionCompleteRequestBody request)
    {

        OrderVersionCompleteResponse response;

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending OrderVersionCompleteAsync SOAP request for VersionID: {@vid}", request.InputParameter.VersionID);

        try
        {
            response = await _soap.OrderVersionCompleteAsync(new OrderVersionCompleteRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("OrderVersionCompleteAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderVersionCompleteAsync Response: {@res}", response.OrderVersionCompleteResult);

        var result = XmlParsing.DeserializeXmlToObject<OrderVersionCompleteResult>(response.OrderVersionCompleteResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("OrderVersionCompleteAsync failed with ReturnCode: {@code} and Errors: {@msg}", result.ReturnCode, result.ReturnErrors);
            throw new InvalidOperationException($"OrderVersionCompleteAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }
}
