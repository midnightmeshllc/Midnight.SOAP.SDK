using Midnight.SOAP.SDK.Models;
using Midnight.SOAP.SDK.RequestObjects.OrderVersionDetailInputs;
using Midnight.SOAP.SDK.ResponseObjects.OrderVersionDetailOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

/// <summary>
/// Provides methods for interacting with order version details via SOAP requests.
/// </summary>
/// <remarks>This service includes functionality to retrieve, insert, and update order version details using
/// asynchronous SOAP operations. Each method requires valid authentication credentials and properly formatted request
/// bodies.</remarks>
public class OrderVersionDetailService
{
    private readonly Service1SoapClient.EndpointConfiguration _soapConfig;
    private readonly Service1Soap _soap;

    public OrderVersionDetailService()
    {
        _soapConfig = new Service1SoapClient.EndpointConfiguration();
        _soap = new Service1SoapClient(_soapConfig);
    }

    /// <summary>
    /// Sends a SOAP request to retrieve a list of order version details and parses the response into a list of <see
    /// cref="Details"/> objects.
    /// </summary>
    /// <remarks>This method logs the request and response data for debugging purposes. Ensure that the
    /// <paramref name="auth"/> parameter contains valid credentials and the <paramref name="request"/> parameter is
    /// properly populated before calling this method.</remarks>
    /// <param name="auth">The authentication header containing validation credentials for the SOAP request. This parameter cannot be null.</param>
    /// <param name="request">The request body containing the input data for the SOAP operation. This parameter cannot be null.</param>
    /// <returns>A list of <see cref="Details"/> objects parsed from the SOAP response. Returns an empty list if no details are
    /// found.</returns>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is null.</exception>
    public async Task<List<Details>> OrderVersionDetailListAsync(ValidationSoapHeader auth, OrderVersionDetailListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        OrderVersionDetailListResponse response;
        List<Details> parsedResponse;

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

            Log.Information("Parsing OrderVersionDetailListAsync response into List of {@type}", typeof(Details));

            parsedResponse = XmlParser.GetOrderVersionDetailData(response.OrderVersionDetailListResult);

        }
        catch (Exception ex)
        {
            Log.Error("OrderVersionDetailListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderVersionDetailListAsync Response: {@res}", response.OrderVersionDetailListResult);

        return parsedResponse;
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
    /// Sends a SOAP request to update the details of an order version.
    /// </summary>
    /// <remarks>This method converts the provided request body into XML format and sends it as part of the
    /// SOAP request. Ensure that <paramref name="auth"/> contains valid credentials and <paramref name="request"/>
    /// includes all required parameters for the update operation.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the parameters for the order version detail update.</param>
    /// <returns>A <see cref="OrderVersionDetailUpdateResponse"/> object containing the result of the update operation.</returns>
    public async Task<OrderVersionDetailUpdateResponse> OrderVersionDetailUpdateAsync(ValidationSoapHeader auth, OrderVersionDetailUpdateRequestBody request)
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

        return response;
    }
}
