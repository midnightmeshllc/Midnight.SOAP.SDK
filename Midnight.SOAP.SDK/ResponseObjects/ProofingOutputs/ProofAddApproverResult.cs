
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.ProofingOutputs;

[XmlRoot("Result")]
public class ProofAddApproverResult : CommonResult
{
    public int RequestApproverID { get; set; }
}
