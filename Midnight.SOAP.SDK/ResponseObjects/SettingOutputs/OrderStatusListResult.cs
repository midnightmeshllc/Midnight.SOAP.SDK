using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

/// <summary>
/// Represents the result of an order status list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class OrderStatusListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of order statuses returned by the request.
    /// </summary>
    [XmlArray("OrderStatuses")]
    [XmlArrayItem("OrderStatus")]
    public List<OrderStatus> OrderStatuses { get; set; } = new List<OrderStatus>();
}

/// <summary>
/// Represents an order status in the Midnight SOAP API.
/// </summary>
public class OrderStatus
{
    /// <summary>Gets or sets the order status ID.</summary>
    public int? OrderStatusID { get; set; }
    /// <summary>Gets or sets the order status name.</summary>
    public string? OrderStattusName { get; set; }
    /// <summary>Gets or sets the order status type.</summary>
    public string? OrderStatusType { get; set; }
}