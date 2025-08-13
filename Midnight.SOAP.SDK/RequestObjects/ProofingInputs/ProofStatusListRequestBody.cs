using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.ProofingInputs;

[XmlRoot("RequestStatusList")]
public class ProofStatusListRequestBody
{
    public required ProofStatusListInputParameter InputParameter { get; set; }
}

public class ProofStatusListInputParameter
{
    public string? Code { get; set; }
    public string? Name { get; set; }
    public bool Active { get; set; } = true;
}