using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.CustomerOutputs;

/// <summary>
/// Represents the result of a customer ghost number list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class CustomerGhostNumberListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of ghost numbers returned by the request.
    /// </summary>
    [XmlArray("GhostList")]
    [XmlArrayItem("Ghost")]
    public List<Ghost>? GhostList { get; set; } = new List<Ghost>();
}

/// <summary>
/// Represents a ghost number in the Midnight SOAP API.
/// </summary>
public class Ghost
{
    /// <summary>Gets or sets the item code.</summary>
    [XmlElement("ItemCode")]
    public string? ItemCode { get; set; }
    /// <summary>Gets or sets the description.</summary>
    [XmlElement("Description")]
    public string? Description { get; set; }
    /// <summary>Gets or sets the raw value indicating if the ghost number is active.</summary>
    [XmlElement("Active")]
    public string? ActiveRaw { get; set; }

    /// <summary>Gets a value indicating whether the ghost number is active.</summary>
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