using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionPostageInputs;

/// <summary>
/// Represents the request body for updating an order version postage in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderVersionPostageUpdate")]
public class OrderVersionPostageUpdateRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the order version postage update request.
    /// </summary>
    public required OrderVersionPostageUpdateInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for updating an order version postage in the Midnight SOAP API.
/// </summary>
public class OrderVersionPostageUpdateInputParameter
{
    /// <summary>Gets or sets the order version postage ID.</summary>
    public required int OrderVersionPostageID { get; set; }
    /// <summary>Gets or sets the postage affix ID.</summary>
    public int? PostageAffixID { get; set; } = null;
    /// <summary>Gets or sets the postage affix name.</summary>
    public string? PostageAffixName { get; set; } = null;
    /// <summary>Gets or sets the postage quantity.</summary>
    public int? PostageQuantity { get; set; } = null;
    /// <summary>Gets or sets the postage rate.</summary>
    public decimal? PostageRate { get; set; } = null;
    /// <summary>Gets or sets the postage total.</summary>
    public decimal? PostageTotal { get; set; } = null;
    /// <summary>Gets or sets the date used.</summary>
    public string? DateUsed { get; set; } = null;
    /// <summary>Gets or sets the mail class ID.</summary>
    public int? MailClassID { get; set; } = null;
    /// <summary>Gets or sets the total weight.</summary>
    public decimal? TotalWeight { get; set; } = null;
    /// <summary>Gets or sets the form number.</summary>
    public string? FormNo { get; set; } = null;
    /// <summary>Gets or sets the lot.</summary>
    public string? Lot { get; set; } = null;
    /// <summary>Gets or sets the permit number.</summary>
    public string? PermitNo { get; set; } = null;
    /// <summary>Gets or sets the non-profit information.</summary>
    public string? NonProfit { get; set; } = null;
    /// <summary>Gets or sets the post office.</summary>
    public string? PostOffice { get; set; } = null;
    /// <summary>Gets or sets the post office city.</summary>
    public string? POCity { get; set; } = null;
    /// <summary>Gets or sets the post office zip code.</summary>
    public string? POZip { get; set; } = null;
    /// <summary>Gets or sets the weight status.</summary>
    public string? WTStatus { get; set; } = null;
    /// <summary>Gets or sets the processing category.</summary>
    public int? ProcessingCategory { get; set; } = null;
    /// <summary>Gets or sets the FTtr1 value.</summary>
    public string? FTtr1 { get; set; } = null;
    /// <summary>Gets or sets the FTtr2 value.</summary>
    public string? FTtr2 { get; set; } = null;
    /// <summary>Gets or sets the number of sacks.</summary>
    public int? Sacks { get; set; } = null;
    /// <summary>Gets or sets the number of pallets.</summary>
    public int? Pallets { get; set; } = null;
    /// <summary>Gets or sets the flat tray value.</summary>
    public string? FlatTr { get; set; } = null;
    /// <summary>Gets or sets other information.</summary>
    public string? Other { get; set; } = null;
    /// <summary>Gets or sets the tare weight.</summary>
    public decimal? TareWt { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the postage is precanceled.</summary>
    public bool? Precanceled { get; set; } = null;
    /// <summary>Gets or sets the postage markup type.</summary>
    public string? PostageMarkupType { get; set; } = null;
    /// <summary>Gets or sets the postage markup value.</summary>
    public decimal? PostageMarkupValue { get; set; } = null;
    /// <summary>Gets or sets the postage sell rate.</summary>
    public decimal? PostageSellRate { get; set; } = null;
}