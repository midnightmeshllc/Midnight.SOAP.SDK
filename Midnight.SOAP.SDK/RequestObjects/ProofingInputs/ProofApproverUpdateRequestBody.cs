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
    public string? ApproverName { get; set; }
    public bool ShouldSerializeApproverName() => IsSet(ApproverName);

    /// <summary>Gets or sets the approver email address.</summary>
    public string? ApproverEmailAddress { get; set; }
    public bool ShouldSerializeApproverEmailAddress() => IsSet(ApproverEmailAddress);

    /// <summary>Gets or sets the approver status.</summary>
    public string? ApproverStatus { get; set; }
    public bool ShouldSerializeApproverStatus() => IsSet(ApproverStatus);

    /// <summary>Gets or sets the approver image ID.</summary>
    public int? ApproverImageID { get; set; }
    public bool ShouldSerializeApproverImageID() => ApproverImageID.HasValue;

    /// <summary>Shared helper for determining whether a nullable string field has a meaningful value to serialize.</summary>
    private static bool IsSet(string? value) => !string.IsNullOrEmpty(value);
}