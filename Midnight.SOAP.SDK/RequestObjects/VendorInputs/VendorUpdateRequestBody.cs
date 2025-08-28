using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.VendorInputs;

/// <summary>
/// Represents the request body for updating a vendor in the Midnight SOAP API.
/// </summary>
[XmlRoot("Vendor")]
public class VendorUpdateRequestBody : UserDefinedFields
{
    /// <summary>Gets or sets the vendor ID.</summary>
    public required int VendorID { get; set; }
    /// <summary>Gets or sets the vendor name.</summary>
    public required string VendorName { get; set; }
    /// <summary>Gets or sets the contact name.</summary>
    public string? ContactName { get; set; }
    /// <summary>Gets or sets the vendor code.</summary>
    public string? Code { get; set; }
    /// <summary>Gets or sets the terms.</summary>
    public string? Terms { get; set; }
    /// <summary>Gets or sets the email address.</summary>
    public string? Email { get; set; }
    /// <summary>Gets or sets the URL.</summary>
    public string? URL { get; set; }
    /// <summary>Gets or sets the licensee ID.</summary>
    public int? LicenseeID { get; set; }
    /// <summary>Gets or sets a value indicating whether the vendor is active.</summary>
    public bool Active { get; set; }
    /// <summary>Gets or sets the comment.</summary>
    public string? Comment { get; set; }
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
    public string? ZipCode { get; set; }
    /// <summary>Gets or sets the country code.</summary>
    public string? CountryCode { get; set; }
    /// <summary>Gets or sets the phone number.</summary>
    public string? Phone { get; set; }
    /// <summary>Gets or sets the fax number.</summary>
    public string? Fax { get; set; }
}
