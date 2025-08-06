
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.CustomerOutputs;

[XmlRoot("Result")]
public class CustomerPermitNumberListResult : CommonResult
{
    [XmlArray("PermitNumberList")]
    [XmlArrayItem("PermitNumber")]
    public List<PermitNumber> PermitNumberList { get; set; } = new List<PermitNumber>();
}

public class PermitNumber
{
    [XmlElement("PermitCode")]
    public string? PermitCode { get; set; }
    [XmlElement("PermitDesc")]
    public string? PermitDesc { get; set; }
    [XmlElement("PermitType")]
    public string? PermitType { get; set; }
    [XmlElement("AccNumber")]
    public string? AccNumber { get; set; }
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