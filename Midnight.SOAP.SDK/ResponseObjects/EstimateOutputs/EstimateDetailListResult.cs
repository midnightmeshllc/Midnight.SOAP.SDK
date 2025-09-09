using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.EstimateOutputs;

/// <summary>
/// Represents the result of an estimate detail list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class EstimateDetailListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of estimate details returned by the request.
    /// </summary>
    [XmlArray("EstimateDetails")]
    [XmlArrayItem("EstimateDetail")]
    public List<EstimateDetail> EstimateDetails { get; set; } = new List<EstimateDetail>();
}

/// <summary>
/// Represents an estimate detail in the Midnight SOAP API.
/// </summary>
public class EstimateDetail
{
    /// <summary>Gets or sets the estimate detail ID.</summary>
    public int? EstimateDetailID { get; set; }
    /// <summary>Gets or sets the estimate ID.</summary>
    public int? EstimateID { get; set; }
    /// <summary>Gets or sets the service type ID.</summary>
    public int? ServiceTypeID { get; set; }
    /// <summary>Gets or sets the service type name.</summary>
    public string? ServiceTypeName { get; set; }
    /// <summary>Gets or sets the service type sort order.</summary>
    public int? ServiceTypeSort { get; set; }
    /// <summary>Gets or sets the service ID.</summary>
    public int? ServiceID { get; set; }
    /// <summary>Gets or sets the service code.</summary>
    public string? ServiceCode { get; set; }
    /// <summary>Gets or sets the service name.</summary>
    public string? ServiceName { get; set; }
    /// <summary>Gets or sets the quantity.</summary>
    public decimal? Quantity { get; set; }
    /// <summary>Gets or sets the unit price without markup.</summary>
    public decimal? UnitPriceNoMarkup { get; set; }
    /// <summary>Gets or sets the service markup.</summary>
    public decimal? ServiceMarkup { get; set; }
    /// <summary>Gets or sets the unit price.</summary>
    public decimal? UnitPrice { get; set; }
    /// <summary>Gets or sets the line total.</summary>
    public decimal? LineTotal { get; set; }

    /// <summary>Gets or sets the raw value indicating if the detail is taxable.</summary>
    [XmlElement("Taxable")]
    public string? TaxableRaw { get; set; }
    /// <summary>Gets a value indicating whether the detail is taxable.</summary>
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

    /// <summary>Gets or sets the taxable percent.</summary>
    public decimal? TaxablePercent { get; set; }
    /// <summary>Gets or sets the tax amount.</summary>
    public decimal? TaxAmount { get; set; }
    /// <summary>Gets or sets the run rate.</summary>
    public decimal? RunRate { get; set; }
    /// <summary>Gets or sets the comment.</summary>
    public string? Comment { get; set; }
    /// <summary>Gets or sets the priority.</summary>
    public int? Priority { get; set; }
    /// <summary>Gets or sets the service hyperlink.</summary>
    public string? ServiceHyperlink { get; set; }
    /// <summary>Gets or sets the file location.</summary>
    public string? FileLocation { get; set; }
}