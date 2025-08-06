using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderOutputs;

[XmlRoot("Result")]
public class OrderNewResult : CommonResult
{
    [XmlArray("Orders")]
    [XmlArrayItem("Order")]
    public List<Order>? Orders { get; set; }
}

public class Order
{
    [XmlElement("OrderId")]
    public int OrderId { get; set; }
    [XmlElement("OrderNumber")]
    public string? OrderNumber { get; set; }
}