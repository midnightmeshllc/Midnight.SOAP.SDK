using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

/// <summary>
/// Represents the result of a mail sort list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class MailSortListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of mail sorts returned by the request.
    /// </summary>
    [XmlArray("MailSorts")]
    [XmlArrayItem("MailSort")]
    public List<MailSort> MailSorts { get; set; } = new List<MailSort>();
}

/// <summary>
/// Represents a mail sort in the Midnight SOAP API.
/// </summary>
public class MailSort
{
    /// <summary>Gets or sets the mail sort ID.</summary>
    public int? MailSortID { get; set; }
    /// <summary>Gets or sets the name of the mail sort.</summary>
    public string? Name { get; set; }
}