using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.CustomerInputs;

[XmlRoot("CustomerUpdate")]
public class CustomerUpdateRequestBody
{
    [Required]
    public required CustomerUpdateInputParameter InputParameter { get; set; }
}

public class CustomerUpdateInputParameter
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
    public string? PostageMarkupType { get; set; } = string.Empty;
    public decimal? PostageMarkupValue { get; set; } = decimal.Zero;
    public decimal? UpaidBalanceLimit { get; set; } = decimal.Zero;
}