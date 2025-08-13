
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.ProofingInputs;

[XmlRoot("RequestApproverList")]
public class ProofApproverListRequestBody
{
    public required ProofApproverListInputParameter InputParameter { get; set; }
}

public class ProofApproverListInputParameter
{
    public required int RequestID { get; set; }
    public int? RequestApproverID { get; set; }
    public string? ApproverName { get; set; }
    public string? ApproverEmailAddress { get; set; }
    public string? ApproverStatus { get; set; }
}