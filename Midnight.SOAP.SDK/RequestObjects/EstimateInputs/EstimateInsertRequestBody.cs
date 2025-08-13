
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.EstimateInputs;

[XmlRoot("EstimateInsertModel")]
public class EstimateInsertRequestBody
{
    public int? ExpectedQuantity { get; set; }
    public int? CustomerID { get; set; }
    public int? ContactID { get; set; }
    public int? SalesRepID { get; set; }
    public int? CSRID { get; set; }
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
    public List<Inventory> InventoryList { get; set; } = new List<Inventory>();
    public List<NewEstimateService> ServiceList { get; set; } = new List<NewEstimateService>();
}

public class NewEstimateService
{
    public int? ServiceID { get; set; }
    public decimal? ServiceQuantity { get; set; }
    public decimal? UnitPrice { get; set; }
    public string? ServiceHyperlink { get; set; }
    public string? FileLocation { get; set; }
    public string? ItemNotes { get; set; }
    public bool Taxable { get; set; }
    public List<NewEstimateServiceUDF> UDFList { get; set; } = new List<NewEstimateServiceUDF>();
}

public class NewEstimateServiceUDF : UserDefinedFields
{
}

public class Inventory
{
    public int? Priority { get; set; }
    public int? ItemID { get; set; }
    public string? Description { get; set; }
    public int? QuantityNeeded { get; set; }
}

public class EstimateUDF : UserDefinedFields
{
}