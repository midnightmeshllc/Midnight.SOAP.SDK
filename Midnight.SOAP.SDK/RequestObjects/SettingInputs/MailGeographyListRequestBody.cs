using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

/// <summary>
/// Represents the request body for listing mail geographies in the Midnight SOAP API.
/// </summary>
[XmlRoot("MailGeographyList")]
public class MailGeographyListRequestBody 
{
    /// <summary>
    /// Gets or sets the input parameter for the mail geography list request.
    /// </summary>
    public required MailGeographyListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing mail geographies in the Midnight SOAP API.
/// </summary>
public class MailGeographyListInputParameter
{
    /// <summary>Gets or sets the mail geography ID.</summary>
    public int? MailGeographyID { get; set; }
    /// <summary>Gets or sets the name of the mail geography.</summary>
    public string? Name { get; set; }
    /// <summary>Gets or sets a value indicating whether the mail geography is active.</summary>
    public bool Active { get; set; } = true;
}