
using Midnight.SOAP.SDK.CommonObjects;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.EstimateOutputs;

[XmlRoot("Result")]
public class EstimateListResult : CommonResult
{
    [XmlArray("Estimates")]
    [XmlArrayItem("Estimate")]
    public List<Estimate> Estimates { get; set; } = new List<Estimate>();
}

public class Estimate : UserDefinedFields
{
    public int EstimateID { get; set; }
    public string? EstimateNumber { get; set; }
    public int? EstimateSuffix { get; set; }
    public int? CustomerID { get; set; }
    public string? CustomerName { get; set; }
    public string? ContactName { get; set; }
    public string? SalesRepName { get; set; }
    public string? CSRName { get; set; }
    public string? ProjectName { get; set; }
    public string? LicenseeName { get; set; }
    public string? Terms { get; set; }

    [XmlElement("Taxable")]
    public string? TaxableRaw { get; set; }

    [XmlIgnore]
    public bool Taxable
    {
        get
        {
            if (string.IsNullOrWhiteSpace(TaxableRaw)) return false;
            return string.Equals(TaxableRaw, "true", StringComparison.OrdinalIgnoreCase)
                || TaxableRaw == "1";
        }
    }

    public string? EstimateStatus { get; set; }
    public string? EstimateDate { get; set; }
    public string? DataInDate { get; set; }
    public string? MaterialInDate { get; set; }
    public string? DueDate { get; set; }
    public int? QuantityExpected { get; set; }
    public decimal? EstimateTax { get; set; }
    public decimal? EstimateTotal { get; set; }
}