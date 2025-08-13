
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.EstimateOutputs;

[XmlRoot("Result")]
public class EstimateInsertResult : CommonResult
{
    [XmlElement("Estimate")]
    public NewEstimate? Estimate { get; set; }
}

public class NewEstimate
{
    public int? EstimateID { get; set; }
    public string? EstimateNumber { get; set; }
}