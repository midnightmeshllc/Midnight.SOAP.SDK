
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.ProofingInputs;

[XmlRoot("RequestUpdate")]
public class ProofUpdateRequestBody
{
    public required ProofUpdateInputParameter InputParameter { get; set; }
}

public class ProofUpdateInputParameter
{
    [XmlArray("Requests")]
    [XmlArrayItem("Request")]
    public List<ProofUpdate> Requests { get; set; } = new List<ProofUpdate>();
}

public class ProofUpdate
{
    public required int RequestID { get; set; }
    public string? RequestDate { get; set; } = null;
    public string? RequestStatusCode { get; set; } = null;
    public int? EstimateID { get; set; } = null;
    public int? EstimateDetailID { get; set; } = null;
    public int? VersionID { get; set; } = null;
    public int? OrderVersionDetailID { get; set; } = null;
    public string? Description { get; set; } = null;
    public string? Comment { get; set; } = null;
}