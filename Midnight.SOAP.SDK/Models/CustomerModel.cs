using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.Models
{
    [XmlRoot(ElementName = "Customer")]
    public class CustomerModel
    {
        public int CustomerID { get; set; }
        public string? CustomerCode { get; set; } = string.Empty;
        public string? CustomerName { get; set; } = string.Empty;
        public bool IsActive { get; set; } = false;
        public int? ParentCustomerID { get; set; } = 0;
        public int? CustomerTypeID { get; set; } = 0;
        public string? CustomerTypeName { get; set; } = string.Empty;
        public string? TermsCode { get; set; } = string.Empty;
        public int? SalesRepID { get; set; } = 0;
        public string? SalesRepName { get; set; } = string.Empty;
        public int? CsrID { get; set; } = 0;
        public string? CsrName { get; set; } = string.Empty;
        public bool IsTaxable { get; set; } = false;
        public string? Website { get; set; } = string.Empty;
        public int? TaxJurisdictionID { get; set; } = 0;
        public string? TaxJurisdictionName { get; set; } = string.Empty;
        public int? TaxExemptionID { get; set; } = 0;
        public string? TaxExemptionName { get; set; } = string.Empty;
        public int? AccountStatusID { get; set; } = 0;
        public string? AccountStatusName { get; set; } = string.Empty;
        public string? Email { get; set; } = string.Empty;

        [XmlElement("CustomerAddress")]
        public CustomerAddress? Address { get; set; }
        public string? PostageMarkupType { get; set; } = "$";
        public decimal PostageMarkupValue { get; set; } = decimal.Zero;
        public decimal UnpaidBalanceLimit { get; set; } = decimal.Zero;
        public List<CustomerContact>? CustomerContacts { get; set; }

    }

    public class CustomerAddress
    {
        public string? CustomerAddressLine1 { get; set; } = string.Empty;
        public string? CustomerAddressLine2 { get; set; } = string.Empty;
        public string? CustomerAddressLine3 { get; set; } = string.Empty;
        public string? CustomerAddressCity { get; set; } = string.Empty;
        public string? CustomerAddressState { get; set; } = string.Empty;
        public string? CustomerAddressZip { get; set; } = string.Empty;
        public string? CustomerAddressCountry { get; set; } = "United States";
    }

    public class CustomerContact
    {
        public int CustomerID { get; set; }
        public int ContactID { get; set; }
        public string? FirstName { get; set; } = string.Empty;
        public string? MiddleName { get; set; } = string.Empty;
        public string? LastName { get; set; } = string.Empty;
        public string? EmailAddress { get; set; } = string.Empty;
        public bool Active { get; set; } = true;
    }
}
