
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.ProofingInputs;

[XmlRoot("RequestApproverDelete")]
public class ProofApproverDeleteRequestBody
{
    public required ProofApproverDeleteInputParameter InputParameter { get; set; }
}

public class ProofApproverDeleteInputParameter
{
    public required int RequestApproverID { get; set; }
}