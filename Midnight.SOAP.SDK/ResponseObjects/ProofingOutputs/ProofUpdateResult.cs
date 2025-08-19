
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.ProofingOutputs;

public class ProofUpdateResult
{
    [XmlArray("Results")]
    [XmlArrayItem("Result")]
    public List<Result> Results { get; set; } = new List<Result>();
}

public class Result : CommonResult
{
}