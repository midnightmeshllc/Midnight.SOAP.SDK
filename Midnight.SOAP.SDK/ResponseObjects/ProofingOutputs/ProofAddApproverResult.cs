
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.ProofingOutputs;

[XmlRoot("Result")]
public class ProofAddApproverResult : CommonResult
{
    [XmlElement("RequestApproverID")]
    public int RequestApproverID { get; set; }
}
