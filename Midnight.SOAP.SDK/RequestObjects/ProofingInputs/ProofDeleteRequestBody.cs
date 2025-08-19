
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.ProofingInputs;

[XmlRoot("RequestDelete")]
public class ProofDeleteRequestBody
{
    public required ProofDeleteInputParameter InputParameter { get; set; }
}

public class ProofDeleteInputParameter
{
    public required int RequestID { get; set; }
}