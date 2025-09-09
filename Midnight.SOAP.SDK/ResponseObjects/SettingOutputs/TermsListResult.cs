using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

/// <summary>
/// Represents the result of a terms list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class TermsListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of terms returned by the request.
    /// </summary>
    [XmlArray("TermsList")]
    [XmlArrayItem("Terms")]
    public List<Terms> TermsList { get; set; } = new List<Terms>();
}

/// <summary>
/// Represents a terms entry in the Midnight SOAP API.
/// </summary>
public class Terms
{
    /// <summary>Gets or sets the terms code.</summary>
    public string? TermsCode { get; set; }
    /// <summary>Gets or sets the terms name.</summary>
    public string? TermsName { get; set; }
    /// <summary>Gets or sets the number of days till due.</summary>
    public int? DaysTillDue { get; set; }
}