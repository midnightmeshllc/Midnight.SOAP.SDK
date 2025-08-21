
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderOutputs;

[XmlRoot("Result")]
public class OrderQuickAddResult : CommonResult
{
    [XmlArray("Orders")]
    [XmlArrayItem("Order")]
    public List<QuickAddOrder>? Orders { get; set; }
}

public class QuickAddOrder
{
    [XmlElement("OrderID")]
    public int OrderID { get; set; }
    [XmlElement("OrderNumber")]
    public string? OrderNumber { get; set; }
}
