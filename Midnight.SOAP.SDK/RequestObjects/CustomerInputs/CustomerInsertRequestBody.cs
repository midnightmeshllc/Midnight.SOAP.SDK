using Midnight.SOAP.SDK.CommonObjects;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.CustomerInputs;

/// <summary>
/// Represents the request body for inserting a customer in the Midnight SOAP API.
/// </summary>
[XmlRoot("CustomerInsert")]
public class CustomerInsertRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the customer insert request.
    /// </summary>
    [Required]
    public required CustomerInsertInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for inserting a customer in the Midnight SOAP API.
/// </summary>
public class CustomerInsertInputParameter : UserDefinedFields
{
    /// <summary>Gets or sets the customer code.</summary>
    public required string CustomerCode { get; set; } = string.Empty;
    /// <summary>Gets or sets the customer name.</summary>
    public string? CustomerName { get; set; } = null;
    /// <summary>Gets or sets the phone number.</summary>
    public string? Phone { get; set; } = null;
    /// <summary>Gets or sets the phone extension.</summary>
    public string? PhoneExtension { get; set; } = null;
    /// <summary>Gets or sets the fax number.</summary>
    public string? Fax { get; set; } = null;
    /// <summary>Gets or sets the email address.</summary>
    public string? Email { get; set; } = null;
    /// <summary>Gets or sets the website.</summary>
    public string? Website { get; set; } = null;
    /// <summary>Gets or sets the terms.</summary>
    public string? Terms { get; set; } = null;
    /// <summary>Gets or sets the company name.</summary>
    public string? Company { get; set; } = null;
    /// <summary>Gets or sets the customer notes.</summary>
    public string? CustomerNotes { get; set; } = null;
    /// <summary>Gets or sets the customer type.</summary>
    public string? CustomerType { get; set; } = null;
    /// <summary>Gets or sets the parent customer code.</summary>
    public int? ParentCustomerCode { get; set; } = null;
    /// <summary>Gets or sets the sales representative.</summary>
    public string? SalesRep { get; set; } = null;
    /// <summary>Gets or sets the customer service representative.</summary>
    public string? CSR { get; set; } = null;
    /// <summary>Gets or sets the permit number.</summary>
    public string? PermitNumber { get; set; } = null;
    /// <summary>Gets or sets the account status.</summary>
    public string? AccountStatus { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether notification is enabled.</summary>
    public bool? Notification { get; set; } = false;
    /// <summary>Gets or sets the notification text.</summary>
    public string? NotificationText { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the customer is taxable.</summary>
    public bool? Taxable { get; set; } = true;
    /// <summary>Gets or sets the tax jurisdiction name.</summary>
    public string? TaxJurisdictionName { get; set; } = null;
    /// <summary>Gets or sets the tax exemption name.</summary>
    public string? TaxExemptionName { get; set; } = null;
    /// <summary>Gets or sets the postage markup type.</summary>
    public string? PostageMarkupType { get; set; } = null;
    /// <summary>Gets or sets the postage markup value.</summary>
    public decimal? PostageMarkupValue { get; set; } = decimal.Zero;
    /// <summary>Gets or sets the unpaid balance limit.</summary>
    public decimal? UpaidBalanceLimit { get; set; } = decimal.Zero;
    /// <summary>Gets or sets the accounting code.</summary>
    public string? AccountingCode { get; set; } = null;

    /// <summary>Gets or sets the customer address.</summary>
    public CustomerAddress? CustomerAddress { get; set; } = null;
    /// <summary>Gets or sets the shipping address.</summary>
    public ShippingAddress? ShippingAddress { get; set; } = null;
    /// <summary>Gets or sets the billing address.</summary>
    public BillingAddress? BillingAdress { get; set; } = null;
}