using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

/// <summary>
/// Represents the request body for listing mail sorts in the Midnight SOAP API.
/// </summary>
[XmlRoot("MailSortList")]
public class MailSortListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the mail sort list request.
    /// </summary>
    public required MailSortListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing mail sorts in the Midnight SOAP API.
/// </summary>
public class MailSortListInputParameter
{
    /// <summary>Gets or sets the mail sort ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? MailSortID { get; set; }
    /// <summary>Gets or sets the name of the mail sort.</summary>
    [XmlElement(IsNullable = true)]
    public string? Name { get; set; }
    /// <summary>Gets or sets a value indicating whether the mail sort is active.</summary>
    public bool Active { get; set; } = true;
}