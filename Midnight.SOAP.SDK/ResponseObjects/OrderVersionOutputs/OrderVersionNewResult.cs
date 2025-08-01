
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionOutputs;

[XmlRoot("Result")]
public class OrderVersionNewResult : CommonResult
{
    public int VersionID { get; set; }
}
