
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.CustomerOutputs;

[XmlRoot("Result")]
public class CustomerRegIDListResult : CommonResult
{
    [XmlArray("RegList")]
    [XmlArrayItem("Reg")]
    public List<Reg> RegList { get; set; } = new List<Reg>();
}

public class Reg
{
    [XmlElement("ItemCode")]
    public string? ItemCode { get; set; }
    [XmlElement("ItemDesc")]
    public string? ItemDesc { get; set; }
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