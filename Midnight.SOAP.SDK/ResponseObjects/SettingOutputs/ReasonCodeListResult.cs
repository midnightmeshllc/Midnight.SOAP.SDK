
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

[XmlRoot("Result")]
public class ReasonCodeListResult : CommonResult
{
    [XmlArray("ReasonCodes")]
    [XmlArrayItem("ReasonCode")]
    public List<ReasonCode> ReasonCodes { get; set; } = new List<ReasonCode>();
}

public class ReasonCode
{
    public int? ReasonCodeID { get; set; }

    [XmlElement("ReasonCode")]
    public string? ReasonCodeValue { get; set; } // Renamed to avoid CS0542

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