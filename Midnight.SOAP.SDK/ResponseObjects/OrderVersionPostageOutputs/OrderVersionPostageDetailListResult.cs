using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionPostageOutputs;

/// <summary>
/// Represents the result of a list request for order version postage details in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class OrderVersionPostageDetailListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of order version postage details returned by the request.
    /// </summary>
    [XmlArray("OrderVersionPostageDetails")]
    [XmlArrayItem("OrderVersionPostageDetail")]
    public List<OrderVersionPostageDetail> OrderVersionPostageDetails { get; set; } = new List<OrderVersionPostageDetail>();
}

/// <summary>
/// Represents an order version postage detail in the Midnight SOAP API.
/// </summary>
public class OrderVersionPostageDetail
{
    /// <summary>Gets or sets the order version postage detail ID.</summary>
    public int? OrderVersionPostageDetailID { get; set; }
    /// <summary>Gets or sets the order version postage ID.</summary>
    public int? OrderVersionPostageID { get; set; }
    /// <summary>Gets or sets the rate description.</summary>
    public string? RateDescription { get; set; }
    /// <summary>Gets or sets the quantity.</summary>
    public int? Quantity { get; set; }
    /// <summary>Gets or sets the rate.</summary>
    public decimal? Rate { get; set; }
    /// <summary>Gets or sets the total weight for the detail.</summary>
    public decimal? DetailTotalWeight { get; set; }
    /// <summary>Gets or sets the total postage for the detail.</summary>
    public decimal? DetailTotalPostage { get; set; }
    /// <summary>Gets or sets the detail date.</summary>
    public string? DetailDate { get; set; }
    /// <summary>Gets or sets the rate code.</summary>
    public string? RateCode { get; set; }
    /// <summary>Gets or sets the weight type.</summary>
    public string? WtType { get; set; }

    /// <summary>Gets or sets the raw value indicating if the postage is precanceled.</summary>
    [XmlElement("Precanceled")]
    public string? PrecanceledRaw { get; set; }
    /// <summary>Gets a value indicating whether the postage is precanceled.</summary>
    [XmlIgnore]
    public bool Precanceled
    {
        get
        {
            if (string.IsNullOrWhiteSpace(PrecanceledRaw)) return false;
            return string.Equals(PrecanceledRaw, "true", StringComparison.OrdinalIgnoreCase)
                || PrecanceledRaw == "1";
        }
    }
}