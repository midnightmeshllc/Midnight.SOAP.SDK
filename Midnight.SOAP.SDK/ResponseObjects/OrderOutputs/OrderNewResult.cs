using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderOutputs;

[XmlRoot("Result")]
public class OrderNewResult : CommonResult
{
    [XmlArray("Orders")]
    [XmlArrayItem("Order")]
    public List<NewOrder>? Orders { get; set; }
}

public class NewOrder
{
    [XmlElement("OrderId")]
    public int OrderId { get; set; }
    [XmlElement("OrderNumber")]
    public string? OrderNumber { get; set; }
}