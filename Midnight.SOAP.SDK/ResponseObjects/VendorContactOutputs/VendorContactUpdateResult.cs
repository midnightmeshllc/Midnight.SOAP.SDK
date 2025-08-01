
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.VendorContactOutputs;

[XmlRoot("Result")]
public class VendorContactUpdateResult : CommonResult
{
    public List<VendorContact>? VendorContacts { get; set; }
}
