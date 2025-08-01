
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.ProofingOutputs;

[XmlRoot("Result")]
public class ProofNewResult : CommonResult
{
    public int RequestID { get; set; }
}
