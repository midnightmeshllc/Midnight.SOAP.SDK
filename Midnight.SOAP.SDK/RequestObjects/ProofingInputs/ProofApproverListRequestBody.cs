using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.ProofingInputs;

/// <summary>
/// Represents the request body for listing proof approvers in the Midnight SOAP API.
/// </summary>
[XmlRoot("RequestApproverList")]
public class ProofApproverListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the proof approver list request.
    /// </summary>
    public required ProofApproverListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing proof approvers in the Midnight SOAP API.
/// </summary>
public class ProofApproverListInputParameter
{
    /// <summary>Gets or sets the request ID.</summary>
    public required int RequestID { get; set; }
    /// <summary>Gets or sets the request approver ID.</summary>
    public int? RequestApproverID { get; set; } = null;
    /// <summary>Gets or sets the approver name.</summary>
    public string? ApproverName { get; set; } = null;
    /// <summary>Gets or sets the approver email address.</summary>
    public string? ApproverEmailAddress { get; set; } = null;
    /// <summary>Gets or sets the approver status.</summary>
    public string? ApproverStatus { get; set; } = null;
}