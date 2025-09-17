using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

/// <summary>
/// Represents the request body for listing terms in the Midnight SOAP API.
/// </summary>
[XmlRoot("TermsList")]
public class TermsListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the terms list request.
    /// </summary>
    public required TermsListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing terms in the Midnight SOAP API.
/// </summary>
public class TermsListInputParameter
{
    /// <summary>Gets or sets the terms code.</summary>
    public string? TermsCode { get; set; } = null;
    /// <summary>Gets or sets the terms name.</summary>
    public string? TermsName { get; set; } = null;
    /// <summary>Gets or sets the number of days till due.</summary>
    public int? DaysTillDue { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the terms are active.</summary>
    public bool Active { get; set; } = true;
}