using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderOutputs;

/// <summary>
/// Represents the result of creating a new order in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class OrderNewResult : CommonResult
{
    /// <summary>
    /// Gets or sets the header information for the new order.
    /// </summary>
    public NewOrder? OrderHeader { get; set; }
}

/// <summary>
/// Represents the header information for a new order in the Midnight SOAP API.
/// </summary>
public class NewOrder
{
    /// <summary>Gets or sets the order ID.</summary>
    [XmlElement("OrderID")]
    public int? OrderID { get; set; }
    /// <summary>Gets or sets the order number.</summary>
    [XmlElement("OrderNumber")]
    public string? OrderNumber { get; set; }
}