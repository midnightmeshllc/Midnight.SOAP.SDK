using Midnight.SOAP.SDK.RequestObjects.OrderVersionDropInputs;
using Midnight.SOAP.SDK.ResponseObjects.OrderVersionDropOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

/// <summary>
/// Provides methods for interacting with the SOAP service to manage order version drops.
/// </summary>
/// <remarks>This service includes functionality to retrieve, insert, and update order version drop information
/// via asynchronous SOAP requests. Each method requires authentication and properly formatted request objects. Ensure
/// that the provided parameters meet the required conditions to avoid exceptions.</remarks>
public class OrderVersionDropService
{
    private readonly Service1SoapClient.EndpointConfiguration _soapConfig;
    private readonly Service1Soap _soap;
    public OrderVersionDropService()
    {
        _soapConfig = new Service1SoapClient.EndpointConfiguration();
        _soap = new Service1SoapClient(_soapConfig);
    }


    /// <summary>
    /// Sends a SOAP request to retrieve a list of drops associated with a specific order version and parses the
    /// response.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes. Ensure that the
    /// <paramref name="auth"/> parameter contains valid credentials.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the parameters needed to query the order version drop list. Cannot be <see
    /// langword="null"/>.</param>
    /// <returns>A list of <see cref="Drops"/> objects representing the parsed response data. Returns an empty list if no drops
    /// are found.</returns>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is <see langword="null"/>.</exception>
    public async Task<OrderVersionDropListResult> OrderVersionDropListAsync(ValidationSoapHeader auth, OrderVersionDropListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        OrderVersionDropListResponse response;

        Log.Information("Converting {@type} to Xml", typeof(OrderVersionDropListRequestBody));
        Log.Debug("{@type}: {@req}", typeof(OrderVersionDropListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending OrderVersionDropListAsync SOAP request");

        try
        {
            response = await _soap.OrderVersionDropListAsync(new OrderVersionDropListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

        }
        catch (Exception ex)
        {
            Log.Error("OrderVersionDropListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderVersionDropListAsync Response: {@res}", response.OrderVersionDropListResult);

        var result = XmlParsing.DeserializeXmlToObject<OrderVersionDropListResult>(response.OrderVersionDropListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("OrderVersionDropListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"OrderVersionDropListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to insert or drop an order version and returns the result of the operation.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes. If the operation
    /// fails, an exception is thrown with details about the failure.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the input parameters for the operation, including the version ID and other details.</param>
    /// <returns>An <see cref="OrderVersionDropInsertResult"/> object containing the result of the operation, including the
    /// return code and any error messages.</returns>
    /// <exception cref="Exception">Thrown if the operation fails with a non-zero return code or if an error occurs during the SOAP request.</exception>
    public async Task<OrderVersionDropInsertResult> OrderVersionDropInsertAsync(ValidationSoapHeader auth, OrderVersionDropInsertRequestBody request)
    {

        Log.Information("Converting {@type} to Xml", typeof(OrderVersionDropInsertRequestBody));
        Log.Debug("{@type}: {@req}", typeof(OrderVersionDropInsertRequestBody), FileOutput.CreateXmlFromClass(request));

        string xmlInput = FileOutput.CreateXmlFromClass(request);

        OrderVersionDropInsertResponse response;

        Log.Information("Sending OrderVersionDropInsertAsync SOAP request for VersionID: {@v}", request.InputParameter.VersionID);

        try
        {
            response = await _soap.OrderVersionDropInsertAsync(new OrderVersionDropInsertRequest
            {
                ValidationSoapHeader = auth,
                inputXML = xmlInput
            });
        }
        catch (Exception ex)
        {
            Log.Error("OrderVersionDropInsertAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderVersionDropInsertAsync Response: {@res}", response.OrderVersionDropInsertResult);

        var result = XmlParsing.DeserializeXmlToObject<OrderVersionDropInsertResult>(response.OrderVersionDropInsertResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("OrderVersionDropInsertAsync failed with ReturnCode: {@code}, Errors: {@msg}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"OrderVersionDropInsertAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }


    /// <summary>
    /// Sends a SOAP request to update the order version drop and returns the result of the operation.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes. If the operation
    /// fails,  an exception is thrown with details about the failure, including the return code and error
    /// messages.</remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the request.</param>
    /// <param name="request">The request body containing the input parameters for the order version drop update operation.</param>
    /// <returns>An <see cref="OrderVersionDropUpdateResult"/> object containing the result of the update operation,  including
    /// the return code and any associated errors.</returns>
    /// <exception cref="Exception">Thrown if the operation fails, such as when the return code in the response indicates an error.</exception>
    public async Task<OrderVersionDropUpdateResult> OrderVersionDropUpdateAsync(ValidationSoapHeader auth, OrderVersionDropUpdateRequestBody request)
    {
        Log.Information("Converting {@type} to Xml", typeof(OrderVersionDropUpdateRequestBody));
        Log.Debug("{@type}: {@req}", typeof(OrderVersionDropUpdateRequestBody), FileOutput.CreateXmlFromClass(request));

        string xmlInput = FileOutput.CreateXmlFromClass(request);

        OrderVersionDropUpdateResponse response;

        Log.Information("Sending OrderVersionDropUpdateAsync SOAP request for DropID: {@d}", request.InputParameter.OrderVersionDropID);

        try
        {
            response = await _soap.OrderVersionDropUpdateAsync(new OrderVersionDropUpdateRequest
            {
                ValidationSoapHeader = auth,
                inputXML = xmlInput
            });
        }
        catch (Exception ex)
        {
            Log.Error("OrderVersionDropUpdateAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderVersionDropUpdateAsync Response: {@res}", response.OrderVersionDropUpdateResult);

        var result = XmlParsing.DeserializeXmlToObject<OrderVersionDropUpdateResult>(response.OrderVersionDropUpdateResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("OrderVersionDropUpdateAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"OrderVersionDropUpdateAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to delete a specific order version drop and returns the result of the operation.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes. If the operation
    /// fails, the method logs the error and throws an exception.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the details of the order version drop to be deleted. Cannot be <see
    /// langword="null"/>.</param>
    /// <returns>An <see cref="OrderVersionDropDeleteResult"/> object containing the result of the operation, including the
    /// return code and any error messages.</returns>
    /// <exception cref="Exception">Thrown if the operation fails with a non-zero return code, or if an error occurs during the SOAP request or
    /// response processing.</exception>
    public async Task<OrderVersionDropDeleteResult> OrderVersionDropDeleteAsync(ValidationSoapHeader auth, OrderVersionDropDeleteRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        OrderVersionDropDeleteResponse response;

        Log.Information("Converting {@type} to Xml", typeof(OrderVersionDropDeleteRequestBody));
        Log.Debug("{@type}: {@req}", typeof(OrderVersionDropDeleteRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending OrderVersionDropDeleteAsync SOAP request");

        try
        {
            response = await _soap.OrderVersionDropDeleteAsync(new OrderVersionDropDeleteRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

        }
        catch (Exception ex)
        {
            Log.Error("OrderVersionDropDeleteAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderVersionDropDeleteAsync Response: {@res}", response.OrderVersionDropDeleteResult);

        var result = XmlParsing.DeserializeXmlToObject<OrderVersionDropDeleteResult>(response.OrderVersionDropDeleteResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("OrderVersionDropDeleteAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"OrderVersionDropDeleteAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }
}
