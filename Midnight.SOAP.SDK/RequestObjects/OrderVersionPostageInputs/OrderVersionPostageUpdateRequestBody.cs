using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionPostageInputs;

[XmlRoot("OrderVersionPostageUpdate")]
public class OrderVersionPostageUpdateRequestBody
{
    public required OrderVersionPostageUpdateInputParameter InputParameter { get; set; }
}

public class OrderVersionPostageUpdateInputParameter
{
    public required int OrderVersionPostageID { get; set; }
    public int? PostageAffixID { get; set; } = null;
    public string? PostageAffixName { get; set; } = null;
    public int? PostageQuantity { get; set; } = null;
    public decimal? PostageRate { get; set; } = null;
    public decimal? PostageTotal { get; set; } = null;
    public string? DateUsed { get; set; } = null;
    public int? MailClassID { get; set; } = null;
    public decimal? TotalWeight { get; set; } = null;
    public string? FormNo { get; set; } = null;
    public string? Lot { get; set; } = null;
    public string? PermitNo { get; set; } = null;
    public string? NonProfit { get; set; } = null;
    public string? PostOffice { get; set; } = null;
    public string? POCity { get; set; } = null;
    public string? POZip { get; set; } = null;
    public string? WTStatus { get; set; } = null;
    public int? ProcessingCategory { get; set; } = null;
    public string? FTtr1 { get; set; } = null;
    public string? FTtr2 { get; set; } = null;
    public int? Sacks { get; set; } = null;
    public int? Pallets { get; set; } = null;
    public string? FlatTr { get; set; } = null;
    public string? Other { get; set; } = null;
    public decimal? TareWt { get; set; } = null;
    public bool? Precanceled { get; set; } = null;
    public string? PostageMarkupType { get; set; } = null;
    public decimal? PostageMarkupValue { get; set; } = null;
    public decimal? PostageSellRate { get; set; } = null;
}