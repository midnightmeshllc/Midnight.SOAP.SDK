using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.ProofingInputs;

/// <summary>
/// Represents the request body for deleting a proof approver in the Midnight SOAP API.
/// </summary>
[XmlRoot("RequestApproverDelete")]
public class ProofApproverDeleteRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the proof approver delete request.
    /// </summary>
    public required ProofApproverDeleteInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for deleting a proof approver in the Midnight SOAP API.
/// </summary>
public class ProofApproverDeleteInputParameter
{
    /// <summary>Gets or sets the request approver ID.</summary>
    public required int RequestApproverID { get; set; }
}