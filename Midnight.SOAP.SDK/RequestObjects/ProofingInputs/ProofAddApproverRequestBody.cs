using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.ProofingInputs;

/// <summary>
/// Represents the request body for adding an approver to a proof in the Midnight SOAP API.
/// </summary>
[XmlRoot("RequestApproverInsert")]
public class ProofAddApproverRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the proof add approver request.
    /// </summary>
    public required ProofAddApproverInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for adding an approver to a proof in the Midnight SOAP API.
/// </summary>
public class ProofAddApproverInputParameter
{
    /// <summary>Gets or sets the request ID.</summary>
    public required int RequestID { get; set; }
    /// <summary>Gets or sets the approver name.</summary>
    [XmlElement(IsNullable = true)]
    public string? ApproverName { get; set; }
    /// <summary>Gets or sets the approver email address.</summary>
    [XmlElement(IsNullable = true)]
    public string? ApproverEmailAddress { get; set; }
}