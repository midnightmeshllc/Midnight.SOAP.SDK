using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.CustomerInputs;

/// <summary>
/// Represents the request body for listing customer permit numbers in the Midnight SOAP API.
/// </summary>
[XmlRoot("CustomerList")]
public class CustomerPermitNumberListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the customer permit number list request.
    /// </summary>
    public required CustomerPermitNumberListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing customer permit numbers in the Midnight SOAP API.
/// </summary>
public class CustomerPermitNumberListInputParameter
{
    /// <summary>Gets or sets the customer ID.</summary>
    public required int CustomerID { get; set; }
}