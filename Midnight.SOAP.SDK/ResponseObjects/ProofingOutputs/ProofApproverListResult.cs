
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.ProofingOutputs;

[XmlRoot("Result")]
public class ProofApproverListResult : CommonResult
{
    [XmlArray("RequestApprovers")]
    [XmlArrayItem("RequestApprover")]
    public List<ProofApprover> RequestApprovers { get; set; } = new List<ProofApprover>();
}

public class ProofApprover : RequestApprover
{
    public int? RequestID { get; set; }
}