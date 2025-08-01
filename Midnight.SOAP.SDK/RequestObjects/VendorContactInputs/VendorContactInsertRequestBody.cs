
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.VendorContactInputs;

[XmlRoot("VendorContactInsert")]
public class VendorContactInsertRequestBody
{
    public required VendorContactInsertInputParameter InputParameter { get; set; }
}

public class VendorContactInsertInputParameter
{
    public required List<VendorContact> VendorContacts { get; set; }
}

public class VendorContact
{
    public required int VendorID { get; set; }
    public string? Salutation { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? MiddleName { get; set; }
    public string? Suffix { get; set; }
    public string? Title { get; set; }
    public string? VendorName { get; set; }
    public VendorContactAddress? Address { get; set; }
    public bool Active { get; set; }
    public string? ContactTypeID { get; set; }
    public VendorContactPhones? Phones { get; set; }
    public VendorContactEmails? Emails { get; set; }
    public string? Comments { get; set; }
}

public class VendorContactEmails
{
    public string? BusinessEmail { get; set; }
    public string? OtherEmail { get; set; }
}

public class VendorContactPhones
{
    public int? BusinessPhone { get; set; }
    public string? BusinessPhoneExtension { get; set; }
    public int? OtherPhone { get; set; }
    public string? OtherPhoneExtension { get; set; }
    public int? Fax { get; set; }
    public string? FaxExtension { get; set; }
}

public class VendorContactAddress
{
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? Address3 { get; set; }
    public string? City { get; set; }
    public string? StateCode { get; set; }
    public string? Zip { get; set; }
    public string? CountryCode { get; set; }
}