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
    public string? CustomerName { get; set; }
    public bool ShouldSerializeCustomerName() => IsSet(CustomerName);

    /// <summary>Gets or sets the phone number.</summary>
    public string? Phone { get; set; }
    public bool ShouldSerializePhone() => IsSet(Phone);

    /// <summary>Gets or sets the phone extension.</summary>
    public string? PhoneExtension { get; set; }
    public bool ShouldSerializePhoneExtension() => IsSet(PhoneExtension);

    /// <summary>Gets or sets the fax number.</summary>
    public string? Fax { get; set; }
    public bool ShouldSerializeFax() => IsSet(Fax);

    /// <summary>Gets or sets the email address.</summary>
    public string? Email { get; set; }
    public bool ShouldSerializeEmail() => IsSet(Email);

    /// <summary>Gets or sets the website.</summary>
    public string? Website { get; set; }
    public bool ShouldSerializeWebsite() => IsSet(Website);

    /// <summary>Gets or sets the terms.</summary>
    public string? Terms { get; set; }
    public bool ShouldSerializeTerms() => IsSet(Terms);

    /// <summary>Gets or sets the company name.</summary>
    public string? Company { get; set; }
    public bool ShouldSerializeCompany() => IsSet(Company);

    /// <summary>Gets or sets the customer notes.</summary>
    public string? CustomerNotes { get; set; }
    public bool ShouldSerializeCustomerNotes() => IsSet(CustomerNotes);

    /// <summary>Gets or sets the customer type.</summary>
    public string? CustomerType { get; set; }
    public bool ShouldSerializeCustomerType() => IsSet(CustomerType);

    /// <summary>Gets or sets the parent customer code.</summary>
    public int? ParentCustomerCode { get; set; }
    public bool ShouldSerializeParentCustomerCode() => ParentCustomerCode.HasValue;

    /// <summary>Gets or sets the sales representative.</summary>
    public string? SalesRep { get; set; }
    public bool ShouldSerializeSalesRep() => IsSet(SalesRep);

    /// <summary>Gets or sets the customer service representative.</summary>
    public string? CSR { get; set; }
    public bool ShouldSerializeCSR() => IsSet(CSR);

    /// <summary>Gets or sets the permit number.</summary>
    public string? PermitNumber { get; set; }
    public bool ShouldSerializePermitNumber() => IsSet(PermitNumber);

    /// <summary>Gets or sets the account status.</summary>
    public string? AccountStatus { get; set; }
    public bool ShouldSerializeAccountStatus() => IsSet(AccountStatus);

    /// <summary>Gets or sets a value indicating whether notification is enabled.</summary>
    public bool? Notification { get; set; }
    public bool ShouldSerializeNotification() => Notification.HasValue;

    /// <summary>Gets or sets the notification text.</summary>
    public string? NotificationText { get; set; }
    public bool ShouldSerializeNotificationText() => IsSet(NotificationText);

    /// <summary>Gets or sets a value indicating whether the customer is taxable.</summary>
    public bool? Taxable { get; set; }
    public bool ShouldSerializeTaxable() => Taxable.HasValue;

    /// <summary>Gets or sets the tax jurisdiction name.</summary>
    public string? TaxJurisdictionName { get; set; }
    public bool ShouldSerializeTaxJurisdictionName() => IsSet(TaxJurisdictionName);

    /// <summary>Gets or sets the tax exemption name.</summary>
    public string? TaxExemptionName { get; set; }
    public bool ShouldSerializeTaxExemptionName() => IsSet(TaxExemptionName);

    /// <summary>Gets or sets the postage markup type.</summary>
    public string? PostageMarkupType { get; set; }
    public bool ShouldSerializePostageMarkupType() => IsSet(PostageMarkupType);

    /// <summary>Gets or sets the postage markup value.</summary>
    public decimal? PostageMarkupValue { get; set; }
    public bool ShouldSerializePostageMarkupValue() => PostageMarkupValue.HasValue;

    /// <summary>Gets or sets the unpaid balance limit.</summary>
    public decimal? UpaidBalanceLimit { get; set; }
    public bool ShouldSerializeUpaidBalanceLimit() => UpaidBalanceLimit.HasValue;

    /// <summary>Gets or sets the customer address.</summary>
    public CustomerAddress? CustomerAddress { get; set; }
    public bool ShouldSerializeCustomerAddress() => CustomerAddress != null;

    /// <summary>Gets or sets the billing address.</summary>
    public BillingAddress? BillingAddress { get; set; }
    public bool ShouldSerializeBillingAddress() => BillingAddress != null;

    /// <summary>Gets or sets the shipping address.</summary>
    public ShippingAddress? ShippingAddress { get; set; }
    public bool ShouldSerializeShippingAddress() => ShippingAddress != null;

    /// <summary>Shared helper for determining whether a nullable string field has a meaningful value to serialize.</summary>
    private static bool IsSet(string? value) => !string.IsNullOrEmpty(value);
}