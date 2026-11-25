using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.VendorInputs;

/// <summary>
/// Represents the request body for inserting a vendor in the Midnight SOAP API.
/// ** NOTICE: This method has a known issue where it is requiring some fields that were not previously required, like URL. **
/// If you are getting an error review the logs and determine which field is missing and add it to the request body. We have a ticket open with support to address this issue.
/// </summary>
[XmlRoot("Vendor")]
public class VendorInsertRequestBody : UserDefinedFields
{
    /// <summary>Gets or sets the vendor name.</summary>
    public required string VendorName { get; set; }

    /// <summary>Gets or sets the contact name.</summary>
    public string? ContactName { get; set; }
    /// <summary>Determines whether <see cref="ContactName"/> should be serialized.</summary>
    public bool ShouldSerializeContactName() => !string.IsNullOrEmpty(ContactName);

    /// <summary>Gets or sets the vendor code.</summary>
    public required string Code { get; set; }

    /// <summary>This should match up to the Description of a Term within Midnight, not the TermsCode</summary>
    public required string TermsCode { get; set; }

    /// <summary>Gets or sets the email address.</summary>
    public string? Email { get; set; }
    /// <summary>Determines whether <see cref="Email"/> should be serialized.</summary>
    public bool ShouldSerializeEmail() => !string.IsNullOrEmpty(Email);

    /// <summary>
    /// Gets or sets the URL.
    /// ** NOTICE: The Midnight API has been observed to require this field even though it is not documented as required. Consider leaving this always serialized. **
    /// </summary>
    public string? URL { get; set; } = "https://";
    /// <summary>Determines whether <see cref="URL"/> should be serialized.</summary>
    public bool ShouldSerializeURL() => !string.IsNullOrEmpty(URL);

    /// <summary>Gets or sets the licensee ID.</summary>
    public int? LicenseeID { get; set; }
    /// <summary>Determines whether <see cref="LicenseeID"/> should be serialized.</summary>
    public bool ShouldSerializeLicenseeID() => LicenseeID.HasValue;

    /// <summary>Gets or sets a value indicating whether the vendor is active.</summary>
    public bool Active { get; set; } = true;

    /// <summary>Gets or sets the comment.</summary>
    public string? Comment { get; set; }
    /// <summary>Determines whether <see cref="Comment"/> should be serialized.</summary>
    public bool ShouldSerializeComment() => !string.IsNullOrEmpty(Comment);

    /// <summary>Gets or sets address line 1.</summary>
    public string? Address1 { get; set; }
    /// <summary>Determines whether <see cref="Address1"/> should be serialized.</summary>
    public bool ShouldSerializeAddress1() => !string.IsNullOrEmpty(Address1);

    /// <summary>Gets or sets address line 2.</summary>
    public string? Address2 { get; set; }
    /// <summary>Determines whether <see cref="Address2"/> should be serialized.</summary>
    public bool ShouldSerializeAddress2() => !string.IsNullOrEmpty(Address2);

    /// <summary>Gets or sets address line 3.</summary>
    public string? Address3 { get; set; }
    /// <summary>Determines whether <see cref="Address3"/> should be serialized.</summary>
    public bool ShouldSerializeAddress3() => !string.IsNullOrEmpty(Address3);

    /// <summary>Gets or sets the city.</summary>
    public string? City { get; set; }
    /// <summary>Determines whether <see cref="City"/> should be serialized.</summary>
    public bool ShouldSerializeCity() => !string.IsNullOrEmpty(City);

    /// <summary>Gets or sets the state code.</summary>
    public string? StateCode { get; set; }
    /// <summary>Determines whether <see cref="StateCode"/> should be serialized.</summary>
    public bool ShouldSerializeStateCode() => !string.IsNullOrEmpty(StateCode);

    /// <summary>Gets or sets the zip code.</summary>
    public string? ZipCode { get; set; }
    /// <summary>Determines whether <see cref="ZipCode"/> should be serialized.</summary>
    public bool ShouldSerializeZipCode() => !string.IsNullOrEmpty(ZipCode);

    /// <summary>Gets or sets the country code.</summary>
    public string? CountryCode { get; set; }
    /// <summary>Determines whether <see cref="CountryCode"/> should be serialized.</summary>
    public bool ShouldSerializeCountryCode() => !string.IsNullOrEmpty(CountryCode);

    /// <summary>Gets or sets the phone number.</summary>
    public string? Phone { get; set; }
    /// <summary>Determines whether <see cref="Phone"/> should be serialized.</summary>
    public bool ShouldSerializePhone() => !string.IsNullOrEmpty(Phone);

    /// <summary>Gets or sets the fax number.</summary>
    public string? Fax { get; set; }
    /// <summary>Determines whether <see cref="Fax"/> should be serialized.</summary>
    public bool ShouldSerializeFax() => !string.IsNullOrEmpty(Fax);
}
