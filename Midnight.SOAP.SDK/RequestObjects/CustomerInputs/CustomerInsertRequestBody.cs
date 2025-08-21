using Midnight.SOAP.SDK.CommonObjects;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.CustomerInputs;

[XmlRoot("CustomerInsert")]
public class CustomerInsertRequestBody
{
    [Required]
    public required CustomerInsertInputParameter InputParameter { get; set; }
}

public class CustomerInsertInputParameter : UserDefinedFields
{
    [Required]
    public string CustomerCode { get; set; } = string.Empty;
    public string? CustomerName { get; set; } = null;
    public string? Phone { get; set; } = null;
    public string? PhoneExtension { get; set; } = null;
    public string? Fax { get; set; } = null;
    public string? Email { get; set; } = null;
    public string? Website { get; set; } = null;
    public string? Terms { get; set; } = null;
    public string? Company { get; set; } = null;
    public string? CustomerNotes { get; set; } = null;
    public string? CustomerType { get; set; } = null;
    public int? ParentCustomerCode { get; set; } = null;
    public string? SalesRep { get; set; } = null;
    public string? CSR { get; set; } = null;
    public string? PermitNumber { get; set; } = null;
    public string? AccountStatus { get; set; } = null;
    public bool? Notification { get; set; } = false;
    public string? NotificationText { get; set; } = null;
    public bool? Taxable { get; set; } = true;
    public string? TaxJurisdictionName { get; set; } = null;
    public string? TaxExemptionName { get; set; } = null;
    public string? PostageMarkupType { get; set; } = null;
    public decimal? PostageMarkupValue { get; set; } = decimal.Zero;
    public decimal? UpaidBalanceLimit { get; set; } = decimal.Zero;
    public string? AccountingCode { get; set; } = null;

    public CustomerAddress? CustomerAddress { get; set; }
    public ShippingAddress? ShippingAddress { get; set; }
    public BillingAddress? BillingAdress { get; set; }
}