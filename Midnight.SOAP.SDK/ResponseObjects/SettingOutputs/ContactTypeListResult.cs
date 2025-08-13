
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

[XmlRoot("Result")]
public class ContactTypeListResult : CommonResult
{
    [XmlArray("ContactTypes")]
    [XmlArrayItem("ContactType")]
    public List<ContactType> ContactTypes { get; set; } = new List<ContactType>();
}

public class ContactType
{
    public int? ContactTypeID { get; set; }
    public string? ContactTypeName { get; set; }

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