
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionPostageOutputs;

[XmlRoot("Result")]
public class OrderVersionPostageInsertResult : CommonResult
{
    [XmlElement("OrderVersionPostageDetailID")]
    public int OrderVersionPostageID { get; set; }
}
