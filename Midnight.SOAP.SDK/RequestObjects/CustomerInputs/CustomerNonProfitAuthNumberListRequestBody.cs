using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.CustomerInputs;

/// <summary>
/// Represents the request body for listing customer non-profit authorization numbers in the Midnight SOAP API.
/// </summary>
[XmlRoot("CustomerList")]
public class CustomerNonProfitAuthNumberListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the customer non-profit auth number list request.
    /// </summary>
    public required CustomerNonProfitAuthNumberListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing customer non-profit authorization numbers in the Midnight SOAP API.
/// </summary>
public class CustomerNonProfitAuthNumberListInputParameter
{
    /// <summary>Gets or sets the customer ID.</summary>
    public required int CustomerID { get; set; }
}