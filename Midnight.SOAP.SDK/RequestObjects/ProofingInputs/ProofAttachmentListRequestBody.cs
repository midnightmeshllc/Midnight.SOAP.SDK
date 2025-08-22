
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.ProofingInputs;

[XmlRoot("RequestAttachmentList")]
public class ProofAttachmentListRequestBody
{
    public required ProofAttachmentListInputParameter InputParameter { get; set; }
}

public class ProofAttachmentListInputParameter
{
    public required int RequestID { get; set; }
}