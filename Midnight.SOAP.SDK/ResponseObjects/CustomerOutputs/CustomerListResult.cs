using Midnight.SOAP.SDK.CommonObjects;
using Midnight.SOAP.SDK.RequestObjects.OrderInputs;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.CustomerOutputs;

/// <summary>
/// Represents the result of a customer list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class CustomerListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of customers returned by the request.
    /// </summary>
    [XmlArray("Customers")]
    [XmlArrayItem("Customer")]
    public List<Customer> Customers { get; set; } = new List<Customer>();
}

/// <summary>
/// Represents a customer in the Midnight SOAP API.
/// </summary>
public class Customer : UserDefinedFields
{
    /// <summary>
    /// Gets or sets the unique identifier for the customer.
    /// </summary>
    [XmlElement("CustomerID")]
    public int CustomerID { get; set; }
    /// <summary>
    /// Gets or sets the customer code.
    /// </summary>
    [XmlElement("CustomerCode")]
    public string CustomerCode { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the name of the customer.
    /// </summary>
    [XmlElement("CustomerName")]
    public string CustomerName { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the unique identifier for the parent's customer.
    /// </summary>
    [XmlElement("ParentCustomerID")]
    public int? ParentCustomerID { get; set; }
    /// <summary>
    /// Gets or sets the licensee identifier.
    /// </summary>
    [XmlElement("LicenseeID")]
    public int? LicenseeID { get; set; }
    /// <summary>
    /// Gets or sets the name of the licensee.
    /// </summary>
    [XmlElement("LicenseeName")]
    public string? LicenseeName { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the accounting code.
    /// </summary>
    [XmlElement("AccountingCode")]
    public string? AccountingCode { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the customer type identifier.
    /// </summary>
    [XmlElement("CustomerTypeID")]
    public int? CustomerTypeID { get; set; }
    /// <summary>
    /// Gets or sets the name of the customer type.
    /// </summary>
    [XmlElement("CustomerTypeName")]
    public string? CustomerTypeName { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the terms code.
    /// </summary>
    [XmlElement("TermsCode")]
    public string? TermsCode { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the sales representative identifier.
    /// </summary>
    [XmlElement("SalesRepID")]
    public int? SalesRepID { get; set; }
    /// <summary>
    /// Gets or sets the name of the sales representative.
    /// </summary>
    [XmlElement("SalesRepName")]
    public string? SalesRepName { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the customer service representative identifier.
    /// </summary>
    [XmlElement("CSRID")]
    public int? CSRID { get; set; }
    /// <summary>
    /// Gets or sets the name of the customer service representative.
    /// </summary>
    [XmlElement("CSRName")]
    public string? CSRName { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the date the customer was entered.
    /// </summary>
    [XmlElement("EnterDate")]
    public string? EnterDate { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the taxable status of the customer.
    /// </summary>
    [XmlElement("Taxable")]
    public string? TaxableRaw { get; set; }
    /// <summary>
    /// Gets the parsed taxable status.
    /// </summary>
    [XmlIgnore]
    public bool Taxable
    {
        get
        {
            if (string.IsNullOrWhiteSpace(TaxableRaw)) return false;
            return string.Equals(TaxableRaw, "true", StringComparison.OrdinalIgnoreCase)
                || TaxableRaw == "1";
        }
    }

    /// <summary>
    /// Gets or sets the permit number.
    /// </summary>
    [XmlElement("PermitNumber")]
    public string? PermitNumber { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the delivery method identifier.
    /// </summary>
    [XmlElement("DeliveryMethodID")]
    public int? DeliveryMethodID { get; set; }
    /// <summary>
    /// Gets or sets the name of the delivery method.
    /// </summary>
    [XmlElement("DeliveryMethodName")]
    public string? DeliveryMethodName { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the URL associated with the customer.
    /// </summary>
    [XmlElement("URL")]
    public string? URL { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the tax jurisdiction identifier.
    /// </summary>
    [XmlElement("TaxJurisdictionID")]
    public int? TaxJurisdictionID { get; set; }
    /// <summary>
    /// Gets or sets the name of the tax jurisdiction.
    /// </summary>
    [XmlElement("TaxJurisdictionName")]
    public string? TaxJurisdictionName { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the tax exemption identifier.
    /// </summary>
    [XmlElement("TaxExemptionID")]
    public int? TaxExemptionID { get; set; }
    /// <summary>
    /// Gets or sets the name of the tax exemption.
    /// </summary>
    [XmlElement("TaxExemptionName")]
    public string? TaxExemptionName { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the account status identifier.
    /// </summary>
    [XmlElement("AccountStatusID")]
    public int? AccountStatusID { get; set; }
    /// <summary>
    /// Gets or sets the name of the account status.
    /// </summary>
    [XmlElement("AccountStatusName")]
    public string? AccountStatusName { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the purchase order required status.
    /// </summary>
    [XmlElement("PORequired")]
    public string? PORequiredRaw { get; set; }

    /// <summary>
    /// Gets the parsed purchase order required status.
    /// </summary>
    [XmlIgnore]
    public bool PORequired
    {
        get
        {
            if (string.IsNullOrWhiteSpace(PORequiredRaw)) return false;
            return string.Equals(PORequiredRaw, "true", StringComparison.OrdinalIgnoreCase)
                || PORequiredRaw == "1";
        }
    }

    /// <summary>
    /// Gets or sets the notification status.
    /// </summary>
    [XmlElement("Notification")]
    public string? NotificationRaw { get; set; }
    /// <summary>
    /// Gets the parsed notification status.
    /// </summary>
    [XmlIgnore]
    public bool Notification
    {
        get
        {
            if (string.IsNullOrWhiteSpace(NotificationRaw)) return false;
            return string.Equals(NotificationRaw, "true", StringComparison.OrdinalIgnoreCase)
                || NotificationRaw == "1";
        }
    }

    /// <summary>
    /// Gets or sets the notification text.
    /// </summary>
    [XmlElement("NotificationText")]
    public string? NotificationText { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the active status.
    /// </summary>
    [XmlElement("Active")]
    public string? ActiveRaw { get; set; }

    /// <summary>
    /// Gets the parsed active status.
    /// </summary>
    [XmlIgnore]
    public bool Active
    {
        get
        {
            if (string.IsNullOrWhiteSpace(ActiveRaw)) return false;
            return string.Equals(ActiveRaw, "true", StringComparison.OrdinalIgnoreCase)
                || ActiveRaw == "1";
        }
    }

    /// <summary>
    /// Gets or sets the email address of the customer.
    /// </summary>
    [XmlElement("EmailAddress")]
    public string? EmailAddress { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the customer address.
    /// </summary>
    [XmlElement("CustomerAddress")]
    public CustomerAddress? CustomerAddress { get; set; }
    /// <summary>
    /// Gets or sets the shipping address.
    /// </summary>
    [XmlElement("ShippingAddress")]
    public ShippingAddress? ShippingAddress { get; set; }
    /// <summary>
    /// Gets or sets the billing address.
    /// </summary>
    [XmlElement("BillingAddress")]
    public BillingAddress? BillingAddress { get; set; }
    /// <summary>
    /// Gets or sets the MOD provider identifier.
    /// </summary>
    [XmlElement("MODProviderID")]
    public string? MODProviderID { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the type of postage markup.
    /// </summary>
    [XmlElement("PostageMarkupType")]
    public string? PostageMarkupType { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the value of postage markup.
    /// </summary>
    [XmlElement("PostageMarkupValue")]
    public decimal? PostageMarkupValue { get; set; } = decimal.Zero;
    /// <summary>
    /// Gets or sets the unpaid balance limit.
    /// </summary>
    [XmlElement("UnpaidBalanceLimit")]
    public string? UnpaidBalanceLimit { get; set; } = string.Empty;

}