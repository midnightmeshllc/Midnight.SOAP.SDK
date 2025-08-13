
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.ProofingOutputs;

[XmlRoot("Result")]
public class ProofStatusListResult : CommonResult
{
    [XmlArray("RequestStatuses")]
    [XmlArrayItem("RequestStatus")]
    public List<RequestStatus> RequestStatuses { get; set; } = new List<RequestStatus>();
}

public class RequestStatus
{
    public string? Code { get; set; }
    public string? Name { get; set; }

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