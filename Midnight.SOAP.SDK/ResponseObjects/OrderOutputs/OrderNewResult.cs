
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderOutputs;

[XmlRoot("Result")]
public class OrderNewResult : CommonResult
{
    public List<Order>? Orders { get; set; }
}

public class Order
{
    public int OrderId { get; set; }
    public string? OrderNumber { get; set; }
}