using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionPostageOutputs;

[XmlRoot("Result")]
public class OrderVersionPostageDetailListResult : CommonResult
{
    [XmlArray("OrderVersionPostageDetails")]
    [XmlArrayItem("OrderVersionPostageDetail")]
    public List<OrderVersionPostageDetail> OrderVersionPostageDetails { get; set; } = new List<OrderVersionPostageDetail>();
}

public class OrderVersionPostageDetail
{
    public int? OrderVersionPostageDetailID { get; set; }
    public int? OrderVersionPostageID { get; set; }
    public string? RateDescription { get; set; }
    public int? Quantity { get; set; }
    public decimal? Rate { get; set; }
    public decimal? DetailTotalWeight { get; set; }
    public decimal? DetailTotalPostage { get; set; }
    public string? DetailDate { get; set; }
    public string? RateCode { get; set; }
    public string? WtType { get; set; }

    [XmlElement("Precanceled")]
    public string? PrecanceledRaw { get; set; }
    [XmlIgnore]
    public bool Precanceled
    {
        get
        {
            if (string.IsNullOrWhiteSpace(PrecanceledRaw)) return false;
            return string.Equals(PrecanceledRaw, "true", StringComparison.OrdinalIgnoreCase)
                || PrecanceledRaw == "1";
        }
    }
}