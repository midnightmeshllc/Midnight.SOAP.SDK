using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.CustomerInputs;

[XmlRoot("CustomerUpdate")]
public class CustomerUpdateRequestBody
{
    public required CustomerUpdateInputParameter InputParameter { get; set; }
}

public class CustomerUpdateInputParameter : UserDefinedFieldsFirst10
{
    public required string CustomerCode { get; set; }
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
    public bool? Notification { get; set; } = null;
    public string? NotificationText { get; set; } = null;
    public bool? Taxable { get; set; } = null;
    public string? TaxJurisdictionName { get; set; } = null;
    public string? TaxExemptionName { get; set; } = null;
    public string? PostageMarkupType { get; set; } = null;
    public decimal? PostageMarkupValue { get; set; } = null;
    public decimal? UpaidBalanceLimit { get; set; } = null;
    public CustomerAddress? CustomerAddress { get; set; } = null;
    public BillingAddress? BillingAddress { get; set; } = null;
    public ShippingAddress? ShippingAddress { get; set; } = null;
}