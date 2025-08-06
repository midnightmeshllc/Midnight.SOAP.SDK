
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.VendorContactOutputs;

[XmlRoot("Result")]
public class VendorContactUpdateResult : CommonResult
{
    [XmlArray("VendorContacts")]
    [XmlArrayItem("VendorContact")]
    public List<VendorContact>? VendorContacts { get; set; }
}
