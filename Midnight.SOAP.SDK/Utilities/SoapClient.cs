using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK.Utilities;

/// <summary>
/// Provides a factory method to configure and create an instance of the <see cref="Service1Soap"/> client.
/// </summary>
/// <remarks>This class simplifies the creation of a <see cref="Service1Soap"/> client by pre-configuring the
/// endpoint using the default <see cref="Service1SoapClient.EndpointConfiguration.Service1Soap"/>
/// configuration.</remarks>
public class SoapClient
{

    /// <summary>
    /// Configures and returns an instance of the <see cref="Service1Soap"/> client.
    /// </summary>
    /// <remarks>This method initializes a new <see cref="Service1SoapClient"/> using the default endpoint
    /// configuration. The returned client is ready to use for invoking SOAP service operations.</remarks>
    /// <returns>An instance of <see cref="Service1Soap"/> configured with the default endpoint.</returns>
    public static Service1Soap Configure()
    {
        var endpointConfig = Service1SoapClient.EndpointConfiguration.Service1Soap;
        Service1SoapClient client = new Service1SoapClient(endpointConfig);

        return client;
    }
}
