using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.VendorInputs;

/// <summary>
/// Represents the request body for updating a vendor in the Midnight SOAP API.
/// **WARNING: All fields in the request body should be passed for the time being, otherwise the API will overwrite missing fields with null values. **
/// This is a known issue with the Midnight SOAP API and should be addressed in a future update. We have a ticket open with support to address this issue.
/// </summary>
[XmlRoot("Vendor")]
public class VendorUpdateRequestBody : UserDefinedFields
{
    /// <summary>Gets or sets the vendor ID.</summary>
    public required int VendorId { get; set; }
    /// <summary>Gets or sets the vendor name.</summary>
    public required string VendorName { get; set; }

    /// <summary>Gets or sets the contact name.</summary>
    public string? ContactName { get; set; }
    public bool ShouldSerializeContactName() => IsSet(ContactName);

    /// <summary>Gets or sets the vendor code.</summary>
    public string? Code { get; set; }
    public bool ShouldSerializeCode() => IsSet(Code);

    /// <summary>Terms should always be set, otherwise the API will wipe out the value.</summary>
    public required string? Terms { get; set; }

    /// <summary>Gets or sets the email address.</summary>
    public string? Email { get; set; }
    public bool ShouldSerializeEmail() => IsSet(Email);

    /// <summary>Gets or sets the URL.</summary>
    public string? URL { get; set; }
    public bool ShouldSerializeURL() => IsSet(URL);

    /// <summary>Gets or sets the licensee ID.</summary>
    public int? LicenseeID { get; set; }
    public bool ShouldSerializeLicenseeID() => LicenseeID.HasValue;

    /// <summary>Gets or sets a value indicating whether the vendor is active.</summary>
    public bool? Active { get; set; }
    public bool ShouldSerializeActive() => Active.HasValue;

    /// <summary>Gets or sets the comment.</summary>
    public string? Comment { get; set; }
    public bool ShouldSerializeComment() => IsSet(Comment);

    /// <summary>Gets or sets address line 1.</summary>
    public string? Address1 { get; set; }
    public bool ShouldSerializeAddress1() => IsSet(Address1);

    /// <summary>Gets or sets address line 2.</summary>
    public string? Address2 { get; set; }
    public bool ShouldSerializeAddress2() => IsSet(Address2);

    /// <summary>Gets or sets address line 3.</summary>
    public string? Address3 { get; set; }
    public bool ShouldSerializeAddress3() => IsSet(Address3);

    /// <summary>Gets or sets the city.</summary>
    public string? City { get; set; }
    public bool ShouldSerializeCity() => IsSet(City);

    /// <summary>Gets or sets the state code.</summary>
    public string? StateCode { get; set; }
    public bool ShouldSerializeStateCode() => IsSet(StateCode);

    /// <summary>Gets or sets the zip code.</summary>
    public string? ZipCode { get; set; }
    public bool ShouldSerializeZipCode() => IsSet(ZipCode);

    /// <summary>If CountryCode is not set with each VendorUpdate, it's value will be wiped out.</summary>
    public string? CountryCode { get; set; }
    public bool ShouldSerializeCountryCode() => IsSet(CountryCode);

    /// <summary>Gets or sets the phone number.</summary>
    public string? Phone { get; set; }
    public bool ShouldSerializePhone() => IsSet(Phone);

    /// <summary>Gets or sets the fax number.</summary>
    public string? Fax { get; set; }
    public bool ShouldSerializeFax() => IsSet(Fax);

    /// <summary>Shared helper for determining whether a nullable string field has a meaningful value to serialize.</summary>
    private static bool IsSet(string? value) => !string.IsNullOrEmpty(value);
}
