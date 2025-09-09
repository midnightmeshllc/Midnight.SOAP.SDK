using Midnight.SOAP.SDK.CommonObjects;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.EstimateOutputs;

/// <summary>
/// Represents the result of an estimate list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class EstimateListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of estimates returned by the request.
    /// </summary>
    [XmlArray("Estimates")]
    [XmlArrayItem("Estimate")]
    public List<Estimate> Estimates { get; set; } = new List<Estimate>();
}

/// <summary>
/// Represents an estimate in the Midnight SOAP API.
/// </summary>
public class Estimate : UserDefinedFields
{
    /// <summary>Gets or sets the estimate ID.</summary>
    public int EstimateID { get; set; }
    /// <summary>Gets or sets the estimate number.</summary>
    public string? EstimateNumber { get; set; }
    /// <summary>Gets or sets the estimate suffix.</summary>
    public int? EstimateSuffix { get; set; }
    /// <summary>Gets or sets the customer ID.</summary>
    public int? CustomerID { get; set; }
    /// <summary>Gets or sets the customer name.</summary>
    public string? CustomerName { get; set; }
    /// <summary>Gets or sets the contact name.</summary>
    public string? ContactName { get; set; }
    /// <summary>Gets or sets the sales representative name.</summary>
    public string? SalesRepName { get; set; }
    /// <summary>Gets or sets the CSR name.</summary>
    public string? CSRName { get; set; }
    /// <summary>Gets or sets the project name.</summary>
    public string? ProjectName { get; set; }
    /// <summary>Gets or sets the licensee name.</summary>
    public string? LicenseeName { get; set; }
    /// <summary>Gets or sets the terms.</summary>
    public string? Terms { get; set; }

    /// <summary>Gets or sets the raw value indicating if the estimate is taxable.</summary>
    [XmlElement("Taxable")]
    public string? TaxableRaw { get; set; }
    /// <summary>Gets a value indicating whether the estimate is taxable.</summary>
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

    /// <summary>Gets or sets the estimate status.</summary>
    public string? EstimateStatus { get; set; }
    /// <summary>Gets or sets the estimate date.</summary>
    public string? EstimateDate { get; set; }
    /// <summary>Gets or sets the data in date.</summary>
    public string? DataInDate { get; set; }
    /// <summary>Gets or sets the material in date.</summary>
    public string? MaterialInDate { get; set; }
    /// <summary>Gets or sets the due date.</summary>
    public string? DueDate { get; set; }
    /// <summary>Gets or sets the expected quantity.</summary>
    public int? QuantityExpected { get; set; }
    /// <summary>Gets or sets the estimate tax.</summary>
    public decimal? EstimateTax { get; set; }
    /// <summary>Gets or sets the estimate total.</summary>
    public decimal? EstimateTotal { get; set; }
}