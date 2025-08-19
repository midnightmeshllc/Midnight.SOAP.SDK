
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionDetailOutputs;

[XmlRoot("Result")]
public class OrderVersionDetailDeleteResult : CommonResult
{
    public string? OrderVersionDetailDelete { get; set; }
}
