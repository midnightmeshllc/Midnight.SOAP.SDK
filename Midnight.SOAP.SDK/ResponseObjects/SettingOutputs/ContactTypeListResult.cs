using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

/// <summary>
/// Represents the result of a contact type list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class ContactTypeListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of contact types returned by the request.
    /// </summary>
    [XmlArray("ContactTypes")]
    [XmlArrayItem("ContactType")]
    public List<ContactType> ContactTypes { get; set; } = new List<ContactType>();
}

/// <summary>
/// Represents a contact type in the Midnight SOAP API.
/// </summary>
public class ContactType
{
    /// <summary>Gets or sets the contact type ID.</summary>
    public int? ContactTypeID { get; set; }
    /// <summary>Gets or sets the contact type name.</summary>
    public string? ContactTypeName { get; set; }

    /// <summary>Gets or sets the raw value indicating if the contact type is active.</summary>
    [XmlElement("Active")]
    public string? ActiveRaw { get; set; }

    /// <summary>Gets a value indicating whether the contact type is active.</summary>
    [XmlIgnore]
    public bool Active
    {
        get
        {
            if (string.IsNullOrWhiteSpace(ActiveRaw)) return false;
            return string.Equals(ActiveRaw, "true", StringComparison.OrdinalIgnoreCase)
                || ActiveRaw == "1";
        }
    }
}