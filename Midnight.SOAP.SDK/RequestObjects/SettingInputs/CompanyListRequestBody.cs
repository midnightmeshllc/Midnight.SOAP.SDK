using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

/// <summary>
/// Represents the request body for listing companies in the Midnight SOAP API.
/// </summary>
[XmlRoot("CompanyList")]
public class CompanyListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the company list request.
    /// </summary>
    public required CompanyListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing companies in the Midnight SOAP API.
/// </summary>
public class CompanyListInputParameter
{
    /// <summary>Gets or sets the company ID.</summary>
    public int CompanyID { get; set; }
    /// <summary>Gets or sets the company code.</summary>
    [XmlElement(IsNullable = true)]
    public string? CompanyCode { get; set; }
    /// <summary>Gets or sets the company name.</summary>
    [XmlElement(IsNullable = true)]
    public string? CompanyName { get; set; }
    /// <summary>Gets or sets the parent company ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? ParentCompanyID { get; set; }
    /// <summary>Gets or sets a value indicating whether the company is active.</summary>
    public bool Active { get; set; } = true;
}