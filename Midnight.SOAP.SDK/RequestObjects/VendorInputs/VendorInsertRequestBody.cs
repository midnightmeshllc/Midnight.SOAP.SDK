
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.VendorInputs;

[XmlRoot("Vendor")]
public class VendorInsertRequestBody : UserDefinedFields
{
    public required string VendorName { get; set; }
    public string? ContactName { get; set; }
    public string? Code { get; set; }
    public string? terms { get; set; }
    public string? Email { get; set; }
    public string? URL { get; set; }
    public int? LicenseeID { get; set; }
    public bool Active { get; set; }
    public string? Comment { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? Address3 { get; set; }
    public string? City { get; set; }
    public string? StateCode { get; set; }
    public string? ZipCode { get; set; }
    public string? CountryCode { get; set; }
    public string? Phone { get; set; }
    public string? Fax { get; set; }
}
