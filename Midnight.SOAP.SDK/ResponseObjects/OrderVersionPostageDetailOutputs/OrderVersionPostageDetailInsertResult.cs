
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionPostageDetailOutputs;

[XmlRoot("Result")]
public class OrderVersionPostageDetailInsertResult : CommonResult
{
    public int OrderVersionPostageDetailID { get; set; }
}
