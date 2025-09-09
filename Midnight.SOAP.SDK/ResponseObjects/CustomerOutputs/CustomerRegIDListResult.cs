using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.CustomerOutputs;

/// <summary>
/// Represents the result of a customer registration ID list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class CustomerRegIDListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of registration IDs returned by the request.
    /// </summary>
    [XmlArray("RegList")]
    [XmlArrayItem("Reg")]
    public List<Reg> RegList { get; set; } = new List<Reg>();
}

/// <summary>
/// Represents a registration ID in the Midnight SOAP API.
/// </summary>
public class Reg
{
    /// <summary>Gets or sets the item code.</summary>
    [XmlElement("ItemCode")]
    public string? ItemCode { get; set; }
    /// <summary>Gets or sets the item description.</summary>
    [XmlElement("ItemDesc")]
    public string? ItemDesc { get; set; }
    /// <summary>Gets or sets the raw value indicating if the registration is active.</summary>
    [XmlElement("Active")]
    public string? ActiveRaw { get; set; }

    /// <summary>Gets a value indicating whether the registration is active.</summary>
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