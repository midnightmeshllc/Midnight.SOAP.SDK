using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.CustomerContactInputs;

[XmlRoot("CustomerContactInsert")]
public class CustomerContactInsertRequestBody
{
    [Required]
    public required CustomerContactInsertInputParamater InputParamater { get; set; }
}

public class CustomerContactInsertInputParamater
{
    [XmlArrayItem("CustomerContacts")]
    public required List<CustomerContactInserts> CustomerContacts { get; set; }
}

public class CustomerContactInserts
{
    public required int CustomerID { get; set; }
    public string? Salutation { get; set; } = null;
    public string? FirstName { get; set; } = null;
    public string? MiddleName { get; set; } = null;
    public string? LastName { get; set; } = null;
    public string? Suffix { get; set; } = null;
    public string? Title { get; set; } = null;
    public string? Company { get; set; } = null;
    public bool? Active { get; set; } = true;
    public int? ContactTypeID { get; set; }
    public string? Comment { get; set; } = null;
    public string? Address1 { get; set; } = null;
    public string? Address2 { get; set; } = null;
    public string? Address3 { get; set; } = null;
    public string? CountryCode { get; set; } = null;
    public string? ZipCode { get; set; } = null;
    public string? StateCode { get; set; } = null;
    public string? BusinessPhone { get; set; } = null;
    public string? BusinessPhoneExtension { get; set; } = null;
    public string? OtherPhone { get; set; } = null;
    public string? OtherPhoneExtension { get; set; } = null;
    public string? Fax { get; set; } = null;
    public string? FaxExtension { get; set; } = null;
    public string? BusinessEmail { get; set; } = null;
    public string? OtherEmail { get; set; } = null;
}