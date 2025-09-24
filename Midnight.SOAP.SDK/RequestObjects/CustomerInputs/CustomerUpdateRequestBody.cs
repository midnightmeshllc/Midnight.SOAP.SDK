using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.CustomerInputs;

/// <summary>
/// Represents the request body for updating a customer in the Midnight SOAP API.
/// </summary>
[XmlRoot("CustomerUpdate")]
public class CustomerUpdateRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the customer update request.
    /// </summary>
    public required CustomerUpdateInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for updating a customer in the Midnight SOAP API.
/// </summary>
public class CustomerUpdateInputParameter : UserDefinedFieldsFirst10
{
    /// <summary>Gets or sets the customer code.</summary>
    public required string CustomerCode { get; set; }
    /// <summary>Gets or sets the customer name.</summary>
    [XmlElement(IsNullable = true)]
    public string? CustomerName { get; set; }
    /// <summary>Gets or sets the phone number.</summary>
    [XmlElement(IsNullable = true)]
    public string? Phone { get; set; }
    /// <summary>Gets or sets the phone extension.</summary>
    [XmlElement(IsNullable = true)]
    public string? PhoneExtension { get; set; }
    /// <summary>Gets or sets the fax number.</summary>
    [XmlElement(IsNullable = true)]
    public string? Fax { get; set; }
    /// <summary>Gets or sets the email address.</summary>
    [XmlElement(IsNullable = true)]
    public string? Email { get; set; }
    /// <summary>Gets or sets the website.</summary>
    [XmlElement(IsNullable = true)]
    public string? Website { get; set; }
    /// <summary>Gets or sets the terms.</summary>
    [XmlElement(IsNullable = true)]
    public string? Terms { get; set; }
    /// <summary>Gets or sets the company name.</summary>
    [XmlElement(IsNullable = true)]
    public string? Company { get; set; }
    /// <summary>Gets or sets the customer notes.</summary>
    [XmlElement(IsNullable = true)]
    public string? CustomerNotes { get; set; }
    /// <summary>Gets or sets the customer type.</summary>
    [XmlElement(IsNullable = true)]
    public string? CustomerType { get; set; }
    /// <summary>Gets or sets the parent customer code.</summary>
    [XmlElement(IsNullable = true)]
    public int? ParentCustomerCode { get; set; }
    /// <summary>Gets or sets the sales representative.</summary>
    [XmlElement(IsNullable = true)]
    public string? SalesRep { get; set; }
    /// <summary>Gets or sets the customer service representative.</summary>
    [XmlElement(IsNullable = true)]
    public string? CSR { get; set; }
    /// <summary>Gets or sets the permit number.</summary>
    [XmlElement(IsNullable = true)]
    public string? PermitNumber { get; set; }
    /// <summary>Gets or sets the account status.</summary>
    [XmlElement(IsNullable = true)]
    public string? AccountStatus { get; set; }
    /// <summary>Gets or sets a value indicating whether notification is enabled.</summary>
    [XmlElement(IsNullable = true)]
    public bool? Notification { get; set; }
    /// <summary>Gets or sets the notification text.</summary>
    [XmlElement(IsNullable = true)]
    public string? NotificationText { get; set; }
    /// <summary>Gets or sets a value indicating whether the customer is taxable.</summary>
    [XmlElement(IsNullable = true)]
    public bool? Taxable { get; set; }
    /// <summary>Gets or sets the tax jurisdiction name.</summary>
    [XmlElement(IsNullable = true)]
    public string? TaxJurisdictionName { get; set; }
    /// <summary>Gets or sets the tax exemption name.</summary>
    [XmlElement(IsNullable = true)]
    public string? TaxExemptionName { get; set; }
    /// <summary>Gets or sets the postage markup type.</summary>
    [XmlElement(IsNullable = true)]
    public string? PostageMarkupType { get; set; }
    /// <summary>Gets or sets the postage markup value.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? PostageMarkupValue { get; set; }
    /// <summary>Gets or sets the unpaid balance limit.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? UpaidBalanceLimit { get; set; }
    /// <summary>Gets or sets the customer address.</summary>
    [XmlElement(IsNullable = true)]
    public CustomerAddress? CustomerAddress { get; set; }
    /// <summary>Gets or sets the billing address.</summary>
    [XmlElement(IsNullable = true)]
    public BillingAddress? BillingAddress { get; set; }
    /// <summary>Gets or sets the shipping address.</summary>
    [XmlElement(IsNullable = true)]
    public ShippingAddress? ShippingAddress { get; set; }
}