using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

/// <summary>
/// Represents the request body for listing contact types in the Midnight SOAP API.
/// </summary>
[XmlRoot("ContactTypeList")]
public class ContactTypeListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the contact type list request.
    /// </summary>
    public required ContactTypeListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing contact types in the Midnight SOAP API.
/// </summary>
public class ContactTypeListInputParameter
{
    /// <summary>Gets or sets the contact type ID.</summary>
    public int? ContactTypeID { get; set; }
    /// <summary>Gets or sets the contact type name.</summary>
    public string? ContactTypeName { get; set; }
    /// <summary>Gets or sets a value indicating whether the contact type is active.</summary>
    public bool Active { get; set; } = true;
}