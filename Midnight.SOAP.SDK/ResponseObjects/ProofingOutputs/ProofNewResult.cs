
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.ProofingOutputs;

[XmlRoot("Result")]
public class ProofNewResult : CommonResult
{
    [XmlElement("RequestID")]
    public int RequestID { get; set; }
}
