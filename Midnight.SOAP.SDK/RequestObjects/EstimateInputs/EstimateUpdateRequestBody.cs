
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.EstimateInputs;

[XmlRoot("EstimateUpdateModel")]
public class EstimateUpdateRequestBody
{
    public required int EstimateID { get; set; }
    public int? UpdatedQuantity { get; set; }
    public int? CustomerID { get; set; }
    public int? ContactID { get; set; }
    public int? SalesRepID { get; set; }
    public int? CSRID { get; set; }
    public int? LicenseeID { get; set; }
    public string? ProjectName { get; set; }
    public string? PONumber { get; set; }
    public string? TermsCode { get; set; }
    public bool EstimateTaxable { get; set; }
    public string? EstimateDate { get; set; }
    public string? DataIn { get; set; }
    public string? MaterialInDate { get; set; }
    public string? ArtworkInDate { get; set; }
    public string? DueDate { get; set; }
    public string? TimeDue { get; set; }
    public string? EstimateDetailComment { get; set; }
    public List<EstimateUDF> EstimateUDFList { get; set; } = new List<EstimateUDF>();
    public string? StatusName { get; set; }
}
