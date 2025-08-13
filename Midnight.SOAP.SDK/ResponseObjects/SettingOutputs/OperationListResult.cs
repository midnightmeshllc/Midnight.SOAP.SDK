
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

[XmlRoot("Result")]
public class OperationListResult : CommonResult
{
    [XmlArray("Operations")]
    [XmlArrayItem("Operation")]
    public List<Operation> Operations { get; set; } = new List<Operation>();
}

public class Operation
{
    public string? OperationCode { get; set; }
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