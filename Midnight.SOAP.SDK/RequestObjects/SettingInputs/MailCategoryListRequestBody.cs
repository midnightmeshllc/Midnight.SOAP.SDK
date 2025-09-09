using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

/// <summary>
/// Represents the request body for listing mail categories in the Midnight SOAP API.
/// </summary>
[XmlRoot("MailCategoryList")]
public class MailCategoryListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the mail category list request.
    /// </summary>
    public required MailCategoryListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing mail categories in the Midnight SOAP API.
/// </summary>
public class MailCategoryListInputParameter
{
    /// <summary>Gets or sets the mail category ID.</summary>
    public int? MailCategoryID { get; set; }
    /// <summary>Gets or sets the name of the mail category.</summary>
    public string? Name { get; set; }
    /// <summary>Gets or sets a value indicating whether the mail category is active.</summary>
    public bool Active { get; set; } = true;
}