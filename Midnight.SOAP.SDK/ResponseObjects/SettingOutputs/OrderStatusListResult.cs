
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

[XmlRoot("Result")]
public class OrderStatusListResult : CommonResult
{
    [XmlArray("OrderStatuses")]
    [XmlArrayItem("OrderStatus")]
    public List<OrderStatus> OrderStatuses { get; set; } = new List<OrderStatus>();
}

public class OrderStatus
{
    public int? OrderStatusID { get; set; }
    public string? OrderStattusName { get; set; }
    public string? OrderStatusType { get; set; }
}