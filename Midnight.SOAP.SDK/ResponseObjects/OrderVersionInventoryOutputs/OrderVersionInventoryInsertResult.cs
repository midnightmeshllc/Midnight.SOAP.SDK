
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionInventoryOutputs;

[XmlRoot("Result")]
public class OrderVersionInventoryInsertResult : CommonResult
{
    [XmlElement("OrderInventoryID")]
    public int OrderInventoryID { get; set; }
}
