
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.EstimateOutputs;

[XmlRoot("Result")]
public class PrintTemplatePreviewPriceResult : CommonResult
{
    public PrintProductItem? PrintProductItem { get; set; } = new PrintProductItem();
}

public class PrintProductItem
{
    public int? ItemID { get; set; }
    public int? NetImpressions { get; set; }
    public decimal? PrintTime { get; set; }
    public decimal? EstInkLbs { get; set; }
    public string? ParentSheets { get; set; }
    public string? RunSheets { get; set; }
    public string? RollSize { get; set; }
    public decimal? EstRunFeet { get; set; }
    public decimal? EstRunLbs { get; set; }
    public decimal? Markup { get; set; }
    public decimal? TotalCost { get; set; }
    public decimal? PriceTotal { get; set; }
    public int? Margin { get; set; }
    public decimal? MarginPercent { get; set; }
    public decimal? ServicePriceTotal { get; set; }
    public decimal? TotalWithAllService { get; set; }
    public decimal? UnitPrice { get; set; }
    public decimal? PricePerM { get; set; }
}