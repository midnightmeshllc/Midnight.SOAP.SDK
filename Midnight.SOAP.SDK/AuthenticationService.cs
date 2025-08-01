using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

/// <summary>
/// Provides methods for authenticating clients and interacting with the Midnight SOAP API.
/// </summary>
/// <remarks>The <see cref="AuthenticationService"/> class is designed to facilitate client authentication  using
/// developer tokens and to interact with the Midnight SOAP API. It provides an asynchronous  method for obtaining
/// authentication headers required for API requests. Ensure that the developer  token used for authentication is valid
/// and properly configured.</remarks>
public class AuthenticationService
{
    private readonly Service1SoapClient.EndpointConfiguration _soapConfig;
    private readonly Service1SoapClient _soap;
    public AuthenticationService()
    {
        _soapConfig = new Service1SoapClient.EndpointConfiguration();
        _soap = new Service1SoapClient(_soapConfig);
    }

    /// <summary>
    /// Authenticates the client using the provided developer token and returns a validation header.
    /// </summary>
    /// <remarks>The method initializes a validation header with the provided developer token and retrieves
    /// the web service version for logging purposes. Ensure that the developer token is valid before calling this
    /// method.</remarks>
    /// <param name="devToken">The developer token used for authentication. This token must be valid and non-null.</param>
    /// <returns>A <see cref="ValidationSoapHeader"/> object containing the authentication details.</returns>
    public async Task<ValidationSoapHeader> AuthenticateAsync(string devToken)
    {
        Log.Information("Authenticating to Midnight SOAP API Version: {@v}", await _soap._GetWebServiceVersionAsync());

        ValidationSoapHeader _auth = new()
        {
            DevToken = devToken
        };

        return _auth;
    }
}
