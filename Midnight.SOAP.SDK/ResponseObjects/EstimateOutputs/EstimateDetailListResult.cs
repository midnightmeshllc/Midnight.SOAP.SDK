using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.EstimateOutputs;

[XmlRoot("Result")]
public class EstimateDetailListResult : CommonResult
{
    [XmlArray("EstimateDetails")]
    [XmlArrayItem("EstimateDetail")]
    public List<EstimateDetail> EstimateDetails { get; set; } = new List<EstimateDetail>();
}

public class EstimateDetail
{
    public int? EstimateDetailID { get; set; }
    public int? EstimateID { get; set; }
    public int? ServiceTypeID { get; set; }
    public string? ServiceTypeName { get; set; }
    public int? ServiceTypeSort { get; set; }
    public int? ServiceID { get; set; }
    public string? ServiceCode { get; set; }
    public string? ServiceName { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? UnitPriceNoMarkup { get; set; }
    public decimal? ServiceMarkup { get; set; }
    public decimal? UnitPrice { get; set; }
    public decimal? LineTotal { get; set; }

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

    public decimal? TaxablePercent { get; set; }
    public decimal? TaxAmount { get; set; }
    public decimal? RunRate { get; set; }
    public string? Comment { get; set; }
    public int? Priority { get; set; }
    public string? ServiceHyperlink { get; set; }
    public string? FileLocation { get; set; }
}