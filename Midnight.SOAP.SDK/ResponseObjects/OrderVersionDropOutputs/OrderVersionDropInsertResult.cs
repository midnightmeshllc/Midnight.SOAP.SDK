
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionDropOutputs;

[XmlRoot("Result")]
public class OrderVersionDropInsertResult : CommonResult
{
    public int OrderVersionDropID { get; set; }
}
