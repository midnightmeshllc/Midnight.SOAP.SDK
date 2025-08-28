using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.ProofingInputs;

/// <summary>
/// Represents the request body for adding an attachment to a proof in the Midnight SOAP API.
/// </summary>
[XmlRoot("RequestAddAttchment")]
public class ProofAddAttachmentRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the proof add attachment request.
    /// </summary>
    public required ProofAddAttachmentInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for adding an attachment to a proof in the Midnight SOAP API.
/// </summary>
public class ProofAddAttachmentInputParameter
{
    /// <summary>Gets or sets the request ID.</summary>
    public required int RequestID { get; set; }
    /// <summary>Gets or sets the file name.</summary>
    public required string FileName { get; set; }
    /// <summary>Gets or sets the file bytes as a base64-encoded value.</summary>
    public required byte FileBytesBase64 { get; set; }
}