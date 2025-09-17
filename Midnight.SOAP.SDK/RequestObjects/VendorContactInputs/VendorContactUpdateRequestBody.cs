using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.VendorContactInputs;

/// <summary>
/// Represents the request body for updating a vendor contact in the Midnight SOAP API.
/// </summary>
[XmlRoot("VendorContactUpdate")]
public class VendorContactUpdateRequestBody
{
    /// <summary>
    /// Gets or sets the vendor contact update input parameter.
    /// </summary>
    public required VendorContactUpdateInputParameter VendorContact { get; set; }
}

/// <summary>
/// Represents the input parameters for updating a vendor contact.
/// </summary>
public class VendorContactUpdateInputParameter
{
    /// <summary>Gets or sets the vendor ID.</summary>
    public required int VendorID { get; set; }
    /// <summary>Gets or sets the contact ID.</summary>
    public required int ContactID { get; set; }
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
    /// <summary>Gets or sets the company name.</summary>
    public string? Company { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the contact is active.</summary>
    public bool Active { get; set; }
    /// <summary>Gets or sets the contact type ID.</summary>
    public int? ContactTypeID { get; set; } = null;
    /// <summary>Gets or sets address line 1.</summary>
    public string? Address1 { get; set; } = null;
    /// <summary>Gets or sets address line 2.</summary>
    public string? Address2 { get; set; } = null;
    /// <summary>Gets or sets address line 3.</summary>
    public string? Address3 { get; set; } = null;
    /// <summary>Gets or sets the city.</summary>
    public string? City { get; set; } = null;
    /// <summary>Gets or sets the state code.</summary>
    public string? StateCode { get; set; } = null;
    /// <summary>Gets or sets the zip code.</summary>
    public string? Zip { get; set; } = null;
    /// <summary>Gets or sets the country code.</summary>
    public string? CountryCode { get; set; } = null;
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
    /// <summary>Gets or sets the business email address.</summary>
    public string? BusinessEmail { get; set; } = null;
    /// <summary>Gets or sets the other email address.</summary>
    public string? OtherEmail { get; set; } = null;
}