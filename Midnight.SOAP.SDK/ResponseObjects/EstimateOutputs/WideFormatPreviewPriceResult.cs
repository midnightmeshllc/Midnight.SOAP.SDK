using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.EstimateOutputs;

/// <summary>
/// Represents the result of a wide format preview price request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class WideFormatPreviewPriceResult : CommonResult
{
    /// <summary>
    /// Gets or sets the wide format product item details for the preview price.
    /// </summary>
    public WFProductItem? WFProductItem { get; set; }
}

/// <summary>
/// Represents a wide format product item in the Midnight SOAP API.
/// </summary>
public class WFProductItem
{
    /// <summary>Gets or sets the print size.</summary>
    public string? PrintSize { get; set; }
    /// <summary>Gets or sets the finished square feet.</summary>
    public decimal? FinishedSqFt { get; set; }
    /// <summary>Gets or sets the total square feet used.</summary>
    public decimal? TotalSqFtUsed { get; set; }
    /// <summary>Gets or sets the linear square feet used.</summary>
    public decimal? LnSqFtUsed { get; set; }
    /// <summary>Gets or sets the printer cost.</summary>
    public decimal? PrinterCost { get; set; }
    /// <summary>Gets or sets the ink cost.</summary>
    public decimal? InkCost { get; set; }
    /// <summary>Gets or sets the material cost.</summary>
    public decimal? MaterialCost { get; set; }
    /// <summary>Gets or sets the waste percent.</summary>
    public decimal? WastePercent { get; set; }
    /// <summary>Gets or sets the total print cost.</summary>
    public decimal? TotalPrintCost { get; set; }
    /// <summary>Gets or sets the service cost.</summary>
    public decimal? ServiceCost { get; set; }
    /// <summary>Gets or sets the total cost.</summary>
    public decimal? TotalCost { get; set; }
    /// <summary>Gets or sets the cost per square foot.</summary>
    public decimal? CostPerSqFt { get; set; }
    /// <summary>Gets or sets the markup.</summary>
    public decimal? Markup { get; set; }
    /// <summary>Gets or sets the price per square foot.</summary>
    public decimal? PricePerSqFt { get; set; }
    /// <summary>Gets or sets the price each.</summary>
    public decimal? PriceEach { get; set; }
    /// <summary>Gets or sets the total price.</summary>
    public decimal? TotalPrice { get; set; }
}