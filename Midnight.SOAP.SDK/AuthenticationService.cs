using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

/// <summary>
/// Provides methods for authenticating clients and managing authentication-related operations. 
/// IMPORTANT: Must inject output of Utilities.SoapClient.Configure().
/// </summary>
/// <remarks>The <see cref="AuthenticationService"/> class is designed to handle client authentication using a
/// developer token. It interacts with the underlying SOAP service to retrieve necessary information, such as the web
/// service version, and returns authentication headers required for subsequent API calls. Ensure that the provided
/// developer token is valid before using this service.</remarks>
/// <param name="_soap"></param>
public class AuthenticationService(Service1Soap _soap)
{

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
