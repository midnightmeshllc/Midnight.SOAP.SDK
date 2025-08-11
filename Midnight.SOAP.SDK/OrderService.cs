using Midnight.SOAP.SDK.Models;
using Midnight.SOAP.SDK.RequestObjects.OrderInputs;
using Midnight.SOAP.SDK.ResponseObjects.OrderOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

/// <summary>
/// Provides methods for interacting with orders via SOAP-based web services.
/// </summary>
/// <remarks>The <see cref="OrderService"/> class facilitates operations such as retrieving, adding, and updating
/// orders by sending SOAP requests to a remote service. Each method in this class requires authentication credentials
/// and properly formatted request objects. This class is designed for asynchronous operations and ensures that
/// responses are parsed into appropriate models for further processing.</remarks>
public class OrderService
{

    private readonly Service1SoapClient.EndpointConfiguration _soapConfig;
    private readonly Service1Soap _soap;
    public OrderService()
    {
        _soapConfig = new Service1SoapClient.EndpointConfiguration();
        _soap = new Service1SoapClient(_soapConfig);
    }

    /// <summary>
    /// Retrieves a list of orders based on the provided request parameters.
    /// </summary>
    /// <remarks>This method sends a SOAP request to retrieve order data and parses the response into a list
    /// of  <see cref="OrderModel"/> objects. Ensure that the <paramref name="auth"/> parameter contains valid 
    /// credentials and that the <paramref name="request"/> parameter is properly populated.</remarks>
    /// <param name="auth">The authentication header containing validation credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the parameters for filtering and retrieving the order list. Cannot be <see
    /// langword="null"/>.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of  <see cref="OrderModel"/>
    /// objects representing the retrieved orders.</returns>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is <see langword="null"/>.</exception>
    public async Task<OrderListResult> OrderListAsync(ValidationSoapHeader auth, OrderListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        OrderListResponse response;

        Log.Information("Converting {@type} to Xml", typeof(OrderListRequestBody));
        Log.Debug("{@type}: {@req}", typeof(OrderListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending OrderListAsync SOAP request");

        try
        {
            response = await _soap.OrderListAsync(new OrderListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

        }
        catch (Exception ex)
        {
            Log.Error("OrderListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderListAsync Response: {@res}", response.OrderListResult);

        var result = XmlParsing.DeserializeXmlToObject<OrderListResult>(response.OrderListResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("OrderListAsync failed with ReturnCode: {@code}, Errors: {@errors}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"OrderListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }


    /// <summary>
    /// Sends a SOAP request to perform a quick add operation for an order.
    /// </summary>
    /// <remarks>This method converts the provided <paramref name="request"/> object into XML format and sends
    /// it as part of the SOAP request. Ensure that the <paramref name="auth"/> parameter contains valid credentials, as
    /// the operation requires authentication.</remarks>
    /// <param name="auth">The authentication header containing validation credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the order details to be added.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the response from the SOAP service,
    /// including the result of the quick add operation.</returns>
    public async Task<OrderQuickAddResponse> OrderQuickAddAsync(ValidationSoapHeader auth, OrderQuickAddRequestBody request)
    {

        OrderQuickAddResponse response;

        Log.Information("Covnerting {@type} to Xml", typeof(OrderQuickAddRequestBody));
        Log.Debug("{@type}: {@req}", typeof(OrderQuickAddRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending OrderQuickAddAsync SOAP request");

        try
        {
            response = await _soap.OrderQuickAddAsync(new OrderQuickAddRequest
            {
                ValidationSoapHeader = auth,
                sXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("OrderQuickAddAsync Excpetion: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderQuickAddAsync Response: {@res}", response.OrderQuickAddResult);

        return response;
    }


    /// <summary>
    /// Sends an asynchronous SOAP request to update an order based on the provided request data.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes. Ensure that the
    /// <paramref name="auth"/> parameter contains valid credentials and the <paramref name="request"/> parameter is
    /// properly populated before calling this method.</remarks>
    /// <param name="auth">The authentication header containing validation credentials required for the SOAP request. Cannot be null.</param>
    /// <param name="request">The request body containing the order update details. This must include all required fields for the order update
    /// operation.</param>
    /// <returns>A <see cref="OrderUpdateResponse"/> object containing the result of the order update operation. The response
    /// includes details about the success or failure of the update.</returns>
    public async Task<OrderUpdateResponse> OrderUpdateAsync(ValidationSoapHeader auth, OrderUpdateRequestBody request)
    {

        OrderUpdateResponse response;

        Log.Information("Converting {@type} to Xml", typeof(OrderUpdateRequestBody));
        Log.Debug("{@type}: {@req}", typeof(OrderUpdateRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending OrderUpdateAsync SOAP request");

        try
        {
            response = await _soap.OrderUpdateAsync(new OrderUpdateRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("OrderUpdateAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderUpdateAsync Response: {@res}", response.OrderUpdateResult);

        return response;
    }

    /// <summary>
    /// Sends a new order request asynchronously using SOAP and returns the response.
    /// </summary>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the details of the new order to be processed.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the response from the SOAP service, 
    /// including the result of the order processing.</returns>
    public async Task<OrderNewResult> OrderNewAsync(ValidationSoapHeader auth, OrderNewRequestBody request)
    {
        OrderNewResponse response;

        Log.Information("Converting {@type} to Xml", typeof(OrderNewRequestBody));
        Log.Debug("{@type}: {@req}", typeof(OrderNewRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending OrderNewAsync SOAP request");
        try
        {
            response = await _soap.OrderNewAsync(new OrderNewRequest
            {
                ValidationSoapHeader = auth,
                sXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("OrderNewAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderNewAsync Response: {@res}", response.OrderNewResult);

        var result = XmlParsing.DeserializeXmlToObject<OrderNewResult>(response.OrderNewResult);

        if ( result.ReturnCode != 0)
        {
            Log.Error("OrderNewAsync failed with ReturnCode: {@code}, Errors: {@errors}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"OrderNewAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }
}
