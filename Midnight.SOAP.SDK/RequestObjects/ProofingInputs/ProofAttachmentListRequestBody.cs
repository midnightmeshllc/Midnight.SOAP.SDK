using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.ProofingInputs;

/// <summary>
/// Represents the request body for listing proof attachments in the Midnight SOAP API.
/// </summary>
[XmlRoot("RequestAttachmentList")]
public class ProofAttachmentListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the proof attachment list request.
    /// </summary>
    public required ProofAttachmentListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing proof attachments in the Midnight SOAP API.
/// </summary>
public class ProofAttachmentListInputParameter
{
    /// <summary>Gets or sets the request ID.</summary>
    public required int RequestID { get; set; }
}