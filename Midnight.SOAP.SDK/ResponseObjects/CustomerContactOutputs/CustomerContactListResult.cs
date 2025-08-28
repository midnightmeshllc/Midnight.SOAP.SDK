using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.CustomerContactOutputs;

/// <summary>
/// Represents the result of a customer contact list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class CustomerContactListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of customer contacts returned by the request.
    /// </summary>
    [XmlArray("CustomerContacts")]
    [XmlArrayItem("CustomerContact")]
    public List<CustomerContact>? CustomerContacts { get; set; } = new List<CustomerContact>();
}

/// <summary>
/// Represents a customer contact in the Midnight SOAP API.
/// </summary>
public class CustomerContact
{
    /// <summary>Gets or sets the customer ID.</summary>
    [XmlElement("CustomerID")]
    public int CustomerID { get; set; }
    /// <summary>Gets or sets the contact ID.</summary>
    [XmlElement("ContactID")]
    public int ContactID { get; set; }
    /// <summary>Gets or sets the first name.</summary>
    [XmlElement("FirstName")]
    public string? FirstName { get; set; }
    /// <summary>Gets or sets the middle name.</summary>
    [XmlElement("MiddleName")]
    public string? MiddleName { get; set; }
    /// <summary>Gets or sets the last name.</summary>
    [XmlElement("LastName")]
    public string? LastName { get; set; }
    /// <summary>Gets or sets the email address.</summary>
    [XmlElement("EmailAddress")]
    public string? EmailAddress { get; set; }
    /// <summary>Gets or sets the raw value indicating if the contact is active.</summary>
    [XmlElement("Active")]
    public string? ActiveRaw { get; set; }

    /// <summary>Gets a value indicating whether the contact is active.</summary>
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