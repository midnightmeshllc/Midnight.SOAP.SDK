using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

[XmlRoot("Result")]
public class CompanyListResult : CommonResult
{
    [XmlArray("Companies")]
    [XmlArrayItem("Company")]
    public List<Company>? Companies { get; set; } = new List<Company>();
}

public class Company
{
    [XmlElement("CompanyID")]
    public int? CompanyID { get; set; }
    [XmlElement("CompanyCode")]
    public string? CompanyCode { get; set; }
    [XmlElement("CompanyName")]
    public string? CompanyName { get; set; }
    [XmlElement("SiteToken")]
    public string? SiteToken { get; set; }

    [XmlElement("ParentCompanyID")]
    public int? ParentCompanyID { get; set; }
    [XmlElement("ParentCompanyName")]
    public string? ParentCompanyName { get; set; }
    [XmlElement("URL")]
    public string? URL { get; set; }
    [XmlElement("TaxJurisdictionName")]
    public string? TaxJurisdictionName { get; set; }
    [XmlElement("CompanyAddressLine1")]
    public string? CompanyAddressLine1 { get; set; }
    [XmlElement("CompanyAddressLine2")]
    public string? CompanyAddressLine2 { get; set; }
    [XmlElement("CompanyAddressLine3")]
    public string? CompanyAddressLine3 { get; set; }
    [XmlElement("CompanyAddressCity")]
    public string? CompanyAddressCity { get; set; }
    [XmlElement("CompanyAddressState")]
    public string? CompanyAddressState { get; set; }
    [XmlElement("CompanyAddressZip")]
    public string? CompanyAddressZip { get; set; }
    [XmlElement("CompanyAddressCountry")]
    public string? CompanyAddressCountry { get; set; }
    [XmlElement("CompanyEmailAddress")]
    public string? CompanyEmailAddress { get; set; }
    [XmlElement("CompanyPhone")]
    public long? CompanyPhone { get; set; }
    [XmlElement("CompanyPhoneExtension")]
    public string? CompanyPhoneExtension { get; set; }
    [XmlElement("CompanyFax")]
    public string? CompanyFax { get; set; }

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
}