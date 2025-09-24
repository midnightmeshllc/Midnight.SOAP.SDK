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
    public string? Salutation { get; set; } = null;
    /// <summary>Gets or sets the first name.</summary>
    public string? FirstName { get; set; } = null;
    /// <summary>Gets or sets the last name.</summary>
    public string? LastName { get; set; } = null;
    /// <summary>Gets or sets the middle name.</summary>
    public string? MiddleName { get; set; } = null;
    /// <summary>Gets or sets the suffix.</summary>
    public string? Suffix { get; set; } = null;
    /// <summary>Gets or sets the title.</summary>
    public string? Title { get; set; } = null;
    /// <summary>Gets or sets the vendor name.</summary>
    public string? VendorName { get; set; } = null;
    /// <summary>Gets or sets the address.</summary>
    public VendorContactAddress? Address { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the contact is active.</summary>
    public bool Active { get; set; }
    /// <summary>Gets or sets the contact type ID.</summary>
    public string? ContactTypeID { get; set; } = null;
    /// <summary>Gets or sets the phones.</summary>
    public VendorContactPhones? Phones { get; set; } = null;
    /// <summary>Gets or sets the emails.</summary>
    public VendorContactEmails? Emails { get; set; } = null;
    /// <summary>Gets or sets the comments.</summary>
    public string? Comments { get; set; } = null;
}

/// <summary>
/// Represents the emails for a vendor contact.
/// </summary>
public class VendorContactEmails
{
    /// <summary>Gets or sets the business email address.</summary>
    public string? BusinessEmail { get; set; } = null;
    /// <summary>Gets or sets the other email address.</summary>
    public string? OtherEmail { get; set; } = null;
}

/// <summary>
/// Represents the phone numbers for a vendor contact.
/// </summary>
public class VendorContactPhones
{
    /// <summary>Gets or sets the business phone number.</summary>
    public int? BusinessPhone { get; set; } = null;
    /// <summary>Gets or sets the business phone extension.</summary>
    public string? BusinessPhoneExtension { get; set; } = null;
    /// <summary>Gets or sets the other phone number.</summary>
    public int? OtherPhone { get; set; } = null;
    /// <summary>Gets or sets the other phone extension.</summary>
    public string? OtherPhoneExtension { get; set; } = null;
    /// <summary>Gets or sets the fax number.</summary>
    public int? Fax { get; set; } = null;
    /// <summary>Gets or sets the fax extension.</summary>
    public string? FaxExtension { get; set; } = null;
}

/// <summary>
/// Represents the address for a vendor contact.
/// </summary>
public class VendorContactAddress
{
    /// <summary>Gets or sets address line 1.</summary>
    public string? Address1 { get; set; }
    /// <summary>Gets or sets address line 2.</summary>
    public string? Address2 { get; set; }
    /// <summary>Gets or sets address line 3.</summary>
    public string? Address3 { get; set; }
    /// <summary>Gets or sets the city.</summary>
    public string? City { get; set; }
    /// <summary>Gets or sets the state code.</summary>
    public string? StateCode { get; set; }
    /// <summary>Gets or sets the zip code.</summary>
    public string? Zip { get; set; }
    /// <summary>Gets or sets the country code.</summary>
    public string? CountryCode { get; set; }
}