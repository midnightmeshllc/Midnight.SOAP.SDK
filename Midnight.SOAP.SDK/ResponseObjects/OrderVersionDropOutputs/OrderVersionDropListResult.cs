using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionDropOutputs;

/// <summary>
/// Represents the result of a list request for order version drops in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class OrderVersionDropListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of order version drops returned by the request.
    /// </summary>
    [XmlArray("OrderVersionDrops")]
    [XmlArrayItem("OrderVersionDrop")]
    public List<OrderVersionDrop> OrderVersionDrops { get; set; } = new List<OrderVersionDrop>();
}

/// <summary>
/// Represents an order version drop in the Midnight SOAP API.
/// </summary>
public class OrderVersionDrop : UserDefinedFieldsFirst5
{
    /// <summary>Gets or sets the order version drop ID.</summary>
    public int? OrderVersionDropID { get; set; }
    /// <summary>Gets or sets the version ID.</summary>
    public int? VersionID { get; set; }
    /// <summary>Gets or sets the quantity.</summary>
    public int? Quantity { get; set; }
    /// <summary>Gets or sets the drop name.</summary>
    public string? DropName { get; set; }
    /// <summary>Gets or sets the drop date.</summary>
    public string? DropDate { get; set; }
    /// <summary>Gets or sets the time due.</summary>
    public string? TimeDue { get; set; }
    /// <summary>Gets or sets the actual drop date.</summary>
    public string? ActualDrop { get; set; }

    /// <summary>Gets or sets the raw value indicating if the drop date is complete.</summary>
    [XmlElement("DropDateComplete")]
    public string? DropDateCompleteRaw { get; set; }
    /// <summary>Gets a value indicating whether the drop date is complete.</summary>
    [XmlIgnore]
    public bool DropDateComplete
    {
        get
        {
            if (string.IsNullOrWhiteSpace(DropDateCompleteRaw)) return false;
            return string.Equals(DropDateCompleteRaw, "true", StringComparison.OrdinalIgnoreCase)
                || DropDateCompleteRaw == "1";
        }
    }

    /// <summary>Gets or sets the postage value.</summary>
    public decimal? PostageValue { get; set; }
}