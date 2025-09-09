using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.CustomerOutputs;

/// <summary>
/// Represents the result of a customer non-profit authorization number list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class CustomerNonProfitAuthNumberListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of non-profit authorization numbers returned by the request.
    /// </summary>
    [XmlArray("NonProfitAuthList")]
    [XmlArrayItem("NonProfitAuth")]
    public List<NonProfitAuth> NonProfitAuthList { get; set; } = new List<NonProfitAuth>();
}

/// <summary>
/// Represents a non-profit authorization number in the Midnight SOAP API.
/// </summary>
public class NonProfitAuth
{
    /// <summary>Gets or sets the item code.</summary>
    [XmlElement("ItemCode")]
    public string? ItemCode { get; set; }
    /// <summary>Gets or sets the item description.</summary>
    [XmlElement("ItemDesc")]
    public string? ItemDesc { get; set; }
    /// <summary>Gets or sets the raw value indicating if the non-profit auth is active.</summary>
    [XmlElement("Active")]
    public string? ActiveRaw { get; set; }

    /// <summary>Gets a value indicating whether the non-profit auth is active.</summary>
    [XmlIgnore]
    public bool Active
    {
        get
        {
            if (string.IsNullOrWhiteSpace(ActiveRaw)) return false;
            return string.Equals(ActiveRaw, "true", StringComparison.OrdinalIgnoreCase)
                || ActiveRaw == "1";
        }
    }
}