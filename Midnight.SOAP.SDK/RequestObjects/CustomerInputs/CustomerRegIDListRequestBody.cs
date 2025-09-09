using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.CustomerInputs;

/// <summary>
/// Represents the request body for listing customer registration IDs in the Midnight SOAP API.
/// </summary>
[XmlRoot("CustomerList")]
public class CustomerRegIDListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the customer registration ID list request.
    /// </summary>
    public required CustomerRegIDListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing customer registration IDs in the Midnight SOAP API.
/// </summary>
public class CustomerRegIDListInputParameter
{
    /// <summary>Gets or sets the customer ID.</summary>
    public required int CustomerID { get; set; }
}