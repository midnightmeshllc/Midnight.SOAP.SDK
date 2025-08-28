using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.JobCostInputs;

/// <summary>
/// Represents the request body for inserting an order version other job cost in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderVersionOtherJobCostInsert")]
public class OrderVersionOtherJobCostInsertRequestBody
{
    /// <summary>Gets or sets the order ID.</summary>
    public required int OrderID { get; set; }
    /// <summary>Gets or sets the version ID.</summary>
    public required int VersionID { get; set; }
    /// <summary>Gets or sets the date.</summary>
    public required string Date { get; set; } = string.Empty;
    /// <summary>Gets or sets the type.</summary>
    public string? Type { get; set; }
    /// <summary>Gets or sets the source.</summary>
    public string? Source { get; set; }
    /// <summary>Gets or sets the quantity.</summary>
    public decimal? Quantity { get; set; } = decimal.Zero;
    /// <summary>Gets or sets the unit price.</summary>
    public decimal? UnitPrice { get; set; } = decimal.Zero;
    /// <summary>Gets or sets the description.</summary>
    public string? Description { get; set; }
}
