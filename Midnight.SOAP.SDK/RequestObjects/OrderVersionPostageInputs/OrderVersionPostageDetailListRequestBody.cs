using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionPostageInputs;

/// <summary>
/// Represents the request body for listing order version postage details in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderVersionPostageDetailList")]
public class OrderVersionPostageDetailListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the order version postage detail list request.
    /// </summary>
    public required OrderVersionPostageDetailListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing order version postage details in the Midnight SOAP API.
/// </summary>
public class OrderVersionPostageDetailListInputParameter
{
    /// <summary>Gets or sets the order version postage ID.</summary>
    public required int OrderVersionPostageID { get; set; }
}