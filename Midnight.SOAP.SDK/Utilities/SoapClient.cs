using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK.Utilities;

public class SoapClient
{
    public static Service1Soap Configure()
    {
        var endpointConfig = Service1SoapClient.EndpointConfiguration.Service1Soap;
        Service1SoapClient client = new Service1SoapClient(endpointConfig);

        return client;
    }
}
