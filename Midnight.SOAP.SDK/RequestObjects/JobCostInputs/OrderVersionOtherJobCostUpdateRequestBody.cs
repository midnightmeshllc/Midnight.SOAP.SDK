using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.JobCostInputs;

/// <summary>
/// Represents the request body for updating an order version other job cost in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderVersionOtherJobCostUpdate")]
public class OrderVersionOtherJobCostUpdateRequestBody
{
    /// <summary>Gets or sets the order version other job cost ID.</summary>
    public required int OrderVersionOtherJobCostID { get; set; }
    /// <summary>Gets or sets the date.</summary>
    public required string Date { get; set; }
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
