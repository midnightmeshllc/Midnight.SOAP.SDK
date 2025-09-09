using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

/// <summary>
/// Represents the result of a mail class list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class MailClassListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of mail classes returned by the request.
    /// </summary>
    [XmlArray("MailClasses")]
    [XmlArrayItem("MailClass")]
    public List<MailClass> MailClasses { get; set; } = new List<MailClass>();
}

/// <summary>
/// Represents a mail class in the Midnight SOAP API.
/// </summary>
public class MailClass
{
    /// <summary>Gets or sets the mail class ID.</summary>
    public int? MailClassID { get; set; }
    /// <summary>Gets or sets the name of the mail class.</summary>
    public string? Name { get; set; }
}