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
    public string? Type { get; set; }
    /// <summary>Gets or sets the source.</summary>
    public string? Source { get; set; }
    /// <summary>Gets or sets the quantity.</summary>
    public decimal? Quantity { get; set; }
    /// <summary>Gets or sets the unit price.</summary>
    public decimal? UnitPrice { get; set; }
    /// <summary>Gets or sets the description.</summary>
    public string? Description { get; set; }
}
