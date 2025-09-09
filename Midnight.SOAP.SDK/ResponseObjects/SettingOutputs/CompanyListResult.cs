using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

/// <summary>
/// Represents the result of a company list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class CompanyListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of companies returned by the request.
    /// </summary>
    [XmlArray("Companies")]
    [XmlArrayItem("Company")]
    public List<Company>? Companies { get; set; } = new List<Company>();
}

/// <summary>
/// Represents a company in the Midnight SOAP API.
/// </summary>
public class Company
{
    /// <summary>Gets or sets the company ID.</summary>
    [XmlElement("CompanyID")]
    public int? CompanyID { get; set; }
    /// <summary>Gets or sets the company code.</summary>
    [XmlElement("CompanyCode")]
    public string? CompanyCode { get; set; }
    /// <summary>Gets or sets the company name.</summary>
    [XmlElement("CompanyName")]
    public string? CompanyName { get; set; }
    /// <summary>Gets or sets the site token.</summary>
    [XmlElement("SiteToken")]
    public string? SiteToken { get; set; }

    /// <summary>Gets or sets the parent company ID.</summary>
    [XmlElement("ParentCompanyID")]
    public int? ParentCompanyID { get; set; }
    /// <summary>Gets or sets the parent company name.</summary>
    [XmlElement("ParentCompanyName")]
    public string? ParentCompanyName { get; set; }
    /// <summary>Gets or sets the URL.</summary>
    [XmlElement("URL")]
    public string? URL { get; set; }
    /// <summary>Gets or sets the tax jurisdiction name.</summary>
    [XmlElement("TaxJurisdictionName")]
    public string? TaxJurisdictionName { get; set; }
    /// <summary>Gets or sets company address line 1.</summary>
    [XmlElement("CompanyAddressLine1")]
    public string? CompanyAddressLine1 { get; set; }
    /// <summary>Gets or sets company address line 2.</summary>
    [XmlElement("CompanyAddressLine2")]
    public string? CompanyAddressLine2 { get; set; }
    /// <summary>Gets or sets company address line 3.</summary>
    [XmlElement("CompanyAddressLine3")]
    public string? CompanyAddressLine3 { get; set; }
    /// <summary>Gets or sets the company city.</summary>
    [XmlElement("CompanyAddressCity")]
    public string? CompanyAddressCity { get; set; }
    /// <summary>Gets or sets the company state.</summary>
    [XmlElement("CompanyAddressState")]
    public string? CompanyAddressState { get; set; }
    /// <summary>Gets or sets the company zip code.</summary>
    [XmlElement("CompanyAddressZip")]
    public string? CompanyAddressZip { get; set; }
    /// <summary>Gets or sets the company country.</summary>
    [XmlElement("CompanyAddressCountry")]
    public string? CompanyAddressCountry { get; set; }
    /// <summary>Gets or sets the company email address.</summary>
    [XmlElement("CompanyEmailAddress")]
    public string? CompanyEmailAddress { get; set; }
    /// <summary>Gets or sets the company phone number.</summary>
    [XmlElement("CompanyPhone")]
    public long? CompanyPhone { get; set; }
    /// <summary>Gets or sets the company phone extension.</summary>
    [XmlElement("CompanyPhoneExtension")]
    public string? CompanyPhoneExtension { get; set; }
    /// <summary>Gets or sets the company fax number.</summary>
    [XmlElement("CompanyFax")]
    public string? CompanyFax { get; set; }

    /// <summary>Gets or sets the raw value indicating if the company is active.</summary>
    [XmlElement("Active")]
    public string? ActiveRaw { get; set; }

    /// <summary>Gets a value indicating whether the company is active.</summary>
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