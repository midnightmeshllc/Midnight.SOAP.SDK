using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionDetailInputs;

/// <summary>
/// Represents the request body for deleting an order version detail in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderVersionDetailDelete")]
public class OrderVersionDetailDeleteRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the order version detail delete request.
    /// </summary>
    public required OrderVersionDetailDeleteInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for deleting an order version detail in the Midnight SOAP API.
/// </summary>
public class OrderVersionDetailDeleteInputParameter
{
    /// <summary>Gets or sets the order version detail ID.</summary>
    public required int OrderVersionDetailID { get; set; }
}