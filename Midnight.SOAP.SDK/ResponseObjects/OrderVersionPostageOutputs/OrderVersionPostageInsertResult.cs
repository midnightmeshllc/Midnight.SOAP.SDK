
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionPostageOutputs;

[XmlRoot("Result")]
public class OrderVersionPostageInsertResult : CommonResult
{
    public int OrderVersionPostageID { get; set; }
}
