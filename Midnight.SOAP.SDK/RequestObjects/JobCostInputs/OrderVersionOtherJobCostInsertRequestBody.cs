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
    [XmlElement(IsNullable = true)]
    public string? Type { get; set; }
    /// <summary>Gets or sets the source.</summary>
    [XmlElement(IsNullable = true)]
    public string? Source { get; set; }
    /// <summary>Gets or sets the quantity.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? Quantity { get; set; }
    /// <summary>Gets or sets the unit price.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? UnitPrice { get; set; }
    /// <summary>Gets or sets the description.</summary>
    [XmlElement(IsNullable = true)]
    public string? Description { get; set; }
}
