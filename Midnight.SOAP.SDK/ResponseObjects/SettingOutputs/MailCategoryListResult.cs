using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

/// <summary>
/// Represents the result of a mail category list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class MailCategoryListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of mail categories returned by the request.
    /// </summary>
    [XmlArray("MailCategories")]
    [XmlArrayItem("MailCategory")]
    public List<MailCategory> MailCategories { get; set; } = new List<MailCategory>();
}

/// <summary>
/// Represents a mail category in the Midnight SOAP API.
/// </summary>
public class MailCategory
{
    /// <summary>Gets or sets the mail category ID.</summary>
    public int? MailCategoryID { get; set; }
    /// <summary>Gets or sets the name of the mail category.</summary>
    public string? Name { get; set; }
}