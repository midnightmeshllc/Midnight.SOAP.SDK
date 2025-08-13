using Midnight.SOAP.SDK.RequestObjects.OrderVersionPostageDetailInputs;
using Midnight.SOAP.SDK.ResponseObjects.OrderVersionPostageDetailOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

public class OrderVersionPostageDetailService
{
    private readonly Service1SoapClient.EndpointConfiguration _soapConfig;
    private readonly Service1Soap _soap;
    public OrderVersionPostageDetailService()
    {
        _soapConfig = new Service1SoapClient.EndpointConfiguration();
        _soap = new Service1SoapClient(_soapConfig);
    }

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
}
