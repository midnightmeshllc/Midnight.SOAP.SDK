using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.EstimateOutputs;

/// <summary>
/// Represents the result of a print template preview price request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class PrintTemplatePreviewPriceResult : CommonResult
{
    /// <summary>
    /// Gets or sets the print product item details for the preview price.
    /// </summary>
    public PrintProductItem? PrintProductItem { get; set; } = new PrintProductItem();
}

/// <summary>
/// Represents a print product item in the Midnight SOAP API.
/// </summary>
public class PrintProductItem
{
    /// <summary>Gets or sets the item ID.</summary>
    public int? ItemID { get; set; }
    /// <summary>Gets or sets the net impressions.</summary>
    public int? NetImpressions { get; set; }
    /// <summary>Gets or sets the print time.</summary>
    public decimal? PrintTime { get; set; }
    /// <summary>Gets or sets the estimated ink pounds.</summary>
    public decimal? EstInkLbs { get; set; }
    /// <summary>Gets or sets the parent sheets.</summary>
    public string? ParentSheets { get; set; }
    /// <summary>Gets or sets the run sheets.</summary>
    public string? RunSheets { get; set; }
    /// <summary>Gets or sets the roll size.</summary>
    public string? RollSize { get; set; }
    /// <summary>Gets or sets the estimated run feet.</summary>
    public decimal? EstRunFeet { get; set; }
    /// <summary>Gets or sets the estimated run pounds.</summary>
    public decimal? EstRunLbs { get; set; }
    /// <summary>Gets or sets the markup.</summary>
    public decimal? Markup { get; set; }
    /// <summary>Gets or sets the total cost.</summary>
    public decimal? TotalCost { get; set; }
    /// <summary>Gets or sets the total price.</summary>
    public decimal? PriceTotal { get; set; }
    /// <summary>Gets or sets the margin.</summary>
    public int? Margin { get; set; }
    /// <summary>Gets or sets the margin percent.</summary>
    public decimal? MarginPercent { get; set; }
    /// <summary>Gets or sets the service price total.</summary>
    public decimal? ServicePriceTotal { get; set; }
    /// <summary>Gets or sets the total with all services.</summary>
    public decimal? TotalWithAllService { get; set; }
    /// <summary>Gets or sets the unit price.</summary>
    public decimal? UnitPrice { get; set; }
    /// <summary>Gets or sets the price per M.</summary>
    public decimal? PricePerM { get; set; }
}