using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.CustomerInputs;

/// <summary>
/// Represents the request body for listing customer postage accounts in the Midnight SOAP API.
/// </summary>
[XmlRoot("CustomerPostageAccountList")]
public class CustomerPostageAccountListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the customer postage account list request.
    /// </summary>
    public required CustomerPostageAccountListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing customer postage accounts in the Midnight SOAP API.
/// </summary>
public class CustomerPostageAccountListInputParameter
{
    /// <summary>Gets or sets the postage account ID.</summary>
    public int? PostageAccountID { get; set; }
    /// <summary>Gets or sets the customer ID.</summary>
    public required int CustomerID { get; set; }
    /// <summary>Gets or sets the account number.</summary>
    public string? AccountNumber { get; set; }
    /// <summary>Gets or sets a value indicating whether the postage account is active.</summary>
    public bool Active { get; set; } = true;
}