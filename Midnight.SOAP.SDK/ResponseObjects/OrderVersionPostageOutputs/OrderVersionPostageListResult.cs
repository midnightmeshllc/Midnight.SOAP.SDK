
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionPostageOutputs;

[XmlRoot("Result")]
public class OrderVersionPostageListResult : CommonResult
{
    [XmlArray("OrderVersionPostages")]
    [XmlArrayItem("OrderVersionPostage")]
    public List<OrderVersionPostage> OrderVersionPostages { get; set; } = new List<OrderVersionPostage>();
}

/// <summary>
/// Valid options for PostageMarkupType: "$" or "%"
/// </summary>
public class OrderVersionPostage
{
    public int? OrderVersionPostageID { get; set; }
    public int? VersionID { get; set; }
    public int? PostageAffixID { get; set; }
    public string? PostageAffixName { get; set; }
    public int? PostageQuantity { get; set; }
    public decimal? PostageRate { get; set; }
    public string? PostageMarkupType { get; set; }
    public decimal? PostageMarkupValue { get; set; }
    public decimal? PostageSellRate { get; set; }
    public decimal? PostageTotal { get; set; }
    public string? DateUsed { get; set; }
    public int? MailClassID { get; set; }
    public string? MailClassName { get; set; }
}