
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.VendorContactOutputs;

[XmlRoot("Result")]
public class VendorContactInsertResult : CommonResult
{
    [XmlArray("VendorContacts")]
    [XmlArrayItem("VendorContact")]
    public List<VendorContactInserted>? VendorContacts { get; set; }
}

public class VendorContactInserted
{
    [XmlElement("VendorContactID")]
    public int VendorContactID { get; set; }
    [XmlElement("Active")]
    public string? ActiveRaw { get; set; }

    [XmlIgnore]
    public bool Active
    {
        get
        {
            if (string.IsNullOrWhiteSpace(ActiveRaw)) return false;
            return string.Equals(ActiveRaw, "true", StringComparison.OrdinalIgnoreCase)
                || ActiveRaw == "1";
        }
    }
}