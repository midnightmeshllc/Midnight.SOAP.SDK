
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.ProofingInputs;

[XmlRoot("RequestApproverUpdate")]
public class ProofApproverUpdateRequestBody
{
    public required ProofApproverUpdateInputParameter InputParameter { get; set; }
}

public class ProofApproverUpdateInputParameter
{
    public required int RequestApproverID { get; set; }
    public string? ApproverName { get; set; } = null;
    public string? ApproverEmailAddress { get; set; } = null;
    public string? ApproverStatus { get; set; } = null;
    public int? ApproverImageID { get; set; } = null;
}