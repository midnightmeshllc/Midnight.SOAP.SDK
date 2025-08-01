
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionInventoryOutputs;

[XmlRoot("Result")]
public class OrderVersionInventoryInsertResult : CommonResult
{
    public int OrderInventoryID { get; set; }
}
