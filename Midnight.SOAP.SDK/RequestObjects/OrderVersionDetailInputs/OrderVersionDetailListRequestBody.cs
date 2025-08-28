using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionDetailInputs;

/// <summary>
/// Represents the request body for listing order version details in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderVersionDetailList")]
public class OrderVersionDetailListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the order version detail list request.
    /// </summary>
    public required OrderVersionDetailListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing order version details in the Midnight SOAP API.
/// </summary>
public class OrderVersionDetailListInputParameter
{
    /// <summary>Gets or sets the version ID.</summary>
    public required int VersionID { get; set; }
}