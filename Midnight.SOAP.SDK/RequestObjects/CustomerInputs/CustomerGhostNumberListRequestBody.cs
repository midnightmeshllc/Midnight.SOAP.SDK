using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.CustomerInputs;

/// <summary>
/// Represents the request body for listing customer ghost numbers in the Midnight SOAP API.
/// </summary>
[XmlRoot("CustomerList")]
public class CustomerGhostNumberListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the customer ghost number list request.
    /// </summary>
    public required CustomerGhostNumberListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing customer ghost numbers in the Midnight SOAP API.
/// </summary>
public class CustomerGhostNumberListInputParameter
{
    /// <summary>Gets or sets the customer ID.</summary>
    public required int CustomerID { get; set; }
}