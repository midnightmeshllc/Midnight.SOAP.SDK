using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.CustomerOutputs;

/// <summary>
/// Represents the result of a customer permit number list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class CustomerPermitNumberListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of permit numbers returned by the request.
    /// </summary>
    [XmlArray("PermitNumberList")]
    [XmlArrayItem("PermitNumber")]
    public List<PermitNumber> PermitNumberList { get; set; } = new List<PermitNumber>();
}

/// <summary>
/// Represents a permit number in the Midnight SOAP API.
/// </summary>
public class PermitNumber
{
    /// <summary>Gets or sets the permit code.</summary>
    [XmlElement("PermitCode")]
    public string? PermitCode { get; set; }
    /// <summary>Gets or sets the permit description.</summary>
    [XmlElement("PermitDesc")]
    public string? PermitDesc { get; set; }
    /// <summary>Gets or sets the permit type.</summary>
    [XmlElement("PermitType")]
    public string? PermitType { get; set; }
    /// <summary>Gets or sets the account number.</summary>
    [XmlElement("AccNumber")]
    public string? AccNumber { get; set; }
    /// <summary>Gets or sets the raw value indicating if the permit is active.</summary>
    [XmlElement("Active")]
    public string? ActiveRaw { get; set; }

    /// <summary>Gets a value indicating whether the permit is active.</summary>
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