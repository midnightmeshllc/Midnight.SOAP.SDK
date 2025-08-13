
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.ProofingInputs;

[XmlRoot("RequestNew")]
public class ProofNewRequestBody
{
    public required ProofNewRequestInputParameter InputParameter { get; set; }
}

public class ProofNewRequestInputParameter
{
    public required List<RequestNew> Requests { get; set; } = new List<RequestNew>();
}

public class RequestNew
{
    [Required]
    public DateOnly RequestDate { get; set; }
    [Required]
    public int CustomerID { get; set; }
    public int? EstimateID { get; set; }
    public int? VersionID { get; set; }
    public int? OrderVersionDetailID { get; set; }
    public string? Description { get; set; }
    public string? Comment { get; set; }
}