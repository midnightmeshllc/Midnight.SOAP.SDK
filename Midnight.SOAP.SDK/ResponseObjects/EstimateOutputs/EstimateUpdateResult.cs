
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.EstimateOutputs;

[XmlRoot("Result")]
public class EstimateUpdateResult : CommonResult
{
    [XmlElement("Estimate")]
    public EstimateUpdated Estimate { get; set; } = new EstimateUpdated();
}

public class EstimateUpdated
{
    public int? EstimateID { get; set; }
    public string? EstimateNumber { get; set; }
}