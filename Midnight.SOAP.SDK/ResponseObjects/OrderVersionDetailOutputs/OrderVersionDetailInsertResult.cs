
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionDetailOutputs;

[XmlRoot("Result")]
public class OrderVersionDetailInsertResult : CommonResult
{
    public int OrderVersionDetailID { get; set; }
}
