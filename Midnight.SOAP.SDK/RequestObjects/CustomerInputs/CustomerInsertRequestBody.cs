using Midnight.SOAP.SDK.Models;
using Midnight.SOAP.SDK.RequestObjects.OrderInputs;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.CustomerInputs;

[XmlRoot("CustomerInsert")]
public class CustomerInsertRequestBody
{
    [Required]
    public required CustomerInsertInputParameter InputParameter { get; set; }
}

public class CustomerInsertInputParameter
{
    [Required]
    public string CustomerCode { get; set; } = string.Empty;
    public string? CustomerName { get; set; } = string.Empty;
    public string? Phone { get; set; } = string.Empty;
    public string? PhoneExtension { get; set; } = string.Empty;
    public string? Fax { get; set; } = string.Empty;
    public string? Email { get; set; } = string.Empty;
    public string? Website { get; set; } = string.Empty;
    public string? Terms { get; set; } = string.Empty;
    public string? Company { get; set; } = string.Empty;
    public string? CustomerNotes { get; set; } = string.Empty;
    public string? CustomerType { get; set; } = string.Empty;
    public int? ParentCustomerCode { get; set; }
    public string? SalesRep { get; set; } = string.Empty;
    public string? CSR { get; set; } = string.Empty;
    public string? PermitNumber { get; set; } = string.Empty;
    public string? AccountStatus { get; set; } = string.Empty;
    public bool? Notification { get; set; } = false;
    public string? NotificationText { get; set; } = string.Empty;
    public bool? Taxable { get; set; } = true;
    public string? TaxJurisdictionName { get; set; } = string.Empty;
    public string? TaxExemptionName { get; set; } = string.Empty;
    public string? PostageMarkupType { get; set; } = "$";
    public decimal? PostageMarkupValue { get; set; } = decimal.Zero;
    public decimal? UpaidBalanceLimit { get; set; } = decimal.Zero;
    public string? AccountingCode { get; set; }

    public CustomerAddress? CustomerAddress { get; set; }
    public CustomerShippingAddress? ShippingAddress { get; set; }
    public CustomerBillingAddress? BillingAdress { get; set; }
}

public class CustomerBillingAddress
{
    public string? BillingAddressName { get; set; }
    public string? BillingAddressLine1 { get; set; }
    public string? BillingAddressLine2 { get; set; }
    public string? BillingAddressLine3 { get; set; }
    public string? BillingAddressCity { get; set; }
    public string? BillingAddressState { get; set; }
    public string? BillingAddressZip { get; set; }
    public string? BillingAddressCountry { get; set; } = "United States";
}

public class CustomerShippingAddress
{
    public string? ShippingAddressName { get; set; }
    public string? ShippingAddressLine1 { get; set; }
    public string? ShippingAddressLine2 { get; set; }
    public string? ShippingAddressLine3 { get; set; }
    public string? ShippingAddressCity { get; set; }
    public string? ShippingAddressState { get; set; }
    public string? ShippingAddressZip { get; set; }
    public string? ShippingAddressCountry { get; set; } = "United States";
    public string? ShippingMethod { get; set; }
}