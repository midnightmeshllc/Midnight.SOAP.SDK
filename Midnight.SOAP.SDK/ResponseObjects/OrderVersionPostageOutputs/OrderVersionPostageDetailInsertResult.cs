using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionPostageOutputs;

[XmlRoot("Result")]
public class OrderVersionPostageDetailInsertResult : CommonResult
{
    [XmlElement("OrderVersionPostageDetailID")]
    public int OrderVersionPostageDetailID { get; set; }
}
