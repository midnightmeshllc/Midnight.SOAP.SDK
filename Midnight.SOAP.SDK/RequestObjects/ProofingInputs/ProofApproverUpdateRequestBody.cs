using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.ProofingInputs;

/// <summary>
/// Represents the request body for updating a proof approver in the Midnight SOAP API.
/// </summary>
[XmlRoot("RequestApproverUpdate")]
public class ProofApproverUpdateRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the proof approver update request.
    /// </summary>
    public required ProofApproverUpdateInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for updating a proof approver in the Midnight SOAP API.
/// </summary>
public class ProofApproverUpdateInputParameter
{
    /// <summary>Gets or sets the request approver ID.</summary>
    public required int RequestApproverID { get; set; }
    /// <summary>Gets or sets the approver name.</summary>
    [XmlElement(IsNullable = true)]
    public string? ApproverName { get; set; }
    /// <summary>Gets or sets the approver email address.</summary>
    [XmlElement(IsNullable = true)]
    public string? ApproverEmailAddress { get; set; }
    /// <summary>Gets or sets the approver status.</summary>
    [XmlElement(IsNullable = true)]
    public string? ApproverStatus { get; set; }
    /// <summary>Gets or sets the approver image ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? ApproverImageID { get; set; }
}