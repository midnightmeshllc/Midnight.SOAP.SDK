namespace Midnight.SOAP.SDK.RequestObjects.CustomerInputs;

/// <summary>
/// Represents the request body for listing customer mailer IDs in the Midnight SOAP API.
/// </summary>
public class CustomerMailerIDListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the customer mailer ID list request.
    /// </summary>
    public required CustomerMailerIDListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing customer mailer IDs in the Midnight SOAP API.
/// </summary>
public class CustomerMailerIDListInputParameter
{
    /// <summary>Gets or sets the customer ID.</summary>
    public required int CustomerID { get; set; }
}