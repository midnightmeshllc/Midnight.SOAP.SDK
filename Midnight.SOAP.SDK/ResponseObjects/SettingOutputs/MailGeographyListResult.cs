using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

/// <summary>
/// Represents the result of a mail geography list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class MailGeographyListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of mail geographies returned by the request.
    /// </summary>
    [XmlArray("MailGeographies")]
    [XmlArrayItem("MailGeography")]
    public List<MailGeography> MailGeographies { get; set; } = new List<MailGeography>();
}

/// <summary>
/// Represents a mail geography in the Midnight SOAP API.
/// </summary>
public class MailGeography
{
    /// <summary>Gets or sets the mail geography ID.</summary>
    public int? MailGeographyID { get; set; }
    /// <summary>Gets or sets the name of the mail geography.</summary>
    public string? Name { get; set; }
}