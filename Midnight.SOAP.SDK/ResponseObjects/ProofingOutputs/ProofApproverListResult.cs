using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.ProofingOutputs;

/// <summary>
/// Represents the result of a proof approver list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class ProofApproverListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of request approvers returned by the request.
    /// </summary>
    [XmlArray("RequestApprovers")]
    [XmlArrayItem("RequestApprover")]
    public List<ProofApprover> RequestApprovers { get; set; } = new List<ProofApprover>();
}

/// <summary>
/// Represents a proof approver in the Midnight SOAP API.
/// </summary>
public class ProofApprover : RequestApprover
{
    /// <summary>Gets or sets the request ID associated with the approver.</summary>
    public int? RequestID { get; set; }
}