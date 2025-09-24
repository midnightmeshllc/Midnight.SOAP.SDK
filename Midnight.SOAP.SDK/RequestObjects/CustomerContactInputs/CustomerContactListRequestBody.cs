using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.CustomerContactInputs;

/// <summary>
/// Represents the request body for listing customer contacts in the Midnight SOAP API.
/// </summary>
[XmlRoot("CustomerContactList")]
public class CustomerContactListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the customer contact list request.
    /// </summary>
    [Required]
    public required CustomerContactListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing customer contacts in the Midnight SOAP API.
/// By default, If Active is True, all active contacts are returned, if False, all inactive contacts are returned. If neither is entered, all active and inactive contacts are returned.
/// </summary>
public class CustomerContactListInputParameter
{
    /// <summary>Gets or sets the customer ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? CustomerID { get; set; }
    /// <summary>Gets or sets the contact ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? ContactID { get; set; }
    /// <summary>Gets or sets the first name.</summary>
    [XmlElement(IsNullable = true)]
    public string? FirstName { get; set; }
    /// <summary>Gets or sets the middle name.</summary>
    [XmlElement(IsNullable = true)]
    public string? MiddleName { get; set; }
    /// <summary>Gets or sets the last name.</summary>
    [XmlElement(IsNullable = true)]
    public string? LastName { get; set; }
    /// <summary>Gets or sets the email address.</summary>
    [XmlElement(IsNullable = true)]
    public string? EmailAddress { get; set; }
    /// <summary>Gets or sets a value indicating whether the contact is active.</summary>
    [XmlElement(IsNullable = true)]
    public bool? Active { get; set; }
}