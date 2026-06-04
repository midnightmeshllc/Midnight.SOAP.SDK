using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.VendorContactInputs;

/// <summary>
/// Represents the request body for inserting a vendor contact in the Midnight SOAP API.
/// </summary>
[XmlRoot("VendorContactInsert")]
public class VendorContactInsertRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for vendor contact insert.
    /// </summary>
    public required VendorContactInsertInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameters for inserting vendor contacts.
/// </summary>
public class VendorContactInsertInputParameter
{
    /// <summary>
    /// Gets or sets the list of vendor contacts to insert.
    /// </summary>
    public required List<VendorContactInsert> VendorContacts { get; set; }
}

/// <summary>
/// Represents a vendor contact to insert.
/// </summary>
public class VendorContactInsert
{
    /// <summary>Gets or sets the vendor ID.</summary>
    public required int VendorID { get; set; }
    /// <summary>Gets or sets the salutation.</summary>
    [XmlElement(IsNullable = true)]
    public string? Salutation { get; set; } = null;
    /// <summary>Gets or sets the first name.</summary>
    [XmlElement(IsNullable = true)]
    public string? FirstName { get; set; } = null;
    /// <summary>Gets or sets the last name.</summary>
    [XmlElement(IsNullable = true)]
    public string? LastName { get; set; } = null;
    /// <summary>Gets or sets the middle name.</summary>
    [XmlElement(IsNullable = true)]
    public string? MiddleName { get; set; } = null;
    /// <summary>Gets or sets the suffix.</summary>
    [XmlElement(IsNullable = true)]
    public string? Suffix { get; set; } = null;
    /// <summary>Gets or sets the title.</summary>
    [XmlElement(IsNullable = true)]
    public string? Title { get; set; } = null;
    /// <summary>Gets or sets the vendor name.</summary>
    [XmlElement(IsNullable = true)]
    public string? VendorName { get; set; } = null;
    /// <summary>Gets or sets the address.</summary>
    [XmlElement(IsNullable = true)]
    public VendorContactAddress? Address { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the contact is active.</summary>
    public bool Active { get; set; }
    /// <summary>Gets or sets the contact type ID.</summary>
    [XmlElement(IsNullable = true)]
    public string? ContactTypeID { get; set; } = null;
    /// <summary>Gets or sets the phones.</summary>
    [XmlElement(IsNullable = true)]
    public VendorContactPhones? Phones { get; set; } = null;
    /// <summary>Gets or sets the emails.</summary>
    [XmlElement(IsNullable = true)]
    public VendorContactEmails? Emails { get; set; } = null;
    /// <summary>Gets or sets the comments.</summary>
    [XmlElement(IsNullable = true)]
    public string? Comments { get; set; } = null;
}

/// <summary>
/// Represents the emails for a vendor contact.
/// </summary>
public class VendorContactEmails
{
    /// <summary>Gets or sets the business email address.</summary>
    [XmlElement(IsNullable = true)]
    public string? BusinessEmail { get; set; } = null;
    /// <summary>Gets or sets the other email address.</summary>
    [XmlElement(IsNullable = true)]
    public string? OtherEmail { get; set; } = null;
}

/// <summary>
/// Represents the phone numbers for a vendor contact.
/// </summary>
public class VendorContactPhones
{
    /// <summary>Gets or sets the business phone number.</summary>
    [XmlElement(IsNullable = true)]
    public string? BusinessPhone { get; set; } = null;
    /// <summary>Gets or sets the business phone extension.</summary>
    [XmlElement(IsNullable = true)]
    public string? BusinessPhoneExtension { get; set; } = null;
    /// <summary>Gets or sets the other phone number.</summary>
    [XmlElement(IsNullable = true)]
    public string? OtherPhone { get; set; } = null;
    /// <summary>Gets or sets the other phone extension.</summary>
    [XmlElement(IsNullable = true)]
    public string? OtherPhoneExtension { get; set; } = null;
    /// <summary>Gets or sets the fax number.</summary>
    [XmlElement(IsNullable = true)]
    public string? Fax { get; set; } = null;
    /// <summary>Gets or sets the fax extension.</summary>
    [XmlElement(IsNullable = true)]
    public string? FaxExtension { get; set; } = null;
}

/// <summary>
/// Represents the address for a vendor contact.
/// </summary>
public class VendorContactAddress
{
    /// <summary>Gets or sets address line 1.</summary>
    [XmlElement(IsNullable = true)]
    public string? Address1 { get; set; }
    /// <summary>Gets or sets address line 2.</summary>
    [XmlElement(IsNullable = true)]
    public string? Address2 { get; set; }
    /// <summary>Gets or sets address line 3.</summary>
    [XmlElement(IsNullable = true)]
    public string? Address3 { get; set; }
    /// <summary>Gets or sets the city.</summary>
    [XmlElement(IsNullable = true)]
    public string? City { get; set; }
    /// <summary>Gets or sets the state code.</summary>
    [XmlElement(IsNullable = true)]
    public string? StateCode { get; set; }
    /// <summary>Gets or sets the zip code.</summary>
    [XmlElement(IsNullable = true)]
    public string? Zip { get; set; }
    /// <summary>Gets or sets the country code.</summary>
    [XmlElement(IsNullable = true)]
    public string? CountryCode { get; set; }
}