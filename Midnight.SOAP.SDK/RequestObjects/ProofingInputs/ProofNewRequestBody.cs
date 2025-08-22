
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.ProofingInputs;

[XmlRoot("RequestNew")]
public class ProofNewRequestBody
{
    public required ProofNewInputParameter InputParameter { get; set; }
}

public class ProofNewInputParameter
{
    public required List<RequestNew> Requests { get; set; } = new List<RequestNew>();
}

public class RequestNew
{
    public required string RequestDate { get; set; }
    public required int CustomerID { get; set; }
    public int? EstimateID { get; set; }
    public int? VersionID { get; set; }
    public int? OrderVersionDetailID { get; set; }
    public string? Description { get; set; }
    public string? Comment { get; set; }
}