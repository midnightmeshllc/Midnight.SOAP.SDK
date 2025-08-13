
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.ProofingInputs;

[XmlRoot("RequestAttachmentList")]
public class ProofAttachmentListRequestBody
{
    public required ProofAttachmentLIstInputParameter InputParameter { get; set; }
}

public class ProofAttachmentLIstInputParameter
{
    public required int RequestID { get; set; }
}