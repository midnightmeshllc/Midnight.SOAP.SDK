
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.CustomerOutputs;

[XmlRoot("Result")]
public class CustomerGhostNumberListResult : CommonResult
{
    [XmlArray("GhostList")]
    [XmlArrayItem("Ghost")]
    public List<Ghost>? GhostList { get; set; } = new List<Ghost>();
}

public class Ghost
{
    [XmlElement("ItemCode")]
    public string? ItemCode { get; set; }
    [XmlElement("Description")]
    public string? Description { get; set; }
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