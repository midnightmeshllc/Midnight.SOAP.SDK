

using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.ProofingInputs;

[XmlRoot("RequestAddAttchment")]
public class ProofAddAttachmentRequestBody
{
    public required ProofAddAttachmentInputParameter InputParameter { get; set; }
}

public class ProofAddAttachmentInputParameter
{
    public required int RequestID { get; set; }
    public required string FileName { get; set; }
    public required byte FileBytesBase64 { get; set; }
}