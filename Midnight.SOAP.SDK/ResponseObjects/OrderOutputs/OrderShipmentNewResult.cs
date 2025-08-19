using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderOutputs;

[XmlRoot("Result")]
public class OrderShipmentNewResult : CommonResult
{
    [XmlElement("Id")]
    public int Id { get; set; }
}
