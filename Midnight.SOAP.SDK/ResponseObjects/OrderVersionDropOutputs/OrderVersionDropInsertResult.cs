
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionDropOutputs;

[XmlRoot("Result")]
public class OrderVersionDropInsertResult : CommonResult
{
    [XmlElement("OrderVersionDropID")]
    public int OrderVersionDropID { get; set; }
}
