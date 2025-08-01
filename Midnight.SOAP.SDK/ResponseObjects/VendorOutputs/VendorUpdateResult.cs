
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.VendorOutputs;

[XmlRoot("Result")]
public class VendorUpdateResult : CommonResult
{
    public int VendorID { get; set; }
    public string? CreateDateTime { get; set; }
}
