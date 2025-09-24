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
    [XmlElement(IsNullable = true)]
    public string? Salutation { get; set; }
    /// <summary>Gets or sets the first name.</summary>
    [XmlElement(IsNullable = true)]
    public string? FirstName { get; set; }
    /// <summary>Gets or sets the middle name.</summary>
    [XmlElement(IsNullable = true)]
    public string? MiddleName { get; set; }
    /// <summary>Gets or sets the last name.</summary>
    [XmlElement(IsNullable = true)]
    public string? LastName { get; set; }
    /// <summary>Gets or sets the suffix.</summary>
    [XmlElement(IsNullable = true)]
    public string? Suffix { get; set; }
    /// <summary>Gets or sets the title.</summary>
    [XmlElement(IsNullable = true)]
    public string? Title { get; set; }
    /// <summary>Gets or sets the company.</summary>
    [XmlElement(IsNullable = true)]
    public string? Company { get; set; }
    /// <summary>Gets or sets a value indicating whether the contact is active.</summary>
    [XmlElement(IsNullable = true)]
    public bool? Active { get; set; }
    /// <summary>Gets or sets the contact type ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? ContactTypeID { get; set; }
    /// <summary>Gets or sets the comment.</summary>
    [XmlElement(IsNullable = true)]
    public string? Comment { get; set; }
    /// <summary>Gets or sets address line 1.</summary>
    [XmlElement(IsNullable = true)]
    public string? Address1 { get; set; }
    /// <summary>Gets or sets address line 2.</summary>
    [XmlElement(IsNullable = true)]
    public string? Address2 { get; set; }
    /// <summary>Gets or sets address line 3.</summary>
    [XmlElement(IsNullable = true)]
    public string? Address3 { get; set; }
    /// <summary>Gets or sets the country code.</summary>
    [XmlElement(IsNullable = true)]
    public string? CountryCode { get; set; }
    /// <summary>Gets or sets the zip code.</summary>
    [XmlElement(IsNullable = true)]
    public string? ZipCode { get; set; }
    /// <summary>Gets or sets the state code.</summary>
    [XmlElement(IsNullable = true)]
    public string? StateCode { get; set; }
    /// <summary>Gets or sets the business phone.</summary>
    [XmlElement(IsNullable = true)]
    public string? BusinessPhone { get; set; }
    /// <summary>Gets or sets the business phone extension.</summary>
    [XmlElement(IsNullable = true)]
    public string? BusinessPhoneExtension { get; set; }
    /// <summary>Gets or sets the other phone.</summary>
    [XmlElement(IsNullable = true)]
    public string? OtherPhone { get; set; }
    /// <summary>Gets or sets the other phone extension.</summary>
    [XmlElement(IsNullable = true)]
    public string? OtherPhoneExtension { get; set; }
    /// <summary>Gets or sets the fax number.</summary>
    [XmlElement(IsNullable = true)]
    public string? Fax { get; set; }
    /// <summary>Gets or sets the fax extension.</summary>
    [XmlElement(IsNullable = true)]
    public string? FaxExtension { get; set; }
    /// <summary>Gets or sets the business email.</summary>
    [XmlElement(IsNullable = true)]
    public string? BusinessEmail { get; set; }
    /// <summary>Gets or sets the other email.</summary>
    [XmlElement(IsNullable = true)]
    public string? OtherEmail { get; set; }
}