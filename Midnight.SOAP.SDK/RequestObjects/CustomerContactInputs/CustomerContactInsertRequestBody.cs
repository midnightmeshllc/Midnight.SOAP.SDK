using Midnight.SOAP.SDK.CommonObjects;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.CustomerContactInputs;

/// <summary>
/// Represents the request body for inserting a customer contact in the Midnight SOAP API.
/// </summary>
[XmlRoot("CustomerContactInsert")]
public class CustomerContactInsertRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the customer contact insert request.
    /// </summary>
    [Required]
    public required CustomerContactInsertInputParamater InputParamater { get; set; }
}

/// <summary>
/// Represents the input parameter for inserting customer contacts in the Midnight SOAP API.
/// </summary>
public class CustomerContactInsertInputParamater
{
    /// <summary>
    /// Gets or sets the list of customer contacts to insert.
    /// </summary>
    [XmlArrayItem("CustomerContacts")]
    public required List<CustomerContactInserts> CustomerContacts { get; set; }
}

/// <summary>
/// Represents a customer contact to insert in the Midnight SOAP API.
/// </summary>
public class CustomerContactInserts : UserDefinedFields
{
    /// <summary>Gets or sets the customer ID.</summary>
    public required int CustomerID { get; set; }
    /// <summary>Gets or sets the salutation.</summary>
    public string? Salutation { get; set; } = null;
    /// <summary>Gets or sets the first name.</summary>
    public string? FirstName { get; set; } = null;
    /// <summary>Gets or sets the middle name.</summary>
    public string? MiddleName { get; set; } = null;
    /// <summary>Gets or sets the last name.</summary>
    public string? LastName { get; set; } = null;
    /// <summary>Gets or sets the suffix.</summary>
    public string? Suffix { get; set; } = null;
    /// <summary>Gets or sets the title.</summary>
    public string? Title { get; set; } = null;
    /// <summary>Gets or sets the company.</summary>
    public string? Company { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the contact is active.</summary>
    public bool? Active { get; set; } = true;
    /// <summary>Gets or sets the contact type ID.</summary>
    public int? ContactTypeID { get; set; }
    /// <summary>Gets or sets the comment.</summary>
    public string? Comment { get; set; } = null;
    /// <summary>Gets or sets address line 1.</summary>
    public string? Address1 { get; set; } = null;
    /// <summary>Gets or sets address line 2.</summary>
    public string? Address2 { get; set; } = null;
    /// <summary>Gets or sets address line 3.</summary>
    public string? Address3 { get; set; } = null;
    /// <summary>Gets or sets the country code.</summary>
    public string? CountryCode { get; set; } = null;
    /// <summary>Gets or sets the zip code.</summary>
    public string? ZipCode { get; set; } = null;
    /// <summary>Gets or sets the state code.</summary>
    public string? StateCode { get; set; } = null;
    /// <summary>Gets or sets the business phone.</summary>
    public string? BusinessPhone { get; set; } = null;
    /// <summary>Gets or sets the business phone extension.</summary>
    public string? BusinessPhoneExtension { get; set; } = null;
    /// <summary>Gets or sets the other phone.</summary>
    public string? OtherPhone { get; set; } = null;
    /// <summary>Gets or sets the other phone extension.</summary>
    public string? OtherPhoneExtension { get; set; } = null;
    /// <summary>Gets or sets the fax number.</summary>
    public string? Fax { get; set; } = null;
    /// <summary>Gets or sets the fax extension.</summary>
    public string? FaxExtension { get; set; } = null;
    /// <summary>Gets or sets the business email.</summary>
    public string? BusinessEmail { get; set; } = null;
    /// <summary>Gets or sets the other email.</summary>
    public string? OtherEmail { get; set; } = null;
}