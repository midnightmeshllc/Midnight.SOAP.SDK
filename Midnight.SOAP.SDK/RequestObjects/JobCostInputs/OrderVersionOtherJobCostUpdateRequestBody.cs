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
    public bool ShouldSerializeType() => IsSet(Type);

    /// <summary>Gets or sets the source.</summary>
    public string? Source { get; set; }
    public bool ShouldSerializeSource() => IsSet(Source);

    /// <summary>Gets or sets the quantity.</summary>
    public decimal? Quantity { get; set; }
    public bool ShouldSerializeQuantity() => Quantity.HasValue;

    /// <summary>Gets or sets the unit price.</summary>
    public decimal? UnitPrice { get; set; }
    public bool ShouldSerializeUnitPrice() => UnitPrice.HasValue;

    /// <summary>Gets or sets the description.</summary>
    public string? Description { get; set; }
    public bool ShouldSerializeDescription() => IsSet(Description);

    /// <summary>Shared helper for determining whether a nullable string field has a meaningful value to serialize.</summary>
    private static bool IsSet(string? value) => !string.IsNullOrEmpty(value);
}
