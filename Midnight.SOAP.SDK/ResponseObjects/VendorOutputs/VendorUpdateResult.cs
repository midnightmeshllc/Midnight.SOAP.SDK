
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.VendorOutputs;

[XmlRoot("Result")]
public class VendorUpdateResult : CommonResult
{
    [XmlElement("VendorID")]
    public int VendorID { get; set; }
    [XmlElement("CreateDateTime")]
    public string? CreateDateTime { get; set; }
}
