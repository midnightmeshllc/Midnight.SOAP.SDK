using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

/// <summary>
/// Represents the request body for listing mail classes in the Midnight SOAP API.
/// </summary>
[XmlRoot("MailClassList")]
public class MailClassListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the mail class list request.
    /// </summary>
    public required MailClassListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing mail classes in the Midnight SOAP API.
/// </summary>
public class MailClassListInputParameter
{
    /// <summary>Gets or sets the mail class ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? MailClassID { get; set; }
    /// <summary>Gets or sets the name of the mail class.</summary>
    [XmlElement(IsNullable = true)]
    public string? Name { get; set; }
    /// <summary>Gets or sets a value indicating whether the mail class is active.</summary>
    public bool Active { get; set; } = true;
}