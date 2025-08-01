
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.VendorContactInputs;

[XmlRoot("VendorContactUpdate")]
public class VendorContactUpdateRequestBody
{
    public required VendorContactUpdateInputParameter VendorContact { get; set; }
}

public class VendorContactUpdateInputParameter
{
    public required int VendorID { get; set; }
    public required int ContactID { get; set; }
    public string? Salutation { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? MiddleName { get; set; }
    public string? Suffix { get; set; }
    public string? Title { get; set; }
    public string? Company { get; set; }
    public bool Active { get; set; }
    public int? ContactTypeID { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? Address3 { get; set; }
    public string? City { get; set; }
    public string? StateCode { get; set; }
    public string? Zip { get; set; }
    public string? CountryCode { get; set; }
    public int? BusinessPhone { get; set; }
    public string? BusinessPhoneExtension { get; set; }
    public int? OtherPhone { get; set; }
    public string? OtherPhoneExtension { get; set; }
    public int? Fax { get; set; }
    public string? FaxExtension { get; set; }
    public string? BusinessEmail { get; set; }
    public string? OtherEmail { get; set; }
}