
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.ProofingOutputs;

[XmlRoot("Result")]
public class ProofUpdateResult
{
    [XmlElement("Results")]
    public List<Result> Results { get; set; } = new List<Result>();
}

public class Result : CommonResult
{
}