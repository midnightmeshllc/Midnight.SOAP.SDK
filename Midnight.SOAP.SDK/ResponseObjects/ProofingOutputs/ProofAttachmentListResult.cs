using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.ProofingOutputs;

/// <summary>
/// Represents the result of a proof attachment list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class ProofAttachmentListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of request attachments returned by the request.
    /// </summary>
    [XmlArray("RequestAttachments")]
    [XmlArrayItem("RequestAttachment")]
    public List<RequestAttachment> RequestAttachments { get; set; } = new List<RequestAttachment>();
}

/// <summary>
/// Represents a request attachment in the Midnight SOAP API.
/// </summary>
public class RequestAttachment
{
    /// <summary>Gets or sets the request ID associated with the attachment.</summary>
    public int? RequestID { get; set; }
    /// <summary>Gets or sets the image ID of the attachment.</summary>
    public int? ImageID { get; set; }
    /// <summary>Gets or sets the image name of the attachment.</summary>
    public string? ImageName { get; set; }
    /// <summary>Gets or sets the image type of the attachment.</summary>
    public string? ImageType { get; set; }
}