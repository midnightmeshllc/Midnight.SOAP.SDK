using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderOutputs;

[XmlRoot("Result")]
public class OrderNewResult : CommonResult
{
    public NewOrder? OrderHeader { get; set; }
}

public class NewOrder
{
    [XmlElement("OrderID")]
    public int? OrderID { get; set; }
    [XmlElement("OrderNumber")]
    public string? OrderNumber { get; set; }
}