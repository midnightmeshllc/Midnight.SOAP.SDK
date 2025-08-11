
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionDetailOutputs;

[XmlRoot("Result")]
public class OrderVersionDetailListResult : CommonResult
{
    [XmlArray("OrderVersionDetails")]
    [XmlArrayItem("OrderVersionDetail")]
    public List<OrderVersionDetailList> OrderVersionDetails { get; set; } = new List<OrderVersionDetailList>();
}

public class OrderVersionDetailList
{
    public int? OrderVersionDetailID { get; set; }
    public int? VersionID { get; set; }
    public int? ServiceTypeID { get; set; }
    public string? ServiceTypeName { get; set; }
    public int? ServiceTypeSort { get; set; }
    public int? ServiceID { get; set; }
    public string? ServiceCode { get; set; }
    public string? ServiceName { get; set; }
    public decimal? Quantity { get; set; }
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
    public decimal? RunTime { get; set; }
    public decimal? QtyDone { get; set; }

    [XmlElement("Complete")]
    public string? CompleteRaw { get; set; }
    [XmlIgnore]
    public bool Complete
    {
        get
        {
            if (string.IsNullOrWhiteSpace(CompleteRaw)) return false;
            return string.Equals(CompleteRaw, "true", StringComparison.OrdinalIgnoreCase)
                || CompleteRaw == "1";
        }
    }

    public int? PrioritySort { get; set; }
    public string? Comment { get; set; }
    public int? Priority { get; set; }
    public string? ServiceHyperlink { get; set; }
    public string? FileLocation { get; set; }
    public decimal? ServiceMarkup { get; set; }
    public decimal? UnitPriceNoMarkup { get; set; }
}