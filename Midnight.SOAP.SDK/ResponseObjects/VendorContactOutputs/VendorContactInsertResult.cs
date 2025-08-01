
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.VendorContactOutputs;

[XmlRoot("Result")]
public class VendorContactInsertResult : CommonResult
{
    public List<VendorContact>? VendorContacts { get; set; }
}

public class VendorContact
{
    public int VendorContactID { get; set; }
    public bool Active { get; set; }
}