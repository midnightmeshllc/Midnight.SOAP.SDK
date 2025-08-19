
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.EstimateOutputs;

[XmlRoot("Result")]
public class WideFormatPreviewPriceResult : CommonResult
{
    public WFProductItem? WFProductItem { get; set; }
}

public class WFProductItem
{
    public string? PrintSize { get; set; }
    public decimal? FinishedSqFt { get; set; }
    public decimal? TotalSqFtUsed { get; set; }
    public decimal? LnSqFtUsed { get; set; }
    public decimal? PrinterCost { get; set; }
    public decimal? InkCost { get; set; }
    public decimal? MaterialCost { get; set; }
    public decimal? WastePercent { get; set; }
    public decimal? TotalPrintCost { get; set; }
    public decimal? ServiceCost { get; set; }
    public decimal? TotalCost { get; set; }
    public decimal? CostPerSqFt { get; set; }
    public decimal? Markup { get; set; }
    public decimal? PricePerSqFt { get; set; }
    public decimal? PriceEach { get; set; }
    public decimal? TotalPrice { get; set; }
}