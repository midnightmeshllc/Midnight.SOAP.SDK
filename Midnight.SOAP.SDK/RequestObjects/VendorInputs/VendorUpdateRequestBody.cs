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
    [XmlElement(IsNullable = true)]
    public string? ContactName { get; set; }
    /// <summary>Gets or sets the vendor code.</summary>
    [XmlElement(IsNullable = true)]
    public string? Code { get; set; }
    /// <summary>Gets or sets the terms.</summary>
    [XmlElement(IsNullable = true)]
    public string? Terms { get; set; }
    /// <summary>Gets or sets the email address.</summary>
    [XmlElement(IsNullable = true)]
    public string? Email { get; set; }
    /// <summary>Gets or sets the URL.</summary>
    [XmlElement(IsNullable = true)]
    public string? URL { get; set; }
    /// <summary>Gets or sets the licensee ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? LicenseeID { get; set; }
    /// <summary>Gets or sets a value indicating whether the vendor is active.</summary>
    [XmlElement(IsNullable = true)]
    public bool? Active { get; set; }
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
    /// <summary>Gets or sets the city.</summary>
    [XmlElement(IsNullable = true)]
    public string? City { get; set; }
    /// <summary>Gets or sets the state code.</summary>
    [XmlElement(IsNullable = true)]
    public string? StateCode { get; set; }
    /// <summary>Gets or sets the zip code.</summary>
    [XmlElement(IsNullable = true)]
    public string? ZipCode { get; set; }
    /// <summary>Gets or sets the country code.</summary>
    [XmlElement(IsNullable = true)]
    public string? CountryCode { get; set; }
    /// <summary>Gets or sets the phone number.</summary>
    [XmlElement(IsNullable = true)]
    public string? Phone { get; set; }
    /// <summary>Gets or sets the fax number.</summary>
    [XmlElement(IsNullable = true)]
    public string? Fax { get; set; }
}
