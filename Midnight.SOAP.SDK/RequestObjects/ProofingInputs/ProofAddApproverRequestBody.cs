
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.ProofingInputs;

[XmlRoot("RequestApproverInsert")]
public class ProofAddApproverRequestBody
{
    public required ProofAddApproverInputParameter InputParameter { get; set; }
}

public class ProofAddApproverInputParameter
{
    public required int RequestID { get; set; }
    public string? ApproverName { get; set; }
    public string? ApproverEmailAddress { get; set; }
}