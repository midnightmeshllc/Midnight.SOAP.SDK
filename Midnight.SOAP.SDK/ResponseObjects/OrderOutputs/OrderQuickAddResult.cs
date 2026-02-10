using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderOutputs;

/// <summary>
/// Represents the result of a quick add operation for orders in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class OrderQuickAddResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of orders returned by the quick add operation.
    /// </summary>
    [XmlArray("Orders")]
    [XmlArrayItem("Order")]
    public List<QuickAddOrder>? Orders { get; set; }
}

/// <summary>
/// Represents an order returned by the quick add operation in the Midnight SOAP API.
/// </summary>
public class QuickAddOrder
{
    /// <summary>Gets or sets the order ID.</summary>
    [XmlElement("OrderId")]
    public int OrderID { get; set; }
    /// <summary>Gets or sets the order number.</summary>
    [XmlElement("OrderNumber")]
    public string? OrderNumber { get; set; }
}
