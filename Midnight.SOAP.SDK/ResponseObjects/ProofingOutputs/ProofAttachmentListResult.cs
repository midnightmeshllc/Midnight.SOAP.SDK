
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.ProofingOutputs;

[XmlRoot("Result")]
public class ProofAttachmentListResult : CommonResult
{
    [XmlArray("RequestAttachments")]
    [XmlArrayItem("RequestAttachment")]
    public List<RequestAttachment> RequestAttachments { get; set; } = new List<RequestAttachment>();
}

public class RequestAttachment
{
    public int? RequestID { get; set; }
    public int? ImageID { get; set; }
    public string? ImageName { get; set; }
    public string? ImageType { get; set; }
}