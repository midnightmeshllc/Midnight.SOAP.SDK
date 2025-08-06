
using Midnight.SOAP.SDK.RequestObjects.JobCostInputs;
using Midnight.SOAP.SDK.RequestObjects.OrderShipmentInputs;
using Midnight.SOAP.SDK.ResponseObjects.JobCostOutputs;
using Midnight.SOAP.SDK.ResponseObjects.OrderShipmentOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

public class OrderShipmentService
{
    private readonly Service1SoapClient.EndpointConfiguration _soapConfig;
    private readonly Service1Soap _soap;
    public OrderShipmentService()
    {
        _soapConfig = new Service1SoapClient.EndpointConfiguration();
        _soap = new Service1SoapClient(_soapConfig);
    }


    public async Task<OrderShipmentNewResult> OrderShipmentNewAsync(ValidationSoapHeader auth, OrderShipmentNewRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(OrderShipmentNewRequestBody)} to Xml");
        Log.Debug($"{typeof(OrderShipmentNewRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        OrderShipmentNewResponse response;

        Log.Information($"Sending OrderShipmentNewAsync SOAP request");

        try
        {
            response = await _soap.OrderShipmentNewAsync(new OrderShipmentNewRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error occurred while sending OrderShipmentNewAsync SOAP request");
            throw;
        }

        Log.Debug($"{typeof(OrderShipmentNewResult)}: {FileOutput.CreateXmlFromClass(response)}");

        var result = XmlParsing.DeserializeXmlToObject<OrderShipmentNewResult>(response.OrderShipmentNewResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("OrderShipmentNewAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"OrderShipmentNewAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }
}
