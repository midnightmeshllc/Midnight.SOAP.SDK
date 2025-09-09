using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

/// <summary>
/// Represents the result of a ReasonCodeList request, including a list of reason codes.
/// </summary>
[XmlRoot("Result")]
public class ReasonCodeListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of reason codes returned by the request.
    /// </summary>
    [XmlArray("ReasonCodes")]
    [XmlArrayItem("ReasonCode")]
    public List<ReasonCode> ReasonCodes { get; set; } = new List<ReasonCode>();
}

/// <summary>
/// Represents a reason code entry in the ReasonCodeListResult.
/// </summary>
public class ReasonCode
{
    /// <summary>
    /// Gets or sets the unique identifier for the reason code.
    /// </summary>
    public int? ReasonCodeID { get; set; }

    /// <summary>
    /// Gets or sets the value of the reason code.
    /// </summary>
    [XmlElement("ReasonCode")]
    public string? ReasonCodeValue { get; set; } // Renamed to avoid CS0542

    /// <summary>
    /// Gets or sets the raw value indicating if the reason code is active ("true", "1", etc.).
    /// </summary>
    [XmlElement("Active")]
    public string? ActiveRaw { get; set; }

    /// <summary>
    /// Gets a value indicating whether the reason code is active.
    /// </summary>
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