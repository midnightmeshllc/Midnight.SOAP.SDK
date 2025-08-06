
using Midnight.SOAP.SDK.CommonObjects;
using Midnight.SOAP.SDK.RequestObjects.OrderInputs;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.CustomerOutputs;

[XmlRoot("Result")]
public class CustomerListResult : CommonResult
{
    [XmlArray("Customers")]
    [XmlArrayItem("Customer")]
    public List<Customer> Customers { get; set; } = new List<Customer>();
}

public class Customer : UserDefinedFields
{
    [XmlElement("CustomerID")]
    public int CustomerID { get; set; }
    [XmlElement("CustomerCode")]
    public string CustomerCode { get; set; } = string.Empty;
    [XmlElement("CustomerName")]
    public string CustomerName { get; set; } = string.Empty;
    [XmlElement("ParentCustomerID")]
    public int? ParentCustomerID { get; set; }
    [XmlElement("LicenseeID")]
    public int? LicenseeID { get; set; }
    [XmlElement("LicenseeName")]
    public string? LicenseeName { get; set; } = string.Empty;
    [XmlElement("AccountingCode")]
    public string? AccountingCode { get; set; } = string.Empty;
    [XmlElement("CustomerTypeID")]
    public int? CustomerTypeID { get; set; }
    [XmlElement("CustomerTypeName")]
    public string? CustomerTypeName { get; set; } = string.Empty;
    [XmlElement("TermsCode")]
    public string? TermsCode { get; set; } = string.Empty;
    [XmlElement("SalesRepID")]
    public int? SalesRepID { get; set; }
    [XmlElement("SalesRepName")]
    public string? SalesRepName { get; set; } = string.Empty;
    [XmlElement("CSRID")]
    public int? CSRID { get; set; }
    [XmlElement("CSRName")]
    public string? CSRName { get; set; } = string.Empty;
    [XmlElement("EnterDate")]
    public string? EnterDate { get; set; } = string.Empty;
    [XmlElement("Taxable")]
    public string? TaxableRaw { get; set; }
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

    [XmlElement("PermitNumber")]
    public string? PermitNumber { get; set; } = string.Empty;
    [XmlElement("DeliveryMethodID")]
    public int? DeliveryMethodID { get; set; }
    [XmlElement("DeliveryMethodName")]
    public string? DeliveryMethodName { get; set; } = string.Empty;
    [XmlElement("URL")]
    public string? URL { get; set; } = string.Empty;
    [XmlElement("TaxJurisdictionID")]
    public int? TaxJurisdictionID { get; set; }
    [XmlElement("TaxJurisdictionName")]
    public string? TaxJurisdictionName { get; set; } = string.Empty;
    [XmlElement("TaxExemptionID")]
    public int? TaxExemptionID { get; set; }
    [XmlElement("TaxExemptionName")]
    public string? TaxExemptionName { get; set; } = string.Empty;
    [XmlElement("AccountStatusID")]
    public int? AccountStatusID { get; set; }
    [XmlElement("AccountStatusName")]
    public string? AccountStatusName { get; set; } = string.Empty;
    [XmlElement("PORequired")]
    public string? PORequiredRaw { get; set; }

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

    [XmlElement("Notification")]
    public string? NotificationRaw { get; set; }
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

    [XmlElement("NotificationText")]
    public string? NotificationText { get; set; } = string.Empty;

    [XmlElement("Active")]
    public string? ActiveRaw { get; set; }

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

    [XmlElement("EmailAddress")]
    public string? EmailAddress { get; set; } = string.Empty;
    [XmlElement("CustomerAddress")]
    public CustomerAddress? CustomerAddress { get; set; }
    [XmlElement("ShippingAddress")]
    public ShippingAddress? ShippingAddress { get; set; }
    [XmlElement("BillingAddress")]
    public BillingAddress? BillingAddress { get; set; }
    [XmlElement("MODProviderID")]
    public string? MODProviderID { get; set; } = string.Empty;
    [XmlElement("PostageMarkupType")]
    public string? PostageMarkupType { get; set; } = string.Empty;
    [XmlElement("PostageMarkupValue")]
    public decimal? PostageMarkupValue { get; set; } = decimal.Zero;
    [XmlElement("UnpaidBalanceLimit")]
    public string? UnpaidBalanceLimit { get; set; } = string.Empty;

}