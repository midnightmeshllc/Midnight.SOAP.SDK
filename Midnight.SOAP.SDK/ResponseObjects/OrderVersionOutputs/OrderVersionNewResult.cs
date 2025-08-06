using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionOutputs;

[XmlRoot("Result")]
public class OrderVersionNewResult : CommonResult
{
    [XmlElement("VersionID")]
    public int VersionID { get; set; }
}
