using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.VendorOutputs;

/// <summary>
/// Represents the result of a vendor list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class VendorListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of vendors returned by the request.
    /// </summary>
    [XmlArray("Vendors")]
    [XmlArrayItem("Vendor")]
    public List<Vendor> Vendors { get; set; } = new List<Vendor>();
}

/// <summary>
/// Represents a vendor in the Midnight SOAP API.
/// </summary>
public class Vendor : UserDefinedFields
{
    /// <summary>Gets or sets the vendor ID.</summary>
    public int? VendorID { get; set; }
    /// <summary>Gets or sets the company ID.</summary>
    public int? CompanyID { get; set; }
    /// <summary>Gets or sets the vendor code.</summary>
    public string? VendorCode { get; set; }

    /// <summary>Gets or sets the raw value indicating if the vendor is active.</summary>
    [XmlElement("Active")]
    public string? ActiveRaw { get; set; }

    /// <summary>Gets a value indicating whether the vendor is active.</summary>
    [XmlIgnore]
    public bool Active
    {
        get
        {
            if (string.IsNullOrWhiteSpace(ActiveRaw)) return false;
            return string.Equals(ActiveRaw, "true", StringComparison.OrdinalIgnoreCase)
                || ActiveRaw == "1";
        }
    }

    /// <summary>Gets or sets the vendor URL.</summary>
    public string? URL { get; set; }
    /// <summary>Gets or sets the enter date.</summary>
    public string? EnterDate { get; set; }
    /// <summary>Gets or sets address line 1.</summary>
    public string? VendorAddressLine1 { get; set; }
    /// <summary>Gets or sets address line 2.</summary>
    public string? VendorAddressLine2 { get; set; }
    /// <summary>Gets or sets address line 3.</summary>
    public string? VendorAddressLine3 { get; set; }
    /// <summary>Gets or sets the vendor city.</summary>
    public string? VendorAddressCity { get; set; }
    /// <summary>Gets or sets the vendor state.</summary>
    public string? VendorAddressState { get; set; }
    /// <summary>Gets or sets the vendor zip code.</summary>
    public string? VendorAddressZip { get; set; }
    /// <summary>Gets or sets the vendor country.</summary>
    public string? VendorAddressCountry { get; set; }
    /// <summary>Gets or sets the vendor email address.</summary>
    public string? VendorEmailAddress { get; set; }
    /// <summary>Gets or sets the vendor phone number.</summary>
    public int? VendorPhone { get; set; }
    /// <summary>Gets or sets the vendor fax number.</summary>
    public int? VendorFax { get; set; }
    /// <summary>Gets or sets the vendor notes.</summary>
    public string? VendorNotes { get; set; }

}