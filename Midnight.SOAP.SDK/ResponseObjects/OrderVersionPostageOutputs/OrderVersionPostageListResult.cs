using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionPostageOutputs;

/// <summary>
/// Represents the result of a list request for order version postages in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class OrderVersionPostageListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of order version postages returned by the request.
    /// </summary>
    [XmlArray("OrderVersionPostages")]
    [XmlArrayItem("OrderVersionPostage")]
    public List<OrderVersionPostage> OrderVersionPostages { get; set; } = new List<OrderVersionPostage>();
}

/// <summary>
/// Represents an order version postage in the Midnight SOAP API.
/// Valid options for PostageMarkupType: "$" or "%"
/// </summary>
public class OrderVersionPostage
{
    /// <summary>Gets or sets the order version postage ID.</summary>
    public int? OrderVersionPostageID { get; set; }
    /// <summary>Gets or sets the version ID.</summary>
    public int? VersionID { get; set; }
    /// <summary>Gets or sets the postage affix ID.</summary>
    public int? PostageAffixID { get; set; }
    /// <summary>Gets or sets the postage affix name.</summary>
    public string? PostageAffixName { get; set; }
    /// <summary>Gets or sets the postage quantity.</summary>
    public int? PostageQuantity { get; set; }
    /// <summary>Gets or sets the postage rate.</summary>
    public decimal? PostageRate { get; set; }
    /// <summary>Gets or sets the postage markup type. Valid options: "$" or "%".</summary>
    public string? PostageMarkupType { get; set; }
    /// <summary>Gets or sets the postage markup value.</summary>
    public decimal? PostageMarkupValue { get; set; }
    /// <summary>Gets or sets the postage sell rate.</summary>
    public decimal? PostageSellRate { get; set; }
    /// <summary>Gets or sets the postage total.</summary>
    public decimal? PostageTotal { get; set; }
    /// <summary>Gets or sets the date used.</summary>
    public string? DateUsed { get; set; }
    /// <summary>Gets or sets the mail class ID.</summary>
    public int? MailClassID { get; set; }
    /// <summary>Gets or sets the mail class name.</summary>
    public string? MailClassName { get; set; }
}